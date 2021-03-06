﻿using System;

namespace Sdl.Community.SdlPluginInstaller.Model
{
    public class StudioVersion
    {
        public string Version { get; set; }
        public string PublicVersion { get; set; }
        public string InstallPath { get; set; }
        public Version ExecutableVersion { get; set; }

        public string Edition { get; set; }

        public override string ToString()
        {
            return string.Format($"{PublicVersion} {Edition} - {ExecutableVersion}");
        }
    }
}
