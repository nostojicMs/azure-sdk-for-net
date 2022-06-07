﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Compute.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Tests
{
    public class VirtualMachineOperationsTests : VirtualMachineTestBase
    {
        public VirtualMachineOperationsTests(bool isAsync)
            : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        [TestCase]
        [RecordedTest]
        public async Task Delete()
        {
            var vmName = Recording.GenerateAssetName("testVM-");
            var vm = await CreateVirtualMachineAsync(vmName);
            await vm.DeleteAsync(WaitUntil.Completed);
        }

        [TestCase]
        [RecordedTest]
        public async Task Get()
        {
            var vmName = Recording.GenerateAssetName("testVM-");
            var vm = await CreateVirtualMachineAsync(vmName);
            VirtualMachineResource vm2 = await vm.GetAsync();

            ResourceDataHelper.AssertVirtualMachine(vm.Data, vm2.Data);
        }

        [TestCase]
        [RecordedTest]
        public async Task Update()
        {
            var vmName = Recording.GenerateAssetName("testVM-");
            var vm = await CreateVirtualMachineAsync(vmName);
            //// Create a PPG here and add this PPG to this virtual machine using Update
            //var ppgName = Recording.GenerateAssetName("testPPG-");
            //var ppgData = new ProximityPlacementGroupData(DefaultLocation) { };
            //var ppgLRO = await _resourceGroup.GetProximityPlacementGroups().CreateOrUpdateAsync(ppgName, ppgData);
            //var ppg = ppgLRO.Value;
            // update PPG requires the VM to be deallocated
            await vm.DeallocateAsync(WaitUntil.Completed);
            var update = new VirtualMachinePatch()
            {
                HardwareProfile = new HardwareProfile
                {
                    VmSize = VirtualMachineSizeTypes.StandardF1
                }
            };
            var lro = await vm.UpdateAsync(WaitUntil.Completed, update);
            VirtualMachineResource updatedVM = lro.Value;

            Assert.AreEqual(VirtualMachineSizeTypes.StandardF1, updatedVM.Data.HardwareProfile.VmSize);
        }

        [TestCase]
        [RecordedTest]
        public async Task PowerOff()
        {
            var vmName = Recording.GenerateAssetName("testVM-");
            var vm = await CreateVirtualMachineAsync(vmName);
            await vm.PowerOffAsync(WaitUntil.Completed);
        }

        [RecordedTest]
        public async Task BootDiagnostic()
        {
            string vmName = Recording.GenerateAssetName("testVM-");
            VirtualMachineResource virtualMachine = await CreateVirtualMachineAsync(vmName);
            Assert.IsNull(virtualMachine.Data.BootDiagnostics);

            VirtualMachinePatch updateOptions = new VirtualMachinePatch();
            updateOptions.BootDiagnostics = new BootDiagnostics();
            updateOptions.BootDiagnostics.Enabled = true;
            virtualMachine = (await virtualMachine.UpdateAsync(WaitUntil.Completed, updateOptions)).Value;
            Assert.AreEqual(true, virtualMachine.Data.BootDiagnostics.Enabled);

            updateOptions.BootDiagnostics = null;
            virtualMachine = (await virtualMachine.UpdateAsync(WaitUntil.Completed, updateOptions)).Value;
            var originalBootDiag = virtualMachine.Data.BootDiagnostics;
            var originalEnabled = virtualMachine.Data.BootDiagnostics?.Enabled;

            string vmName2 = Recording.GenerateAssetName("testVM-");
            VirtualMachineResource virtualMachine2 = await CreateVirtualMachineAsync(vmName2);
            Assert.IsNull(virtualMachine2.Data.DiagnosticsProfile?.BootDiagnostics);

            VirtualMachinePatch updateOptions2 = new VirtualMachinePatch();
            updateOptions2.DiagnosticsProfile = new DiagnosticsProfile();
            updateOptions2.DiagnosticsProfile.BootDiagnostics= new BootDiagnostics();
            updateOptions2.DiagnosticsProfile.BootDiagnostics.Enabled = true;
            virtualMachine2 = (await virtualMachine2.UpdateAsync(WaitUntil.Completed, updateOptions2)).Value;
            Assert.AreEqual(true, virtualMachine2.Data.DiagnosticsProfile.BootDiagnostics.Enabled);

            updateOptions2.DiagnosticsProfile.BootDiagnostics = null;
            virtualMachine2 = (await virtualMachine2.UpdateAsync(WaitUntil.Completed, updateOptions2)).Value;
            var newBootDiag = virtualMachine2.Data.DiagnosticsProfile?.BootDiagnostics;
            var newEnabled = virtualMachine2.Data.DiagnosticsProfile?.BootDiagnostics?.Enabled;
            Assert.AreEqual(originalBootDiag is null, newBootDiag is null);
            Assert.AreEqual(originalEnabled, newEnabled);

            updateOptions2.DiagnosticsProfile = null;
            virtualMachine2 = (await virtualMachine2.UpdateAsync(WaitUntil.Completed, updateOptions2)).Value;
            newBootDiag = virtualMachine2.Data.DiagnosticsProfile?.BootDiagnostics;
            newEnabled = virtualMachine2.Data.DiagnosticsProfile?.BootDiagnostics?.Enabled;
            Assert.AreEqual(originalBootDiag is null, newBootDiag is null);
            Assert.AreEqual(originalEnabled, newEnabled);
        }
    }
}
