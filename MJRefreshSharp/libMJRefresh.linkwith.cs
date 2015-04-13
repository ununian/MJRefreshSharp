using System;
using ObjCRuntime;

[assembly: LinkWith("libMJRefresh.a", LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.ArmV7s | LinkTarget.Simulator64, SmartLink = true, ForceLoad = true)]

