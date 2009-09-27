﻿using System;
using NServiceBus.Host;

namespace LoggingFromAppConfig
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Client, IWantCustomLogging
    {
        public void Init()
        {
            Console.WriteLine("I'm using the logging configured in the app.config.");
        }
    }
}
