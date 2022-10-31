using Cinemachine;
using NUnit.Framework;
using UnityEngine;

namespace Tests.Runtime
{
    public class CinemachineRuntimeFixtureBase : CinemachineFixtureBase
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            
            // force a uniform deltaTime, otherwise tests will be unstable
            CinemachineCore.UniformDeltaTimeOverride = 0.1f;
            
            // disable delta time compensation for deterministic test results
            CinemachineCore.FrameDeltaCompensationEnabled = false;
        }
        
        [TearDown]
        public override void TearDown()
        {
            base.TearDown();
        }
    }
}
