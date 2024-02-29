using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetCore.RequiredForWebHelper
{
    internal class UsingIHostApplicationLifetime : IHostedService
    {
        private readonly IHostApplicationLifetime _appLifetime;

        public UsingIHostApplicationLifetime(IHostApplicationLifetime appLifetime)
        {
            _appLifetime = appLifetime;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _appLifetime.ApplicationStarted.Register(OnStarted);

            _appLifetime.ApplicationStopping.Register(OnStopping);

            _appLifetime.ApplicationStopped.Register(OnStopped);

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private void OnStarted()
        {
            // Actions to be performed when the application is started
        }

        private void OnStopping()
        {
            // Actions to be performed when the application is in the process of stopping
        }

        private void OnStopped()
        {
            // Actions to be performed when the application has completely stopped
        }
    }

}
