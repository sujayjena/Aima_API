﻿using Aima.Application.Interfaces;
using Aima.Domain.Entities;
using Microsoft.Extensions.Options;
using Aima.Application.Helpers;
using Aima.Application.Models;

namespace Aima.API.Middlewares
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _appSettings;

        public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
        {
            _next = next;
            _appSettings = appSettings.Value;
        }

        public async Task Invoke(HttpContext context, IJwtUtilsRepository jwtUtils)
        {
            string token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last().SanitizeValue()!;
            UsersLoginSessionData? usersData = await jwtUtils.ValidateJwtToken(token);

            if (usersData != null)
            {
                // attach account to context on successful jwt validation
                context.Items["SessionData"] = usersData;
            }
            var vSessionManager = new SessionManager();

            await _next(context);
        }
    }
}
