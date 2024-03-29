﻿using System.Threading.Tasks;

namespace Netch.Interfaces
{
    public interface IController
    {
        public string Name { get; }

        public Task StopAsync();
    }
}