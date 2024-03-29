﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Sep3.Models;

namespace Sep3.HttpServices
{
    public interface IBranchService
    {
        Task<List<Branch>> GetBranchesAsync();
        Task AddBranchAsync(Branch branch);
        Task RemoveBranchAsync(int id);

        Task<Branch> GetBranchByIdAsync(int id);

        Task AddFoodToBranchAsync(Food food);

        Task<List<Food>> GetFood(int id);
    }
}