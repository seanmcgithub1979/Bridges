﻿using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Bridges.Extensions
{
    public static class AzureAdAuthenticationBuilderExtensions
    {
        public static AuthenticationBuilder AddAzureAd(this AuthenticationBuilder builder)
            => builder.AddAzureAd(_ => { });

        public static AuthenticationBuilder AddAzureAd(this AuthenticationBuilder builder, Action<AzureAdOptions> configureOptions)
        {
            builder.Services.Configure(configureOptions);
            builder.Services.AddSingleton<IConfigureOptions<OpenIdConnectOptions>, ConfigureAzureOptions>();
            builder.AddOpenIdConnect();
            return builder;
        }
    }
}
