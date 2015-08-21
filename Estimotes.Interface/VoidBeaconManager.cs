using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;


namespace Estimotes {

	public class VoidBeaconManager : IBeaconManager {

        public async Task<BeaconInitStatus> Initialize() => BeaconInitStatus.Unknown;
		public void StartMonitoring(BeaconRegion region) {}
		public void StartRanging(BeaconRegion region) {}
		public void StopMonitoring(BeaconRegion region) {}
		public void StopRanging(BeaconRegion region) {}
		public void StopAllMonitoring() {}
		public void StopAllRanging() {}
        public async Task<IEnumerable<IBeacon>> FetchNearbyBeacons(BeaconRegion region, TimeSpan? time) {
            return new List<IBeacon>(0);
        }
        public event EventHandler<IEnumerable<IBeacon>> Ranged;
        public event EventHandler<BeaconRegionStatusChangedEventArgs> RegionStatusChanged;

		public IReadOnlyList<BeaconRegion> MonitoringRegions { get; } = new ReadOnlyCollection<BeaconRegion>(new List<BeaconRegion>(0));
		public IReadOnlyList<BeaconRegion> RangingRegions { get; } = new ReadOnlyCollection<BeaconRegion>(new List<BeaconRegion>(0));
    }
}