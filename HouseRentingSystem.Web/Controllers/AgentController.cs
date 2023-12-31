﻿namespace HouseRentingSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure.Extensions;
    using HouseRentingSystem.Services.Data.Interfaces;

    using static Common.NotificationMessagesConstants;

    [Authorize]
    public class AgentController : Controller
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService agentService)
        {
            this.agentService = agentService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            string? userId = User.GetId();
            bool isAgent = await agentService.AgentExistsByUserIdAsync(userId!);
            if (isAgent)
            {
                TempData[ErrorMessage] = "You are already an agent!";

                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
