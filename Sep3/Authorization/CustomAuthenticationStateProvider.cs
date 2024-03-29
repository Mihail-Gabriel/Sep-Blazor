﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

using Sep3.HttpServices;
using Sep3.Models;

namespace Sep3.Authorization
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime jsRuntime;
        private readonly IUserService userService;
        private User _cachedUser { get; set; }

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime, IUserService userService)
        {
            this.jsRuntime = jsRuntime;
            this.userService = userService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            if (_cachedUser == null) 
            {
                string userAsJson = await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson)) 
                {
                    User tmp = JsonSerializer.Deserialize<User>(userAsJson);
                    await ValidateLogin(tmp.username, tmp.password);
                    identity = SetupClaimsForUser(_cachedUser);
                }
            } else {
                identity = SetupClaimsForUser(_cachedUser);
            }

            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
        }

        public async Task ValidateLogin(string username, string password)
        {
            Console.WriteLine("Validating log in");
            if (string.IsNullOrEmpty(username)) throw new Exception("Enter username");
            if (string.IsNullOrEmpty(password)) throw new Exception("Enter password");
            ClaimsIdentity identity = new ClaimsIdentity();
            try
            {
                User user = await userService.ValidateUserAsync(username, password);
                identity = SetupClaimsForUser(user);
                string serialisedData = JsonSerializer.Serialize(user);
                await jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serialisedData);
                _cachedUser = user;
            }
            catch (Exception e)
            {
                throw e;
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        }

        public async Task ValidateRegister(string username, string password, string number, string address,
            string city)
        {
            if (string.IsNullOrEmpty(username)) throw new Exception("Invalid Username");
            if (string.IsNullOrEmpty(password)) throw new Exception("Password doesn't meet the requirements");
            if (string.IsNullOrEmpty(number)) throw new Exception("Please enter a mobile number");
            if (string.IsNullOrEmpty(address)) throw new Exception("Please enter your address");
            if (string.IsNullOrEmpty(city)) throw new Exception("Please enter a valid city");

            try
            {
                await userService.RegisterUserAsync(username, password, number, address, city);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public User GetCachedUser()
        {
            return _cachedUser;
        }

        public async Task Logout()
        {
            _cachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            await jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        private ClaimsIdentity SetupClaimsForUser(User user)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.username));
            claims.Add(new Claim("role",user.role));
            
            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }
    }
}