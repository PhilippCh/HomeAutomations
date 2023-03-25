using System;
using System.Collections.Generic;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Entities.Core;
using System.Text.Json.Serialization;

namespace HomeAutomations.Models.Generated
{
	public interface IEntities
	{
		AlarmControlPanelEntities AlarmControlPanel { get; }

		BinarySensorEntities BinarySensor { get; }

		ButtonEntities Button { get; }

		CalendarEntities Calendar { get; }

		CameraEntities Camera { get; }

		ClimateEntities Climate { get; }

		CounterEntities Counter { get; }

		CoverEntities Cover { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		GroupEntities Group { get; }

		InputBooleanEntities InputBoolean { get; }

		InputNumberEntities InputNumber { get; }

		InputSelectEntities InputSelect { get; }

		InputTextEntities InputText { get; }

		LightEntities Light { get; }

		LockEntities Lock { get; }

		MediaPlayerEntities MediaPlayer { get; }

		NumberEntities Number { get; }

		PersistentNotificationEntities PersistentNotification { get; }

		PersonEntities Person { get; }

		RemoteEntities Remote { get; }

		SelectEntities Select { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		TimerEntities Timer { get; }

		UpdateEntities Update { get; }

		VacuumEntities Vacuum { get; }

		WeatherEntities Weather { get; }

		ZoneEntities Zone { get; }
	}

	public partial class Entities : IEntities
	{
		private readonly IHaContext _haContext;
		public Entities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelEntities AlarmControlPanel => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public ButtonEntities Button => new(_haContext);
		public CalendarEntities Calendar => new(_haContext);
		public CameraEntities Camera => new(_haContext);
		public ClimateEntities Climate => new(_haContext);
		public CounterEntities Counter => new(_haContext);
		public CoverEntities Cover => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public GroupEntities Group => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public InputNumberEntities InputNumber => new(_haContext);
		public InputSelectEntities InputSelect => new(_haContext);
		public InputTextEntities InputText => new(_haContext);
		public LightEntities Light => new(_haContext);
		public LockEntities Lock => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public NumberEntities Number => new(_haContext);
		public PersistentNotificationEntities PersistentNotification => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public RemoteEntities Remote => new(_haContext);
		public SelectEntities Select => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public TimerEntities Timer => new(_haContext);
		public UpdateEntities Update => new(_haContext);
		public VacuumEntities Vacuum => new(_haContext);
		public WeatherEntities Weather => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public partial class AlarmControlPanelEntities
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Intrusion Detection System</summary>
		public AlarmControlPanelEntity IntrusionDetectionSystem => new(_haContext, "alarm_control_panel.intrusion_detection_system");
	}

	public partial class BinarySensorEntities
	{
		private readonly IHaContext _haContext;
		public BinarySensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Balkontür links</summary>
		public BinarySensorEntity BalkonturLinks => new(_haContext, "binary_sensor.balkontur_links");
		///<summary>Balkontür links Battery</summary>
		public BinarySensorEntity BalkonturLinksBattery => new(_haContext, "binary_sensor.balkontur_links_battery");
		///<summary>Balkontür rechts</summary>
		public BinarySensorEntity BalkonturRechts => new(_haContext, "binary_sensor.balkontur_rechts");
		///<summary>Balkontür rechts Battery</summary>
		public BinarySensorEntity BalkonturRechtsBattery => new(_haContext, "binary_sensor.balkontur_rechts_battery");
		///<summary>bedroom/lava_lamp_update_available</summary>
		public BinarySensorEntity BedroomLavaLampUpdateAvailable => new(_haContext, "binary_sensor.bedroom_lava_lamp_update_available");
		///<summary>bedroom/roller_shutter_left_charging_status</summary>
		public BinarySensorEntity BedroomRollerShutterLeftChargingStatus => new(_haContext, "binary_sensor.bedroom_roller_shutter_left_charging_status");
		///<summary>bedroom/roller_shutter_left_running</summary>
		public BinarySensorEntity BedroomRollerShutterLeftRunning => new(_haContext, "binary_sensor.bedroom_roller_shutter_left_running");
		///<summary>bedroom/roller_shutter_left_update_available</summary>
		public BinarySensorEntity BedroomRollerShutterLeftUpdateAvailable => new(_haContext, "binary_sensor.bedroom_roller_shutter_left_update_available");
		///<summary>bedroom/roller_shutter_right_charging_status</summary>
		public BinarySensorEntity BedroomRollerShutterRightChargingStatus => new(_haContext, "binary_sensor.bedroom_roller_shutter_right_charging_status");
		///<summary>bedroom/roller_shutter_right_running</summary>
		public BinarySensorEntity BedroomRollerShutterRightRunning => new(_haContext, "binary_sensor.bedroom_roller_shutter_right_running");
		///<summary>bedroom/roller_shutter_right_update_available</summary>
		public BinarySensorEntity BedroomRollerShutterRightUpdateAvailable => new(_haContext, "binary_sensor.bedroom_roller_shutter_right_update_available");
		///<summary>desktop-171ttut Client</summary>
		public BinarySensorEntity Desktop171ttutClient => new(_haContext, "binary_sensor.desktop_171ttut_client");
		///<summary>desktop-171ttut Supports hairpinning</summary>
		public BinarySensorEntity Desktop171ttutSupportsHairpinning => new(_haContext, "binary_sensor.desktop_171ttut_supports_hairpinning");
		///<summary>desktop-171ttut Supports IPv6</summary>
		public BinarySensorEntity Desktop171ttutSupportsIpv6 => new(_haContext, "binary_sensor.desktop_171ttut_supports_ipv6");
		///<summary>desktop-171ttut Supports NAT-PMP</summary>
		public BinarySensorEntity Desktop171ttutSupportsNatPmp => new(_haContext, "binary_sensor.desktop_171ttut_supports_nat_pmp");
		///<summary>desktop-171ttut Supports PCP</summary>
		public BinarySensorEntity Desktop171ttutSupportsPcp => new(_haContext, "binary_sensor.desktop_171ttut_supports_pcp");
		///<summary>desktop-171ttut Supports UDP</summary>
		public BinarySensorEntity Desktop171ttutSupportsUdp => new(_haContext, "binary_sensor.desktop_171ttut_supports_udp");
		///<summary>desktop-171ttut Supports UPnP</summary>
		public BinarySensorEntity Desktop171ttutSupportsUpnp => new(_haContext, "binary_sensor.desktop_171ttut_supports_upnp");
		///<summary>DesktopFabienne</summary>
		public BinarySensorEntity Desktopfabienne => new(_haContext, "binary_sensor.desktopfabienne");
		///<summary>DesktopPhilipp</summary>
		public BinarySensorEntity Desktopphilipp => new(_haContext, "binary_sensor.desktopphilipp");
		///<summary>Fantenpad Focus</summary>
		public BinarySensorEntity FantenpadFocus => new(_haContext, "binary_sensor.fantenpad_focus");
		///<summary>FantenPhone2 Focus</summary>
		public BinarySensorEntity Fantenphone2Focus => new(_haContext, "binary_sensor.fantenphone2_focus");
		///<summary>Fantenrüssel Mop attached</summary>
		public BinarySensorEntity FantenrusselMopAttached => new(_haContext, "binary_sensor.fantenrussel_mop_attached");
		///<summary>Fantenrüssel Water box attached</summary>
		public BinarySensorEntity FantenrusselWaterBoxAttached => new(_haContext, "binary_sensor.fantenrussel_water_box_attached");
		///<summary>Fenster Arbeitszimmer</summary>
		public BinarySensorEntity FensterArbeitszimmer => new(_haContext, "binary_sensor.fenster_arbeitszimmer");
		///<summary>Fenster Arbeitszimmer Battery</summary>
		public BinarySensorEntity FensterArbeitszimmerBattery => new(_haContext, "binary_sensor.fenster_arbeitszimmer_battery");
		///<summary>Fenster Badezimmer</summary>
		public BinarySensorEntity FensterBadezimmer => new(_haContext, "binary_sensor.fenster_badezimmer");
		///<summary>Fenster Badezimmer Battery</summary>
		public BinarySensorEntity FensterBadezimmerBattery => new(_haContext, "binary_sensor.fenster_badezimmer_battery");
		///<summary>Fenster Schlafzimmer</summary>
		public BinarySensorEntity FensterSchlafzimmer => new(_haContext, "binary_sensor.fenster_schlafzimmer");
		///<summary>Fenster Schlafzimmer Battery</summary>
		public BinarySensorEntity FensterSchlafzimmerBattery => new(_haContext, "binary_sensor.fenster_schlafzimmer_battery");
		///<summary>home-desktop-fabienne Client</summary>
		public BinarySensorEntity HomeDesktopFabienneClient => new(_haContext, "binary_sensor.home_desktop_fabienne_client");
		///<summary>home-desktop-fabienne Supports hairpinning</summary>
		public BinarySensorEntity HomeDesktopFabienneSupportsHairpinning => new(_haContext, "binary_sensor.home_desktop_fabienne_supports_hairpinning");
		///<summary>home-desktop-fabienne Supports IPv6</summary>
		public BinarySensorEntity HomeDesktopFabienneSupportsIpv6 => new(_haContext, "binary_sensor.home_desktop_fabienne_supports_ipv6");
		///<summary>home-desktop-fabienne Supports NAT-PMP</summary>
		public BinarySensorEntity HomeDesktopFabienneSupportsNatPmp => new(_haContext, "binary_sensor.home_desktop_fabienne_supports_nat_pmp");
		///<summary>home-desktop-fabienne Supports PCP</summary>
		public BinarySensorEntity HomeDesktopFabienneSupportsPcp => new(_haContext, "binary_sensor.home_desktop_fabienne_supports_pcp");
		///<summary>home-desktop-fabienne Supports UDP</summary>
		public BinarySensorEntity HomeDesktopFabienneSupportsUdp => new(_haContext, "binary_sensor.home_desktop_fabienne_supports_udp");
		///<summary>home-desktop-fabienne Supports UPnP</summary>
		public BinarySensorEntity HomeDesktopFabienneSupportsUpnp => new(_haContext, "binary_sensor.home_desktop_fabienne_supports_upnp");
		///<summary>home-desktop-oma Client</summary>
		public BinarySensorEntity HomeDesktopOmaClient => new(_haContext, "binary_sensor.home_desktop_oma_client");
		///<summary>home-desktop-oma Supports hairpinning</summary>
		public BinarySensorEntity HomeDesktopOmaSupportsHairpinning => new(_haContext, "binary_sensor.home_desktop_oma_supports_hairpinning");
		///<summary>home-desktop-oma Supports IPv6</summary>
		public BinarySensorEntity HomeDesktopOmaSupportsIpv6 => new(_haContext, "binary_sensor.home_desktop_oma_supports_ipv6");
		///<summary>home-desktop-oma Supports NAT-PMP</summary>
		public BinarySensorEntity HomeDesktopOmaSupportsNatPmp => new(_haContext, "binary_sensor.home_desktop_oma_supports_nat_pmp");
		///<summary>home-desktop-oma Supports PCP</summary>
		public BinarySensorEntity HomeDesktopOmaSupportsPcp => new(_haContext, "binary_sensor.home_desktop_oma_supports_pcp");
		///<summary>home-desktop-oma Supports UDP</summary>
		public BinarySensorEntity HomeDesktopOmaSupportsUdp => new(_haContext, "binary_sensor.home_desktop_oma_supports_udp");
		///<summary>home-desktop-oma Supports UPnP</summary>
		public BinarySensorEntity HomeDesktopOmaSupportsUpnp => new(_haContext, "binary_sensor.home_desktop_oma_supports_upnp");
		///<summary>home-desktop-philipp Client</summary>
		public BinarySensorEntity HomeDesktopPhilippClient => new(_haContext, "binary_sensor.home_desktop_philipp_client");
		///<summary>home-desktop-philipp Supports hairpinning</summary>
		public BinarySensorEntity HomeDesktopPhilippSupportsHairpinning => new(_haContext, "binary_sensor.home_desktop_philipp_supports_hairpinning");
		///<summary>home-desktop-philipp Supports IPv6</summary>
		public BinarySensorEntity HomeDesktopPhilippSupportsIpv6 => new(_haContext, "binary_sensor.home_desktop_philipp_supports_ipv6");
		///<summary>home-desktop-philipp Supports NAT-PMP</summary>
		public BinarySensorEntity HomeDesktopPhilippSupportsNatPmp => new(_haContext, "binary_sensor.home_desktop_philipp_supports_nat_pmp");
		///<summary>home-desktop-philipp Supports PCP</summary>
		public BinarySensorEntity HomeDesktopPhilippSupportsPcp => new(_haContext, "binary_sensor.home_desktop_philipp_supports_pcp");
		///<summary>home-desktop-philipp Supports UDP</summary>
		public BinarySensorEntity HomeDesktopPhilippSupportsUdp => new(_haContext, "binary_sensor.home_desktop_philipp_supports_udp");
		///<summary>home-desktop-philipp Supports UPnP</summary>
		public BinarySensorEntity HomeDesktopPhilippSupportsUpnp => new(_haContext, "binary_sensor.home_desktop_philipp_supports_upnp");
		///<summary>home-k8s-master Client</summary>
		public BinarySensorEntity HomeK8sMasterClient => new(_haContext, "binary_sensor.home_k8s_master_client");
		///<summary>home-k8s-master Supports hairpinning</summary>
		public BinarySensorEntity HomeK8sMasterSupportsHairpinning => new(_haContext, "binary_sensor.home_k8s_master_supports_hairpinning");
		///<summary>home-k8s-master Supports IPv6</summary>
		public BinarySensorEntity HomeK8sMasterSupportsIpv6 => new(_haContext, "binary_sensor.home_k8s_master_supports_ipv6");
		///<summary>home-k8s-master Supports NAT-PMP</summary>
		public BinarySensorEntity HomeK8sMasterSupportsNatPmp => new(_haContext, "binary_sensor.home_k8s_master_supports_nat_pmp");
		///<summary>home-k8s-master Supports PCP</summary>
		public BinarySensorEntity HomeK8sMasterSupportsPcp => new(_haContext, "binary_sensor.home_k8s_master_supports_pcp");
		///<summary>home-k8s-master Supports UDP</summary>
		public BinarySensorEntity HomeK8sMasterSupportsUdp => new(_haContext, "binary_sensor.home_k8s_master_supports_udp");
		///<summary>home-k8s-master Supports UPnP</summary>
		public BinarySensorEntity HomeK8sMasterSupportsUpnp => new(_haContext, "binary_sensor.home_k8s_master_supports_upnp");
		///<summary>home-laptop-enbw Client</summary>
		public BinarySensorEntity HomeLaptopEnbwClient => new(_haContext, "binary_sensor.home_laptop_enbw_client");
		///<summary>home-laptop-enbw Supports hairpinning</summary>
		public BinarySensorEntity HomeLaptopEnbwSupportsHairpinning => new(_haContext, "binary_sensor.home_laptop_enbw_supports_hairpinning");
		///<summary>home-laptop-enbw Supports IPv6</summary>
		public BinarySensorEntity HomeLaptopEnbwSupportsIpv6 => new(_haContext, "binary_sensor.home_laptop_enbw_supports_ipv6");
		///<summary>home-laptop-enbw Supports NAT-PMP</summary>
		public BinarySensorEntity HomeLaptopEnbwSupportsNatPmp => new(_haContext, "binary_sensor.home_laptop_enbw_supports_nat_pmp");
		///<summary>home-laptop-enbw Supports PCP</summary>
		public BinarySensorEntity HomeLaptopEnbwSupportsPcp => new(_haContext, "binary_sensor.home_laptop_enbw_supports_pcp");
		///<summary>home-laptop-enbw Supports UDP</summary>
		public BinarySensorEntity HomeLaptopEnbwSupportsUdp => new(_haContext, "binary_sensor.home_laptop_enbw_supports_udp");
		///<summary>home-laptop-enbw Supports UPnP</summary>
		public BinarySensorEntity HomeLaptopEnbwSupportsUpnp => new(_haContext, "binary_sensor.home_laptop_enbw_supports_upnp");
		///<summary>home-laptop-fabienne Client</summary>
		public BinarySensorEntity HomeLaptopFabienneClient => new(_haContext, "binary_sensor.home_laptop_fabienne_client");
		///<summary>home-laptop-fabienne Supports hairpinning</summary>
		public BinarySensorEntity HomeLaptopFabienneSupportsHairpinning => new(_haContext, "binary_sensor.home_laptop_fabienne_supports_hairpinning");
		///<summary>home-laptop-fabienne Supports IPv6</summary>
		public BinarySensorEntity HomeLaptopFabienneSupportsIpv6 => new(_haContext, "binary_sensor.home_laptop_fabienne_supports_ipv6");
		///<summary>home-laptop-fabienne Supports NAT-PMP</summary>
		public BinarySensorEntity HomeLaptopFabienneSupportsNatPmp => new(_haContext, "binary_sensor.home_laptop_fabienne_supports_nat_pmp");
		///<summary>home-laptop-fabienne Supports PCP</summary>
		public BinarySensorEntity HomeLaptopFabienneSupportsPcp => new(_haContext, "binary_sensor.home_laptop_fabienne_supports_pcp");
		///<summary>home-laptop-fabienne Supports UDP</summary>
		public BinarySensorEntity HomeLaptopFabienneSupportsUdp => new(_haContext, "binary_sensor.home_laptop_fabienne_supports_udp");
		///<summary>home-laptop-fabienne Supports UPnP</summary>
		public BinarySensorEntity HomeLaptopFabienneSupportsUpnp => new(_haContext, "binary_sensor.home_laptop_fabienne_supports_upnp");
		///<summary>home-smartphone-fabienne Client</summary>
		public BinarySensorEntity HomeSmartphoneFabienneClient => new(_haContext, "binary_sensor.home_smartphone_fabienne_client");
		///<summary>home-smartphone-fabienne Supports hairpinning</summary>
		public BinarySensorEntity HomeSmartphoneFabienneSupportsHairpinning => new(_haContext, "binary_sensor.home_smartphone_fabienne_supports_hairpinning");
		///<summary>home-smartphone-fabienne Supports IPv6</summary>
		public BinarySensorEntity HomeSmartphoneFabienneSupportsIpv6 => new(_haContext, "binary_sensor.home_smartphone_fabienne_supports_ipv6");
		///<summary>home-smartphone-fabienne Supports NAT-PMP</summary>
		public BinarySensorEntity HomeSmartphoneFabienneSupportsNatPmp => new(_haContext, "binary_sensor.home_smartphone_fabienne_supports_nat_pmp");
		///<summary>home-smartphone-fabienne Supports PCP</summary>
		public BinarySensorEntity HomeSmartphoneFabienneSupportsPcp => new(_haContext, "binary_sensor.home_smartphone_fabienne_supports_pcp");
		///<summary>home-smartphone-fabienne Supports UDP</summary>
		public BinarySensorEntity HomeSmartphoneFabienneSupportsUdp => new(_haContext, "binary_sensor.home_smartphone_fabienne_supports_udp");
		///<summary>home-smartphone-fabienne Supports UPnP</summary>
		public BinarySensorEntity HomeSmartphoneFabienneSupportsUpnp => new(_haContext, "binary_sensor.home_smartphone_fabienne_supports_upnp");
		///<summary>home-smartphone-philipp Client</summary>
		public BinarySensorEntity HomeSmartphonePhilippClient => new(_haContext, "binary_sensor.home_smartphone_philipp_client");
		///<summary>home-smartphone-philipp Supports hairpinning</summary>
		public BinarySensorEntity HomeSmartphonePhilippSupportsHairpinning => new(_haContext, "binary_sensor.home_smartphone_philipp_supports_hairpinning");
		///<summary>home-smartphone-philipp Supports IPv6</summary>
		public BinarySensorEntity HomeSmartphonePhilippSupportsIpv6 => new(_haContext, "binary_sensor.home_smartphone_philipp_supports_ipv6");
		///<summary>home-smartphone-philipp Supports NAT-PMP</summary>
		public BinarySensorEntity HomeSmartphonePhilippSupportsNatPmp => new(_haContext, "binary_sensor.home_smartphone_philipp_supports_nat_pmp");
		///<summary>home-smartphone-philipp Supports PCP</summary>
		public BinarySensorEntity HomeSmartphonePhilippSupportsPcp => new(_haContext, "binary_sensor.home_smartphone_philipp_supports_pcp");
		///<summary>home-smartphone-philipp Supports UDP</summary>
		public BinarySensorEntity HomeSmartphonePhilippSupportsUdp => new(_haContext, "binary_sensor.home_smartphone_philipp_supports_udp");
		///<summary>home-smartphone-philipp Supports UPnP</summary>
		public BinarySensorEntity HomeSmartphonePhilippSupportsUpnp => new(_haContext, "binary_sensor.home_smartphone_philipp_supports_upnp");
		///<summary>home-tablet-hallway-android Client</summary>
		public BinarySensorEntity HomeTabletHallwayAndroidClient => new(_haContext, "binary_sensor.home_tablet_hallway_android_client");
		///<summary>home-tablet-hallway-android Supports hairpinning</summary>
		public BinarySensorEntity HomeTabletHallwayAndroidSupportsHairpinning => new(_haContext, "binary_sensor.home_tablet_hallway_android_supports_hairpinning");
		///<summary>home-tablet-hallway-android Supports IPv6</summary>
		public BinarySensorEntity HomeTabletHallwayAndroidSupportsIpv6 => new(_haContext, "binary_sensor.home_tablet_hallway_android_supports_ipv6");
		///<summary>home-tablet-hallway-android Supports NAT-PMP</summary>
		public BinarySensorEntity HomeTabletHallwayAndroidSupportsNatPmp => new(_haContext, "binary_sensor.home_tablet_hallway_android_supports_nat_pmp");
		///<summary>home-tablet-hallway-android Supports PCP</summary>
		public BinarySensorEntity HomeTabletHallwayAndroidSupportsPcp => new(_haContext, "binary_sensor.home_tablet_hallway_android_supports_pcp");
		///<summary>home-tablet-hallway-android Supports UDP</summary>
		public BinarySensorEntity HomeTabletHallwayAndroidSupportsUdp => new(_haContext, "binary_sensor.home_tablet_hallway_android_supports_udp");
		///<summary>home-tablet-hallway-android Supports UPnP</summary>
		public BinarySensorEntity HomeTabletHallwayAndroidSupportsUpnp => new(_haContext, "binary_sensor.home_tablet_hallway_android_supports_upnp");
		///<summary>home-tablet-ios Client</summary>
		public BinarySensorEntity HomeTabletIosClient => new(_haContext, "binary_sensor.home_tablet_ios_client");
		///<summary>home-tablet-ios Supports hairpinning</summary>
		public BinarySensorEntity HomeTabletIosSupportsHairpinning => new(_haContext, "binary_sensor.home_tablet_ios_supports_hairpinning");
		///<summary>home-tablet-ios Supports IPv6</summary>
		public BinarySensorEntity HomeTabletIosSupportsIpv6 => new(_haContext, "binary_sensor.home_tablet_ios_supports_ipv6");
		///<summary>home-tablet-ios Supports NAT-PMP</summary>
		public BinarySensorEntity HomeTabletIosSupportsNatPmp => new(_haContext, "binary_sensor.home_tablet_ios_supports_nat_pmp");
		///<summary>home-tablet-ios Supports PCP</summary>
		public BinarySensorEntity HomeTabletIosSupportsPcp => new(_haContext, "binary_sensor.home_tablet_ios_supports_pcp");
		///<summary>home-tablet-ios Supports UDP</summary>
		public BinarySensorEntity HomeTabletIosSupportsUdp => new(_haContext, "binary_sensor.home_tablet_ios_supports_udp");
		///<summary>home-tablet-ios Supports UPnP</summary>
		public BinarySensorEntity HomeTabletIosSupportsUpnp => new(_haContext, "binary_sensor.home_tablet_ios_supports_upnp");
		///<summary>home-thinclient-development Client</summary>
		public BinarySensorEntity HomeThinclientDevelopmentClient => new(_haContext, "binary_sensor.home_thinclient_development_client");
		///<summary>home-thinclient-development Supports hairpinning</summary>
		public BinarySensorEntity HomeThinclientDevelopmentSupportsHairpinning => new(_haContext, "binary_sensor.home_thinclient_development_supports_hairpinning");
		///<summary>home-thinclient-development Supports IPv6</summary>
		public BinarySensorEntity HomeThinclientDevelopmentSupportsIpv6 => new(_haContext, "binary_sensor.home_thinclient_development_supports_ipv6");
		///<summary>home-thinclient-development Supports NAT-PMP</summary>
		public BinarySensorEntity HomeThinclientDevelopmentSupportsNatPmp => new(_haContext, "binary_sensor.home_thinclient_development_supports_nat_pmp");
		///<summary>home-thinclient-development Supports PCP</summary>
		public BinarySensorEntity HomeThinclientDevelopmentSupportsPcp => new(_haContext, "binary_sensor.home_thinclient_development_supports_pcp");
		///<summary>home-thinclient-development Supports UDP</summary>
		public BinarySensorEntity HomeThinclientDevelopmentSupportsUdp => new(_haContext, "binary_sensor.home_thinclient_development_supports_udp");
		///<summary>home-thinclient-development Supports UPnP</summary>
		public BinarySensorEntity HomeThinclientDevelopmentSupportsUpnp => new(_haContext, "binary_sensor.home_thinclient_development_supports_upnp");
		///<summary>home-thinclient-living-room Client</summary>
		public BinarySensorEntity HomeThinclientLivingRoomClient => new(_haContext, "binary_sensor.home_thinclient_living_room_client");
		///<summary>home-thinclient-living-room Supports hairpinning</summary>
		public BinarySensorEntity HomeThinclientLivingRoomSupportsHairpinning => new(_haContext, "binary_sensor.home_thinclient_living_room_supports_hairpinning");
		///<summary>home-thinclient-living-room Supports IPv6</summary>
		public BinarySensorEntity HomeThinclientLivingRoomSupportsIpv6 => new(_haContext, "binary_sensor.home_thinclient_living_room_supports_ipv6");
		///<summary>home-thinclient-living-room Supports NAT-PMP</summary>
		public BinarySensorEntity HomeThinclientLivingRoomSupportsNatPmp => new(_haContext, "binary_sensor.home_thinclient_living_room_supports_nat_pmp");
		///<summary>home-thinclient-living-room Supports PCP</summary>
		public BinarySensorEntity HomeThinclientLivingRoomSupportsPcp => new(_haContext, "binary_sensor.home_thinclient_living_room_supports_pcp");
		///<summary>home-thinclient-living-room Supports UDP</summary>
		public BinarySensorEntity HomeThinclientLivingRoomSupportsUdp => new(_haContext, "binary_sensor.home_thinclient_living_room_supports_udp");
		///<summary>home-thinclient-living-room Supports UPnP</summary>
		public BinarySensorEntity HomeThinclientLivingRoomSupportsUpnp => new(_haContext, "binary_sensor.home_thinclient_living_room_supports_upnp");
		///<summary>iPhone Fabienne Focus</summary>
		public BinarySensorEntity IphoneFabienneFocus => new(_haContext, "binary_sensor.iphone_fabienne_focus");
		///<summary>iPhone Philipp Focus</summary>
		public BinarySensorEntity IphonePhilippFocus => new(_haContext, "binary_sensor.iphone_philipp_focus");
		///<summary>kitchen/cabinet_light_update_available</summary>
		public BinarySensorEntity KitchenCabinetLightUpdateAvailable => new(_haContext, "binary_sensor.kitchen_cabinet_light_update_available");
		///<summary>kitchen/ceiling_light_update_available</summary>
		public BinarySensorEntity KitchenCeilingLightUpdateAvailable => new(_haContext, "binary_sensor.kitchen_ceiling_light_update_available");
		///<summary>kitchen/motion_detector_occupancy</summary>
		public BinarySensorEntity KitchenMotionDetectorOccupancy => new(_haContext, "binary_sensor.kitchen_motion_detector_occupancy");
		///<summary>LaptopFabienne</summary>
		public BinarySensorEntity Laptopfabienne => new(_haContext, "binary_sensor.laptopfabienne");
		///<summary>LaptopPhilipp</summary>
		public BinarySensorEntity Laptopphilipp => new(_haContext, "binary_sensor.laptopphilipp");
		///<summary>Nuki battery low</summary>
		public BinarySensorEntity NukiBatteryLow => new(_haContext, "binary_sensor.nuki_battery_low");
		///<summary>Nuki Bridge Bridge Callback Set</summary>
		public BinarySensorEntity NukiBridgeBridgeCallbackSet => new(_haContext, "binary_sensor.nuki_bridge_bridge_callback_set");
		///<summary>Nuki Bridge Connected</summary>
		public BinarySensorEntity NukiBridgeConnected => new(_haContext, "binary_sensor.nuki_bridge_connected");
		///<summary>Nuki Haustür Battery Critical</summary>
		public BinarySensorEntity NukiHausturBatteryCritical => new(_haContext, "binary_sensor.nuki_haustur_battery_critical");
		///<summary>Nuki Haustür Locked</summary>
		public BinarySensorEntity NukiHausturLocked => new(_haContext, "binary_sensor.nuki_haustur_locked");
		///<summary>Nuki Haustür Ring Action</summary>
		public BinarySensorEntity NukiHausturRingAction => new(_haContext, "binary_sensor.nuki_haustur_ring_action");
		///<summary>Nuki Wohnungstür Battery Charging</summary>
		public BinarySensorEntity NukiWohnungsturBatteryCharging => new(_haContext, "binary_sensor.nuki_wohnungstur_battery_charging");
		///<summary>Nuki Wohnungstür Battery Critical</summary>
		public BinarySensorEntity NukiWohnungsturBatteryCritical => new(_haContext, "binary_sensor.nuki_wohnungstur_battery_critical");
		///<summary>Nuki Wohnungstür Locked</summary>
		public BinarySensorEntity NukiWohnungsturLocked => new(_haContext, "binary_sensor.nuki_wohnungstur_locked");
		///<summary>PupsStation (Drive 1) Below Min Remaining Life</summary>
		public BinarySensorEntity PupsstationBelowMinRemainingLife => new(_haContext, "binary_sensor.pupsstation_below_min_remaining_life");
		///<summary>PupsStation (Drive 2) Below Min Remaining Life</summary>
		public BinarySensorEntity PupsstationBelowMinRemainingLife2 => new(_haContext, "binary_sensor.pupsstation_below_min_remaining_life_2");
		///<summary>PupsStation (Drive 3) Below Min Remaining Life</summary>
		public BinarySensorEntity PupsstationBelowMinRemainingLife3 => new(_haContext, "binary_sensor.pupsstation_below_min_remaining_life_3");
		///<summary>pupsstation Client</summary>
		public BinarySensorEntity PupsstationClient => new(_haContext, "binary_sensor.pupsstation_client");
		///<summary>PupsStation (Drive 1) Exceeded Max Bad Sectors</summary>
		public BinarySensorEntity PupsstationExceededMaxBadSectors => new(_haContext, "binary_sensor.pupsstation_exceeded_max_bad_sectors");
		///<summary>PupsStation (Drive 2) Exceeded Max Bad Sectors</summary>
		public BinarySensorEntity PupsstationExceededMaxBadSectors2 => new(_haContext, "binary_sensor.pupsstation_exceeded_max_bad_sectors_2");
		///<summary>PupsStation (Drive 3) Exceeded Max Bad Sectors</summary>
		public BinarySensorEntity PupsstationExceededMaxBadSectors3 => new(_haContext, "binary_sensor.pupsstation_exceeded_max_bad_sectors_3");
		///<summary>PupsStation Security Status</summary>
		public BinarySensorEntity PupsstationSecurityStatus => new(_haContext, "binary_sensor.pupsstation_security_status");
		///<summary>pupsstation Supports hairpinning</summary>
		public BinarySensorEntity PupsstationSupportsHairpinning => new(_haContext, "binary_sensor.pupsstation_supports_hairpinning");
		///<summary>pupsstation Supports IPv6</summary>
		public BinarySensorEntity PupsstationSupportsIpv6 => new(_haContext, "binary_sensor.pupsstation_supports_ipv6");
		///<summary>pupsstation Supports NAT-PMP</summary>
		public BinarySensorEntity PupsstationSupportsNatPmp => new(_haContext, "binary_sensor.pupsstation_supports_nat_pmp");
		///<summary>pupsstation Supports PCP</summary>
		public BinarySensorEntity PupsstationSupportsPcp => new(_haContext, "binary_sensor.pupsstation_supports_pcp");
		///<summary>pupsstation Supports UDP</summary>
		public BinarySensorEntity PupsstationSupportsUdp => new(_haContext, "binary_sensor.pupsstation_supports_udp");
		///<summary>pupsstation Supports UPnP</summary>
		public BinarySensorEntity PupsstationSupportsUpnp => new(_haContext, "binary_sensor.pupsstation_supports_upnp");
		///<summary>study/motion_detector_occupancy</summary>
		public BinarySensorEntity StudyMotionDetectorOccupancy => new(_haContext, "binary_sensor.study_motion_detector_occupancy");
		///<summary>Thermostat Arbeitszimmer Battery</summary>
		public BinarySensorEntity ThermostatArbeitszimmerBattery => new(_haContext, "binary_sensor.thermostat_arbeitszimmer_battery");
		///<summary>Thermostat Badezimmer Battery</summary>
		public BinarySensorEntity ThermostatBadezimmerBattery => new(_haContext, "binary_sensor.thermostat_badezimmer_battery");
		///<summary>Thermostat Küche Battery</summary>
		public BinarySensorEntity ThermostatKucheBattery => new(_haContext, "binary_sensor.thermostat_kuche_battery");
		///<summary>Thermostat Schlafzimmer Battery</summary>
		public BinarySensorEntity ThermostatSchlafzimmerBattery => new(_haContext, "binary_sensor.thermostat_schlafzimmer_battery");
		///<summary>Thermostat Wohnzimmer Battery</summary>
		public BinarySensorEntity ThermostatWohnzimmerBattery => new(_haContext, "binary_sensor.thermostat_wohnzimmer_battery");
		///<summary>Updater</summary>
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
		///<summary>Wallpanel Hallway AC Plugged</summary>
		public BinarySensorEntity WallpanelHallwayAcPlugged => new(_haContext, "binary_sensor.wallpanel_hallway_ac_plugged");
		///<summary>Wallpanel Hallway Charging</summary>
		public BinarySensorEntity WallpanelHallwayCharging => new(_haContext, "binary_sensor.wallpanel_hallway_charging");
		///<summary>Wallpanel Hallway Motion Detected</summary>
		public BinarySensorEntity WallpanelHallwayMotionDetected => new(_haContext, "binary_sensor.wallpanel_hallway_motion_detected");
		///<summary>Wallpanel Hallway USB Plugged</summary>
		public BinarySensorEntity WallpanelHallwayUsbPlugged => new(_haContext, "binary_sensor.wallpanel_hallway_usb_plugged");
	}

	public partial class ButtonEntities
	{
		private readonly IHaContext _haContext;
		public ButtonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Nuki Bridge Firmware Update</summary>
		public ButtonEntity NukiBridgeFirmwareUpdate => new(_haContext, "button.nuki_bridge_firmware_update");
		///<summary>Nuki Bridge Reboot</summary>
		public ButtonEntity NukiBridgeReboot => new(_haContext, "button.nuki_bridge_reboot");
		///<summary>PupsStation Reboot</summary>
		public ButtonEntity PupsstationReboot => new(_haContext, "button.pupsstation_reboot");
		///<summary>PupsStation Shutdown</summary>
		public ButtonEntity PupsstationShutdown => new(_haContext, "button.pupsstation_shutdown");
	}

	public partial class CalendarEntities
	{
		private readonly IHaContext _haContext;
		public CalendarEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Calendar</summary>
		public CalendarEntity CalendarPhilipp => new(_haContext, "calendar.calendar_philipp");
		///<summary>Deutsche Feiertage</summary>
		public CalendarEntity DeutscheFeiertagePhilipp => new(_haContext, "calendar.deutsche_feiertage_philipp");
		///<summary>FILIADATA</summary>
		public CalendarEntity FiliadataPhilipp => new(_haContext, "calendar.filiadata_philipp");
		///<summary>Geburtstagskalender</summary>
		public CalendarEntity GeburtstagskalenderPhilipp => new(_haContext, "calendar.geburtstagskalender_philipp");
		///<summary>TINF11B2</summary>
		public CalendarEntity Tinf11b2Philipp => new(_haContext, "calendar.tinf11b2_philipp");
	}

	public partial class CameraEntities
	{
		private readonly IHaContext _haContext;
		public CameraEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Fantenrüssel_Map</summary>
		public CameraEntity FantenrusselMap => new(_haContext, "camera.fantenrussel_map");
		///<summary>Wohnzimmer Camera</summary>
		public CameraEntity WohnzimmerCamera => new(_haContext, "camera.wohnzimmer_camera");
	}

	public partial class ClimateEntities
	{
		private readonly IHaContext _haContext;
		public ClimateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Room Climate Arbeitszimmer</summary>
		public ClimateEntity RoomClimateArbeitszimmer => new(_haContext, "climate.room_climate_arbeitszimmer");
		///<summary>Room Climate Badezimmer</summary>
		public ClimateEntity RoomClimateBadezimmer => new(_haContext, "climate.room_climate_badezimmer");
		///<summary>Room Climate Küche</summary>
		public ClimateEntity RoomClimateKuche => new(_haContext, "climate.room_climate_kuche");
		///<summary>Room Climate Schlafzimmer</summary>
		public ClimateEntity RoomClimateSchlafzimmer => new(_haContext, "climate.room_climate_schlafzimmer");
		///<summary>Room Climate Wohnzimmer</summary>
		public ClimateEntity RoomClimateWohnzimmer => new(_haContext, "climate.room_climate_wohnzimmer");
	}

	public partial class CounterEntities
	{
		private readonly IHaContext _haContext;
		public CounterEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public CounterEntity KratomIntakeDay => new(_haContext, "counter.kratom_intake_day");
		public CounterEntity MeditationMinutesWeek => new(_haContext, "counter.meditation_minutes_week");
	}

	public partial class CoverEntities
	{
		private readonly IHaContext _haContext;
		public CoverEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>bedroom/roller_shutter_left</summary>
		public CoverEntity BedroomRollerShutterLeft => new(_haContext, "cover.bedroom_roller_shutter_left");
		///<summary>bedroom/roller_shutter_right</summary>
		public CoverEntity BedroomRollerShutterRight => new(_haContext, "cover.bedroom_roller_shutter_right");
	}

	public partial class DeviceTrackerEntities
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>iPhone Fabienne</summary>
		public DeviceTrackerEntity Fabienne => new(_haContext, "device_tracker.fabienne");
		///<summary>FantenPhone2</summary>
		public DeviceTrackerEntity Fantenphone2 => new(_haContext, "device_tracker.fantenphone2");
		///<summary>Fantenpad</summary>
		public DeviceTrackerEntity IpadVonFabienne => new(_haContext, "device_tracker.ipad_von_fabienne");
		///<summary>Philipp</summary>
		public DeviceTrackerEntity IphonePhilipp => new(_haContext, "device_tracker.iphone_philipp");
		///<summary>iPhone Philipp</summary>
		public DeviceTrackerEntity IphonePhilipp2 => new(_haContext, "device_tracker.iphone_philipp_2");
		///<summary>philipp</summary>
		public DeviceTrackerEntity Philipp2b775363D7b348719abc6f36aa202757 => new(_haContext, "device_tracker.philipp_2b775363_d7b3_4871_9abc_6f36aa202757");
	}

	public partial class GroupEntities
	{
		private readonly IHaContext _haContext;
		public GroupEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alle Fenster</summary>
		public GroupEntity Allwindows => new(_haContext, "group.allwindows");
	}

	public partial class InputBooleanEntities
	{
		private readonly IHaContext _haContext;
		public InputBooleanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Barcode scanner connected?</summary>
		public InputBooleanEntity BarcodeScannerConnected => new(_haContext, "input_boolean.barcode_scanner_connected");
		///<summary>Desktop Fabienne</summary>
		public InputBooleanEntity ComputerWolDesktopFabienne => new(_haContext, "input_boolean.computer_wol_desktop_fabienne");
		///<summary>Desktop Philipp</summary>
		public InputBooleanEntity ComputerWolDesktopPhilipp => new(_haContext, "input_boolean.computer_wol_desktop_philipp");
		///<summary>Enable motion detector</summary>
		public InputBooleanEntity EnableMotionDetector => new(_haContext, "input_boolean.enable_motion_detector");
		///<summary>Meditation active?</summary>
		public InputBooleanEntity MeditationActive => new(_haContext, "input_boolean.meditation_active");
		///<summary>Shut down harmony activity after moonlight stream ends?</summary>
		public InputBooleanEntity MoonlightShutdownHarmony => new(_haContext, "input_boolean.moonlight_shutdown_harmony");
		///<summary>Shut down host after moonlight stream ends?</summary>
		public InputBooleanEntity MoonlightShutdownHost => new(_haContext, "input_boolean.moonlight_shutdown_host");
		///<summary>Kontrolliere Kino-Lichter</summary>
		public InputBooleanEntity MovieTimeEnableLightControl => new(_haContext, "input_boolean.movie_time_enable_light_control");
		///<summary>netdaemon_home_automations_apps_calorie_counter_calorie_counter</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsCalorieCounterCalorieCounter => new(_haContext, "input_boolean.netdaemon_home_automations_apps_calorie_counter_calorie_counter");
		///<summary>netdaemon_home_automations_apps_computer_switches_computer_switches</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsComputerSwitchesComputerSwitches => new(_haContext, "input_boolean.netdaemon_home_automations_apps_computer_switches_computer_switches");
		///<summary>netdaemon_home_automations_apps_counters_kratom_counter_kratom_counter</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsCountersKratomCounterKratomCounter => new(_haContext, "input_boolean.netdaemon_home_automations_apps_counters_kratom_counter_kratom_counter");
		///<summary>netdaemon_home_automations_apps_counters_water_counter_water_counter</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsCountersWaterCounterWaterCounter => new(_haContext, "input_boolean.netdaemon_home_automations_apps_counters_water_counter_water_counter");
		///<summary>netdaemon_home_automations_apps_door_lock_door_lock</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsDoorLockDoorLock => new(_haContext, "input_boolean.netdaemon_home_automations_apps_door_lock_door_lock");
		///<summary>netdaemon_home_automations_apps_kite_reminder_kite_reminder</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsKiteReminderKiteReminder => new(_haContext, "input_boolean.netdaemon_home_automations_apps_kite_reminder_kite_reminder");
		///<summary>netdaemon_home_automations_apps_lights_automatic_lights_automatic_lights</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsLightsAutomaticLightsAutomaticLights => new(_haContext, "input_boolean.netdaemon_home_automations_apps_lights_automatic_lights_automatic_lights");
		///<summary>netdaemon_home_automations_apps_lights_scheduled_lights_scheduled_lights</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsLightsScheduledLightsScheduledLights => new(_haContext, "input_boolean.netdaemon_home_automations_apps_lights_scheduled_lights_scheduled_lights");
		///<summary>netdaemon_home_automations_apps_living_room_button_living_room_button</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsLivingRoomButtonLivingRoomButton => new(_haContext, "input_boolean.netdaemon_home_automations_apps_living_room_button_living_room_button");
		///<summary>netdaemon_home_automations_apps_moonlight_remote_moonlight_remote</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsMoonlightRemoteMoonlightRemote => new(_haContext, "input_boolean.netdaemon_home_automations_apps_moonlight_remote_moonlight_remote");
		///<summary>netdaemon_home_automations_apps_motion_detector_motion_detector</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsMotionDetectorMotionDetector => new(_haContext, "input_boolean.netdaemon_home_automations_apps_motion_detector_motion_detector");
		///<summary>netdaemon_home_automations_apps_movie_time_movie_time</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsMovieTimeMovieTime => new(_haContext, "input_boolean.netdaemon_home_automations_apps_movie_time_movie_time");
		///<summary>netdaemon_home_automations_apps_razor_blade_usage_razor_blade_usage</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsRazorBladeUsageRazorBladeUsage => new(_haContext, "input_boolean.netdaemon_home_automations_apps_razor_blade_usage_razor_blade_usage");
		///<summary>netdaemon_home_automations_apps_shutters_shutters</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsShuttersShutters => new(_haContext, "input_boolean.netdaemon_home_automations_apps_shutters_shutters");
		///<summary>netdaemon_home_automations_apps_sleep_soundscapes_sleep_soundscapes</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsSleepSoundscapesSleepSoundscapes => new(_haContext, "input_boolean.netdaemon_home_automations_apps_sleep_soundscapes_sleep_soundscapes");
		///<summary>netdaemon_home_automations_apps_study_automations_study_automations</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsStudyAutomationsStudyAutomations => new(_haContext, "input_boolean.netdaemon_home_automations_apps_study_automations_study_automations");
		///<summary>netdaemon_home_automations_apps_training_schedule_training_schedule</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsTrainingScheduleTrainingSchedule => new(_haContext, "input_boolean.netdaemon_home_automations_apps_training_schedule_training_schedule");
		///<summary>netdaemon_home_automations_apps_trash_reminder_trash_reminder</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsTrashReminderTrashReminder => new(_haContext, "input_boolean.netdaemon_home_automations_apps_trash_reminder_trash_reminder");
		///<summary>netdaemon_home_automations_apps_update_instagram_token_update_instagram_token</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsUpdateInstagramTokenUpdateInstagramToken => new(_haContext, "input_boolean.netdaemon_home_automations_apps_update_instagram_token_update_instagram_token");
		///<summary>netdaemon_home_automations_apps_vacuum_vacuum</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsVacuumVacuum => new(_haContext, "input_boolean.netdaemon_home_automations_apps_vacuum_vacuum");
		///<summary>netdaemon_home_automations_apps_wall_panel_wall_panel_monitor</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsWallPanelWallPanelMonitor => new(_haContext, "input_boolean.netdaemon_home_automations_apps_wall_panel_wall_panel_monitor");
		///<summary>Override desk lamp</summary>
		public InputBooleanEntity OverrideDeskLamp => new(_haContext, "input_boolean.override_desk_lamp");
		///<summary>Bio</summary>
		public InputBooleanEntity TrashBio => new(_haContext, "input_boolean.trash_bio");
		///<summary>Glas</summary>
		public InputBooleanEntity TrashGlass => new(_haContext, "input_boolean.trash_glass");
		///<summary>Papier</summary>
		public InputBooleanEntity TrashPaper => new(_haContext, "input_boolean.trash_paper");
		///<summary>Gelber Sack</summary>
		public InputBooleanEntity TrashRecycling => new(_haContext, "input_boolean.trash_recycling");
		///<summary>Wir sind dran</summary>
		public InputBooleanEntity TrashTakeOutside => new(_haContext, "input_boolean.trash_take_outside");
		///<summary>Restmüll</summary>
		public InputBooleanEntity TrashWaste => new(_haContext, "input_boolean.trash_waste");
	}

	public partial class InputNumberEntities
	{
		private readonly IHaContext _haContext;
		public InputNumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Kitchen scale calories</summary>
		public InputNumberEntity KitchenScaleCalories => new(_haContext, "input_number.kitchen_scale_calories");
		///<summary>Daily kratom intake</summary>
		public InputNumberEntity KratomIntakeDaily => new(_haContext, "input_number.kratom_intake_daily");
		///<summary>Maximum daily kratom intake</summary>
		public InputNumberEntity MaxKratomIntakeDaily => new(_haContext, "input_number.max_kratom_intake_daily");
		///<summary>Rasuren bis zum Klingenwechsel</summary>
		public InputNumberEntity MaxShavesBeforeChange => new(_haContext, "input_number.max_shaves_before_change");
		///<summary>Meditation timer (minutes)</summary>
		public InputNumberEntity MeditationTimerMinutes => new(_haContext, "input_number.meditation_timer_minutes");
		///<summary>Moonlight running PID</summary>
		public InputNumberEntity MoonlightPid => new(_haContext, "input_number.moonlight_pid");
		///<summary>Bewegungsmelder Aktivierungsdauer (Sekunden)</summary>
		public InputNumberEntity MotionSensorIdleSecs => new(_haContext, "input_number.motion_sensor_idle_secs");
		///<summary>Night</summary>
		public InputNumberEntity Nighttime => new(_haContext, "input_number.nighttime");
	}

	public partial class InputSelectEntities
	{
		private readonly IHaContext _haContext;
		public InputSelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Active Chrome Remote Media Control Device</summary>
		public InputSelectEntity ChromeRemoteMediaControlDevices => new(_haContext, "input_select.chrome_remote_media_control_devices");
		///<summary>Kitchen scale selected product</summary>
		public InputSelectEntity KitchenScaleSelectedProduct => new(_haContext, "input_select.kitchen_scale_selected_product");
		///<summary>Spiel</summary>
		public InputSelectEntity MoonlightSelectedGame => new(_haContext, "input_select.moonlight_selected_game");
		///<summary>Zielgerät</summary>
		public InputSelectEntity MoonlightSelectedHost => new(_haContext, "input_select.moonlight_selected_host");
	}

	public partial class InputTextEntities
	{
		private readonly IHaContext _haContext;
		public InputTextEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Calorie counter</summary>
		public InputTextEntity CalorieCounter => new(_haContext, "input_text.calorie_counter");
		///<summary>Kitchen scale nutriscore grade</summary>
		public InputTextEntity KitchenScaleNutriscoreGrade => new(_haContext, "input_text.kitchen_scale_nutriscore_grade");
		///<summary>Kitchen scale nutriscore url</summary>
		public InputTextEntity KitchenScaleNutriscoreUrl => new(_haContext, "input_text.kitchen_scale_nutriscore_url");
		///<summary>Kitchen scale search term</summary>
		public InputTextEntity KitchenScaleSearchTerm => new(_haContext, "input_text.kitchen_scale_search_term");
		///<summary>Moonlight current host</summary>
		public InputTextEntity MoonlightCurrentHost => new(_haContext, "input_text.moonlight_current_host");
		///<summary>Vacuum State Test</summary>
		public InputTextEntity VacuumStateTest => new(_haContext, "input_text.vacuum_state_test");
	}

	public partial class LightEntities
	{
		private readonly IHaContext _haContext;
		public LightEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>bedroom/bedside_light_fabienne</summary>
		public LightEntity BedroomBedsideLightFabienne => new(_haContext, "light.bedroom_bedside_light_fabienne");
		///<summary>kitchen/cabinet_light</summary>
		public LightEntity KitchenCabinetLight => new(_haContext, "light.kitchen_cabinet_light");
		///<summary>kitchen/ceiling_light</summary>
		public LightEntity KitchenCeilingLight => new(_haContext, "light.kitchen_ceiling_light");
		///<summary>living_room/standard_lamp</summary>
		public LightEntity LivingRoomStandardLamp => new(_haContext, "light.living_room_standard_lamp");
		///<summary>living_room/tv_lightstrip</summary>
		public LightEntity LivingRoomTvLightstrip => new(_haContext, "light.living_room_tv_lightstrip");
		///<summary>study/desk_lamp</summary>
		public LightEntity StudyDeskLamp => new(_haContext, "light.study_desk_lamp");
	}

	public partial class LockEntities
	{
		private readonly IHaContext _haContext;
		public LockEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>bedroom/lava_lamp_child_lock</summary>
		public LockEntity BedroomLavaLampChildLock => new(_haContext, "lock.bedroom_lava_lamp_child_lock");
		///<summary>Nuki</summary>
		public LockEntity Nuki => new(_haContext, "lock.nuki");
		///<summary>Nuki Haustür Lock</summary>
		public LockEntity NukiHausturLock => new(_haContext, "lock.nuki_haustur_lock");
		///<summary>Nuki Wohnungstür Lock</summary>
		public LockEntity NukiWohnungsturLock => new(_haContext, "lock.nuki_wohnungstur_lock");
	}

	public partial class MediaPlayerEntities
	{
		private readonly IHaContext _haContext;
		public MediaPlayerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>master_bedroom_speaker</summary>
		public MediaPlayerEntity MasterBedroomSpeaker => new(_haContext, "media_player.master_bedroom_speaker");
		///<summary>Hall Display</summary>
		public MediaPlayerEntity Nesthub4ae6 => new(_haContext, "media_player.nesthub4ae6");
	}

	public partial class NumberEntities
	{
		private readonly IHaContext _haContext;
		public NumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Nuki LED brightness</summary>
		public NumberEntity NukiLedBrightness => new(_haContext, "number.nuki_led_brightness");
		///<summary>Raumthermostat Schlafzimmer Offset</summary>
		public NumberEntity RaumthermostatSchlafzimmerOffset => new(_haContext, "number.raumthermostat_schlafzimmer_offset");
		///<summary>Thermostat Arbeitszimmer Offset</summary>
		public NumberEntity ThermostatArbeitszimmerOffset => new(_haContext, "number.thermostat_arbeitszimmer_offset");
		///<summary>Thermostat Badezimmer Offset</summary>
		public NumberEntity ThermostatBadezimmerOffset => new(_haContext, "number.thermostat_badezimmer_offset");
		///<summary>Thermostat Küche Offset</summary>
		public NumberEntity ThermostatKucheOffset => new(_haContext, "number.thermostat_kuche_offset");
		///<summary>Thermostat Schlafzimmer Offset</summary>
		public NumberEntity ThermostatSchlafzimmerOffset => new(_haContext, "number.thermostat_schlafzimmer_offset");
		///<summary>Thermostat Wohnzimmer Offset</summary>
		public NumberEntity ThermostatWohnzimmerOffset => new(_haContext, "number.thermostat_wohnzimmer_offset");
	}

	public partial class PersistentNotificationEntities
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Invalid config</summary>
		public PersistentNotificationEntity InvalidConfig => new(_haContext, "persistent_notification.invalid_config");
		///<summary>Package 1Z14597W6808897066 delivered</summary>
		public PersistentNotificationEntity Package1z14597w6808897066Delivered => new(_haContext, "persistent_notification.package_1z14597w6808897066_delivered");
	}

	public partial class PersonEntities
	{
		private readonly IHaContext _haContext;
		public PersonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Fabienne</summary>
		public PersonEntity Fabienne => new(_haContext, "person.fabienne");
		///<summary>Philipp</summary>
		public PersonEntity Philipp => new(_haContext, "person.philipp");
	}

	public partial class RemoteEntities
	{
		private readonly IHaContext _haContext;
		public RemoteEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Fernbedienung</summary>
		public RemoteEntity FernbedienungRemote => new(_haContext, "remote.fernbedienung_remote");
	}

	public partial class SelectEntities
	{
		private readonly IHaContext _haContext;
		public SelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>bedroom/bedside_light_fabienne_power_on_behavior</summary>
		public SelectEntity BedroomBedsideLightFabiennePowerOnBehavior => new(_haContext, "select.bedroom_bedside_light_fabienne_power_on_behavior");
		///<summary>bedroom/lava_lamp_indicator_mode</summary>
		public SelectEntity BedroomLavaLampIndicatorMode => new(_haContext, "select.bedroom_lava_lamp_indicator_mode");
		///<summary>bedroom/lava_lamp_power_outage_memory</summary>
		public SelectEntity BedroomLavaLampPowerOutageMemory => new(_haContext, "select.bedroom_lava_lamp_power_outage_memory");
		///<summary>kitchen/cabinet_light_power_on_behavior</summary>
		public SelectEntity KitchenCabinetLightPowerOnBehavior => new(_haContext, "select.kitchen_cabinet_light_power_on_behavior");
		///<summary>kitchen/ceiling_light_power_on_behavior</summary>
		public SelectEntity KitchenCeilingLightPowerOnBehavior => new(_haContext, "select.kitchen_ceiling_light_power_on_behavior");
		///<summary>living_room/christmas_stars Indicator light mode</summary>
		public SelectEntity LivingRoomChristmasStarsIndicatorLightMode => new(_haContext, "select.living_room_christmas_stars_indicator_light_mode");
		///<summary>living_room/christmas_stars Power on behavior</summary>
		public SelectEntity LivingRoomChristmasStarsPowerOnBehavior => new(_haContext, "select.living_room_christmas_stars_power_on_behavior");
		///<summary>living_room/christmas_tree Indicator light mode</summary>
		public SelectEntity LivingRoomChristmasTreeIndicatorLightMode => new(_haContext, "select.living_room_christmas_tree_indicator_light_mode");
		///<summary>living_room/christmas_tree Power on behavior</summary>
		public SelectEntity LivingRoomChristmasTreePowerOnBehavior => new(_haContext, "select.living_room_christmas_tree_power_on_behavior");
		///<summary>living_room/standard_lamp_power_on_behavior</summary>
		public SelectEntity LivingRoomStandardLampPowerOnBehavior => new(_haContext, "select.living_room_standard_lamp_power_on_behavior");
	}

	public partial class SensorEntities
	{
		private readonly IHaContext _haContext;
		public SensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>living_room/lamp_switch_battery</summary>
		public NumericSensorEntity E0x90ab96fffe180250Battery => new(_haContext, "sensor.0x90ab96fffe180250_battery");
		///<summary>AMC Entertainment Holdings Inc</summary>
		public NumericSensorEntity AmcEntertainmentHoldingsInc => new(_haContext, "sensor.amc_entertainment_holdings_inc");
		///<summary>bathroom/razor_blade_usage_battery</summary>
		public NumericSensorEntity BathroomRazorBladeUsageBattery => new(_haContext, "sensor.bathroom_razor_blade_usage_battery");
		///<summary>bathroom/razor_blade_usage_device_temperature</summary>
		public NumericSensorEntity BathroomRazorBladeUsageDeviceTemperature => new(_haContext, "sensor.bathroom_razor_blade_usage_device_temperature");
		///<summary>bedroom/bedside_light_switch_fabienne_battery</summary>
		public NumericSensorEntity BedroomBedsideLightSwitchFabienneBattery => new(_haContext, "sensor.bedroom_bedside_light_switch_fabienne_battery");
		///<summary>bedroom/bedside_light_switch_fabienne_device_temperature</summary>
		public NumericSensorEntity BedroomBedsideLightSwitchFabienneDeviceTemperature => new(_haContext, "sensor.bedroom_bedside_light_switch_fabienne_device_temperature");
		///<summary>bedroom/bedside_light_switch_philipp_battery</summary>
		public NumericSensorEntity BedroomBedsideLightSwitchPhilippBattery => new(_haContext, "sensor.bedroom_bedside_light_switch_philipp_battery");
		///<summary>bedroom/bedside_light_switch_philipp_device_temperature</summary>
		public NumericSensorEntity BedroomBedsideLightSwitchPhilippDeviceTemperature => new(_haContext, "sensor.bedroom_bedside_light_switch_philipp_device_temperature");
		///<summary>bedroom/lava_lamp_energy</summary>
		public NumericSensorEntity BedroomLavaLampEnergy => new(_haContext, "sensor.bedroom_lava_lamp_energy");
		///<summary>bedroom/lava_lamp_power</summary>
		public NumericSensorEntity BedroomLavaLampPower => new(_haContext, "sensor.bedroom_lava_lamp_power");
		///<summary>bedroom/motion_detector_temperature</summary>
		public NumericSensorEntity BedroomMotionDetectorTemperature => new(_haContext, "sensor.bedroom_motion_detector_temperature");
		///<summary>bedroom/roller_shutter_left_battery</summary>
		public NumericSensorEntity BedroomRollerShutterLeftBattery => new(_haContext, "sensor.bedroom_roller_shutter_left_battery");
		///<summary>bedroom/roller_shutter_left_device_temperature</summary>
		public NumericSensorEntity BedroomRollerShutterLeftDeviceTemperature => new(_haContext, "sensor.bedroom_roller_shutter_left_device_temperature");
		///<summary>bedroom/roller_shutter_right_battery</summary>
		public NumericSensorEntity BedroomRollerShutterRightBattery => new(_haContext, "sensor.bedroom_roller_shutter_right_battery");
		///<summary>bedroom/roller_shutter_right_device_temperature</summary>
		public NumericSensorEntity BedroomRollerShutterRightDeviceTemperature => new(_haContext, "sensor.bedroom_roller_shutter_right_device_temperature");
		///<summary>BlackBerry Ltd</summary>
		public NumericSensorEntity BlackberryLtd => new(_haContext, "sensor.blackberry_ltd");
		///<summary>Core DAX</summary>
		public NumericSensorEntity CoreDax => new(_haContext, "sensor.core_dax");
		///<summary>Fantenpad Battery Level</summary>
		public NumericSensorEntity FantenpadBatteryLevel => new(_haContext, "sensor.fantenpad_battery_level");
		///<summary>Fantenpad Storage</summary>
		public NumericSensorEntity FantenpadStorage => new(_haContext, "sensor.fantenpad_storage");
		///<summary>FantenPhone2 Average Active Pace</summary>
		public NumericSensorEntity Fantenphone2AverageActivePace => new(_haContext, "sensor.fantenphone2_average_active_pace");
		///<summary>FantenPhone2 Battery Level</summary>
		public NumericSensorEntity Fantenphone2BatteryLevel => new(_haContext, "sensor.fantenphone2_battery_level");
		///<summary>FantenPhone2 Distance</summary>
		public NumericSensorEntity Fantenphone2Distance => new(_haContext, "sensor.fantenphone2_distance");
		///<summary>FantenPhone2 Floors Ascended</summary>
		public NumericSensorEntity Fantenphone2FloorsAscended => new(_haContext, "sensor.fantenphone2_floors_ascended");
		///<summary>FantenPhone2 Floors Descended</summary>
		public NumericSensorEntity Fantenphone2FloorsDescended => new(_haContext, "sensor.fantenphone2_floors_descended");
		///<summary>FantenPhone2 Steps</summary>
		public NumericSensorEntity Fantenphone2Steps => new(_haContext, "sensor.fantenphone2_steps");
		///<summary>FantenPhone2 Storage</summary>
		public NumericSensorEntity Fantenphone2Storage => new(_haContext, "sensor.fantenphone2_storage");
		///<summary>Fantenrüssel Current clean area</summary>
		public NumericSensorEntity FantenrusselCurrentCleanArea => new(_haContext, "sensor.fantenrussel_current_clean_area");
		///<summary>Fantenrüssel Current clean duration</summary>
		public NumericSensorEntity FantenrusselCurrentCleanDuration => new(_haContext, "sensor.fantenrussel_current_clean_duration");
		///<summary>Fantenrüssel Filter left</summary>
		public NumericSensorEntity FantenrusselFilterLeft => new(_haContext, "sensor.fantenrussel_filter_left");
		///<summary>Fantenrüssel Last clean area</summary>
		public NumericSensorEntity FantenrusselLastCleanArea => new(_haContext, "sensor.fantenrussel_last_clean_area");
		///<summary>Fantenrüssel Last clean duration</summary>
		public NumericSensorEntity FantenrusselLastCleanDuration => new(_haContext, "sensor.fantenrussel_last_clean_duration");
		///<summary>Fantenrüssel Main brush left</summary>
		public NumericSensorEntity FantenrusselMainBrushLeft => new(_haContext, "sensor.fantenrussel_main_brush_left");
		///<summary>Fantenrüssel Sensor dirty left</summary>
		public NumericSensorEntity FantenrusselSensorDirtyLeft => new(_haContext, "sensor.fantenrussel_sensor_dirty_left");
		///<summary>Fantenrüssel Side brush left</summary>
		public NumericSensorEntity FantenrusselSideBrushLeft => new(_haContext, "sensor.fantenrussel_side_brush_left");
		///<summary>GameStop Corp</summary>
		public NumericSensorEntity GamestopCorp => new(_haContext, "sensor.gamestop_corp");
		///<summary>hacs</summary>
		public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
		///<summary>hallway Cluster Size</summary>
		public NumericSensorEntity HallwayClusterSize => new(_haContext, "sensor.hallway_cluster_size");
		///<summary>iPhone Fabienne Average Active Pace</summary>
		public NumericSensorEntity IphoneFabienneAverageActivePace => new(_haContext, "sensor.iphone_fabienne_average_active_pace");
		///<summary>iPhone Fabienne Battery Level</summary>
		public NumericSensorEntity IphoneFabienneBatteryLevel => new(_haContext, "sensor.iphone_fabienne_battery_level");
		///<summary>iPhone Fabienne Distance</summary>
		public NumericSensorEntity IphoneFabienneDistance => new(_haContext, "sensor.iphone_fabienne_distance");
		///<summary>iPhone Fabienne Floors Ascended</summary>
		public NumericSensorEntity IphoneFabienneFloorsAscended => new(_haContext, "sensor.iphone_fabienne_floors_ascended");
		///<summary>iPhone Fabienne Floors Descended</summary>
		public NumericSensorEntity IphoneFabienneFloorsDescended => new(_haContext, "sensor.iphone_fabienne_floors_descended");
		///<summary>iPhone Fabienne Steps</summary>
		public NumericSensorEntity IphoneFabienneSteps => new(_haContext, "sensor.iphone_fabienne_steps");
		///<summary>iPhone Fabienne Storage</summary>
		public NumericSensorEntity IphoneFabienneStorage => new(_haContext, "sensor.iphone_fabienne_storage");
		///<summary>iPhone Philipp Average Active Pace</summary>
		public NumericSensorEntity IphonePhilippAverageActivePace => new(_haContext, "sensor.iphone_philipp_average_active_pace");
		///<summary>iPhone-Philipp Battery</summary>
		public NumericSensorEntity IphonePhilippBattery => new(_haContext, "sensor.iphone_philipp_battery");
		///<summary>iPhone Philipp Battery Level</summary>
		public NumericSensorEntity IphonePhilippBatteryLevel => new(_haContext, "sensor.iphone_philipp_battery_level");
		///<summary>iPhone-Philipp Calc Dist</summary>
		public NumericSensorEntity IphonePhilippCalcDistance => new(_haContext, "sensor.iphone_philipp_calc_distance");
		///<summary>iPhone Philipp Distance</summary>
		public NumericSensorEntity IphonePhilippDistance => new(_haContext, "sensor.iphone_philipp_distance");
		///<summary>iPhone Philipp Floors Ascended</summary>
		public NumericSensorEntity IphonePhilippFloorsAscended => new(_haContext, "sensor.iphone_philipp_floors_ascended");
		///<summary>iPhone Philipp Floors Descended</summary>
		public NumericSensorEntity IphonePhilippFloorsDescended => new(_haContext, "sensor.iphone_philipp_floors_descended");
		///<summary>iPhone Philipp Steps</summary>
		public NumericSensorEntity IphonePhilippSteps => new(_haContext, "sensor.iphone_philipp_steps");
		///<summary>iPhone Philipp Storage</summary>
		public NumericSensorEntity IphonePhilippStorage => new(_haContext, "sensor.iphone_philipp_storage");
		///<summary>iPhone-Philipp Travel Dist</summary>
		public NumericSensorEntity IphonePhilippTravelDistance => new(_haContext, "sensor.iphone_philipp_travel_distance");
		///<summary>iPhone-Philipp Travel Time</summary>
		public NumericSensorEntity IphonePhilippTravelTime => new(_haContext, "sensor.iphone_philipp_travel_time");
		///<summary>iPhone-Philipp Travel Time</summary>
		public NumericSensorEntity IphonePhilippTravelTimeMin => new(_haContext, "sensor.iphone_philipp_travel_time_min");
		///<summary>iPhone-Philipp Waze Dist</summary>
		public NumericSensorEntity IphonePhilippWazeDistance => new(_haContext, "sensor.iphone_philipp_waze_distance");
		///<summary>iPhone-Philipp Zone Distance</summary>
		public NumericSensorEntity IphonePhilippZoneDistance => new(_haContext, "sensor.iphone_philipp_zone_distance");
		///<summary>kitchen/cabinet_light_button_battery</summary>
		public NumericSensorEntity KitchenCabinetLightButtonBattery => new(_haContext, "sensor.kitchen_cabinet_light_button_battery");
		///<summary>kitchen/cabinet_light_button_device_temperature</summary>
		public NumericSensorEntity KitchenCabinetLightButtonDeviceTemperature => new(_haContext, "sensor.kitchen_cabinet_light_button_device_temperature");
		///<summary>kitchen/ceiling_light_button_battery</summary>
		public NumericSensorEntity KitchenCeilingLightButtonBattery => new(_haContext, "sensor.kitchen_ceiling_light_button_battery");
		///<summary>kitchen/ceiling_light_button_device_temperature</summary>
		public NumericSensorEntity KitchenCeilingLightButtonDeviceTemperature => new(_haContext, "sensor.kitchen_ceiling_light_button_device_temperature");
		///<summary>kitchen/kratom_counter_battery</summary>
		public NumericSensorEntity KitchenKratomCounterBattery => new(_haContext, "sensor.kitchen_kratom_counter_battery");
		///<summary>kitchen/kratom_counter_device_temperature</summary>
		public NumericSensorEntity KitchenKratomCounterDeviceTemperature => new(_haContext, "sensor.kitchen_kratom_counter_device_temperature");
		///<summary>kitchen/motion_detector_battery</summary>
		public NumericSensorEntity KitchenMotionDetectorBattery => new(_haContext, "sensor.kitchen_motion_detector_battery");
		///<summary>kitchen/motion_detector_device_temperature</summary>
		public NumericSensorEntity KitchenMotionDetectorDeviceTemperature => new(_haContext, "sensor.kitchen_motion_detector_device_temperature");
		///<summary>kitchen/motion_detector_illuminance_lux</summary>
		public NumericSensorEntity KitchenMotionDetectorIlluminanceLux => new(_haContext, "sensor.kitchen_motion_detector_illuminance_lux");
		///<summary>kitchen/motion_detector_temperature</summary>
		public NumericSensorEntity KitchenMotionDetectorTemperature => new(_haContext, "sensor.kitchen_motion_detector_temperature");
		///<summary>Lufthansa</summary>
		public NumericSensorEntity Lufthansa => new(_haContext, "sensor.lufthansa");
		///<summary>METRO AG</summary>
		public NumericSensorEntity MetroAg => new(_haContext, "sensor.metro_ag");
		///<summary>Black toner remaining</summary>
		public NumericSensorEntity Mfc1910wBlackTonerRemaining => new(_haContext, "sensor.mfc_1910w_black_toner_remaining");
		///<summary>Drum counter</summary>
		public NumericSensorEntity Mfc1910wDrumCounter => new(_haContext, "sensor.mfc_1910w_drum_counter");
		///<summary>Drum remaining life</summary>
		public NumericSensorEntity Mfc1910wDrumRemainingLife => new(_haContext, "sensor.mfc_1910w_drum_remaining_life");
		///<summary>Drum remaining pages</summary>
		public NumericSensorEntity Mfc1910wDrumRemainingPages => new(_haContext, "sensor.mfc_1910w_drum_remaining_pages");
		///<summary>Page counter</summary>
		public NumericSensorEntity Mfc1910wPageCounter => new(_haContext, "sensor.mfc_1910w_page_counter");
		///<summary>Nuki battery level</summary>
		public NumericSensorEntity NukiBatteryLevel => new(_haContext, "sensor.nuki_battery_level");
		///<summary>Nuki battery voltage</summary>
		public NumericSensorEntity NukiBatteryVoltage => new(_haContext, "sensor.nuki_battery_voltage");
		///<summary>Nuki bluetooth signal strength</summary>
		public NumericSensorEntity NukiBluetoothSignalStrength => new(_haContext, "sensor.nuki_bluetooth_signal_strength");
		///<summary>Nuki Haustür RSSI</summary>
		public NumericSensorEntity NukiHausturRssi => new(_haContext, "sensor.nuki_haustur_rssi");
		///<summary>Nuki wifi signal strength</summary>
		public NumericSensorEntity NukiWifiSignalStrength => new(_haContext, "sensor.nuki_wifi_signal_strength");
		///<summary>Nuki Wohnungstür Battery</summary>
		public NumericSensorEntity NukiWohnungsturBattery => new(_haContext, "sensor.nuki_wohnungstur_battery");
		///<summary>Nuki Wohnungstür RSSI</summary>
		public NumericSensorEntity NukiWohnungsturRssi => new(_haContext, "sensor.nuki_wohnungstur_rssi");
		///<summary>PupsStation (Volume 1) Average Disk Temp</summary>
		public NumericSensorEntity PupsstationAverageDiskTemp => new(_haContext, "sensor.pupsstation_average_disk_temp");
		///<summary>PupsStation CPU Load Average (15 min)</summary>
		public NumericSensorEntity PupsstationCpuLoadAverage15Min => new(_haContext, "sensor.pupsstation_cpu_load_average_15_min");
		///<summary>PupsStation CPU Load Average (5 min)</summary>
		public NumericSensorEntity PupsstationCpuLoadAverage5Min => new(_haContext, "sensor.pupsstation_cpu_load_average_5_min");
		///<summary>PupsStation CPU Utilization (Total)</summary>
		public NumericSensorEntity PupsstationCpuUtilizationTotal => new(_haContext, "sensor.pupsstation_cpu_utilization_total");
		///<summary>PupsStation CPU Utilization (User)</summary>
		public NumericSensorEntity PupsstationCpuUtilizationUser => new(_haContext, "sensor.pupsstation_cpu_utilization_user");
		///<summary>PupsStation Download Throughput</summary>
		public NumericSensorEntity PupsstationDownloadThroughput => new(_haContext, "sensor.pupsstation_download_throughput");
		///<summary>PupsStation Memory Available (Real)</summary>
		public NumericSensorEntity PupsstationMemoryAvailableReal => new(_haContext, "sensor.pupsstation_memory_available_real");
		///<summary>PupsStation Memory Available (Swap)</summary>
		public NumericSensorEntity PupsstationMemoryAvailableSwap => new(_haContext, "sensor.pupsstation_memory_available_swap");
		///<summary>PupsStation Memory Total (Real)</summary>
		public NumericSensorEntity PupsstationMemoryTotalReal => new(_haContext, "sensor.pupsstation_memory_total_real");
		///<summary>PupsStation Memory Total (Swap)</summary>
		public NumericSensorEntity PupsstationMemoryTotalSwap => new(_haContext, "sensor.pupsstation_memory_total_swap");
		///<summary>PupsStation Memory Usage (Real)</summary>
		public NumericSensorEntity PupsstationMemoryUsageReal => new(_haContext, "sensor.pupsstation_memory_usage_real");
		///<summary>PupsStation (Drive 1) Temperature</summary>
		public NumericSensorEntity PupsstationTemperature => new(_haContext, "sensor.pupsstation_temperature");
		///<summary>PupsStation (Drive 2) Temperature</summary>
		public NumericSensorEntity PupsstationTemperature2 => new(_haContext, "sensor.pupsstation_temperature_2");
		///<summary>PupsStation (Drive 3) Temperature</summary>
		public NumericSensorEntity PupsstationTemperature3 => new(_haContext, "sensor.pupsstation_temperature_3");
		///<summary>PupsStation Temperature</summary>
		public NumericSensorEntity PupsstationTemperature4 => new(_haContext, "sensor.pupsstation_temperature_4");
		///<summary>PupsStation Upload Throughput</summary>
		public NumericSensorEntity PupsstationUploadThroughput => new(_haContext, "sensor.pupsstation_upload_throughput");
		///<summary>PupsStation (Volume 1) Used Space</summary>
		public NumericSensorEntity PupsstationUsedSpace => new(_haContext, "sensor.pupsstation_used_space");
		///<summary>PupsStation (Volume 1) Volume Used</summary>
		public NumericSensorEntity PupsstationVolumeUsed => new(_haContext, "sensor.pupsstation_volume_used");
		///<summary>Raumthermostat Schlafzimmer Humidity</summary>
		public NumericSensorEntity RaumthermostatSchlafzimmerHumidity => new(_haContext, "sensor.raumthermostat_schlafzimmer_humidity");
		///<summary>Raumthermostat Schlafzimmer Temperature</summary>
		public NumericSensorEntity RaumthermostatSchlafzimmerTemperature => new(_haContext, "sensor.raumthermostat_schlafzimmer_temperature");
		///<summary>Seventeentrack Packages Delivered</summary>
		public NumericSensorEntity SeventeentrackPackagesDelivered => new(_haContext, "sensor.seventeentrack_packages_delivered");
		///<summary>Seventeentrack Packages Expired</summary>
		public NumericSensorEntity SeventeentrackPackagesExpired => new(_haContext, "sensor.seventeentrack_packages_expired");
		///<summary>Seventeentrack Packages In Transit</summary>
		public NumericSensorEntity SeventeentrackPackagesInTransit => new(_haContext, "sensor.seventeentrack_packages_in_transit");
		///<summary>Seventeentrack Packages Not Found</summary>
		public NumericSensorEntity SeventeentrackPackagesNotFound => new(_haContext, "sensor.seventeentrack_packages_not_found");
		///<summary>Seventeentrack Packages Ready to be Picked Up</summary>
		public NumericSensorEntity SeventeentrackPackagesReadyToBePickedUp => new(_haContext, "sensor.seventeentrack_packages_ready_to_be_picked_up");
		///<summary>Seventeentrack Packages Returned</summary>
		public NumericSensorEntity SeventeentrackPackagesReturned => new(_haContext, "sensor.seventeentrack_packages_returned");
		///<summary>Seventeentrack Packages Undelivered</summary>
		public NumericSensorEntity SeventeentrackPackagesUndelivered => new(_haContext, "sensor.seventeentrack_packages_undelivered");
		///<summary>SpeedTest Download</summary>
		public NumericSensorEntity SpeedtestDownload => new(_haContext, "sensor.speedtest_download");
		///<summary>SpeedTest Ping</summary>
		public NumericSensorEntity SpeedtestPing => new(_haContext, "sensor.speedtest_ping");
		///<summary>SpeedTest Upload</summary>
		public NumericSensorEntity SpeedtestUpload => new(_haContext, "sensor.speedtest_upload");
		///<summary>BlackBerry Ltd. Profit</summary>
		public NumericSensorEntity StockBlackberryLtdProfit => new(_haContext, "sensor.stock_blackberry_ltd_profit");
		///<summary>BlackBerry Ltd. Price</summary>
		public NumericSensorEntity StockBlackberryLtdShareprice => new(_haContext, "sensor.stock_blackberry_ltd_shareprice");
		///<summary>BlackBerry Ltd. Total</summary>
		public NumericSensorEntity StockBlackberryLtdTotalvalue => new(_haContext, "sensor.stock_blackberry_ltd_totalvalue");
		///<summary>Core DAX Profit</summary>
		public NumericSensorEntity StockCoreDaxProfit => new(_haContext, "sensor.stock_core_dax_profit");
		///<summary>Core DAX Price</summary>
		public NumericSensorEntity StockCoreDaxShareprice => new(_haContext, "sensor.stock_core_dax_shareprice");
		///<summary>Core DAX Total</summary>
		public NumericSensorEntity StockCoreDaxTotalvalue => new(_haContext, "sensor.stock_core_dax_totalvalue");
		///<summary>GameStop Profit</summary>
		public NumericSensorEntity StockGamestopProfit => new(_haContext, "sensor.stock_gamestop_profit");
		///<summary>GameStop Price</summary>
		public NumericSensorEntity StockGamestopShareprice => new(_haContext, "sensor.stock_gamestop_shareprice");
		///<summary>GameStop Total</summary>
		public NumericSensorEntity StockGamestopTotalvalue => new(_haContext, "sensor.stock_gamestop_totalvalue");
		///<summary>Lufthansa Profit</summary>
		public NumericSensorEntity StockLufthansaProfit => new(_haContext, "sensor.stock_lufthansa_profit");
		///<summary>Lufthansa Price</summary>
		public NumericSensorEntity StockLufthansaShareprice => new(_haContext, "sensor.stock_lufthansa_shareprice");
		///<summary>Lufthansa Total</summary>
		public NumericSensorEntity StockLufthansaTotalvalue => new(_haContext, "sensor.stock_lufthansa_totalvalue");
		///<summary>Metro AG Profit</summary>
		public NumericSensorEntity StockMetroAgProfit => new(_haContext, "sensor.stock_metro_ag_profit");
		///<summary>Metro AG Price</summary>
		public NumericSensorEntity StockMetroAgShareprice => new(_haContext, "sensor.stock_metro_ag_shareprice");
		///<summary>Metro AG Total</summary>
		public NumericSensorEntity StockMetroAgTotalvalue => new(_haContext, "sensor.stock_metro_ag_totalvalue");
		///<summary>study/desk_lamp_switch_battery</summary>
		public NumericSensorEntity StudyDeskLampSwitchBattery => new(_haContext, "sensor.study_desk_lamp_switch_battery");
		///<summary>study/desk_lamp_switch_device_temperature</summary>
		public NumericSensorEntity StudyDeskLampSwitchDeviceTemperature => new(_haContext, "sensor.study_desk_lamp_switch_device_temperature");
		///<summary>study/motion_detector_battery</summary>
		public NumericSensorEntity StudyMotionDetectorBattery => new(_haContext, "sensor.study_motion_detector_battery");
		///<summary>study/motion_detector_device_temperature</summary>
		public NumericSensorEntity StudyMotionDetectorDeviceTemperature => new(_haContext, "sensor.study_motion_detector_device_temperature");
		///<summary>study/motion_detector_illuminance_lux</summary>
		public NumericSensorEntity StudyMotionDetectorIlluminanceLux => new(_haContext, "sensor.study_motion_detector_illuminance_lux");
		///<summary>Thermostat Arbeitszimmer Temperature</summary>
		public NumericSensorEntity ThermostatArbeitszimmerTemperature => new(_haContext, "sensor.thermostat_arbeitszimmer_temperature");
		///<summary>Thermostat Arbeitszimmer Valvetappet</summary>
		public NumericSensorEntity ThermostatArbeitszimmerValvetappet => new(_haContext, "sensor.thermostat_arbeitszimmer_valvetappet");
		///<summary>Thermostat Badezimmer Temperature</summary>
		public NumericSensorEntity ThermostatBadezimmerTemperature => new(_haContext, "sensor.thermostat_badezimmer_temperature");
		///<summary>Thermostat Badezimmer Valvetappet</summary>
		public NumericSensorEntity ThermostatBadezimmerValvetappet => new(_haContext, "sensor.thermostat_badezimmer_valvetappet");
		///<summary>Thermostat Küche Temperature</summary>
		public NumericSensorEntity ThermostatKucheTemperature => new(_haContext, "sensor.thermostat_kuche_temperature");
		///<summary>Thermostat Küche Valvetappet</summary>
		public NumericSensorEntity ThermostatKucheValvetappet => new(_haContext, "sensor.thermostat_kuche_valvetappet");
		///<summary>Thermostat Schlafzimmer Temperature</summary>
		public NumericSensorEntity ThermostatSchlafzimmerTemperature => new(_haContext, "sensor.thermostat_schlafzimmer_temperature");
		///<summary>Thermostat Schlafzimmer Valvetappet</summary>
		public NumericSensorEntity ThermostatSchlafzimmerValvetappet => new(_haContext, "sensor.thermostat_schlafzimmer_valvetappet");
		///<summary>Thermostat Wohnzimmer Temperature</summary>
		public NumericSensorEntity ThermostatWohnzimmerTemperature => new(_haContext, "sensor.thermostat_wohnzimmer_temperature");
		///<summary>Thermostat Wohnzimmer Valvetappet</summary>
		public NumericSensorEntity ThermostatWohnzimmerValvetappet => new(_haContext, "sensor.thermostat_wohnzimmer_valvetappet");
		///<summary>Wallpanel Hallway Battery Level</summary>
		public NumericSensorEntity WallpanelHallwayBatteryLevel => new(_haContext, "sensor.wallpanel_hallway_battery_level");
		///<summary>Wallpanel Hallway Light</summary>
		public NumericSensorEntity WallpanelHallwayLight => new(_haContext, "sensor.wallpanel_hallway_light");
		///<summary>2-Wochen-Gerichte Philipp</summary>
		public SensorEntity E2WochenGerichtePhilipp => new(_haContext, "sensor.2_wochen_gerichte_philipp");
		///<summary>Am Ende der Tausend Sterne Philipp</summary>
		public SensorEntity AmEndeDerTausendSternePhilipp => new(_haContext, "sensor.am_ende_der_tausend_sterne_philipp");
		///<summary>Anno 1800 Philipp</summary>
		public SensorEntity Anno1800Philipp => new(_haContext, "sensor.anno_1800_philipp");
		///<summary>Aufgaben Philipp</summary>
		public SensorEntity AufgabenPhilipp => new(_haContext, "sensor.aufgaben_philipp");
		///<summary>Ausflüge & Urlaub Philipp</summary>
		public SensorEntity AusflugeUrlaubPhilipp => new(_haContext, "sensor.ausfluge_urlaub_philipp");
		///<summary>Base calories for fabienne</summary>
		public SensorEntity BaseCaloriesForFabienne => new(_haContext, "sensor.base_calories_for_fabienne");
		///<summary>Base calories for philipp</summary>
		public SensorEntity BaseCaloriesForPhilipp => new(_haContext, "sensor.base_calories_for_philipp");
		///<summary>bathroom/razor_blade_usage_action</summary>
		public SensorEntity BathroomRazorBladeUsageAction => new(_haContext, "sensor.bathroom_razor_blade_usage_action");
		///<summary>bathroom/razor_blade_usage_click</summary>
		public SensorEntity BathroomRazorBladeUsageClick => new(_haContext, "sensor.bathroom_razor_blade_usage_click");
		///<summary>bathroom/razor_blade_usage_power_outage_count</summary>
		public SensorEntity BathroomRazorBladeUsagePowerOutageCount => new(_haContext, "sensor.bathroom_razor_blade_usage_power_outage_count");
		///<summary>bedroom/bedside_light_switch_fabienne_action</summary>
		public SensorEntity BedroomBedsideLightSwitchFabienneAction => new(_haContext, "sensor.bedroom_bedside_light_switch_fabienne_action");
		///<summary>bedroom/bedside_light_switch_fabienne_click</summary>
		public SensorEntity BedroomBedsideLightSwitchFabienneClick => new(_haContext, "sensor.bedroom_bedside_light_switch_fabienne_click");
		///<summary>bedroom/bedside_light_switch_fabienne_power_outage_count</summary>
		public SensorEntity BedroomBedsideLightSwitchFabiennePowerOutageCount => new(_haContext, "sensor.bedroom_bedside_light_switch_fabienne_power_outage_count");
		///<summary>bedroom/bedside_light_switch_philipp_action</summary>
		public SensorEntity BedroomBedsideLightSwitchPhilippAction => new(_haContext, "sensor.bedroom_bedside_light_switch_philipp_action");
		///<summary>bedroom/bedside_light_switch_philipp_click</summary>
		public SensorEntity BedroomBedsideLightSwitchPhilippClick => new(_haContext, "sensor.bedroom_bedside_light_switch_philipp_click");
		///<summary>bedroom/bedside_light_switch_philipp_power_outage_count</summary>
		public SensorEntity BedroomBedsideLightSwitchPhilippPowerOutageCount => new(_haContext, "sensor.bedroom_bedside_light_switch_philipp_power_outage_count");
		///<summary>bedroom/roller_shutter_left_motor_state</summary>
		public SensorEntity BedroomRollerShutterLeftMotorState => new(_haContext, "sensor.bedroom_roller_shutter_left_motor_state");
		///<summary>bedroom/roller_shutter_right_motor_state</summary>
		public SensorEntity BedroomRollerShutterRightMotorState => new(_haContext, "sensor.bedroom_roller_shutter_right_motor_state");
		///<summary>Brother MFC-1910W, using brlaser v6</summary>
		public SensorEntity BrotherMfc1910wUsingBrlaserV6 => new(_haContext, "sensor.brother_mfc_1910w_using_brlaser_v6");
		///<summary>Bücher Oma Philipp</summary>
		public SensorEntity BucherOmaPhilipp => new(_haContext, "sensor.bucher_oma_philipp");
		///<summary>Current training schedule</summary>
		public SensorEntity CurrentTrainingSchedule => new(_haContext, "sensor.current_training_schedule");
		///<summary>desktop-171ttut Expires</summary>
		public SensorEntity Desktop171ttutExpires => new(_haContext, "sensor.desktop_171ttut_expires");
		///<summary>desktop-171ttut IP address</summary>
		public SensorEntity Desktop171ttutIpAddress => new(_haContext, "sensor.desktop_171ttut_ip_address");
		///<summary>desktop-171ttut Last seen</summary>
		public SensorEntity Desktop171ttutLastSeen => new(_haContext, "sensor.desktop_171ttut_last_seen");
		///<summary>Dioramen Philipp</summary>
		public SensorEntity DioramenPhilipp => new(_haContext, "sensor.dioramen_philipp");
		///<summary>Einkaufen 🛒 Philipp</summary>
		public SensorEntity EinkaufenPhilipp => new(_haContext, "sensor.einkaufen_philipp");
		///<summary>🥘 Essen holen 🍱 Philipp</summary>
		public SensorEntity EssenHolenPhilipp => new(_haContext, "sensor.essen_holen_philipp");
		///<summary>Essen 😍 Philipp</summary>
		public SensorEntity EssenPhilipp => new(_haContext, "sensor.essen_philipp");
		///<summary>Fantenpad Activity</summary>
		public SensorEntity FantenpadActivity => new(_haContext, "sensor.fantenpad_activity");
		///<summary>Fantenpad Battery State</summary>
		public SensorEntity FantenpadBatteryState => new(_haContext, "sensor.fantenpad_battery_state");
		///<summary>Fantenpad BSSID</summary>
		public SensorEntity FantenpadBssid => new(_haContext, "sensor.fantenpad_bssid");
		///<summary>Fantenpad Connection Type</summary>
		public SensorEntity FantenpadConnectionType => new(_haContext, "sensor.fantenpad_connection_type");
		///<summary>Fantenpad Geocoded Location</summary>
		public SensorEntity FantenpadGeocodedLocation => new(_haContext, "sensor.fantenpad_geocoded_location");
		///<summary>Fantenpad Last Update Trigger</summary>
		public SensorEntity FantenpadLastUpdateTrigger => new(_haContext, "sensor.fantenpad_last_update_trigger");
		///<summary>Fantenpad SSID</summary>
		public SensorEntity FantenpadSsid => new(_haContext, "sensor.fantenpad_ssid");
		///<summary>FantenPhone2 Activity</summary>
		public SensorEntity Fantenphone2Activity => new(_haContext, "sensor.fantenphone2_activity");
		///<summary>FantenPhone2 Battery State</summary>
		public SensorEntity Fantenphone2BatteryState => new(_haContext, "sensor.fantenphone2_battery_state");
		///<summary>FantenPhone2 BSSID</summary>
		public SensorEntity Fantenphone2Bssid => new(_haContext, "sensor.fantenphone2_bssid");
		///<summary>FantenPhone2 Connection Type</summary>
		public SensorEntity Fantenphone2ConnectionType => new(_haContext, "sensor.fantenphone2_connection_type");
		///<summary>FantenPhone2 Geocoded Location</summary>
		public SensorEntity Fantenphone2GeocodedLocation => new(_haContext, "sensor.fantenphone2_geocoded_location");
		///<summary>FantenPhone2 Last Update Trigger</summary>
		public SensorEntity Fantenphone2LastUpdateTrigger => new(_haContext, "sensor.fantenphone2_last_update_trigger");
		///<summary>FantenPhone2 SIM 1</summary>
		public SensorEntity Fantenphone2Sim1 => new(_haContext, "sensor.fantenphone2_sim_1");
		///<summary>FantenPhone2 SIM 2</summary>
		public SensorEntity Fantenphone2Sim2 => new(_haContext, "sensor.fantenphone2_sim_2");
		///<summary>FantenPhone2 SSID</summary>
		public SensorEntity Fantenphone2Ssid => new(_haContext, "sensor.fantenphone2_ssid");
		///<summary>Fantenrüssel Last clean end</summary>
		public SensorEntity FantenrusselLastCleanEnd => new(_haContext, "sensor.fantenrussel_last_clean_end");
		///<summary>Fantenrüssel Last clean start</summary>
		public SensorEntity FantenrusselLastCleanStart => new(_haContext, "sensor.fantenrussel_last_clean_start");
		///<summary>🍔 Finger Food evening 🍟 Philipp</summary>
		public SensorEntity FingerFoodEveningPhilipp => new(_haContext, "sensor.finger_food_evening_philipp");
		///<summary>Flagged Emails Philipp</summary>
		public SensorEntity FlaggedEmailsPhilipp => new(_haContext, "sensor.flagged_emails_philipp");
		///<summary>Fragen Mieterbund Philipp</summary>
		public SensorEntity FragenMieterbundPhilipp => new(_haContext, "sensor.fragen_mieterbund_philipp");
		///<summary>Game ideas Philipp</summary>
		public SensorEntity GameIdeasPhilipp => new(_haContext, "sensor.game_ideas_philipp");
		///<summary>Games Philipp</summary>
		public SensorEntity GamesPhilipp => new(_haContext, "sensor.games_philipp");
		///<summary>🎁 Geschenke Eltern 🎁 Philipp</summary>
		public SensorEntity GeschenkeElternPhilipp => new(_haContext, "sensor.geschenke_eltern_philipp");
		///<summary>Geschenke 🎁 Philipp</summary>
		public SensorEntity GeschenkePhilipp => new(_haContext, "sensor.geschenke_philipp");
		///<summary>hallway Cluster Leader</summary>
		public SensorEntity HallwayClusterLeader => new(_haContext, "sensor.hallway_cluster_leader");
		///<summary>Haushaltstag Philipp</summary>
		public SensorEntity HaushaltstagPhilipp => new(_haContext, "sensor.haushaltstag_philipp");
		///<summary>Hochzeit Philipp</summary>
		public SensorEntity HochzeitPhilipp => new(_haContext, "sensor.hochzeit_philipp");
		///<summary>home-desktop-fabienne Expires</summary>
		public SensorEntity HomeDesktopFabienneExpires => new(_haContext, "sensor.home_desktop_fabienne_expires");
		///<summary>home-desktop-fabienne IP address</summary>
		public SensorEntity HomeDesktopFabienneIpAddress => new(_haContext, "sensor.home_desktop_fabienne_ip_address");
		///<summary>home-desktop-fabienne Last seen</summary>
		public SensorEntity HomeDesktopFabienneLastSeen => new(_haContext, "sensor.home_desktop_fabienne_last_seen");
		///<summary>home-desktop-oma Expires</summary>
		public SensorEntity HomeDesktopOmaExpires => new(_haContext, "sensor.home_desktop_oma_expires");
		///<summary>home-desktop-oma IP address</summary>
		public SensorEntity HomeDesktopOmaIpAddress => new(_haContext, "sensor.home_desktop_oma_ip_address");
		///<summary>home-desktop-oma Last seen</summary>
		public SensorEntity HomeDesktopOmaLastSeen => new(_haContext, "sensor.home_desktop_oma_last_seen");
		///<summary>home-desktop-philipp Expires</summary>
		public SensorEntity HomeDesktopPhilippExpires => new(_haContext, "sensor.home_desktop_philipp_expires");
		///<summary>home-desktop-philipp IP address</summary>
		public SensorEntity HomeDesktopPhilippIpAddress => new(_haContext, "sensor.home_desktop_philipp_ip_address");
		///<summary>home-desktop-philipp Last seen</summary>
		public SensorEntity HomeDesktopPhilippLastSeen => new(_haContext, "sensor.home_desktop_philipp_last_seen");
		///<summary>home-k8s-master Expires</summary>
		public SensorEntity HomeK8sMasterExpires => new(_haContext, "sensor.home_k8s_master_expires");
		///<summary>home-k8s-master IP address</summary>
		public SensorEntity HomeK8sMasterIpAddress => new(_haContext, "sensor.home_k8s_master_ip_address");
		///<summary>home-k8s-master Last seen</summary>
		public SensorEntity HomeK8sMasterLastSeen => new(_haContext, "sensor.home_k8s_master_last_seen");
		///<summary>home-laptop-enbw Expires</summary>
		public SensorEntity HomeLaptopEnbwExpires => new(_haContext, "sensor.home_laptop_enbw_expires");
		///<summary>home-laptop-enbw IP address</summary>
		public SensorEntity HomeLaptopEnbwIpAddress => new(_haContext, "sensor.home_laptop_enbw_ip_address");
		///<summary>home-laptop-enbw Last seen</summary>
		public SensorEntity HomeLaptopEnbwLastSeen => new(_haContext, "sensor.home_laptop_enbw_last_seen");
		///<summary>home-laptop-fabienne Expires</summary>
		public SensorEntity HomeLaptopFabienneExpires => new(_haContext, "sensor.home_laptop_fabienne_expires");
		///<summary>home-laptop-fabienne IP address</summary>
		public SensorEntity HomeLaptopFabienneIpAddress => new(_haContext, "sensor.home_laptop_fabienne_ip_address");
		///<summary>home-laptop-fabienne Last seen</summary>
		public SensorEntity HomeLaptopFabienneLastSeen => new(_haContext, "sensor.home_laptop_fabienne_last_seen");
		///<summary>home-smartphone-fabienne Expires</summary>
		public SensorEntity HomeSmartphoneFabienneExpires => new(_haContext, "sensor.home_smartphone_fabienne_expires");
		///<summary>home-smartphone-fabienne IP address</summary>
		public SensorEntity HomeSmartphoneFabienneIpAddress => new(_haContext, "sensor.home_smartphone_fabienne_ip_address");
		///<summary>home-smartphone-fabienne Last seen</summary>
		public SensorEntity HomeSmartphoneFabienneLastSeen => new(_haContext, "sensor.home_smartphone_fabienne_last_seen");
		///<summary>home-smartphone-philipp Expires</summary>
		public SensorEntity HomeSmartphonePhilippExpires => new(_haContext, "sensor.home_smartphone_philipp_expires");
		///<summary>home-smartphone-philipp IP address</summary>
		public SensorEntity HomeSmartphonePhilippIpAddress => new(_haContext, "sensor.home_smartphone_philipp_ip_address");
		///<summary>home-smartphone-philipp Last seen</summary>
		public SensorEntity HomeSmartphonePhilippLastSeen => new(_haContext, "sensor.home_smartphone_philipp_last_seen");
		///<summary>home-tablet-hallway-android Expires</summary>
		public SensorEntity HomeTabletHallwayAndroidExpires => new(_haContext, "sensor.home_tablet_hallway_android_expires");
		///<summary>home-tablet-hallway-android IP address</summary>
		public SensorEntity HomeTabletHallwayAndroidIpAddress => new(_haContext, "sensor.home_tablet_hallway_android_ip_address");
		///<summary>home-tablet-hallway-android Last seen</summary>
		public SensorEntity HomeTabletHallwayAndroidLastSeen => new(_haContext, "sensor.home_tablet_hallway_android_last_seen");
		///<summary>home-tablet-ios Expires</summary>
		public SensorEntity HomeTabletIosExpires => new(_haContext, "sensor.home_tablet_ios_expires");
		///<summary>home-tablet-ios IP address</summary>
		public SensorEntity HomeTabletIosIpAddress => new(_haContext, "sensor.home_tablet_ios_ip_address");
		///<summary>home-tablet-ios Last seen</summary>
		public SensorEntity HomeTabletIosLastSeen => new(_haContext, "sensor.home_tablet_ios_last_seen");
		///<summary>home-thinclient-development Expires</summary>
		public SensorEntity HomeThinclientDevelopmentExpires => new(_haContext, "sensor.home_thinclient_development_expires");
		///<summary>home-thinclient-development IP address</summary>
		public SensorEntity HomeThinclientDevelopmentIpAddress => new(_haContext, "sensor.home_thinclient_development_ip_address");
		///<summary>home-thinclient-development Last seen</summary>
		public SensorEntity HomeThinclientDevelopmentLastSeen => new(_haContext, "sensor.home_thinclient_development_last_seen");
		///<summary>home-thinclient-living-room Expires</summary>
		public SensorEntity HomeThinclientLivingRoomExpires => new(_haContext, "sensor.home_thinclient_living_room_expires");
		///<summary>home-thinclient-living-room IP address</summary>
		public SensorEntity HomeThinclientLivingRoomIpAddress => new(_haContext, "sensor.home_thinclient_living_room_ip_address");
		///<summary>home-thinclient-living-room Last seen</summary>
		public SensorEntity HomeThinclientLivingRoomLastSeen => new(_haContext, "sensor.home_thinclient_living_room_last_seen");
		///<summary>Homelab Philipp</summary>
		public SensorEntity HomelabPhilipp => new(_haContext, "sensor.homelab_philipp");
		public SensorEntity Icloud3EventLog => new(_haContext, "sensor.icloud3_event_log");
		///<summary>iPhone Fabienne Activity</summary>
		public SensorEntity IphoneFabienneActivity => new(_haContext, "sensor.iphone_fabienne_activity");
		///<summary>iPhone Fabienne Battery State</summary>
		public SensorEntity IphoneFabienneBatteryState => new(_haContext, "sensor.iphone_fabienne_battery_state");
		///<summary>iPhone Fabienne BSSID</summary>
		public SensorEntity IphoneFabienneBssid => new(_haContext, "sensor.iphone_fabienne_bssid");
		///<summary>iPhone Fabienne Connection Type</summary>
		public SensorEntity IphoneFabienneConnectionType => new(_haContext, "sensor.iphone_fabienne_connection_type");
		///<summary>iPhone Fabienne Geocoded Location</summary>
		public SensorEntity IphoneFabienneGeocodedLocation => new(_haContext, "sensor.iphone_fabienne_geocoded_location");
		///<summary>iPhone Fabienne Last Update Trigger</summary>
		public SensorEntity IphoneFabienneLastUpdateTrigger => new(_haContext, "sensor.iphone_fabienne_last_update_trigger");
		///<summary>iPhone Fabienne SIM 1</summary>
		public SensorEntity IphoneFabienneSim1 => new(_haContext, "sensor.iphone_fabienne_sim_1");
		///<summary>iPhone Fabienne SIM 2</summary>
		public SensorEntity IphoneFabienneSim2 => new(_haContext, "sensor.iphone_fabienne_sim_2");
		///<summary>iPhone Fabienne SSID</summary>
		public SensorEntity IphoneFabienneSsid => new(_haContext, "sensor.iphone_fabienne_ssid");
		///<summary>iPhone Philipp 2 SIM 2</summary>
		public SensorEntity IphonePhilipp2Sim2 => new(_haContext, "sensor.iphone_philipp_2_sim_2");
		///<summary>iPhone Philipp Activity</summary>
		public SensorEntity IphonePhilippActivity => new(_haContext, "sensor.iphone_philipp_activity");
		///<summary>Philipp</summary>
		public SensorEntity IphonePhilippBadge => new(_haContext, "sensor.iphone_philipp_badge");
		///<summary>iPhone Philipp Battery State</summary>
		public SensorEntity IphonePhilippBatteryState => new(_haContext, "sensor.iphone_philipp_battery_state");
		///<summary>iPhone Philipp BSSID</summary>
		public SensorEntity IphonePhilippBssid => new(_haContext, "sensor.iphone_philipp_bssid");
		///<summary>iPhone Philipp Connection Type</summary>
		public SensorEntity IphonePhilippConnectionType => new(_haContext, "sensor.iphone_philipp_connection_type");
		///<summary>iPhone-Philipp Direction</summary>
		public SensorEntity IphonePhilippDirOfTravel => new(_haContext, "sensor.iphone_philipp_dir_of_travel");
		///<summary>iPhone Philipp Geocoded Location</summary>
		public SensorEntity IphonePhilippGeocodedLocation => new(_haContext, "sensor.iphone_philipp_geocoded_location");
		///<summary>iPhone-Philipp GPS Accuracy</summary>
		public SensorEntity IphonePhilippGpsAccuracy => new(_haContext, "sensor.iphone_philipp_gps_accuracy");
		///<summary>iPhone-Philipp Info</summary>
		public SensorEntity IphonePhilippInfo => new(_haContext, "sensor.iphone_philipp_info");
		///<summary>iPhone-Philipp Interval</summary>
		public SensorEntity IphonePhilippInterval => new(_haContext, "sensor.iphone_philipp_interval");
		///<summary>iPhone-Philipp Last Located</summary>
		public SensorEntity IphonePhilippLastLocated => new(_haContext, "sensor.iphone_philipp_last_located");
		///<summary>iPhone-Philipp Last Update</summary>
		public SensorEntity IphonePhilippLastUpdate => new(_haContext, "sensor.iphone_philipp_last_update");
		///<summary>iPhone Philipp Last Update Trigger</summary>
		public SensorEntity IphonePhilippLastUpdateTrigger => new(_haContext, "sensor.iphone_philipp_last_update_trigger");
		///<summary>iPhone-Philipp Last Zone</summary>
		public SensorEntity IphonePhilippLastZone => new(_haContext, "sensor.iphone_philipp_last_zone");
		///<summary>iPhone-Philipp  Last Zone Fname</summary>
		public SensorEntity IphonePhilippLastZoneFname => new(_haContext, "sensor.iphone_philipp_last_zone_fname");
		///<summary>iPhone-Philipp Next Update</summary>
		public SensorEntity IphonePhilippNextUpdate => new(_haContext, "sensor.iphone_philipp_next_update");
		///<summary>iPhone-Philipp Poll Count</summary>
		public SensorEntity IphonePhilippPollCount => new(_haContext, "sensor.iphone_philipp_poll_count");
		///<summary>iPhone Philipp SIM 1</summary>
		public SensorEntity IphonePhilippSim1 => new(_haContext, "sensor.iphone_philipp_sim_1");
		///<summary>iPhone Philipp SSID</summary>
		public SensorEntity IphonePhilippSsid => new(_haContext, "sensor.iphone_philipp_ssid");
		///<summary>iPhone-Philipp Trigger</summary>
		public SensorEntity IphonePhilippTrigger => new(_haContext, "sensor.iphone_philipp_trigger");
		///<summary>iPhone-Philipp Zone</summary>
		public SensorEntity IphonePhilippZone => new(_haContext, "sensor.iphone_philipp_zone");
		///<summary>iPhone-Philipp  Zone Fname</summary>
		public SensorEntity IphonePhilippZoneFname => new(_haContext, "sensor.iphone_philipp_zone_fname");
		///<summary>iPhone-Philipp  Zone Name</summary>
		public SensorEntity IphonePhilippZoneName => new(_haContext, "sensor.iphone_philipp_zone_name");
		///<summary>iPhone-Philipp Zone Timestamp</summary>
		public SensorEntity IphonePhilippZoneTimestamp => new(_haContext, "sensor.iphone_philipp_zone_timestamp");
		///<summary>iPhone-Philipp  Zone Title</summary>
		public SensorEntity IphonePhilippZoneTitle => new(_haContext, "sensor.iphone_philipp_zone_title");
		///<summary>kitchen/cabinet_light_button_action</summary>
		public SensorEntity KitchenCabinetLightButtonAction => new(_haContext, "sensor.kitchen_cabinet_light_button_action");
		///<summary>kitchen/cabinet_light_button_click</summary>
		public SensorEntity KitchenCabinetLightButtonClick => new(_haContext, "sensor.kitchen_cabinet_light_button_click");
		///<summary>kitchen/cabinet_light_button_power_outage_count</summary>
		public SensorEntity KitchenCabinetLightButtonPowerOutageCount => new(_haContext, "sensor.kitchen_cabinet_light_button_power_outage_count");
		///<summary>kitchen/ceiling_light_button_action</summary>
		public SensorEntity KitchenCeilingLightButtonAction => new(_haContext, "sensor.kitchen_ceiling_light_button_action");
		///<summary>kitchen/ceiling_light_button_click</summary>
		public SensorEntity KitchenCeilingLightButtonClick => new(_haContext, "sensor.kitchen_ceiling_light_button_click");
		///<summary>kitchen/ceiling_light_button_power_outage_count</summary>
		public SensorEntity KitchenCeilingLightButtonPowerOutageCount => new(_haContext, "sensor.kitchen_ceiling_light_button_power_outage_count");
		///<summary>kitchen/kratom_counter_action</summary>
		public SensorEntity KitchenKratomCounterAction => new(_haContext, "sensor.kitchen_kratom_counter_action");
		///<summary>kitchen/kratom_counter_click</summary>
		public SensorEntity KitchenKratomCounterClick => new(_haContext, "sensor.kitchen_kratom_counter_click");
		///<summary>kitchen/kratom_counter_power_outage_count</summary>
		public SensorEntity KitchenKratomCounterPowerOutageCount => new(_haContext, "sensor.kitchen_kratom_counter_power_outage_count");
		///<summary>kitchen/motion_detector_power_outage_count</summary>
		public SensorEntity KitchenMotionDetectorPowerOutageCount => new(_haContext, "sensor.kitchen_motion_detector_power_outage_count");
		///<summary>Koch- und Backideen Philipp</summary>
		public SensorEntity KochUndBackideenPhilipp => new(_haContext, "sensor.koch_und_backideen_philipp");
		///<summary>Daily kratom intake for fabienne</summary>
		public SensorEntity KratomIntakeFabienne => new(_haContext, "sensor.kratom_intake_fabienne");
		///<summary>Daily kratom intake target for fabienne</summary>
		public SensorEntity KratomIntakeFabienneTarget => new(_haContext, "sensor.kratom_intake_fabienne_target");
		///<summary>Daily kratom intake for philipp</summary>
		public SensorEntity KratomIntakePhilipp => new(_haContext, "sensor.kratom_intake_philipp");
		///<summary>Daily kratom intake target for philipp</summary>
		public SensorEntity KratomIntakePhilippTarget => new(_haContext, "sensor.kratom_intake_philipp_target");
		///<summary>living_room/lamp_switch_action</summary>
		public SensorEntity LivingRoomLampSwitchAction => new(_haContext, "sensor.living_room_lamp_switch_action");
		///<summary>living_room/lamp_switch_click</summary>
		public SensorEntity LivingRoomLampSwitchClick => new(_haContext, "sensor.living_room_lamp_switch_click");
		///<summary>Mailbox door sensor</summary>
		public SensorEntity MailboxDoor => new(_haContext, "sensor.mailbox_door");
		///<summary>Status</summary>
		public SensorEntity Mfc1910wStatus => new(_haContext, "sensor.mfc_1910w_status");
		///<summary>netdaemon_status</summary>
		public SensorEntity NetdaemonStatus => new(_haContext, "sensor.netdaemon_status");
		///<summary>🇫🇷 Normandie 🇫🇷 Philipp</summary>
		public SensorEntity NormandiePhilipp => new(_haContext, "sensor.normandie_philipp");
		///<summary>Nuki Bridge Firmware Version</summary>
		public SensorEntity NukiBridgeFirmwareVersion => new(_haContext, "sensor.nuki_bridge_firmware_version");
		///<summary>Nuki Bridge WiFi Firmware Version</summary>
		public SensorEntity NukiBridgeWifiFirmwareVersion => new(_haContext, "sensor.nuki_bridge_wifi_firmware_version");
		///<summary>Nuki Firmware version</summary>
		public SensorEntity NukiFirmwareVersion => new(_haContext, "sensor.nuki_firmware_version");
		///<summary>Nuki Hardware version</summary>
		public SensorEntity NukiHardwareVersion => new(_haContext, "sensor.nuki_hardware_version");
		///<summary>Nuki Haustür Firmware Version</summary>
		public SensorEntity NukiHausturFirmwareVersion => new(_haContext, "sensor.nuki_haustur_firmware_version");
		///<summary>Nuki Haustür State</summary>
		public SensorEntity NukiHausturState => new(_haContext, "sensor.nuki_haustur_state");
		///<summary>Nuki trigger</summary>
		public SensorEntity NukiTrigger => new(_haContext, "sensor.nuki_trigger");
		///<summary>Nuki Wohnungstür Firmware Version</summary>
		public SensorEntity NukiWohnungsturFirmwareVersion => new(_haContext, "sensor.nuki_wohnungstur_firmware_version");
		///<summary>Nuki Wohnungstür State</summary>
		public SensorEntity NukiWohnungsturState => new(_haContext, "sensor.nuki_wohnungstur_state");
		///<summary>🌲Nürnberg🎄🍄 Philipp</summary>
		public SensorEntity NurnbergPhilipp => new(_haContext, "sensor.nurnberg_philipp");
		///<summary>openwindows_count</summary>
		public SensorEntity OpenwindowsCount => new(_haContext, "sensor.openwindows_count");
		///<summary>pupsstation Expires</summary>
		public SensorEntity PupsstationExpires => new(_haContext, "sensor.pupsstation_expires");
		///<summary>pupsstation IP address</summary>
		public SensorEntity PupsstationIpAddress => new(_haContext, "sensor.pupsstation_ip_address");
		///<summary>pupsstation Last seen</summary>
		public SensorEntity PupsstationLastSeen => new(_haContext, "sensor.pupsstation_last_seen");
		///<summary>PupsStation (Volume 1) Status</summary>
		public SensorEntity PupsstationStatus => new(_haContext, "sensor.pupsstation_status");
		///<summary>PupsStation (Drive 1) Status</summary>
		public SensorEntity PupsstationStatus2 => new(_haContext, "sensor.pupsstation_status_2");
		///<summary>PupsStation (Drive 2) Status</summary>
		public SensorEntity PupsstationStatus3 => new(_haContext, "sensor.pupsstation_status_3");
		///<summary>PupsStation (Drive 3) Status</summary>
		public SensorEntity PupsstationStatus4 => new(_haContext, "sensor.pupsstation_status_4");
		///<summary>Razor blade usage</summary>
		public SensorEntity RazorBladeUsage => new(_haContext, "sensor.razor_blade_usage");
		///<summary>🇳🇿 Rundreise Neuseeland 🇳🇿 Philipp</summary>
		public SensorEntity RundreiseNeuseelandPhilipp => new(_haContext, "sensor.rundreise_neuseeland_philipp");
		///<summary>🇺🇸 Rundreise West Coast 🇺🇸 Philipp</summary>
		public SensorEntity RundreiseWestCoastPhilipp => new(_haContext, "sensor.rundreise_west_coast_philipp");
		///<summary>🇺🇸 Rundreisen Zukunft 🇺🇸 Philipp</summary>
		public SensorEntity RundreisenZukunftPhilipp => new(_haContext, "sensor.rundreisen_zukunft_philipp");
		///<summary>Schreib-Ideen Philipp</summary>
		public SensorEntity SchreibIdeenPhilipp => new(_haContext, "sensor.schreib_ideen_philipp");
		///<summary>Sehenswerte Filme Philipp</summary>
		public SensorEntity SehenswerteFilmePhilipp => new(_haContext, "sensor.sehenswerte_filme_philipp");
		///<summary>Serien Philipp</summary>
		public SensorEntity SerienPhilipp => new(_haContext, "sensor.serien_philipp");
		///<summary>Ist heute Haushaltstag?</summary>
		public SensorEntity ShowHouseholdDayTodo => new(_haContext, "sensor.show_household_day_todo");
		///<summary>study/desk_lamp_switch_action</summary>
		public SensorEntity StudyDeskLampSwitchAction => new(_haContext, "sensor.study_desk_lamp_switch_action");
		///<summary>study/desk_lamp_switch_click</summary>
		public SensorEntity StudyDeskLampSwitchClick => new(_haContext, "sensor.study_desk_lamp_switch_click");
		///<summary>study/desk_lamp_switch_power_outage_count</summary>
		public SensorEntity StudyDeskLampSwitchPowerOutageCount => new(_haContext, "sensor.study_desk_lamp_switch_power_outage_count");
		///<summary>study/motion_detector_power_outage_count</summary>
		public SensorEntity StudyMotionDetectorPowerOutageCount => new(_haContext, "sensor.study_motion_detector_power_outage_count");
		///<summary>🫖 Tee-Ranking ☕️ (und anderes…) Philipp</summary>
		public SensorEntity TeeRankingUndAnderesPhilipp => new(_haContext, "sensor.tee_ranking_und_anderes_philipp");
		///<summary>💸 The Millionaire’s Bucket List 💸 Philipp</summary>
		public SensorEntity TheMillionairesBucketListPhilipp => new(_haContext, "sensor.the_millionaires_bucket_list_philipp");
		///<summary>Thermostat Arbeitszimmer</summary>
		public SensorEntity ThermostatArbeitszimmer => new(_haContext, "sensor.thermostat_arbeitszimmer");
		///<summary>Thermostat Badezimmer</summary>
		public SensorEntity ThermostatBadezimmer => new(_haContext, "sensor.thermostat_badezimmer");
		///<summary>Thermostat Wohnzimmer</summary>
		public SensorEntity ThermostatWohnzimmer => new(_haContext, "sensor.thermostat_wohnzimmer");
		///<summary>Unser Haus 🏠 Philipp</summary>
		public SensorEntity UnserHausPhilipp => new(_haContext, "sensor.unser_haus_philipp");
		///<summary>🌺 Urlaub Hawaii 🧳 Philipp</summary>
		public SensorEntity UrlaubHawaiiPhilipp => new(_haContext, "sensor.urlaub_hawaii_philipp");
		///<summary>Urlaub Köln SYML ⛪️ Philipp</summary>
		public SensorEntity UrlaubKolnSymlPhilipp => new(_haContext, "sensor.urlaub_koln_syml_philipp");
		///<summary>🇨🇺 Urlaub Kuba 🇨🇺 Philipp</summary>
		public SensorEntity UrlaubKubaPhilipp => new(_haContext, "sensor.urlaub_kuba_philipp");
		///<summary>🇫🇷 Urlaub Paris 🇫🇷 Philipp</summary>
		public SensorEntity UrlaubParisPhilipp => new(_haContext, "sensor.urlaub_paris_philipp");
		///<summary>🏴󠁧󠁢󠁳󠁣󠁴󠁿 Urlaub Schottland 🏴󠁧󠁢󠁳󠁣󠁴󠁿 Philipp</summary>
		public SensorEntity UrlaubSchottlandPhilipp => new(_haContext, "sensor.urlaub_schottland_philipp");
		///<summary>Urlaubsziele 2023 Philipp</summary>
		public SensorEntity Urlaubsziele2023Philipp => new(_haContext, "sensor.urlaubsziele_2023_philipp");
		///<summary>Daily water intake for fabienne</summary>
		public SensorEntity WaterIntakeFabienne => new(_haContext, "sensor.water_intake_fabienne");
		///<summary>Daily water intake target for fabienne</summary>
		public SensorEntity WaterIntakeFabienneTarget => new(_haContext, "sensor.water_intake_fabienne_target");
		///<summary>Daily water intake for philipp</summary>
		public SensorEntity WaterIntakePhilipp => new(_haContext, "sensor.water_intake_philipp");
		///<summary>Daily water intake target for philipp</summary>
		public SensorEntity WaterIntakePhilippTarget => new(_haContext, "sensor.water_intake_philipp_target");
		///<summary>Weihnachtsgeschenke Philipp</summary>
		public SensorEntity WeihnachtsgeschenkePhilipp => new(_haContext, "sensor.weihnachtsgeschenke_philipp");
		///<summary>Weihnachtswünsche Philipp</summary>
		public SensorEntity WeihnachtswunschePhilipp => new(_haContext, "sensor.weihnachtswunsche_philipp");
		///<summary>🌍 Zoo Philipp</summary>
		public SensorEntity ZooPhilipp => new(_haContext, "sensor.zoo_philipp");
	}

	public partial class SunEntities
	{
		private readonly IHaContext _haContext;
		public SunEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public partial class SwitchEntities
	{
		private readonly IHaContext _haContext;
		public SwitchEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>bedroom/lava_lamp</summary>
		public SwitchEntity BedroomLavaLamp => new(_haContext, "switch.bedroom_lava_lamp");
		///<summary>WOL switch for Desktop Philipp</summary>
		public SwitchEntity ComputerWolDesktopPhilipp => new(_haContext, "switch.computer_wol_desktop_philipp");
		///<summary>WOL switch for Desktop Philipp</summary>
		public SwitchEntity ComputerWolDesktopPhilipp2 => new(_haContext, "switch.computer_wol_desktop_philipp_2");
		///<summary>hallway/tablet Socket 1</summary>
		public SwitchEntity HallwayTabletSocket1 => new(_haContext, "switch.hallway_tablet_socket_1");
		///<summary>kitchen/neon_clock Socket 1</summary>
		public SwitchEntity KitchenNeonClockSocket1 => new(_haContext, "switch.kitchen_neon_clock_socket_1");
		///<summary>living_room/buddha_fountain Socket 1</summary>
		public SwitchEntity LivingRoomBuddhaFountainSocket1 => new(_haContext, "switch.living_room_buddha_fountain_socket_1");
		///<summary>living_room/christmas_stars Socket 1</summary>
		public SwitchEntity LivingRoomChristmasStars => new(_haContext, "switch.living_room_christmas_stars");
		///<summary>living_room/christmas_stars Child Lock</summary>
		public SwitchEntity LivingRoomChristmasStarsChildLock => new(_haContext, "switch.living_room_christmas_stars_child_lock");
		///<summary>living_room/christmas_tree Child Lock</summary>
		public SwitchEntity LivingRoomChristmasTreeChildLock => new(_haContext, "switch.living_room_christmas_tree_child_lock");
		///<summary>living_room/christmas_tree Socket 1</summary>
		public SwitchEntity LivingRoomChristmasTreeSocket1 => new(_haContext, "switch.living_room_christmas_tree_socket_1");
		///<summary>living_room/contract_light Socket 1</summary>
		public SwitchEntity LivingRoomContractLightSocket1 => new(_haContext, "switch.living_room_contract_light_socket_1");
		///<summary>living_room/lightbar Socket 1</summary>
		public SwitchEntity LivingRoomLightbarSocket1 => new(_haContext, "switch.living_room_lightbar_socket_1");
		///<summary>living_room/twtyh_diorama Socket 1</summary>
		public SwitchEntity LivingRoomTwtyhDioramaSocket1 => new(_haContext, "switch.living_room_twtyh_diorama_socket_1");
		///<summary>Enable movie time light control.</summary>
		public SwitchEntity MovieTimeEnableLightControl => new(_haContext, "switch.movie_time_enable_light_control");
		///<summary>netdaemon_caloriecounter</summary>
		public SwitchEntity NetdaemonCaloriecounter => new(_haContext, "switch.netdaemon_caloriecounter");
		///<summary>netdaemon_castdashboard</summary>
		public SwitchEntity NetdaemonCastdashboard => new(_haContext, "switch.netdaemon_castdashboard");
		///<summary>netdaemon_kitchenlight</summary>
		public SwitchEntity NetdaemonKitchenlight => new(_haContext, "switch.netdaemon_kitchenlight");
		///<summary>netdaemon_kitchenscale</summary>
		public SwitchEntity NetdaemonKitchenscale => new(_haContext, "switch.netdaemon_kitchenscale");
		///<summary>netdaemon_moonlightgamelauncher</summary>
		public SwitchEntity NetdaemonMoonlightgamelauncher => new(_haContext, "switch.netdaemon_moonlightgamelauncher");
		///<summary>netdaemon_moonlightinputselectupdater</summary>
		public SwitchEntity NetdaemonMoonlightinputselectupdater => new(_haContext, "switch.netdaemon_moonlightinputselectupdater");
		///<summary>netdaemon_trashreminder</summary>
		public SwitchEntity NetdaemonTrashreminder => new(_haContext, "switch.netdaemon_trashreminder");
		///<summary>netdaemon_vacuumreminder</summary>
		public SwitchEntity NetdaemonVacuumreminder => new(_haContext, "switch.netdaemon_vacuumreminder");
		///<summary>netdaemon_webhookserver</summary>
		public SwitchEntity NetdaemonWebhookserver => new(_haContext, "switch.netdaemon_webhookserver");
		///<summary>Nuki Button enabled</summary>
		public SwitchEntity NukiButtonEnabled => new(_haContext, "switch.nuki_button_enabled");
		///<summary>Nuki LED enabled</summary>
		public SwitchEntity NukiLedEnabled => new(_haContext, "switch.nuki_led_enabled");
		///<summary>Raumthermostat Schlafzimmer ChildLock</summary>
		public SwitchEntity RaumthermostatSchlafzimmerChildlock => new(_haContext, "switch.raumthermostat_schlafzimmer_childlock");
		///<summary>Thermostat Arbeitszimmer ChildLock</summary>
		public SwitchEntity ThermostatArbeitszimmerChildlock => new(_haContext, "switch.thermostat_arbeitszimmer_childlock");
		///<summary>Thermostat Badezimmer ChildLock</summary>
		public SwitchEntity ThermostatBadezimmerChildlock => new(_haContext, "switch.thermostat_badezimmer_childlock");
		///<summary>Thermostat Küche ChildLock</summary>
		public SwitchEntity ThermostatKucheChildlock => new(_haContext, "switch.thermostat_kuche_childlock");
		///<summary>Thermostat Schlafzimmer ChildLock</summary>
		public SwitchEntity ThermostatSchlafzimmerChildlock => new(_haContext, "switch.thermostat_schlafzimmer_childlock");
		///<summary>Thermostat Wohnzimmer ChildLock</summary>
		public SwitchEntity ThermostatWohnzimmerChildlock => new(_haContext, "switch.thermostat_wohnzimmer_childlock");
		///<summary>windows</summary>
		public SwitchEntity Windows => new(_haContext, "switch.windows");
		///<summary>windowswol</summary>
		public SwitchEntity Windowswol => new(_haContext, "switch.windowswol");
	}

	public partial class TimerEntities
	{
		private readonly IHaContext _haContext;
		public TimerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public TimerEntity Meditation => new(_haContext, "timer.meditation");
	}

	public partial class UpdateEntities
	{
		private readonly IHaContext _haContext;
		public UpdateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>living_room/lamp_switch</summary>
		public UpdateEntity E0x90ab96fffe180250 => new(_haContext, "update.0x90ab96fffe180250");
		///<summary>bedroom/lava_lamp</summary>
		public UpdateEntity BedroomLavaLamp => new(_haContext, "update.bedroom_lava_lamp");
		///<summary>bedroom/roller_shutter_left</summary>
		public UpdateEntity BedroomRollerShutterLeft => new(_haContext, "update.bedroom_roller_shutter_left");
		///<summary>bedroom/roller_shutter_right</summary>
		public UpdateEntity BedroomRollerShutterRight => new(_haContext, "update.bedroom_roller_shutter_right");
		///<summary>kitchen/cabinet_light</summary>
		public UpdateEntity KitchenCabinetLight => new(_haContext, "update.kitchen_cabinet_light");
		///<summary>kitchen/ceiling_light</summary>
		public UpdateEntity KitchenCeilingLight => new(_haContext, "update.kitchen_ceiling_light");
		///<summary>living_room/standard_lamp</summary>
		public UpdateEntity LivingRoomStandardLamp => new(_haContext, "update.living_room_standard_lamp");
		///<summary>PupsStation DSM Update</summary>
		public UpdateEntity PupsstationDsmUpdate => new(_haContext, "update.pupsstation_dsm_update");
	}

	public partial class VacuumEntities
	{
		private readonly IHaContext _haContext;
		public VacuumEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Fantenrüssel</summary>
		public VacuumEntity Fantenrussel => new(_haContext, "vacuum.fantenrussel");
	}

	public partial class WeatherEntities
	{
		private readonly IHaContext _haContext;
		public WeatherEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Forecast Zuhause</summary>
		public WeatherEntity Zuhause => new(_haContext, "weather.zuhause");
	}

	public partial class ZoneEntities
	{
		private readonly IHaContext _haContext;
		public ZoneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>EnBW</summary>
		public ZoneEntity Enbw => new(_haContext, "zone.enbw");
		///<summary>Home</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
		///<summary>iphone_philipp_stationary</summary>
		public ZoneEntity IphonePhilippStationary => new(_haContext, "zone.iphone_philipp_stationary");
		///<summary>Messe Karlsruhe (dm Arena)</summary>
		public ZoneEntity MesseKarlsruheDmArena => new(_haContext, "zone.messe_karlsruhe_dm_arena");
		///<summary>Messe Karlsruhe (Festplatz)</summary>
		public ZoneEntity MesseKarlsruheFestplatz => new(_haContext, "zone.messe_karlsruhe_festplatz");
	}

	public partial record AlarmControlPanelEntity : Entity<AlarmControlPanelEntity, EntityState<AlarmControlPanelAttributes>, AlarmControlPanelAttributes>
	{
		public AlarmControlPanelEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AlarmControlPanelEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AlarmControlPanelAttributes
	{
		[JsonPropertyName("changed_by")]
		public object? ChangedBy { get; init; }

		[JsonPropertyName("code_arm_required")]
		public bool? CodeArmRequired { get; init; }

		[JsonPropertyName("code_format")]
		public object? CodeFormat { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("callback#0")]
		public string? Callback0 { get; init; }

		[JsonPropertyName("callback#1")]
		public string? Callback1 { get; init; }

		[JsonPropertyName("charging_status")]
		public object? ChargingStatus { get; init; }

		[JsonPropertyName("child_lock")]
		public string? ChildLock { get; init; }

		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("color_temp")]
		public double? ColorTemp { get; init; }

		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("device")]
		public object? Device { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_temperature")]
		public double? DeviceTemperature { get; init; }

		[JsonPropertyName("energy")]
		public double? Energy { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("indicator_mode")]
		public string? IndicatorMode { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("malware")]
		public string? Malware { get; init; }

		[JsonPropertyName("motor_state")]
		public object? MotorState { get; init; }

		[JsonPropertyName("network")]
		public string? Network { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("position")]
		public double? Position { get; init; }

		[JsonPropertyName("power")]
		public double? Power { get; init; }

		[JsonPropertyName("power_on_behavior")]
		public string? PowerOnBehavior { get; init; }

		[JsonPropertyName("power_outage_count")]
		public double? PowerOutageCount { get; init; }

		[JsonPropertyName("power_outage_memory")]
		public string? PowerOutageMemory { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("round_trip_time_avg")]
		public double? RoundTripTimeAvg { get; init; }

		[JsonPropertyName("round_trip_time_max")]
		public double? RoundTripTimeMax { get; init; }

		[JsonPropertyName("round_trip_time_mdev")]
		public string? RoundTripTimeMdev { get; init; }

		[JsonPropertyName("round_trip_time_min")]
		public double? RoundTripTimeMin { get; init; }

		[JsonPropertyName("running")]
		public object? Running { get; init; }

		[JsonPropertyName("securitySetting")]
		public string? SecuritySetting { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("systemCheck")]
		public string? SystemCheck { get; init; }

		[JsonPropertyName("timestamp")]
		public string? Timestamp { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("userInfo")]
		public string? UserInfo { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }

		[JsonPropertyName("wifiFirmwareVersion")]
		public string? WifiFirmwareVersion { get; init; }
	}

	public partial record ButtonEntity : Entity<ButtonEntity, EntityState<ButtonAttributes>, ButtonAttributes>
	{
		public ButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ButtonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ButtonAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }
	}

	public partial record CalendarEntity : Entity<CalendarEntity, EntityState<CalendarAttributes>, CalendarAttributes>
	{
		public CalendarEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CalendarEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CalendarAttributes
	{
		[JsonPropertyName("data")]
		public IReadOnlyList<object>? Data { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public partial record CameraEntity : Entity<CameraEntity, EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CameraEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CameraAttributes
	{
		[JsonPropertyName("access_token")]
		public string? AccessToken { get; init; }

		[JsonPropertyName("calibration_points")]
		public IReadOnlyList<object>? CalibrationPoints { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("model")]
		public string? Model { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("used_api")]
		public string? UsedApi { get; init; }
	}

	public partial record ClimateEntity : Entity<ClimateEntity, EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ClimateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ClimateAttributes
	{
		[JsonPropertyName("current_temperature")]
		public double? CurrentTemperature { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hvac_modes")]
		public IReadOnlyList<string>? HvacModes { get; init; }

		[JsonPropertyName("max_temp")]
		public double? MaxTemp { get; init; }

		[JsonPropertyName("min_temp")]
		public double? MinTemp { get; init; }

		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }

		[JsonPropertyName("preset_modes")]
		public IReadOnlyList<string>? PresetModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("target_temp_step")]
		public double? TargetTempStep { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public partial record CounterEntity : Entity<CounterEntity, EntityState<CounterAttributes>, CounterAttributes>
	{
		public CounterEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CounterEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CounterAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("initial")]
		public double? Initial { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record CoverEntity : Entity<CoverEntity, EntityState<CoverAttributes>, CoverAttributes>
	{
		public CoverEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CoverEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CoverAttributes
	{
		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("charging_status")]
		public object? ChargingStatus { get; init; }

		[JsonPropertyName("current_position")]
		public double? CurrentPosition { get; init; }

		[JsonPropertyName("device")]
		public object? Device { get; init; }

		[JsonPropertyName("device_temperature")]
		public object? DeviceTemperature { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("motor_state")]
		public object? MotorState { get; init; }

		[JsonPropertyName("position")]
		public double? Position { get; init; }

		[JsonPropertyName("running")]
		public object? Running { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }
	}

	public partial record DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerAttributes
	{
		[JsonPropertyName("altitude")]
		public double? Altitude { get; init; }

		[JsonPropertyName("authenticated")]
		public string? Authenticated { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("battery_level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("battery_status")]
		public string? BatteryStatus { get; init; }

		[JsonPropertyName("calc_distance")]
		public double? CalcDistance { get; init; }

		[JsonPropertyName("course")]
		public double? Course { get; init; }

		[JsonPropertyName("device_status")]
		public string? DeviceStatus { get; init; }

		[JsonPropertyName("dir_of_travel")]
		public string? DirOfTravel { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("icloud3_version")]
		public string? Icloud3Version { get; init; }

		[JsonPropertyName("info")]
		public string? Info { get; init; }

		[JsonPropertyName("interval")]
		public string? Interval { get; init; }

		[JsonPropertyName("last_located")]
		public string? LastLocated { get; init; }

		[JsonPropertyName("last_update")]
		public string? LastUpdate { get; init; }

		[JsonPropertyName("last_zone")]
		public string? LastZone { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("low_power_mode")]
		public bool? LowPowerMode { get; init; }

		[JsonPropertyName("name")]
		public string? Name { get; init; }

		[JsonPropertyName("next_update")]
		public string? NextUpdate { get; init; }

		[JsonPropertyName("poll_count")]
		public string? PollCount { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("source_type")]
		public string? SourceType { get; init; }

		[JsonPropertyName("speed")]
		public double? Speed { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("timestamp")]
		public string? Timestamp { get; init; }

		[JsonPropertyName("tracking")]
		public string? Tracking { get; init; }

		[JsonPropertyName("travel_distance")]
		public double? TravelDistance { get; init; }

		[JsonPropertyName("travel_time")]
		public double? TravelTime { get; init; }

		[JsonPropertyName("travel_time_min")]
		public double? TravelTimeMin { get; init; }

		[JsonPropertyName("trigger")]
		public string? Trigger { get; init; }

		[JsonPropertyName("vertical_accuracy")]
		public double? VerticalAccuracy { get; init; }

		[JsonPropertyName("waze_distance")]
		public double? WazeDistance { get; init; }

		[JsonPropertyName("zone")]
		public string? Zone { get; init; }

		[JsonPropertyName("zone_distance")]
		public double? ZoneDistance { get; init; }

		[JsonPropertyName("zone_timestamp")]
		public string? ZoneTimestamp { get; init; }
	}

	public partial record GroupEntity : Entity<GroupEntity, EntityState<GroupAttributes>, GroupAttributes>
	{
		public GroupEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public GroupEntity(Entity entity) : base(entity)
		{
		}
	}

	public record GroupAttributes
	{
		[JsonPropertyName("entity_id")]
		public IReadOnlyList<string>? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("order")]
		public double? Order { get; init; }
	}

	public partial record InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputBooleanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputBooleanAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record InputNumberEntity : NumericEntity<InputNumberEntity, NumericEntityState<InputNumberAttributes>, InputNumberAttributes>
	{
		public InputNumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputNumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputNumberAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("initial")]
		public double? Initial { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record InputSelectEntity : Entity<InputSelectEntity, EntityState<InputSelectAttributes>, InputSelectAttributes>
	{
		public InputSelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputSelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputSelectAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("options")]
		public IReadOnlyList<string>? Options { get; init; }
	}

	public partial record InputTextEntity : Entity<InputTextEntity, EntityState<InputTextAttributes>, InputTextAttributes>
	{
		public InputTextEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputTextEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputTextAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("pattern")]
		public object? Pattern { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LightAttributes
	{
		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("color")]
		public object? Color { get; init; }

		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("color_temp")]
		public double? ColorTemp { get; init; }

		[JsonPropertyName("color_temp_kelvin")]
		public double? ColorTempKelvin { get; init; }

		[JsonPropertyName("device")]
		public object? Device { get; init; }

		[JsonPropertyName("effect_list")]
		public IReadOnlyList<string>? EffectList { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hs_color")]
		public IReadOnlyList<double>? HsColor { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("max_color_temp_kelvin")]
		public double? MaxColorTempKelvin { get; init; }

		[JsonPropertyName("max_mireds")]
		public double? MaxMireds { get; init; }

		[JsonPropertyName("min_color_temp_kelvin")]
		public double? MinColorTempKelvin { get; init; }

		[JsonPropertyName("min_mireds")]
		public double? MinMireds { get; init; }

		[JsonPropertyName("power_on_behavior")]
		public string? PowerOnBehavior { get; init; }

		[JsonPropertyName("rgb_color")]
		public IReadOnlyList<double>? RgbColor { get; init; }

		[JsonPropertyName("supported_color_modes")]
		public IReadOnlyList<string>? SupportedColorModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("xy_color")]
		public IReadOnlyList<double>? XyColor { get; init; }
	}

	public partial record LockEntity : Entity<LockEntity, EntityState<LockAttributes>, LockAttributes>
	{
		public LockEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LockEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LockAttributes
	{
		[JsonPropertyName("child_lock")]
		public string? ChildLock { get; init; }

		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("device")]
		public object? Device { get; init; }

		[JsonPropertyName("energy")]
		public double? Energy { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("indicator_mode")]
		public string? IndicatorMode { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("power")]
		public double? Power { get; init; }

		[JsonPropertyName("power_outage_memory")]
		public string? PowerOutageMemory { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public object? UpdateAvailable { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
	}

	public partial record MediaPlayerEntity : Entity<MediaPlayerEntity, EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record NumberEntity : NumericEntity<NumberEntity, NumericEntityState<NumberAttributes>, NumberAttributes>
	{
		public NumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumberAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }
	}

	public partial record PersistentNotificationEntity : Entity<PersistentNotificationEntity, EntityState<PersistentNotificationAttributes>, PersistentNotificationAttributes>
	{
		public PersistentNotificationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersistentNotificationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersistentNotificationAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("message")]
		public string? Message { get; init; }

		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public partial record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersonAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("user_id")]
		public string? UserId { get; init; }
	}

	public partial record RemoteEntity : Entity<RemoteEntity, EntityState<RemoteAttributes>, RemoteAttributes>
	{
		public RemoteEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public RemoteEntity(Entity entity) : base(entity)
		{
		}
	}

	public record RemoteAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record SelectEntity : Entity<SelectEntity, EntityState<SelectAttributes>, SelectAttributes>
	{
		public SelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SelectAttributes
	{
		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("child_lock")]
		public string? ChildLock { get; init; }

		[JsonPropertyName("color")]
		public object? Color { get; init; }

		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("color_temp")]
		public double? ColorTemp { get; init; }

		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("device")]
		public object? Device { get; init; }

		[JsonPropertyName("energy")]
		public double? Energy { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("indicator_mode")]
		public string? IndicatorMode { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("options")]
		public IReadOnlyList<string>? Options { get; init; }

		[JsonPropertyName("power")]
		public double? Power { get; init; }

		[JsonPropertyName("power_on_behavior")]
		public string? PowerOnBehavior { get; init; }

		[JsonPropertyName("power_outage_memory")]
		public string? PowerOutageMemory { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
	}

	public partial record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorAttributes
	{
		[JsonPropertyName("action")]
		public object? Action { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("Available")]
		public string? Available { get; init; }

		[JsonPropertyName("Available (Important)")]
		public string? AvailableImportant { get; init; }

		[JsonPropertyName("Available (Opportunistic)")]
		public string? AvailableOpportunistic { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("bytes_received")]
		public double? BytesReceived { get; init; }

		[JsonPropertyName("bytes_sent")]
		public double? BytesSent { get; init; }

		[JsonPropertyName("change")]
		public double? Change { get; init; }

		[JsonPropertyName("changeCurrentYear")]
		public double? ChangeCurrentYear { get; init; }

		[JsonPropertyName("changeFiveYears")]
		public object? ChangeFiveYears { get; init; }

		[JsonPropertyName("changeOneMonth")]
		public double? ChangeOneMonth { get; init; }

		[JsonPropertyName("changeOneWeek")]
		public double? ChangeOneWeek { get; init; }

		[JsonPropertyName("changeOneYear")]
		public double? ChangeOneYear { get; init; }

		[JsonPropertyName("changePercent")]
		public double? ChangePercent { get; init; }

		[JsonPropertyName("changePercentCurrentYear")]
		public double? ChangePercentCurrentYear { get; init; }

		[JsonPropertyName("changePercentFiveYears")]
		public object? ChangePercentFiveYears { get; init; }

		[JsonPropertyName("changePercentOneMonth")]
		public double? ChangePercentOneMonth { get; init; }

		[JsonPropertyName("changePercentOneWeek")]
		public double? ChangePercentOneWeek { get; init; }

		[JsonPropertyName("changePercentOneYear")]
		public double? ChangePercentOneYear { get; init; }

		[JsonPropertyName("changePercentTenYears")]
		public object? ChangePercentTenYears { get; init; }

		[JsonPropertyName("changePercentThreeMonths")]
		public double? ChangePercentThreeMonths { get; init; }

		[JsonPropertyName("changePercentThreeYears")]
		public double? ChangePercentThreeYears { get; init; }

		[JsonPropertyName("changeTenYears")]
		public object? ChangeTenYears { get; init; }

		[JsonPropertyName("changeThreeMonths")]
		public double? ChangeThreeMonths { get; init; }

		[JsonPropertyName("changeThreeYears")]
		public double? ChangeThreeYears { get; init; }

		[JsonPropertyName("charging_status")]
		public object? ChargingStatus { get; init; }

		[JsonPropertyName("child_lock")]
		public string? ChildLock { get; init; }

		[JsonPropertyName("click")]
		public object? Click { get; init; }

		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("device")]
		public object? Device { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_temperature")]
		public double? DeviceTemperature { get; init; }

		[JsonPropertyName("energy")]
		public double? Energy { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("indicator_mode")]
		public string? IndicatorMode { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("motor_state")]
		public object? MotorState { get; init; }

		[JsonPropertyName("name")]
		public string? Name { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("packages")]
		public IReadOnlyList<object>? Packages { get; init; }

		[JsonPropertyName("position")]
		public double? Position { get; init; }

		[JsonPropertyName("power")]
		public double? Power { get; init; }

		[JsonPropertyName("power_outage_count")]
		public double? PowerOutageCount { get; init; }

		[JsonPropertyName("power_outage_memory")]
		public string? PowerOutageMemory { get; init; }

		[JsonPropertyName("profitLoss")]
		public double? ProfitLoss { get; init; }

		[JsonPropertyName("profitLossPercentage")]
		public double? ProfitLossPercentage { get; init; }

		[JsonPropertyName("purchasePrice")]
		public double? PurchasePrice { get; init; }

		[JsonPropertyName("repositories")]
		public IReadOnlyList<object>? Repositories { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("running")]
		public object? Running { get; init; }

		[JsonPropertyName("server_country")]
		public string? ServerCountry { get; init; }

		[JsonPropertyName("server_id")]
		public string? ServerId { get; init; }

		[JsonPropertyName("server_name")]
		public string? ServerName { get; init; }

		[JsonPropertyName("shares")]
		public double? Shares { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("Total")]
		public string? Total { get; init; }

		[JsonPropertyName("totalChange")]
		public double? TotalChange { get; init; }

		[JsonPropertyName("totalChangeCurrentYear")]
		public double? TotalChangeCurrentYear { get; init; }

		[JsonPropertyName("totalChangeFiveYears")]
		public object? TotalChangeFiveYears { get; init; }

		[JsonPropertyName("totalChangeOneMonth")]
		public double? TotalChangeOneMonth { get; init; }

		[JsonPropertyName("totalChangeOneWeek")]
		public double? TotalChangeOneWeek { get; init; }

		[JsonPropertyName("totalChangeOneYear")]
		public double? TotalChangeOneYear { get; init; }

		[JsonPropertyName("totalChangeTenYears")]
		public object? TotalChangeTenYears { get; init; }

		[JsonPropertyName("totalChangeThreeMonths")]
		public double? TotalChangeThreeMonths { get; init; }

		[JsonPropertyName("totalChangeThreeYears")]
		public double? TotalChangeThreeYears { get; init; }

		[JsonPropertyName("totalProfitLoss")]
		public double? TotalProfitLoss { get; init; }

		[JsonPropertyName("totalValue")]
		public double? TotalValue { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("valve_tappet_state")]
		public string? ValveTappetState { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
	}

	public partial record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SensorAttributes
	{
		[JsonPropertyName("action")]
		public object? Action { get; init; }

		[JsonPropertyName("Administrative Area")]
		public string? AdministrativeArea { get; init; }

		[JsonPropertyName("Allows VoIP")]
		public bool? AllowsVoIP { get; init; }

		[JsonPropertyName("all_tasks")]
		public IReadOnlyList<object>? AllTasks { get; init; }

		[JsonPropertyName("Areas Of Interest")]
		public string? AreasOfInterest { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("Carrier ID")]
		public string? CarrierID { get; init; }

		[JsonPropertyName("Carrier Name")]
		public string? CarrierName { get; init; }

		[JsonPropertyName("charging_status")]
		public object? ChargingStatus { get; init; }

		[JsonPropertyName("click")]
		public object? Click { get; init; }

		[JsonPropertyName("command_set")]
		public string? CommandSet { get; init; }

		[JsonPropertyName("Confidence")]
		public string? Confidence { get; init; }

		[JsonPropertyName("Country")]
		public string? Country { get; init; }

		[JsonPropertyName("Current Radio Technology")]
		public string? CurrentRadioTechnology { get; init; }

		[JsonPropertyName("device")]
		public object? Device { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_temperature")]
		public double? DeviceTemperature { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("filtername")]
		public string? Filtername { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("info")]
		public string? Info { get; init; }

		[JsonPropertyName("Inland Water")]
		public string? InlandWater { get; init; }

		[JsonPropertyName("integration")]
		public string? Integration { get; init; }

		[JsonPropertyName("ISO Country Code")]
		public string? ISOCountryCode { get; init; }

		[JsonPropertyName("last_increment")]
		public double? LastIncrement { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("Locality")]
		public string? Locality { get; init; }

		[JsonPropertyName("location")]
		public string? Location_0 { get; init; }

		[JsonPropertyName("Location")]
		public IReadOnlyList<double>? Location_1 { get; init; }

		[JsonPropertyName("log_level_debug")]
		public string? LogLevelDebug { get; init; }

		[JsonPropertyName("logs")]
		public string? Logs { get; init; }

		[JsonPropertyName("Low Power Mode")]
		public bool? LowPowerMode { get; init; }

		[JsonPropertyName("Mobile Country Code")]
		public string? MobileCountryCode { get; init; }

		[JsonPropertyName("Mobile Network Code")]
		public string? MobileNetworkCode { get; init; }

		[JsonPropertyName("motor_state")]
		public object? MotorState { get; init; }

		[JsonPropertyName("Name")]
		public string? Name { get; init; }

		[JsonPropertyName("names")]
		public object? Names { get; init; }

		[JsonPropertyName("number_of_loaded_apps")]
		public double? NumberOfLoadedApps { get; init; }

		[JsonPropertyName("number_of_running_apps")]
		public double? NumberOfRunningApps { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("Ocean")]
		public string? Ocean { get; init; }

		[JsonPropertyName("options")]
		public IReadOnlyList<string>? Options { get; init; }

		[JsonPropertyName("overdue_tasks")]
		public IReadOnlyList<object>? OverdueTasks { get; init; }

		[JsonPropertyName("position")]
		public double? Position { get; init; }

		[JsonPropertyName("Postal Code")]
		public string? PostalCode { get; init; }

		[JsonPropertyName("power_outage_count")]
		public double? PowerOutageCount { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("running")]
		public object? Running { get; init; }

		[JsonPropertyName("serial")]
		public object? Serial { get; init; }

		[JsonPropertyName("state_message")]
		public string? StateMessage { get; init; }

		[JsonPropertyName("state_reason")]
		public object? StateReason { get; init; }

		[JsonPropertyName("Sub Administrative Area")]
		public string? SubAdministrativeArea { get; init; }

		[JsonPropertyName("Sub Locality")]
		public string? SubLocality { get; init; }

		[JsonPropertyName("Sub Thoroughfare")]
		public string? SubThoroughfare { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("Thoroughfare")]
		public string? Thoroughfare { get; init; }

		[JsonPropertyName("Time Zone")]
		public string? TimeZone { get; init; }

		[JsonPropertyName("Types")]
		public IReadOnlyList<string>? Types { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("update_time")]
		public string? UpdateTime { get; init; }

		[JsonPropertyName("uri_supported")]
		public string? UriSupported { get; init; }

		[JsonPropertyName("version")]
		public string? Version { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }

		[JsonPropertyName("workout0_title")]
		public string? Workout0Title { get; init; }

		[JsonPropertyName("workout0_url")]
		public string? Workout0Url { get; init; }

		[JsonPropertyName("workout1_title")]
		public string? Workout1Title { get; init; }

		[JsonPropertyName("workout1_url")]
		public string? Workout1Url { get; init; }

		[JsonPropertyName("Zones")]
		public IReadOnlyList<string>? Zones { get; init; }
	}

	public partial record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SunAttributes
	{
		[JsonPropertyName("azimuth")]
		public double? Azimuth { get; init; }

		[JsonPropertyName("elevation")]
		public double? Elevation { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("next_dawn")]
		public string? NextDawn { get; init; }

		[JsonPropertyName("next_dusk")]
		public string? NextDusk { get; init; }

		[JsonPropertyName("next_midnight")]
		public string? NextMidnight { get; init; }

		[JsonPropertyName("next_noon")]
		public string? NextNoon { get; init; }

		[JsonPropertyName("next_rising")]
		public string? NextRising { get; init; }

		[JsonPropertyName("next_setting")]
		public string? NextSetting { get; init; }

		[JsonPropertyName("rising")]
		public bool? Rising { get; init; }
	}

	public partial record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SwitchAttributes
	{
		[JsonPropertyName("child_lock")]
		public string? ChildLock { get; init; }

		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("device")]
		public object? Device { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("energy")]
		public double? Energy { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("indicator_mode")]
		public string? IndicatorMode { get; init; }

		[JsonPropertyName("integration")]
		public string? Integration { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("power")]
		public double? Power { get; init; }

		[JsonPropertyName("power_outage_memory")]
		public string? PowerOutageMemory { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public object? UpdateAvailable { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
	}

	public partial record TimerEntity : Entity<TimerEntity, EntityState<TimerAttributes>, TimerAttributes>
	{
		public TimerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public TimerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record TimerAttributes
	{
		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record UpdateEntity : Entity<UpdateEntity, EntityState<UpdateAttributes>, UpdateAttributes>
	{
		public UpdateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public UpdateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record UpdateAttributes
	{
		[JsonPropertyName("action")]
		public object? Action { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("auto_update")]
		public bool? AutoUpdate { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("charging_status")]
		public object? ChargingStatus { get; init; }

		[JsonPropertyName("child_lock")]
		public string? ChildLock { get; init; }

		[JsonPropertyName("click")]
		public object? Click { get; init; }

		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("color_temp")]
		public double? ColorTemp { get; init; }

		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("device")]
		public object? Device { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_temperature")]
		public object? DeviceTemperature { get; init; }

		[JsonPropertyName("energy")]
		public double? Energy { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("indicator_mode")]
		public string? IndicatorMode { get; init; }

		[JsonPropertyName("in_progress")]
		public bool? InProgress { get; init; }

		[JsonPropertyName("installed_version")]
		public string? InstalledVersion { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("latest_version")]
		public string? LatestVersion { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("motor_state")]
		public object? MotorState { get; init; }

		[JsonPropertyName("position")]
		public double? Position { get; init; }

		[JsonPropertyName("power")]
		public double? Power { get; init; }

		[JsonPropertyName("power_on_behavior")]
		public string? PowerOnBehavior { get; init; }

		[JsonPropertyName("power_outage_memory")]
		public string? PowerOutageMemory { get; init; }

		[JsonPropertyName("release_summary")]
		public object? ReleaseSummary { get; init; }

		[JsonPropertyName("release_url")]
		public string? ReleaseUrl { get; init; }

		[JsonPropertyName("running")]
		public object? Running { get; init; }

		[JsonPropertyName("skipped_version")]
		public object? SkippedVersion { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("title")]
		public string? Title { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
	}

	public partial record VacuumEntity : Entity<VacuumEntity, EntityState<VacuumAttributes>, VacuumAttributes>
	{
		public VacuumEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VacuumEntity(Entity entity) : base(entity)
		{
		}
	}

	public record VacuumAttributes
	{
		[JsonPropertyName("battery_icon")]
		public string? BatteryIcon { get; init; }

		[JsonPropertyName("battery_level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }

		[JsonPropertyName("fan_speed_list")]
		public IReadOnlyList<string>? FanSpeedList { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record WeatherEntity : Entity<WeatherEntity, EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public WeatherEntity(Entity entity) : base(entity)
		{
		}
	}

	public record WeatherAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("forecast")]
		public IReadOnlyList<object>? Forecast { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("precipitation_unit")]
		public string? PrecipitationUnit { get; init; }

		[JsonPropertyName("pressure")]
		public double? Pressure { get; init; }

		[JsonPropertyName("pressure_unit")]
		public string? PressureUnit { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("temperature_unit")]
		public string? TemperatureUnit { get; init; }

		[JsonPropertyName("visibility_unit")]
		public string? VisibilityUnit { get; init; }

		[JsonPropertyName("wind_bearing")]
		public double? WindBearing { get; init; }

		[JsonPropertyName("wind_speed")]
		public double? WindSpeed { get; init; }

		[JsonPropertyName("wind_speed_unit")]
		public string? WindSpeedUnit { get; init; }
	}

	public partial record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ZoneAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("name")]
		public string? Name { get; init; }

		[JsonPropertyName("passive")]
		public bool? Passive { get; init; }

		[JsonPropertyName("persons")]
		public IReadOnlyList<string>? Persons { get; init; }

		[JsonPropertyName("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AlarmControlPanelServices AlarmControlPanel { get; }

		AutomationServices Automation { get; }

		BackupServices Backup { get; }

		BoschShcServices BoschShc { get; }

		BrowserModServices BrowserMod { get; }

		ButtonServices Button { get; }

		CalendarServices Calendar { get; }

		CameraServices Camera { get; }

		CastServices Cast { get; }

		ClimateServices Climate { get; }

		CloudServices Cloud { get; }

		CloudflareServices Cloudflare { get; }

		ConversationServices Conversation { get; }

		CounterServices Counter { get; }

		CoverServices Cover { get; }

		DeviceTrackerServices DeviceTracker { get; }

		FanServices Fan { get; }

		FfmpegServices Ffmpeg { get; }

		FrontendServices Frontend { get; }

		GroupServices Group { get; }

		HomeassistantServices Homeassistant { get; }

		HumidifierServices Humidifier { get; }

		InputBooleanServices InputBoolean { get; }

		InputButtonServices InputButton { get; }

		InputDatetimeServices InputDatetime { get; }

		InputNumberServices InputNumber { get; }

		InputSelectServices InputSelect { get; }

		InputTextServices InputText { get; }

		LightServices Light { get; }

		LockServices Lock { get; }

		LogbookServices Logbook { get; }

		LoggerServices Logger { get; }

		LovelaceServices Lovelace { get; }

		MediaPlayerServices MediaPlayer { get; }

		MqttServices Mqtt { get; }

		NetdaemonServices Netdaemon { get; }

		NotifyServices Notify { get; }

		NukiNgServices NukiNg { get; }

		NumberServices Number { get; }

		O365Services O365 { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		PingServices Ping { get; }

		RecorderServices Recorder { get; }

		RemoteServices Remote { get; }

		SceneServices Scene { get; }

		ScheduleServices Schedule { get; }

		ScriptServices Script { get; }

		SelectServices Select { get; }

		SirenServices Siren { get; }

		SwitchServices Switch { get; }

		SynologyDsmServices SynologyDsm { get; }

		SystemLogServices SystemLog { get; }

		TemplateServices Template { get; }

		TextServices Text { get; }

		TimerServices Timer { get; }

		UpdateServices Update { get; }

		VacuumServices Vacuum { get; }

		WakeOnLanServices WakeOnLan { get; }

		WebrtcServices Webrtc { get; }

		XiaomiCloudMapExtractorServices XiaomiCloudMapExtractor { get; }

		XiaomiMiioServices XiaomiMiio { get; }

		ZoneServices Zone { get; }
	}

	public class Services : IServices
	{
		private readonly IHaContext _haContext;
		public Services(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
		public AutomationServices Automation => new(_haContext);
		public BackupServices Backup => new(_haContext);
		public BoschShcServices BoschShc => new(_haContext);
		public BrowserModServices BrowserMod => new(_haContext);
		public ButtonServices Button => new(_haContext);
		public CalendarServices Calendar => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public CastServices Cast => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CloudServices Cloud => new(_haContext);
		public CloudflareServices Cloudflare => new(_haContext);
		public ConversationServices Conversation => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public CoverServices Cover => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public FanServices Fan => new(_haContext);
		public FfmpegServices Ffmpeg => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GroupServices Group => new(_haContext);
		public HomeassistantServices Homeassistant => new(_haContext);
		public HumidifierServices Humidifier => new(_haContext);
		public InputBooleanServices InputBoolean => new(_haContext);
		public InputButtonServices InputButton => new(_haContext);
		public InputDatetimeServices InputDatetime => new(_haContext);
		public InputNumberServices InputNumber => new(_haContext);
		public InputSelectServices InputSelect => new(_haContext);
		public InputTextServices InputText => new(_haContext);
		public LightServices Light => new(_haContext);
		public LockServices Lock => new(_haContext);
		public LogbookServices Logbook => new(_haContext);
		public LoggerServices Logger => new(_haContext);
		public LovelaceServices Lovelace => new(_haContext);
		public MediaPlayerServices MediaPlayer => new(_haContext);
		public MqttServices Mqtt => new(_haContext);
		public NetdaemonServices Netdaemon => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public NukiNgServices NukiNg => new(_haContext);
		public NumberServices Number => new(_haContext);
		public O365Services O365 => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public PingServices Ping => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public RemoteServices Remote => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public ScheduleServices Schedule => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public SelectServices Select => new(_haContext);
		public SirenServices Siren => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SynologyDsmServices SynologyDsm => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TemplateServices Template => new(_haContext);
		public TextServices Text => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public UpdateServices Update => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public WakeOnLanServices WakeOnLan => new(_haContext);
		public WebrtcServices Webrtc => new(_haContext);
		public XiaomiCloudMapExtractorServices XiaomiCloudMapExtractor => new(_haContext);
		public XiaomiMiioServices XiaomiMiio => new(_haContext);
		public ZoneServices Zone => new(_haContext);
	}

	public class AlarmControlPanelServices
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public void AlarmArmAway(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public void AlarmArmCustomBypass(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public void AlarmArmHome(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public void AlarmArmNight(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public void AlarmArmVacation(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public void AlarmDisarm(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public void AlarmTrigger(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public record AlarmControlPanelAlarmArmAwayParameters
	{
		///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmCustomBypassParameters
	{
		///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmHomeParameters
	{
		///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmNightParameters
	{
		///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmVacationParameters
	{
		///<summary>An optional code to arm vacation the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmDisarmParameters
	{
		///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmTriggerParameters
	{
		///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class AutomationServices
	{
		private readonly IHaContext _haContext;
		public AutomationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the automation configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Trigger(ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public void Trigger(ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public void TurnOff(ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		///<summary>Whether or not the conditions will be skipped.</summary>
		[JsonPropertyName("skip_condition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		///<summary>Stop currently running actions.</summary>
		[JsonPropertyName("stop_actions")]
		public bool? StopActions { get; init; }
	}

	public class BackupServices
	{
		private readonly IHaContext _haContext;
		public BackupServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a new backup.</summary>
		public void Create()
		{
			_haContext.CallService("backup", "create", null);
		}
	}

	public class BoschShcServices
	{
		private readonly IHaContext _haContext;
		public BoschShcServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Triggers a custom alarm state on a smoke detector.</summary>
		public void SmokedetectorAlarmstate(BoschShcSmokedetectorAlarmstateParameters data)
		{
			_haContext.CallService("bosch_shc", "smokedetector_alarmstate", null, data);
		}

		///<summary>Triggers a custom alarm state on a smoke detector.</summary>
		///<param name="entityId">Name of the smoke detector entity to set eg: binary_sensor.smokedetector_living_room</param>
		///<param name="command">Command string to send to the smoke detector. eg: CUSTOM_COMMAND</param>
		public void SmokedetectorAlarmstate(object? @entityId = null, object? @command = null)
		{
			_haContext.CallService("bosch_shc", "smokedetector_alarmstate", null, new BoschShcSmokedetectorAlarmstateParameters{EntityId = @entityId, Command = @command});
		}

		///<summary>Calls test routine of a smoke detector.</summary>
		public void SmokedetectorCheck(BoschShcSmokedetectorCheckParameters data)
		{
			_haContext.CallService("bosch_shc", "smokedetector_check", null, data);
		}

		///<summary>Calls test routine of a smoke detector.</summary>
		///<param name="entityId">Name of the smoke detector entity to set eg: binary_sensor.smokedetector_living_room</param>
		public void SmokedetectorCheck(object? @entityId = null)
		{
			_haContext.CallService("bosch_shc", "smokedetector_check", null, new BoschShcSmokedetectorCheckParameters{EntityId = @entityId});
		}

		///<summary>Triggers a scenario on Bosch SHC.</summary>
		public void TriggerScenario(BoschShcTriggerScenarioParameters data)
		{
			_haContext.CallService("bosch_shc", "trigger_scenario", null, data);
		}

		///<summary>Triggers a scenario on Bosch SHC.</summary>
		///<param name="name">Name of the scenario to trigger eg: Scenario Name</param>
		public void TriggerScenario(object? @name = null)
		{
			_haContext.CallService("bosch_shc", "trigger_scenario", null, new BoschShcTriggerScenarioParameters{Name = @name});
		}
	}

	public record BoschShcSmokedetectorAlarmstateParameters
	{
		///<summary>Name of the smoke detector entity to set eg: binary_sensor.smokedetector_living_room</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>Command string to send to the smoke detector. eg: CUSTOM_COMMAND</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }
	}

	public record BoschShcSmokedetectorCheckParameters
	{
		///<summary>Name of the smoke detector entity to set eg: binary_sensor.smokedetector_living_room</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public record BoschShcTriggerScenarioParameters
	{
		///<summary>Name of the scenario to trigger eg: Scenario Name</summary>
		[JsonPropertyName("name")]
		public object? Name { get; init; }
	}

	public class BrowserModServices
	{
		private readonly IHaContext _haContext;
		public BrowserModServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close a popup</summary>
		///<param name="target">The target for this service call</param>
		public void ClosePopup(ServiceTarget target)
		{
			_haContext.CallService("browser_mod", "close_popup", target);
		}

		///<summary>Print text to browser console</summary>
		///<param name="target">The target for this service call</param>
		public void Console(ServiceTarget target, BrowserModConsoleParameters data)
		{
			_haContext.CallService("browser_mod", "console", target, data);
		}

		///<summary>Print text to browser console</summary>
		///<param name="target">The target for this service call</param>
		///<param name="message">Text to print</param>
		public void Console(ServiceTarget target, string? @message = null)
		{
			_haContext.CallService("browser_mod", "console", target, new BrowserModConsoleParameters{Message = @message});
		}

		///<summary>Wait for a time</summary>
		///<param name="target">The target for this service call</param>
		public void Delay(ServiceTarget target, BrowserModDelayParameters data)
		{
			_haContext.CallService("browser_mod", "delay", target, data);
		}

		///<summary>Wait for a time</summary>
		///<param name="target">The target for this service call</param>
		///<param name="time">Time to wait (ms)</param>
		public void Delay(ServiceTarget target, long? @time = null)
		{
			_haContext.CallService("browser_mod", "delay", target, new BrowserModDelayParameters{Time = @time});
		}

		///<summary>Run arbitrary JavaScript code</summary>
		///<param name="target">The target for this service call</param>
		public void Javascript(ServiceTarget target, BrowserModJavascriptParameters data)
		{
			_haContext.CallService("browser_mod", "javascript", target, data);
		}

		///<summary>Run arbitrary JavaScript code</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">JavaScript code to run</param>
		public void Javascript(ServiceTarget target, object? @code = null)
		{
			_haContext.CallService("browser_mod", "javascript", target, new BrowserModJavascriptParameters{Code = @code});
		}

		///<summary>Show more-info dialog</summary>
		///<param name="target">The target for this service call</param>
		public void MoreInfo(ServiceTarget target, BrowserModMoreInfoParameters data)
		{
			_haContext.CallService("browser_mod", "more_info", target, data);
		}

		///<summary>Show more-info dialog</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entity"></param>
		///<param name="large"></param>
		///<param name="ignorePopupCard"></param>
		public void MoreInfo(ServiceTarget target, string @entity, bool? @large = null, bool? @ignorePopupCard = null)
		{
			_haContext.CallService("browser_mod", "more_info", target, new BrowserModMoreInfoParameters{Entity = @entity, Large = @large, IgnorePopupCard = @ignorePopupCard});
		}

		///<summary>Navigate browser to a different page</summary>
		///<param name="target">The target for this service call</param>
		public void Navigate(ServiceTarget target, BrowserModNavigateParameters data)
		{
			_haContext.CallService("browser_mod", "navigate", target, data);
		}

		///<summary>Navigate browser to a different page</summary>
		///<param name="target">The target for this service call</param>
		///<param name="path">Target path</param>
		public void Navigate(ServiceTarget target, string? @path = null)
		{
			_haContext.CallService("browser_mod", "navigate", target, new BrowserModNavigateParameters{Path = @path});
		}

		///<summary>Display a short notification</summary>
		///<param name="target">The target for this service call</param>
		public void Notification(ServiceTarget target, BrowserModNotificationParameters data)
		{
			_haContext.CallService("browser_mod", "notification", target, data);
		}

		///<summary>Display a short notification</summary>
		///<param name="target">The target for this service call</param>
		///<param name="message">Message to display</param>
		///<param name="duration">Time before closing (ms)</param>
		///<param name="actionText">Text of optional action button</param>
		///<param name="action">Action to perform when the action button is pressed</param>
		public void Notification(ServiceTarget target, string @message, long? @duration = null, string? @actionText = null, object? @action = null)
		{
			_haContext.CallService("browser_mod", "notification", target, new BrowserModNotificationParameters{Message = @message, Duration = @duration, ActionText = @actionText, Action = @action});
		}

		///<summary>Display a popup</summary>
		///<param name="target">The target for this service call</param>
		public void Popup(ServiceTarget target, BrowserModPopupParameters data)
		{
			_haContext.CallService("browser_mod", "popup", target, data);
		}

		///<summary>Display a popup</summary>
		///<param name="target">The target for this service call</param>
		///<param name="title">Popup title</param>
		///<param name="content">Popup content (Test or lovelace card configuration)</param>
		///<param name="size"></param>
		///<param name="rightButton">Text of the right button</param>
		///<param name="rightButtonAction">Action to perform when the right button is pressed</param>
		///<param name="leftButton">Text of the left button</param>
		///<param name="leftButtonAction">Action to perform when left button is pressed</param>
		///<param name="dismissable">Whether the popup can be closed by the user without action</param>
		///<param name="dismissAction">Action to perform when popup is dismissed</param>
		///<param name="autoclose">Close the popup automatically on mouse, pointer or keyboard activity</param>
		///<param name="timeout">Time before closing (ms)</param>
		///<param name="timeoutAction">Action to perform when popup is closed by timeout</param>
		///<param name="style">CSS code to apply to the popup window</param>
		public void Popup(ServiceTarget target, object @content, string? @title = null, object? @size = null, string? @rightButton = null, object? @rightButtonAction = null, string? @leftButton = null, object? @leftButtonAction = null, bool? @dismissable = null, object? @dismissAction = null, bool? @autoclose = null, long? @timeout = null, object? @timeoutAction = null, string? @style = null)
		{
			_haContext.CallService("browser_mod", "popup", target, new BrowserModPopupParameters{Title = @title, Content = @content, Size = @size, RightButton = @rightButton, RightButtonAction = @rightButtonAction, LeftButton = @leftButton, LeftButtonAction = @leftButtonAction, Dismissable = @dismissable, DismissAction = @dismissAction, Autoclose = @autoclose, Timeout = @timeout, TimeoutAction = @timeoutAction, Style = @style});
		}

		///<summary>Refresh page</summary>
		///<param name="target">The target for this service call</param>
		public void Refresh(ServiceTarget target)
		{
			_haContext.CallService("browser_mod", "refresh", target);
		}

		///<summary>Run a sequence of services</summary>
		///<param name="target">The target for this service call</param>
		public void Sequence(ServiceTarget target, BrowserModSequenceParameters data)
		{
			_haContext.CallService("browser_mod", "sequence", target, data);
		}

		///<summary>Run a sequence of services</summary>
		///<param name="target">The target for this service call</param>
		///<param name="sequence">List of services to run</param>
		public void Sequence(ServiceTarget target, object? @sequence = null)
		{
			_haContext.CallService("browser_mod", "sequence", target, new BrowserModSequenceParameters{Sequence = @sequence});
		}

		///<summary>Change the current theme</summary>
		///<param name="target">The target for this service call</param>
		public void SetTheme(ServiceTarget target, BrowserModSetThemeParameters data)
		{
			_haContext.CallService("browser_mod", "set_theme", target, data);
		}

		///<summary>Change the current theme</summary>
		///<param name="target">The target for this service call</param>
		///<param name="theme">Name of theme or 'auto'</param>
		///<param name="dark">Dark/light mode</param>
		///<param name="primaryColor">Primary theme color</param>
		///<param name="accentColor">Accent theme color</param>
		public void SetTheme(ServiceTarget target, string? @theme = null, object? @dark = null, object? @primaryColor = null, object? @accentColor = null)
		{
			_haContext.CallService("browser_mod", "set_theme", target, new BrowserModSetThemeParameters{Theme = @theme, Dark = @dark, PrimaryColor = @primaryColor, AccentColor = @accentColor});
		}
	}

	public record BrowserModConsoleParameters
	{
		///<summary>Text to print</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }
	}

	public record BrowserModDelayParameters
	{
		///<summary>Time to wait (ms)</summary>
		[JsonPropertyName("time")]
		public long? Time { get; init; }
	}

	public record BrowserModJavascriptParameters
	{
		///<summary>JavaScript code to run</summary>
		[JsonPropertyName("code")]
		public object? Code { get; init; }
	}

	public record BrowserModMoreInfoParameters
	{
		[JsonPropertyName("entity")]
		public string? Entity { get; init; }

		[JsonPropertyName("large")]
		public bool? Large { get; init; }

		[JsonPropertyName("ignore_popup_card")]
		public bool? IgnorePopupCard { get; init; }
	}

	public record BrowserModNavigateParameters
	{
		///<summary>Target path</summary>
		[JsonPropertyName("path")]
		public string? Path { get; init; }
	}

	public record BrowserModNotificationParameters
	{
		///<summary>Message to display</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Time before closing (ms)</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Text of optional action button</summary>
		[JsonPropertyName("action_text")]
		public string? ActionText { get; init; }

		///<summary>Action to perform when the action button is pressed</summary>
		[JsonPropertyName("action")]
		public object? Action { get; init; }
	}

	public record BrowserModPopupParameters
	{
		///<summary>Popup title</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Popup content (Test or lovelace card configuration)</summary>
		[JsonPropertyName("content")]
		public object? Content { get; init; }

		[JsonPropertyName("size")]
		public object? Size { get; init; }

		///<summary>Text of the right button</summary>
		[JsonPropertyName("right_button")]
		public string? RightButton { get; init; }

		///<summary>Action to perform when the right button is pressed</summary>
		[JsonPropertyName("right_button_action")]
		public object? RightButtonAction { get; init; }

		///<summary>Text of the left button</summary>
		[JsonPropertyName("left_button")]
		public string? LeftButton { get; init; }

		///<summary>Action to perform when left button is pressed</summary>
		[JsonPropertyName("left_button_action")]
		public object? LeftButtonAction { get; init; }

		///<summary>Whether the popup can be closed by the user without action</summary>
		[JsonPropertyName("dismissable")]
		public bool? Dismissable { get; init; }

		///<summary>Action to perform when popup is dismissed</summary>
		[JsonPropertyName("dismiss_action")]
		public object? DismissAction { get; init; }

		///<summary>Close the popup automatically on mouse, pointer or keyboard activity</summary>
		[JsonPropertyName("autoclose")]
		public bool? Autoclose { get; init; }

		///<summary>Time before closing (ms)</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }

		///<summary>Action to perform when popup is closed by timeout</summary>
		[JsonPropertyName("timeout_action")]
		public object? TimeoutAction { get; init; }

		///<summary>CSS code to apply to the popup window</summary>
		[JsonPropertyName("style")]
		public string? Style { get; init; }
	}

	public record BrowserModSequenceParameters
	{
		///<summary>List of services to run</summary>
		[JsonPropertyName("sequence")]
		public object? Sequence { get; init; }
	}

	public record BrowserModSetThemeParameters
	{
		///<summary>Name of theme or 'auto'</summary>
		[JsonPropertyName("theme")]
		public string? Theme { get; init; }

		///<summary>Dark/light mode</summary>
		[JsonPropertyName("dark")]
		public object? Dark { get; init; }

		///<summary>Primary theme color</summary>
		[JsonPropertyName("primaryColor")]
		public object? PrimaryColor { get; init; }

		///<summary>Accent theme color</summary>
		[JsonPropertyName("accentColor")]
		public object? AccentColor { get; init; }
	}

	public class ButtonServices
	{
		private readonly IHaContext _haContext;
		public ButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("button", "press", target);
		}
	}

	public class CalendarServices
	{
		private readonly IHaContext _haContext;
		public CalendarServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Add a new calendar event.</summary>
		///<param name="target">The target for this service call</param>
		public void CreateEvent(ServiceTarget target, CalendarCreateEventParameters data)
		{
			_haContext.CallService("calendar", "create_event", target, data);
		}

		///<summary>Add a new calendar event.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="summary">Defines the short summary or subject for the event eg: Department Party</param>
		///<param name="description">A more complete description of the event than that provided by the summary. eg: Meeting to provide technical review for 'Phoenix' design.</param>
		///<param name="startDateTime">The date and time the event should start. eg: 2022-03-22 20:00:00</param>
		///<param name="endDateTime">The date and time the event should end. eg: 2022-03-22 22:00:00</param>
		///<param name="startDate">The date the all-day event should start. eg: 2022-03-22</param>
		///<param name="endDate">The date the all-day event should end (exclusive). eg: 2022-03-23</param>
		///<param name="in">Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</param>
		public void CreateEvent(ServiceTarget target, string @summary, string? @description = null, object? @startDateTime = null, object? @endDateTime = null, object? @startDate = null, object? @endDate = null, object? @in = null)
		{
			_haContext.CallService("calendar", "create_event", target, new CalendarCreateEventParameters{Summary = @summary, Description = @description, StartDateTime = @startDateTime, EndDateTime = @endDateTime, StartDate = @startDate, EndDate = @endDate, In = @in});
		}
	}

	public record CalendarCreateEventParameters
	{
		///<summary>Defines the short summary or subject for the event eg: Department Party</summary>
		[JsonPropertyName("summary")]
		public string? Summary { get; init; }

		///<summary>A more complete description of the event than that provided by the summary. eg: Meeting to provide technical review for 'Phoenix' design.</summary>
		[JsonPropertyName("description")]
		public string? Description { get; init; }

		///<summary>The date and time the event should start. eg: 2022-03-22 20:00:00</summary>
		[JsonPropertyName("start_date_time")]
		public object? StartDateTime { get; init; }

		///<summary>The date and time the event should end. eg: 2022-03-22 22:00:00</summary>
		[JsonPropertyName("end_date_time")]
		public object? EndDateTime { get; init; }

		///<summary>The date the all-day event should start. eg: 2022-03-22</summary>
		[JsonPropertyName("start_date")]
		public object? StartDate { get; init; }

		///<summary>The date the all-day event should end (exclusive). eg: 2022-03-23</summary>
		[JsonPropertyName("end_date")]
		public object? EndDate { get; init; }

		///<summary>Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</summary>
		[JsonPropertyName("in")]
		public object? In { get; init; }
	}

	public class CameraServices
	{
		private readonly IHaContext _haContext;
		public CameraServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Disable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void DisableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		///<summary>Enable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void EnableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayStream(ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public void PlayStream(ServiceTarget target, string @mediaPlayer, object? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		public void Record(ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public void Record(ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Snapshot(ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public void Snapshot(ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		///<summary>Turn on camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		///<summary>Name(s) of media player to stream to.</summary>
		[JsonPropertyName("media_player")]
		public string? MediaPlayer { get; init; }

		///<summary>Stream format supported by media player.</summary>
		[JsonPropertyName("format")]
		public object? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }

		///<summary>Target recording length.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
		[JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }
	}

	public class CastServices
	{
		private readonly IHaContext _haContext;
		public CastServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		public void ShowLovelaceView(CastShowLovelaceViewParameters data)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, data);
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		///<param name="entityId">Media Player entity to show the Lovelace view on.</param>
		///<param name="dashboardPath">The URL path of the Lovelace dashboard to show. eg: lovelace-cast</param>
		///<param name="viewPath">The path of the Lovelace view to show. eg: downstairs</param>
		public void ShowLovelaceView(string @entityId, string @dashboardPath, string? @viewPath = null)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, new CastShowLovelaceViewParameters{EntityId = @entityId, DashboardPath = @dashboardPath, ViewPath = @viewPath});
		}
	}

	public record CastShowLovelaceViewParameters
	{
		///<summary>Media Player entity to show the Lovelace view on.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The URL path of the Lovelace dashboard to show. eg: lovelace-cast</summary>
		[JsonPropertyName("dashboard_path")]
		public string? DashboardPath { get; init; }

		///<summary>The path of the Lovelace view to show. eg: downstairs</summary>
		[JsonPropertyName("view_path")]
		public string? ViewPath { get; init; }
	}

	public class ClimateServices
	{
		private readonly IHaContext _haContext;
		public ClimateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAuxHeat(ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public void SetAuxHeat(ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHvacMode(ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public void SetHvacMode(ServiceTarget target, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSwingMode(ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public void SetSwingMode(ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public void SetTemperature(ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		///<summary>Turn climate device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		///<summary>New value of auxiliary heater.</summary>
		[JsonPropertyName("aux_heat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		///<summary>New target humidity for climate device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		///<summary>New value of operation mode.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: away</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		///<summary>New value of swing mode. eg: horizontal</summary>
		[JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		///<summary>New target temperature for HVAC.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New target high temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_high")]
		public double? TargetTempHigh { get; init; }

		///<summary>New target low temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_low")]
		public double? TargetTempLow { get; init; }

		///<summary>HVAC operation mode to set temperature to.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public class CloudServices
	{
		private readonly IHaContext _haContext;
		public CloudServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Make instance UI available outside over NabuCasa cloud</summary>
		public void RemoteConnect()
		{
			_haContext.CallService("cloud", "remote_connect", null);
		}

		///<summary>Disconnect UI from NabuCasa cloud</summary>
		public void RemoteDisconnect()
		{
			_haContext.CallService("cloud", "remote_disconnect", null);
		}
	}

	public class CloudflareServices
	{
		private readonly IHaContext _haContext;
		public CloudflareServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Manually trigger update to Cloudflare records</summary>
		public void UpdateRecords()
		{
			_haContext.CallService("cloudflare", "update_records", null);
		}
	}

	public class ConversationServices
	{
		private readonly IHaContext _haContext;
		public ConversationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Launch a conversation from a transcribed text.</summary>
		public void Process(ConversationProcessParameters data)
		{
			_haContext.CallService("conversation", "process", null, data);
		}

		///<summary>Launch a conversation from a transcribed text.</summary>
		///<param name="text">Transcribed text eg: Turn all lights on</param>
		public void Process(string? @text = null)
		{
			_haContext.CallService("conversation", "process", null, new ConversationProcessParameters{Text = @text});
		}

		public void Reload()
		{
			_haContext.CallService("conversation", "reload", null);
		}
	}

	public record ConversationProcessParameters
	{
		///<summary>Transcribed text eg: Turn all lights on</summary>
		[JsonPropertyName("text")]
		public string? Text { get; init; }
	}

	public class CounterServices
	{
		private readonly IHaContext _haContext;
		public CounterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		public void Configure(ServiceTarget target, CounterConfigureParameters data)
		{
			_haContext.CallService("counter", "configure", target, data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public void Configure(ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		///<summary>Increment a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		///<summary>Reset a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		///<summary>New minimum value for the counter or None to remove minimum.</summary>
		[JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		///<summary>New maximum value for the counter or None to remove maximum.</summary>
		[JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		///<summary>New value for step.</summary>
		[JsonPropertyName("step")]
		public long? Step { get; init; }

		///<summary>New value for initial.</summary>
		[JsonPropertyName("initial")]
		public long? Initial { get; init; }

		///<summary>New state value.</summary>
		[JsonPropertyName("value")]
		public long? Value { get; init; }
	}

	public class CoverServices
	{
		private readonly IHaContext _haContext;
		public CoverServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		///<summary>Close all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		///<summary>Open all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		///<summary>Open all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverPosition(ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="position">Position of the cover</param>
		public void SetCoverPosition(ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverTiltPosition(ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public void SetCoverTiltPosition(ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		///<summary>Toggle a cover open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void ToggleCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		///<summary>Position of the cover</summary>
		[JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		///<summary>Tilt position of the cover.</summary>
		[JsonPropertyName("tilt_position")]
		public long? TiltPosition { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Icloud3FindIphoneAlert()
		{
			_haContext.CallService("device_tracker", "icloud3_find_iphone_alert", null);
		}

		public void Icloud3Restart()
		{
			_haContext.CallService("device_tracker", "icloud3_restart", null);
		}

		public void Icloud3SetInterval()
		{
			_haContext.CallService("device_tracker", "icloud3_set_interval", null);
		}

		public void Icloud3Update()
		{
			_haContext.CallService("device_tracker", "icloud3_update", null);
		}

		///<summary>Control tracked device.</summary>
		public void See(DeviceTrackerSeeParameters data)
		{
			_haContext.CallService("device_tracker", "see", null, data);
		}

		///<summary>Control tracked device.</summary>
		///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
		///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
		///<param name="hostName">Hostname of device eg: Dave</param>
		///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
		///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
		///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
		///<param name="battery">Battery level of device.</param>
		public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
		{
			_haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters{Mac = @mac, DevId = @devId, HostName = @hostName, LocationName = @locationName, Gps = @gps, GpsAccuracy = @gpsAccuracy, Battery = @battery});
		}
	}

	public record DeviceTrackerSeeParameters
	{
		///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
		[JsonPropertyName("dev_id")]
		public string? DevId { get; init; }

		///<summary>Hostname of device eg: Dave</summary>
		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		///<summary>Name of location where device is located (not_home is away). eg: home</summary>
		[JsonPropertyName("location_name")]
		public string? LocationName { get; init; }

		///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
		[JsonPropertyName("gps")]
		public object? Gps { get; init; }

		///<summary>Accuracy of GPS coordinates.</summary>
		[JsonPropertyName("gps_accuracy")]
		public long? GpsAccuracy { get; init; }

		///<summary>Battery level of device.</summary>
		[JsonPropertyName("battery")]
		public long? Battery { get; init; }
	}

	public class FanServices
	{
		private readonly IHaContext _haContext;
		public FanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void DecreaseSpeed(ServiceTarget target, FanDecreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "decrease_speed", target, data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public void DecreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "decrease_speed", target, new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void IncreaseSpeed(ServiceTarget target, FanIncreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "increase_speed", target, data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public void IncreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "increase_speed", target, new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		public void Oscillate(ServiceTarget target, FanOscillateParameters data)
		{
			_haContext.CallService("fan", "oscillate", target, data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public void Oscillate(ServiceTarget target, bool @oscillating)
		{
			_haContext.CallService("fan", "oscillate", target, new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDirection(ServiceTarget target, FanSetDirectionParameters data)
		{
			_haContext.CallService("fan", "set_direction", target, data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="direction">The direction to rotate.</param>
		public void SetDirection(ServiceTarget target, object @direction)
		{
			_haContext.CallService("fan", "set_direction", target, new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPercentage(ServiceTarget target, FanSetPercentageParameters data)
		{
			_haContext.CallService("fan", "set_percentage", target, data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentage">Percentage speed setting.</param>
		public void SetPercentage(ServiceTarget target, long @percentage)
		{
			_haContext.CallService("fan", "set_percentage", target, new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, FanSetPresetModeParameters data)
		{
			_haContext.CallService("fan", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("fan", "set_preset_mode", target, new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Toggle the fan on/off.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("fan", "toggle", target);
		}

		///<summary>Turn fan off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("fan", "turn_off", target);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, FanTurnOnParameters data)
		{
			_haContext.CallService("fan", "turn_on", target, data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public void TurnOn(ServiceTarget target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			_haContext.CallService("fan", "turn_on", target, new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public record FanDecreaseSpeedParameters
	{
		///<summary>Decrease speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanIncreaseSpeedParameters
	{
		///<summary>Increase speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanOscillateParameters
	{
		///<summary>Flag to turn on/off oscillation.</summary>
		[JsonPropertyName("oscillating")]
		public bool? Oscillating { get; init; }
	}

	public record FanSetDirectionParameters
	{
		///<summary>The direction to rotate.</summary>
		[JsonPropertyName("direction")]
		public object? Direction { get; init; }
	}

	public record FanSetPercentageParameters
	{
		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }
	}

	public record FanSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record FanTurnOnParameters
	{
		///<summary>Speed setting. eg: high</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }

		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }

		///<summary>Preset mode setting. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public class FfmpegServices
	{
		private readonly IHaContext _haContext;
		public FfmpegServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		public void Restart(FfmpegRestartParameters data)
		{
			_haContext.CallService("ffmpeg", "restart", null, data);
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will restart. Platform dependent.</param>
		public void Restart(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "restart", null, new FfmpegRestartParameters{EntityId = @entityId});
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		public void Start(FfmpegStartParameters data)
		{
			_haContext.CallService("ffmpeg", "start", null, data);
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will start. Platform dependent.</param>
		public void Start(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "start", null, new FfmpegStartParameters{EntityId = @entityId});
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		public void Stop(FfmpegStopParameters data)
		{
			_haContext.CallService("ffmpeg", "stop", null, data);
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will stop. Platform dependent.</param>
		public void Stop(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "stop", null, new FfmpegStopParameters{EntityId = @entityId});
		}
	}

	public record FfmpegRestartParameters
	{
		///<summary>Name of entity that will restart. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStartParameters
	{
		///<summary>Name of entity that will start. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStopParameters
	{
		///<summary>Name of entity that will stop. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public class FrontendServices
	{
		private readonly IHaContext _haContext;
		public FrontendServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload themes from YAML configuration.</summary>
		public void ReloadThemes()
		{
			_haContext.CallService("frontend", "reload_themes", null);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		public void SetTheme(FrontendSetThemeParameters data)
		{
			_haContext.CallService("frontend", "set_theme", null, data);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		///<param name="name">Name of a predefined theme eg: default</param>
		///<param name="mode">The mode the theme is for.</param>
		public void SetTheme(object @name, object? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters{Name = @name, Mode = @mode});
		}
	}

	public record FrontendSetThemeParameters
	{
		///<summary>Name of a predefined theme eg: default</summary>
		[JsonPropertyName("name")]
		public object? Name { get; init; }

		///<summary>The mode the theme is for.</summary>
		[JsonPropertyName("mode")]
		public object? Mode { get; init; }
	}

	public class GroupServices
	{
		private readonly IHaContext _haContext;
		public GroupServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload group configuration, entities, and notify services.</summary>
		public void Reload()
		{
			_haContext.CallService("group", "reload", null);
		}

		///<summary>Remove a user group.</summary>
		public void Remove(GroupRemoveParameters data)
		{
			_haContext.CallService("group", "remove", null, data);
		}

		///<summary>Remove a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		public void Remove(object @objectId)
		{
			_haContext.CallService("group", "remove", null, new GroupRemoveParameters{ObjectId = @objectId});
		}

		///<summary>Create/Update a user group.</summary>
		public void Set(GroupSetParameters data)
		{
			_haContext.CallService("group", "set", null, data);
		}

		///<summary>Create/Update a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		///<param name="name">Name of group eg: My test group</param>
		///<param name="icon">Name of icon for the group. eg: mdi:camera</param>
		///<param name="entities">List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="removeEntities">List of members that will be removed from group listening. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
		public void Set(string @objectId, string? @name = null, object? @icon = null, object? @entities = null, object? @addEntities = null, object? @removeEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, RemoveEntities = @removeEntities, All = @all});
		}
	}

	public record GroupRemoveParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public string? ObjectId { get; init; }

		///<summary>Name of group eg: My test group</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Name of icon for the group. eg: mdi:camera</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("add_entities")]
		public object? AddEntities { get; init; }

		///<summary>List of members that will be removed from group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("remove_entities")]
		public object? RemoveEntities { get; init; }

		///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
		[JsonPropertyName("all")]
		public bool? All { get; init; }
	}

	public class HomeassistantServices
	{
		private readonly IHaContext _haContext;
		public HomeassistantServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		public void ReloadConfigEntry(ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
		public void ReloadConfigEntry(ServiceTarget target, string? @entryId = null)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, new HomeassistantReloadConfigEntryParameters{EntryId = @entryId});
		}

		///<summary>Reload the core configuration.</summary>
		public void ReloadCoreConfig()
		{
			_haContext.CallService("homeassistant", "reload_core_config", null);
		}

		///<summary>Restart the Home Assistant service.</summary>
		public void Restart()
		{
			_haContext.CallService("homeassistant", "restart", null);
		}

		///<summary>Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic saving interval.</summary>
		public void SavePersistentStates()
		{
			_haContext.CallService("homeassistant", "save_persistent_states", null);
		}

		///<summary>Update the Home Assistant location.</summary>
		public void SetLocation(HomeassistantSetLocationParameters data)
		{
			_haContext.CallService("homeassistant", "set_location", null, data);
		}

		///<summary>Update the Home Assistant location.</summary>
		///<param name="latitude">Latitude of your location. eg: 32,87336</param>
		///<param name="longitude">Longitude of your location. eg: 117,22743</param>
		public void SetLocation(string @latitude, string @longitude)
		{
			_haContext.CallService("homeassistant", "set_location", null, new HomeassistantSetLocationParameters{Latitude = @latitude, Longitude = @longitude});
		}

		///<summary>Stop the Home Assistant service.</summary>
		public void Stop()
		{
			_haContext.CallService("homeassistant", "stop", null);
		}

		///<summary>Generic service to toggle devices on/off under any domain</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		///<summary>Generic service to turn devices off under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		///<summary>Generic service to turn devices on under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		///<summary>Force one or more entities to update its data</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateEntity(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
		[JsonPropertyName("entry_id")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		///<summary>Latitude of your location. eg: 32,87336</summary>
		[JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		///<summary>Longitude of your location. eg: 117,22743</summary>
		[JsonPropertyName("longitude")]
		public string? Longitude { get; init; }
	}

	public class HumidifierServices
	{
		private readonly IHaContext _haContext;
		public HumidifierServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, HumidifierSetHumidityParameters data)
		{
			_haContext.CallService("humidifier", "set_humidity", target, data);
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for humidifier device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("humidifier", "set_humidity", target, new HumidifierSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetMode(ServiceTarget target, HumidifierSetModeParameters data)
		{
			_haContext.CallService("humidifier", "set_mode", target, data);
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mode">New mode eg: away</param>
		public void SetMode(ServiceTarget target, string @mode)
		{
			_haContext.CallService("humidifier", "set_mode", target, new HumidifierSetModeParameters{Mode = @mode});
		}

		///<summary>Toggles a humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "toggle", target);
		}

		///<summary>Turn humidifier device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_off", target);
		}

		///<summary>Turn humidifier device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_on", target);
		}
	}

	public record HumidifierSetHumidityParameters
	{
		///<summary>New target humidity for humidifier device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record HumidifierSetModeParameters
	{
		///<summary>New mode eg: away</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly IHaContext _haContext;
		public InputBooleanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_boolean configuration</summary>
		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		///<summary>Toggle an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		///<summary>Turn off an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		///<summary>Turn on an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputButtonServices
	{
		private readonly IHaContext _haContext;
		public InputButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the input button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("input_button", "press", target);
		}

		public void Reload()
		{
			_haContext.CallService("input_button", "reload", null);
		}
	}

	public class InputDatetimeServices
	{
		private readonly IHaContext _haContext;
		public InputDatetimeServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_datetime configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDatetime(ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public void SetDatetime(ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
		[JsonPropertyName("date")]
		public string? Date { get; init; }

		///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
		[JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly IHaContext _haContext;
		public InputNumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("input_number", "increment", target);
		}

		///<summary>Reload the input_number configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_number", "reload", null);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to.</param>
		public void SetValue(ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters{Value = @value});
		}
	}

	public record InputNumberSetValueParameters
	{
		///<summary>The target value the entity should be set to.</summary>
		[JsonPropertyName("value")]
		public double? Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly IHaContext _haContext;
		public InputSelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_select configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		///<summary>Select the first option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectFirst(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		///<summary>Select the last option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectLast(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectNext(ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public void SelectNext(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectPrevious(ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public void SelectPrevious(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOptions(ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public void SetOptions(ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public record InputSelectSelectNextParameters
	{
		///<summary>If the option should cycle from the last to the first.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		///<summary>If the option should cycle from the first to the last.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly IHaContext _haContext;
		public InputTextServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_text configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public void SetValue(ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters{Value = @value});
		}
	}

	public record InputTextSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: This is an example text</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class LightServices
	{
		private readonly IHaContext _haContext;
		public LightServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target, LightToggleParameters data)
		{
			_haContext.CallService("light", "toggle", target, data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void Toggle(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public void TurnOff(ServiceTarget target, long? @transition = null, object? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public record LightToggleParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>The color for the light (based on RGB - red, green, blue).</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
		[JsonPropertyName("rgbw_color")]
		public object? RgbwColor { get; init; }

		///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
		[JsonPropertyName("rgbww_color")]
		public object? RgbwwColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Change brightness by an amount.</summary>
		[JsonPropertyName("brightness_step")]
		public long? BrightnessStep { get; init; }

		///<summary>Change brightness by a percentage.</summary>
		[JsonPropertyName("brightness_step_pct")]
		public long? BrightnessStepPct { get; init; }

		///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("white")]
		public long? White { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public class LockServices
	{
		private readonly IHaContext _haContext;
		public LockServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Lock(ServiceTarget target, LockLockParameters data)
		{
			_haContext.CallService("lock", "lock", target, data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public void Lock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "lock", target, new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Open(ServiceTarget target, LockOpenParameters data)
		{
			_haContext.CallService("lock", "open", target, data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public void Open(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "open", target, new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Unlock(ServiceTarget target, LockUnlockParameters data)
		{
			_haContext.CallService("lock", "unlock", target, data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public void Unlock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "unlock", target, new LockUnlockParameters{Code = @code});
		}
	}

	public record LockLockParameters
	{
		///<summary>An optional code to lock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockOpenParameters
	{
		///<summary>An optional code to open the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockUnlockParameters
	{
		///<summary>An optional code to unlock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class LogbookServices
	{
		private readonly IHaContext _haContext;
		public LogbookServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a custom entry in your logbook.</summary>
		public void Log(LogbookLogParameters data)
		{
			_haContext.CallService("logbook", "log", null, data);
		}

		///<summary>Create a custom entry in your logbook.</summary>
		///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
		///<param name="message">Message of the custom logbook entry. eg: is being used</param>
		///<param name="entityId">Entity to reference in custom logbook entry.</param>
		///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
		public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
		{
			_haContext.CallService("logbook", "log", null, new LogbookLogParameters{Name = @name, Message = @message, EntityId = @entityId, Domain = @domain});
		}
	}

	public record LogbookLogParameters
	{
		///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Message of the custom logbook entry. eg: is being used</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Entity to reference in custom logbook entry.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
		[JsonPropertyName("domain")]
		public string? Domain { get; init; }
	}

	public class LoggerServices
	{
		private readonly IHaContext _haContext;
		public LoggerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the default log level for integrations.</summary>
		public void SetDefaultLevel(LoggerSetDefaultLevelParameters data)
		{
			_haContext.CallService("logger", "set_default_level", null, data);
		}

		///<summary>Set the default log level for integrations.</summary>
		///<param name="level">Default severity level for all integrations.</param>
		public void SetDefaultLevel(object? @level = null)
		{
			_haContext.CallService("logger", "set_default_level", null, new LoggerSetDefaultLevelParameters{Level = @level});
		}

		///<summary>Set log level for integrations.</summary>
		public void SetLevel()
		{
			_haContext.CallService("logger", "set_level", null);
		}
	}

	public record LoggerSetDefaultLevelParameters
	{
		///<summary>Default severity level for all integrations.</summary>
		[JsonPropertyName("level")]
		public object? Level { get; init; }
	}

	public class LovelaceServices
	{
		private readonly IHaContext _haContext;
		public LovelaceServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload Lovelace resources from YAML configuration</summary>
		public void ReloadResources()
		{
			_haContext.CallService("lovelace", "reload_resources", null);
		}
	}

	public class MediaPlayerServices
	{
		private readonly IHaContext _haContext;
		public MediaPlayerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearPlaylist(ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Join(ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: - media_player.multiroom_player2 - media_player.multiroom_player3 </param>
		public void Join(ServiceTarget target, string @groupMembers)
		{
			_haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaNextTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		///<summary>Send the media player the command for pause.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		///<summary>Send the media player the command for play.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlay(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		///<summary>Toggle media player play/pause state.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlayPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		///<summary>Send the media player the command for previous track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPreviousTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaSeek(ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public void MediaSeek(ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaStop(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public void PlayMedia(ServiceTarget target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		public void RepeatSet(ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="repeat">Repeat mode to set.</param>
		public void RepeatSet(ServiceTarget target, object @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSoundMode(ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public void SelectSoundMode(ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSource(ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public void SelectSource(ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		public void ShuffleSet(ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public void ShuffleSet(ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		///<summary>Turn a media player power off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		///<summary>Turn a media player power on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		///<summary>Turn a media player volume down.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeDown(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeMute(ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public void VolumeMute(ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeSet(ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public void VolumeSet(ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeUp(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		///<summary>The players which will be synced with the target player. eg: - media_player.multiroom_player2 - media_player.multiroom_player3 </summary>
		[JsonPropertyName("group_members")]
		public string? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		///<summary>Position to seek to. The format is platform dependent.</summary>
		[JsonPropertyName("seek_position")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		///<summary>If the content should be played now or be added to the queue.</summary>
		[JsonPropertyName("enqueue")]
		public object? Enqueue { get; init; }

		///<summary>If the media should be played as an announcement. eg: true</summary>
		[JsonPropertyName("announce")]
		public bool? Announce { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		///<summary>Repeat mode to set.</summary>
		[JsonPropertyName("repeat")]
		public object? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		///<summary>Name of the sound mode to switch to. eg: Music</summary>
		[JsonPropertyName("sound_mode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
		[JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		///<summary>True/false for enabling/disabling shuffle.</summary>
		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		///<summary>True/false for mute/unmute.</summary>
		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		///<summary>Volume level to set as float.</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public class MqttServices
	{
		private readonly IHaContext _haContext;
		public MqttServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		public void Dump(MqttDumpParameters data)
		{
			_haContext.CallService("mqtt", "dump", null, data);
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		///<param name="topic">topic to listen to eg: OpenZWave/#</param>
		///<param name="duration">how long we should listen for messages in seconds</param>
		public void Dump(string? @topic = null, long? @duration = null)
		{
			_haContext.CallService("mqtt", "dump", null, new MqttDumpParameters{Topic = @topic, Duration = @duration});
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		public void Publish(MqttPublishParameters data)
		{
			_haContext.CallService("mqtt", "publish", null, data);
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		///<param name="topic">Topic to publish payload. eg: /homeassistant/hello</param>
		///<param name="payload">Payload to publish. eg: This is great</param>
		///<param name="payloadTemplate">Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</param>
		///<param name="qos">Quality of Service to use.</param>
		///<param name="retain">If message should have the retain flag set.</param>
		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, object? @qos = null, bool? @retain = null)
		{
			_haContext.CallService("mqtt", "publish", null, new MqttPublishParameters{Topic = @topic, Payload = @payload, PayloadTemplate = @payloadTemplate, Qos = @qos, Retain = @retain});
		}

		///<summary>Reload all MQTT entities from YAML.</summary>
		public void Reload()
		{
			_haContext.CallService("mqtt", "reload", null);
		}
	}

	public record MqttDumpParameters
	{
		///<summary>topic to listen to eg: OpenZWave/#</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>how long we should listen for messages in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>Payload to publish. eg: This is great</summary>
		[JsonPropertyName("payload")]
		public string? Payload { get; init; }

		///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
		[JsonPropertyName("payload_template")]
		public object? PayloadTemplate { get; init; }

		///<summary>Quality of Service to use.</summary>
		[JsonPropertyName("qos")]
		public object? Qos { get; init; }

		///<summary>If message should have the retain flag set.</summary>
		[JsonPropertyName("retain")]
		public bool? Retain { get; init; }
	}

	public class NetdaemonServices
	{
		private readonly IHaContext _haContext;
		public NetdaemonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create an entity</summary>
		public void EntityCreate(NetdaemonEntityCreateParameters data)
		{
			_haContext.CallService("netdaemon", "entity_create", null, data);
		}

		///<summary>Create an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		///<param name="state">The state of the entity eg: Lorem ipsum</param>
		///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
		///<param name="unit">The unit of measurement for the entity</param>
		///<param name="options">List of options for a select entity</param>
		///<param name="attributes">The attributes of the entity</param>
		public void EntityCreate(object? @entityId = null, object? @state = null, object? @icon = null, object? @unit = null, object? @options = null, object? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_create", null, new NetdaemonEntityCreateParameters{EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Options = @options, Attributes = @attributes});
		}

		///<summary>Remove an entity</summary>
		public void EntityRemove(NetdaemonEntityRemoveParameters data)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, data);
		}

		///<summary>Remove an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		public void EntityRemove(object? @entityId = null)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, new NetdaemonEntityRemoveParameters{EntityId = @entityId});
		}

		///<summary>Update an entity</summary>
		public void EntityUpdate(NetdaemonEntityUpdateParameters data)
		{
			_haContext.CallService("netdaemon", "entity_update", null, data);
		}

		///<summary>Update an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		///<param name="state">The state of the entity eg: Lorem ipsum</param>
		///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
		///<param name="unit">The unit of measurement for the entity</param>
		///<param name="options">List of options for a select entity</param>
		///<param name="attributes">The attributes of the entity</param>
		public void EntityUpdate(object? @entityId = null, object? @state = null, object? @icon = null, object? @unit = null, object? @options = null, object? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_update", null, new NetdaemonEntityUpdateParameters{EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Options = @options, Attributes = @attributes});
		}

		public void MoonlightResetBluetooth()
		{
			_haContext.CallService("netdaemon", "moonlight_reset_bluetooth", null);
		}

		public void MoonlightStart()
		{
			_haContext.CallService("netdaemon", "moonlight_start", null);
		}

		public void MoonlightStop()
		{
			_haContext.CallService("netdaemon", "moonlight_stop", null);
		}

		///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
		public void RegisterService(NetdaemonRegisterServiceParameters data)
		{
			_haContext.CallService("netdaemon", "register_service", null, data);
		}

		///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
		///<param name="service">The name of the service to register</param>
		///<param name="class">The class that implements the service call</param>
		///<param name="method">The method to call</param>
		public void RegisterService(object? @service = null, object? @class = null, object? @method = null)
		{
			_haContext.CallService("netdaemon", "register_service", null, new NetdaemonRegisterServiceParameters{Service = @service, Class = @class, Method = @method});
		}

		public void ReloadApps()
		{
			_haContext.CallService("netdaemon", "reload_apps", null);
		}

		public void TrainingStart()
		{
			_haContext.CallService("netdaemon", "training_start", null);
		}
	}

	public record NetdaemonEntityCreateParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The state of the entity eg: Lorem ipsum</summary>
		[JsonPropertyName("state")]
		public object? State { get; init; }

		///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>The unit of measurement for the entity</summary>
		[JsonPropertyName("unit")]
		public object? Unit { get; init; }

		///<summary>List of options for a select entity</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>The attributes of the entity</summary>
		[JsonPropertyName("attributes")]
		public object? Attributes { get; init; }
	}

	public record NetdaemonEntityRemoveParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public record NetdaemonEntityUpdateParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The state of the entity eg: Lorem ipsum</summary>
		[JsonPropertyName("state")]
		public object? State { get; init; }

		///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>The unit of measurement for the entity</summary>
		[JsonPropertyName("unit")]
		public object? Unit { get; init; }

		///<summary>List of options for a select entity</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>The attributes of the entity</summary>
		[JsonPropertyName("attributes")]
		public object? Attributes { get; init; }
	}

	public record NetdaemonRegisterServiceParameters
	{
		///<summary>The name of the service to register</summary>
		[JsonPropertyName("service")]
		public object? Service { get; init; }

		///<summary>The class that implements the service call</summary>
		[JsonPropertyName("class")]
		public object? Class { get; init; }

		///<summary>The method to call</summary>
		[JsonPropertyName("method")]
		public object? Method { get; init; }
	}

	public class NotifyServices
	{
		private readonly IHaContext _haContext;
		public NotifyServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends a notification message using the mobile_app_fantenpad integration.</summary>
		public void MobileAppFantenpad(NotifyMobileAppFantenpadParameters data)
		{
			_haContext.CallService("notify", "mobile_app_fantenpad", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_fantenpad integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppFantenpad(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_fantenpad", null, new NotifyMobileAppFantenpadParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_fantenphone integration.</summary>
		public void MobileAppFantenphone(NotifyMobileAppFantenphoneParameters data)
		{
			_haContext.CallService("notify", "mobile_app_fantenphone", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_fantenphone integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppFantenphone(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_fantenphone", null, new NotifyMobileAppFantenphoneParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_fantenphone2 integration.</summary>
		public void MobileAppFantenphone2(NotifyMobileAppFantenphone2Parameters data)
		{
			_haContext.CallService("notify", "mobile_app_fantenphone2", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_fantenphone2 integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppFantenphone2(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_fantenphone2", null, new NotifyMobileAppFantenphone2Parameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_iphone_philipp integration.</summary>
		public void MobileAppIphonePhilipp(NotifyMobileAppIphonePhilippParameters data)
		{
			_haContext.CallService("notify", "mobile_app_iphone_philipp", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_iphone_philipp integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppIphonePhilipp(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_iphone_philipp", null, new NotifyMobileAppIphonePhilippParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the notify service.</summary>
		public void Notify(NotifyNotifyParameters data)
		{
			_haContext.CallService("notify", "notify", null, data);
		}

		///<summary>Sends a notification message using the notify service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "notify", null, new NotifyNotifyParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the o365_email_philipp integration.</summary>
		public void O365EmailPhilipp(NotifyO365EmailPhilippParameters data)
		{
			_haContext.CallService("notify", "o365_email_philipp", null, data);
		}

		///<summary>Sends a notification message using the o365_email_philipp integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void O365EmailPhilipp(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "o365_email_philipp", null, new NotifyO365EmailPhilippParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters{Message = @message, Title = @title});
		}
	}

	public record NotifyMobileAppFantenpadParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppFantenphoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppFantenphone2Parameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppIphonePhilippParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyO365EmailPhilippParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public class NukiNgServices
	{
		private readonly IHaContext _haContext;
		public NukiNgServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>The callbacks currently set are exposed as attributes of the 'Bridge Callback Set' entity</summary>
		///<param name="target">The target for this service call</param>
		public void BridgeDeleteCallback(ServiceTarget target, NukiNgBridgeDeleteCallbackParameters data)
		{
			_haContext.CallService("nuki_ng", "bridge_delete_callback", target, data);
		}

		///<summary>The callbacks currently set are exposed as attributes of the 'Bridge Callback Set' entity</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">URL to delete eg: http://192.168.0.0/callback</param>
		public void BridgeDeleteCallback(ServiceTarget target, string @command)
		{
			_haContext.CallService("nuki_ng", "bridge_delete_callback", target, new NukiNgBridgeDeleteCallbackParameters{Command = @command});
		}

		///<param name="target">The target for this service call</param>
		public void BridgeFwupdate(ServiceTarget target)
		{
			_haContext.CallService("nuki_ng", "bridge_fwupdate", target);
		}

		///<param name="target">The target for this service call</param>
		public void BridgeReboot(ServiceTarget target)
		{
			_haContext.CallService("nuki_ng", "bridge_reboot", target);
		}

		///<param name="target">The target for this service call</param>
		public void ExecuteAction(ServiceTarget target, NukiNgExecuteActionParameters data)
		{
			_haContext.CallService("nuki_ng", "execute_action", target, data);
		}

		///<param name="target">The target for this service call</param>
		///<param name="action">Lock action to execute eg: unlock</param>
		public void ExecuteAction(ServiceTarget target, object @action)
		{
			_haContext.CallService("nuki_ng", "execute_action", target, new NukiNgExecuteActionParameters{Action = @action});
		}
	}

	public record NukiNgBridgeDeleteCallbackParameters
	{
		///<summary>URL to delete eg: http://192.168.0.0/callback</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }
	}

	public record NukiNgExecuteActionParameters
	{
		///<summary>Lock action to execute eg: unlock</summary>
		[JsonPropertyName("action")]
		public object? Action { get; init; }
	}

	public class NumberServices
	{
		private readonly IHaContext _haContext;
		public NumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, NumberSetValueParameters data)
		{
			_haContext.CallService("number", "set_value", target, data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public void SetValue(ServiceTarget target, string? @value = null)
		{
			_haContext.CallService("number", "set_value", target, new NumberSetValueParameters{Value = @value});
		}
	}

	public record NumberSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: 42</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class O365Services
	{
		private readonly IHaContext _haContext;
		public O365Services(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create new calendar event</summary>
		///<param name="target">The target for this service call</param>
		public void CreateCalendarEvent(ServiceTarget target, O365CreateCalendarEventParameters data)
		{
			_haContext.CallService("o365", "create_calendar_event", target, data);
		}

		///<summary>Create new calendar event</summary>
		///<param name="target">The target for this service call</param>
		///<param name="subject">The subject of the created event eg: Clean up the garage</param>
		///<param name="start">The start time of the event eg: 2023-01-01T12:00:00+0000</param>
		///<param name="end">The end time of the event eg: 2023-01-01T12:30:00+0000</param>
		///<param name="body">The body text for the event (optional) eg: Remember to also clean out the gutters</param>
		///<param name="location">The location for the event (optional) eg: 1600 Pennsylvania Ave Nw, Washington, DC 20500</param>
		///<param name="categories">list of categories for the event (optional)</param>
		///<param name="sensitivity">The sensitivity for the event (optional) [Normal, Personal, Private, Confidential] eg: normal</param>
		///<param name="showAs">Show event as (optional) [Free, Tentative, Busy, Oof, WorkingElsewhere, Unknown] eg: busy</param>
		///<param name="isAllDay">Set whether event is all day (optional) eg: False</param>
		///<param name="attendees">list of attendees formatted as email: example@example.com type: Required, Optional, or Resource (optional)</param>
		public void CreateCalendarEvent(ServiceTarget target, string @subject, string @start, string @end, string? @body = null, string? @location = null, string? @categories = null, object? @sensitivity = null, object? @showAs = null, bool? @isAllDay = null, object? @attendees = null)
		{
			_haContext.CallService("o365", "create_calendar_event", target, new O365CreateCalendarEventParameters{Subject = @subject, Start = @start, End = @end, Body = @body, Location = @location, Categories = @categories, Sensitivity = @sensitivity, ShowAs = @showAs, IsAllDay = @isAllDay, Attendees = @attendees});
		}

		///<summary>Delete a new task/ToDo</summary>
		///<param name="target">The target for this service call</param>
		public void DeleteTask(ServiceTarget target, O365DeleteTaskParameters data)
		{
			_haContext.CallService("o365", "delete_task", target, data);
		}

		///<summary>Delete a new task/ToDo</summary>
		///<param name="target">The target for this service call</param>
		///<param name="taskId">ID for the task, can be found as an attribute on your task eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		public void DeleteTask(ServiceTarget target, string @taskId)
		{
			_haContext.CallService("o365", "delete_task", target, new O365DeleteTaskParameters{TaskId = @taskId});
		}

		///<summary>Modify existing calendar event, all properties except event_id are optional.</summary>
		///<param name="target">The target for this service call</param>
		public void ModifyCalendarEvent(ServiceTarget target, O365ModifyCalendarEventParameters data)
		{
			_haContext.CallService("o365", "modify_calendar_event", target, data);
		}

		///<summary>Modify existing calendar event, all properties except event_id are optional.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="eventId">ID for the event, can be found as an attribute on you calendar entity's events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		///<param name="subject">The subject of the created event eg: Clean up the garage</param>
		///<param name="start">The start time of the event eg: 2023-01-01T12:00:00+0000</param>
		///<param name="end">The end time of the event eg: 2023-01-01T12:30:00+0000</param>
		///<param name="body">The body text for the event eg: Remember to also clean out the gutters</param>
		///<param name="location">The location for the event eg: 1600 Pennsylvania Ave Nw, Washington, DC 20500</param>
		///<param name="categories">list of categories for the event</param>
		///<param name="sensitivity">The sensitivity for the event[Normal, Personal, Private, Confidential] eg: normal</param>
		///<param name="showAs">Show event as [Free, Tentative, Busy, Oof, WorkingElsewhere, Unknown] eg: busy</param>
		///<param name="isAllDay">Set whether event is all day eg: False</param>
		///<param name="attendees">list of attendees formatted as email: example@example.com type: Required, Optional, or Resource</param>
		public void ModifyCalendarEvent(ServiceTarget target, string @eventId, string? @subject = null, string? @start = null, string? @end = null, string? @body = null, string? @location = null, string? @categories = null, object? @sensitivity = null, object? @showAs = null, bool? @isAllDay = null, object? @attendees = null)
		{
			_haContext.CallService("o365", "modify_calendar_event", target, new O365ModifyCalendarEventParameters{EventId = @eventId, Subject = @subject, Start = @start, End = @end, Body = @body, Location = @location, Categories = @categories, Sensitivity = @sensitivity, ShowAs = @showAs, IsAllDay = @isAllDay, Attendees = @attendees});
		}

		///<summary>Create a new task/ToDo</summary>
		///<param name="target">The target for this service call</param>
		public void NewTask(ServiceTarget target, O365NewTaskParameters data)
		{
			_haContext.CallService("o365", "new_task", target, data);
		}

		///<summary>Create a new task/ToDo</summary>
		///<param name="target">The target for this service call</param>
		///<param name="subject">The subject of the task eg: Pick up the mail</param>
		///<param name="description">Description of the task eg: Walk to the post box and collect the mail</param>
		///<param name="due">When the task is due by eg: YYYY-MM-DD</param>
		///<param name="reminder">When a reminder is needed eg: 2023-01-01T12:00:00+0000</param>
		public void NewTask(ServiceTarget target, string @subject, string? @description = null, object? @due = null, string? @reminder = null)
		{
			_haContext.CallService("o365", "new_task", target, new O365NewTaskParameters{Subject = @subject, Description = @description, Due = @due, Reminder = @reminder});
		}

		///<summary>Delete calendar event</summary>
		///<param name="target">The target for this service call</param>
		public void RemoveCalendarEvent(ServiceTarget target, O365RemoveCalendarEventParameters data)
		{
			_haContext.CallService("o365", "remove_calendar_event", target, data);
		}

		///<summary>Delete calendar event</summary>
		///<param name="target">The target for this service call</param>
		///<param name="eventId">ID for the event, can be found as an attribute on you calendar entity's events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		public void RemoveCalendarEvent(ServiceTarget target, string @eventId)
		{
			_haContext.CallService("o365", "remove_calendar_event", target, new O365RemoveCalendarEventParameters{EventId = @eventId});
		}

		///<summary>Respond to calendar event/invite</summary>
		///<param name="target">The target for this service call</param>
		public void RespondCalendarEvent(ServiceTarget target, O365RespondCalendarEventParameters data)
		{
			_haContext.CallService("o365", "respond_calendar_event", target, data);
		}

		///<summary>Respond to calendar event/invite</summary>
		///<param name="target">The target for this service call</param>
		///<param name="eventId">ID for event, can be found as an attribute on you calendar entity's events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		///<param name="response">The response to the invite [Accept, Tentative, Decline] eg: Decline</param>
		///<param name="message">The response message to the invite (Optional) eg: I cannot attend this meeting</param>
		///<param name="sendResponse">Send the response to the organizer (Optional) eg: True</param>
		public void RespondCalendarEvent(ServiceTarget target, string @eventId, string @response, string? @message = null, bool? @sendResponse = null)
		{
			_haContext.CallService("o365", "respond_calendar_event", target, new O365RespondCalendarEventParameters{EventId = @eventId, Response = @response, Message = @message, SendResponse = @sendResponse});
		}

		///<summary>Scan for newly available calendars</summary>
		public void ScanForCalendars()
		{
			_haContext.CallService("o365", "scan_for_calendars", null);
		}

		///<summary>Scan for newly available task lists</summary>
		public void ScanForTaskLists()
		{
			_haContext.CallService("o365", "scan_for_task_lists", null);
		}

		///<summary>Update a new task/ToDo</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateTask(ServiceTarget target, O365UpdateTaskParameters data)
		{
			_haContext.CallService("o365", "update_task", target, data);
		}

		///<summary>Update a new task/ToDo</summary>
		///<param name="target">The target for this service call</param>
		///<param name="taskId">ID for the task, can be found as an attribute on your task eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		///<param name="subject">The subject of the task eg: Pick up the mail</param>
		///<param name="description">Description of the task eg: Walk to the post box and collect the mail</param>
		///<param name="due">When the task is due by eg: 2023-01-01</param>
		///<param name="reminder">When a reminder is needed eg: 2023-01-01T12:00:00+0000</param>
		public void UpdateTask(ServiceTarget target, string @taskId, string? @subject = null, string? @description = null, object? @due = null, string? @reminder = null)
		{
			_haContext.CallService("o365", "update_task", target, new O365UpdateTaskParameters{TaskId = @taskId, Subject = @subject, Description = @description, Due = @due, Reminder = @reminder});
		}
	}

	public record O365CreateCalendarEventParameters
	{
		///<summary>The subject of the created event eg: Clean up the garage</summary>
		[JsonPropertyName("subject")]
		public string? Subject { get; init; }

		///<summary>The start time of the event eg: 2023-01-01T12:00:00+0000</summary>
		[JsonPropertyName("start")]
		public string? Start { get; init; }

		///<summary>The end time of the event eg: 2023-01-01T12:30:00+0000</summary>
		[JsonPropertyName("end")]
		public string? End { get; init; }

		///<summary>The body text for the event (optional) eg: Remember to also clean out the gutters</summary>
		[JsonPropertyName("body")]
		public string? Body { get; init; }

		///<summary>The location for the event (optional) eg: 1600 Pennsylvania Ave Nw, Washington, DC 20500</summary>
		[JsonPropertyName("location")]
		public string? Location { get; init; }

		///<summary>list of categories for the event (optional)</summary>
		[JsonPropertyName("categories")]
		public string? Categories { get; init; }

		///<summary>The sensitivity for the event (optional) [Normal, Personal, Private, Confidential] eg: normal</summary>
		[JsonPropertyName("sensitivity")]
		public object? Sensitivity { get; init; }

		///<summary>Show event as (optional) [Free, Tentative, Busy, Oof, WorkingElsewhere, Unknown] eg: busy</summary>
		[JsonPropertyName("show_as")]
		public object? ShowAs { get; init; }

		///<summary>Set whether event is all day (optional) eg: False</summary>
		[JsonPropertyName("is_all_day")]
		public bool? IsAllDay { get; init; }

		///<summary>list of attendees formatted as email: example@example.com type: Required, Optional, or Resource (optional)</summary>
		[JsonPropertyName("attendees")]
		public object? Attendees { get; init; }
	}

	public record O365DeleteTaskParameters
	{
		///<summary>ID for the task, can be found as an attribute on your task eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</summary>
		[JsonPropertyName("task_id")]
		public string? TaskId { get; init; }
	}

	public record O365ModifyCalendarEventParameters
	{
		///<summary>ID for the event, can be found as an attribute on you calendar entity's events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</summary>
		[JsonPropertyName("event_id")]
		public string? EventId { get; init; }

		///<summary>The subject of the created event eg: Clean up the garage</summary>
		[JsonPropertyName("subject")]
		public string? Subject { get; init; }

		///<summary>The start time of the event eg: 2023-01-01T12:00:00+0000</summary>
		[JsonPropertyName("start")]
		public string? Start { get; init; }

		///<summary>The end time of the event eg: 2023-01-01T12:30:00+0000</summary>
		[JsonPropertyName("end")]
		public string? End { get; init; }

		///<summary>The body text for the event eg: Remember to also clean out the gutters</summary>
		[JsonPropertyName("body")]
		public string? Body { get; init; }

		///<summary>The location for the event eg: 1600 Pennsylvania Ave Nw, Washington, DC 20500</summary>
		[JsonPropertyName("location")]
		public string? Location { get; init; }

		///<summary>list of categories for the event</summary>
		[JsonPropertyName("categories")]
		public string? Categories { get; init; }

		///<summary>The sensitivity for the event[Normal, Personal, Private, Confidential] eg: normal</summary>
		[JsonPropertyName("sensitivity")]
		public object? Sensitivity { get; init; }

		///<summary>Show event as [Free, Tentative, Busy, Oof, WorkingElsewhere, Unknown] eg: busy</summary>
		[JsonPropertyName("show_as")]
		public object? ShowAs { get; init; }

		///<summary>Set whether event is all day eg: False</summary>
		[JsonPropertyName("is_all_day")]
		public bool? IsAllDay { get; init; }

		///<summary>list of attendees formatted as email: example@example.com type: Required, Optional, or Resource</summary>
		[JsonPropertyName("attendees")]
		public object? Attendees { get; init; }
	}

	public record O365NewTaskParameters
	{
		///<summary>The subject of the task eg: Pick up the mail</summary>
		[JsonPropertyName("subject")]
		public string? Subject { get; init; }

		///<summary>Description of the task eg: Walk to the post box and collect the mail</summary>
		[JsonPropertyName("description")]
		public string? Description { get; init; }

		///<summary>When the task is due by eg: YYYY-MM-DD</summary>
		[JsonPropertyName("due")]
		public object? Due { get; init; }

		///<summary>When a reminder is needed eg: 2023-01-01T12:00:00+0000</summary>
		[JsonPropertyName("reminder")]
		public string? Reminder { get; init; }
	}

	public record O365RemoveCalendarEventParameters
	{
		///<summary>ID for the event, can be found as an attribute on you calendar entity's events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</summary>
		[JsonPropertyName("event_id")]
		public string? EventId { get; init; }
	}

	public record O365RespondCalendarEventParameters
	{
		///<summary>ID for event, can be found as an attribute on you calendar entity's events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</summary>
		[JsonPropertyName("event_id")]
		public string? EventId { get; init; }

		///<summary>The response to the invite [Accept, Tentative, Decline] eg: Decline</summary>
		[JsonPropertyName("response")]
		public string? Response { get; init; }

		///<summary>The response message to the invite (Optional) eg: I cannot attend this meeting</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Send the response to the organizer (Optional) eg: True</summary>
		[JsonPropertyName("send_response")]
		public bool? SendResponse { get; init; }
	}

	public record O365UpdateTaskParameters
	{
		///<summary>ID for the task, can be found as an attribute on your task eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</summary>
		[JsonPropertyName("task_id")]
		public string? TaskId { get; init; }

		///<summary>The subject of the task eg: Pick up the mail</summary>
		[JsonPropertyName("subject")]
		public string? Subject { get; init; }

		///<summary>Description of the task eg: Walk to the post box and collect the mail</summary>
		[JsonPropertyName("description")]
		public string? Description { get; init; }

		///<summary>When the task is due by eg: 2023-01-01</summary>
		[JsonPropertyName("due")]
		public object? Due { get; init; }

		///<summary>When a reminder is needed eg: 2023-01-01T12:00:00+0000</summary>
		[JsonPropertyName("reminder")]
		public string? Reminder { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a notification in the frontend.</summary>
		public void Create(PersistentNotificationCreateParameters data)
		{
			_haContext.CallService("persistent_notification", "create", null, data);
		}

		///<summary>Show a notification in the frontend.</summary>
		///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
		///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
		///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
		public void Create(string @message, string? @title = null, string? @notificationId = null)
		{
			_haContext.CallService("persistent_notification", "create", null, new PersistentNotificationCreateParameters{Message = @message, Title = @title, NotificationId = @notificationId});
		}

		///<summary>Remove a notification from the frontend.</summary>
		public void Dismiss(PersistentNotificationDismissParameters data)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, data);
		}

		///<summary>Remove a notification from the frontend.</summary>
		///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
		public void Dismiss(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, new PersistentNotificationDismissParameters{NotificationId = @notificationId});
		}

		///<summary>Mark a notification read.</summary>
		public void MarkRead(PersistentNotificationMarkReadParameters data)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, data);
		}

		///<summary>Mark a notification read.</summary>
		///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
		public void MarkRead(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, new PersistentNotificationMarkReadParameters{NotificationId = @notificationId});
		}
	}

	public record PersistentNotificationCreateParameters
	{
		///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly IHaContext _haContext;
		public PersonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the person configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("person", "reload", null);
		}
	}

	public class PingServices
	{
		private readonly IHaContext _haContext;
		public PingServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all ping entities.</summary>
		public void Reload()
		{
			_haContext.CallService("ping", "reload", null);
		}
	}

	public class RecorderServices
	{
		private readonly IHaContext _haContext;
		public RecorderServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Stop the recording of events and state changes</summary>
		public void Disable()
		{
			_haContext.CallService("recorder", "disable", null);
		}

		///<summary>Start the recording of events and state changes</summary>
		public void Enable()
		{
			_haContext.CallService("recorder", "enable", null);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		public void Purge(RecorderPurgeParameters data)
		{
			_haContext.CallService("recorder", "purge", null, data);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		///<param name="keepDays">Number of history days to keep in database after purge.</param>
		///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
		///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
		public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
		{
			_haContext.CallService("recorder", "purge", null, new RecorderPurgeParameters{KeepDays = @keepDays, Repack = @repack, ApplyFilter = @applyFilter});
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		public void PurgeEntities(ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
		///<param name="entityGlobs">List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</param>
		public void PurgeEntities(ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters{Domains = @domains, EntityGlobs = @entityGlobs});
		}
	}

	public record RecorderPurgeParameters
	{
		///<summary>Number of history days to keep in database after purge.</summary>
		[JsonPropertyName("keep_days")]
		public long? KeepDays { get; init; }

		///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
		[JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
		[JsonPropertyName("apply_filter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
		[JsonPropertyName("domains")]
		public object? Domains { get; init; }

		///<summary>List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
		[JsonPropertyName("entity_globs")]
		public object? EntityGlobs { get; init; }
	}

	public class RemoteServices
	{
		private readonly IHaContext _haContext;
		public RemoteServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		public void DeleteCommand(ServiceTarget target, RemoteDeleteCommandParameters data)
		{
			_haContext.CallService("remote", "delete_command", target, data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public void DeleteCommand(ServiceTarget target, object @command, string? @device = null)
		{
			_haContext.CallService("remote", "delete_command", target, new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		public void LearnCommand(ServiceTarget target, RemoteLearnCommandParameters data)
		{
			_haContext.CallService("remote", "learn_command", target, data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public void LearnCommand(ServiceTarget target, string? @device = null, object? @command = null, object? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			_haContext.CallService("remote", "learn_command", target, new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, RemoteSendCommandParameters data)
		{
			_haContext.CallService("remote", "send_command", target, data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public void SendCommand(ServiceTarget target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			_haContext.CallService("remote", "send_command", target, new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("remote", "toggle", target);
		}

		///<summary>Sends the Power Off Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("remote", "turn_off", target);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, RemoteTurnOnParameters data)
		{
			_haContext.CallService("remote", "turn_on", target, data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public void TurnOn(ServiceTarget target, string? @activity = null)
		{
			_haContext.CallService("remote", "turn_on", target, new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public record RemoteDeleteCommandParameters
	{
		///<summary>Name of the device from which commands will be deleted. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to delete. eg: Mute</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }
	}

	public record RemoteLearnCommandParameters
	{
		///<summary>Device ID to learn command from. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to learn. eg: Turn on</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The type of command to be learned.</summary>
		[JsonPropertyName("command_type")]
		public object? CommandType { get; init; }

		///<summary>If code must be stored as alternative (useful for discrete remotes).</summary>
		[JsonPropertyName("alternative")]
		public bool? Alternative { get; init; }

		///<summary>Timeout for the command to be learned.</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }
	}

	public record RemoteSendCommandParameters
	{
		///<summary>Device ID to send command to. eg: 32756745</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to send. eg: Play</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The number of times you want to repeat the command(s).</summary>
		[JsonPropertyName("num_repeats")]
		public long? NumRepeats { get; init; }

		///<summary>The time you want to wait in between repeated commands.</summary>
		[JsonPropertyName("delay_secs")]
		public double? DelaySecs { get; init; }

		///<summary>The time you want to have it held before the release is send.</summary>
		[JsonPropertyName("hold_secs")]
		public double? HoldSecs { get; init; }
	}

	public record RemoteTurnOnParameters
	{
		///<summary>Activity ID or Activity Name to start. eg: BedroomTV</summary>
		[JsonPropertyName("activity")]
		public string? Activity { get; init; }
	}

	public class SceneServices
	{
		private readonly IHaContext _haContext;
		public SceneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a scene with configuration.</summary>
		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		///<summary>Activate a scene with configuration.</summary>
		///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void Apply(object @entities, long? @transition = null)
		{
			_haContext.CallService("scene", "apply", null, new SceneApplyParameters{Entities = @entities, Transition = @transition});
		}

		///<summary>Creates a new scene.</summary>
		public void Create(SceneCreateParameters data)
		{
			_haContext.CallService("scene", "create", null, data);
		}

		///<summary>Creates a new scene.</summary>
		///<param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
		///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</param>
		///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</param>
		public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
		{
			_haContext.CallService("scene", "create", null, new SceneCreateParameters{SceneId = @sceneId, Entities = @entities, SnapshotEntities = @snapshotEntities});
		}

		///<summary>Reload the scene configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("scene", "reload", null);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public record SceneApplyParameters
	{
		///<summary>The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		///<summary>The entity_id of the new scene. eg: all_lights</summary>
		[JsonPropertyName("scene_id")]
		public string? SceneId { get; init; }

		///<summary>The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</summary>
		[JsonPropertyName("snapshot_entities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public class ScheduleServices
	{
		private readonly IHaContext _haContext;
		public ScheduleServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the schedule configuration</summary>
		public void Reload()
		{
			_haContext.CallService("schedule", "reload", null);
		}
	}

	public class ScriptServices
	{
		private readonly IHaContext _haContext;
		public ScriptServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all the available scripts</summary>
		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		///<summary>Toggle script</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		///<summary>Turn off script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		///<summary>Turn on script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}
	}

	public class SelectServices
	{
		private readonly IHaContext _haContext;
		public SelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, SelectSelectOptionParameters data)
		{
			_haContext.CallService("select", "select_option", target, data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters{Option = @option});
		}
	}

	public record SelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public class SirenServices
	{
		private readonly IHaContext _haContext;
		public SirenServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a siren.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("siren", "toggle", target);
		}

		///<summary>Turn siren off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("siren", "turn_off", target);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SirenTurnOnParameters data)
		{
			_haContext.CallService("siren", "turn_on", target, data);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tone">The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
		///<param name="volumeLevel">The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0,5</param>
		///<param name="duration">The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</param>
		public void TurnOn(ServiceTarget target, string? @tone = null, double? @volumeLevel = null, string? @duration = null)
		{
			_haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters{Tone = @tone, VolumeLevel = @volumeLevel, Duration = @duration});
		}
	}

	public record SirenTurnOnParameters
	{
		///<summary>The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
		[JsonPropertyName("tone")]
		public string? Tone { get; init; }

		///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0,5</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }

		///<summary>The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class SwitchServices
	{
		private readonly IHaContext _haContext;
		public SwitchServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a switch state</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		///<summary>Turn a switch off</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		///<summary>Turn a switch on</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SynologyDsmServices
	{
		private readonly IHaContext _haContext;
		public SynologyDsmServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reboot the NAS. This service is deprecated and will be removed in future release. Please use the corresponding button entity.</summary>
		public void Reboot(SynologyDsmRebootParameters data)
		{
			_haContext.CallService("synology_dsm", "reboot", null, data);
		}

		///<summary>Reboot the NAS. This service is deprecated and will be removed in future release. Please use the corresponding button entity.</summary>
		///<param name="serial">serial of the NAS to reboot; required when multiple NAS are configured. eg: 1NDVC86409</param>
		public void Reboot(string? @serial = null)
		{
			_haContext.CallService("synology_dsm", "reboot", null, new SynologyDsmRebootParameters{Serial = @serial});
		}

		///<summary>Shutdown the NAS. This service is deprecated and will be removed in future release. Please use the corresponding button entity.</summary>
		public void Shutdown(SynologyDsmShutdownParameters data)
		{
			_haContext.CallService("synology_dsm", "shutdown", null, data);
		}

		///<summary>Shutdown the NAS. This service is deprecated and will be removed in future release. Please use the corresponding button entity.</summary>
		///<param name="serial">serial of the NAS to shutdown; required when multiple NAS are configured. eg: 1NDVC86409</param>
		public void Shutdown(string? @serial = null)
		{
			_haContext.CallService("synology_dsm", "shutdown", null, new SynologyDsmShutdownParameters{Serial = @serial});
		}
	}

	public record SynologyDsmRebootParameters
	{
		///<summary>serial of the NAS to reboot; required when multiple NAS are configured. eg: 1NDVC86409</summary>
		[JsonPropertyName("serial")]
		public string? Serial { get; init; }
	}

	public record SynologyDsmShutdownParameters
	{
		///<summary>serial of the NAS to shutdown; required when multiple NAS are configured. eg: 1NDVC86409</summary>
		[JsonPropertyName("serial")]
		public string? Serial { get; init; }
	}

	public class SystemLogServices
	{
		private readonly IHaContext _haContext;
		public SystemLogServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear all log entries.</summary>
		public void Clear()
		{
			_haContext.CallService("system_log", "clear", null);
		}

		///<summary>Write log entry.</summary>
		public void Write(SystemLogWriteParameters data)
		{
			_haContext.CallService("system_log", "write", null, data);
		}

		///<summary>Write log entry.</summary>
		///<param name="message">Message to log. eg: Something went wrong</param>
		///<param name="level">Log level.</param>
		///<param name="logger">Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</param>
		public void Write(string @message, object? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new SystemLogWriteParameters{Message = @message, Level = @level, Logger = @logger});
		}
	}

	public record SystemLogWriteParameters
	{
		///<summary>Message to log. eg: Something went wrong</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Log level.</summary>
		[JsonPropertyName("level")]
		public object? Level { get; init; }

		///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
		[JsonPropertyName("logger")]
		public string? Logger { get; init; }
	}

	public class TemplateServices
	{
		private readonly IHaContext _haContext;
		public TemplateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all template entities.</summary>
		public void Reload()
		{
			_haContext.CallService("template", "reload", null);
		}
	}

	public class TextServices
	{
		private readonly IHaContext _haContext;
		public TextServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set value of a text entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, TextSetValueParameters data)
		{
			_haContext.CallService("text", "set_value", target, data);
		}

		///<summary>Set value of a text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">Value to set. eg: Hello world!</param>
		public void SetValue(ServiceTarget target, string @value)
		{
			_haContext.CallService("text", "set_value", target, new TextSetValueParameters{Value = @value});
		}
	}

	public record TextSetValueParameters
	{
		///<summary>Value to set. eg: Hello world!</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class TimerServices
	{
		private readonly IHaContext _haContext;
		public TimerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cancel a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Cancel(ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		///<summary>Finish a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Finish(ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		///<summary>Pause a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public void Start(ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new TimerStartParameters{Duration = @duration});
		}
	}

	public record TimerStartParameters
	{
		///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class UpdateServices
	{
		private readonly IHaContext _haContext;
		public UpdateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearSkipped(ServiceTarget target)
		{
			_haContext.CallService("update", "clear_skipped", target);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		public void Install(ServiceTarget target, UpdateInstallParameters data)
		{
			_haContext.CallService("update", "install", target, data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public void Install(ServiceTarget target, string? @version = null, bool? @backup = null)
		{
			_haContext.CallService("update", "install", target, new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		///<param name="target">The target for this service call</param>
		public void Skip(ServiceTarget target)
		{
			_haContext.CallService("update", "skip", target);
		}
	}

	public record UpdateInstallParameters
	{
		///<summary>Version to install, if omitted, the latest version will be installed. eg: 1.0.0</summary>
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		///<summary>Backup before installing the update, if supported by the integration.</summary>
		[JsonPropertyName("backup")]
		public bool? Backup { get; init; }
	}

	public class VacuumServices
	{
		private readonly IHaContext _haContext;
		public VacuumServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		///<param name="target">The target for this service call</param>
		public void CleanSpot(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		///<param name="target">The target for this service call</param>
		public void Locate(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		///<summary>Pause the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		///<param name="target">The target for this service call</param>
		public void ReturnToBase(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public void SendCommand(ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanSpeed(ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public void SetFanSpeed(ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void StartPause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		///<summary>Stop the current cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Stop(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		///<summary>Start a new cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		///<summary>Command to execute. eg: set_dnd_timer</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>Parameters for the command. eg: { "key": "value" }</summary>
		[JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }
	}

	public class WakeOnLanServices
	{
		private readonly IHaContext _haContext;
		public WakeOnLanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a 'magic packet' to wake up a device with 'Wake-On-LAN' capabilities.</summary>
		public void SendMagicPacket(WakeOnLanSendMagicPacketParameters data)
		{
			_haContext.CallService("wake_on_lan", "send_magic_packet", null, data);
		}

		///<summary>Send a 'magic packet' to wake up a device with 'Wake-On-LAN' capabilities.</summary>
		///<param name="mac">MAC address of the device to wake up. eg: aa:bb:cc:dd:ee:ff</param>
		///<param name="broadcastAddress">Broadcast IP where to send the magic packet. eg: 192.168.255.255</param>
		///<param name="broadcastPort">Port where to send the magic packet.</param>
		public void SendMagicPacket(string @mac, string? @broadcastAddress = null, long? @broadcastPort = null)
		{
			_haContext.CallService("wake_on_lan", "send_magic_packet", null, new WakeOnLanSendMagicPacketParameters{Mac = @mac, BroadcastAddress = @broadcastAddress, BroadcastPort = @broadcastPort});
		}
	}

	public record WakeOnLanSendMagicPacketParameters
	{
		///<summary>MAC address of the device to wake up. eg: aa:bb:cc:dd:ee:ff</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Broadcast IP where to send the magic packet. eg: 192.168.255.255</summary>
		[JsonPropertyName("broadcast_address")]
		public string? BroadcastAddress { get; init; }

		///<summary>Port where to send the magic packet.</summary>
		[JsonPropertyName("broadcast_port")]
		public long? BroadcastPort { get; init; }
	}

	public class WebrtcServices
	{
		private readonly IHaContext _haContext;
		public WebrtcServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a temporary or permanent link to a stream (enter "url" or "entity")</summary>
		public void CreateLink(WebrtcCreateLinkParameters data)
		{
			_haContext.CallService("webrtc", "create_link", null, data);
		}

		///<summary>Create a temporary or permanent link to a stream (enter "url" or "entity")</summary>
		///<param name="linkId">Create a random or permanent ID for your link eg: fd0a53ca-e9ab-4e7a-86a2-441642b16ae1</param>
		///<param name="url">Link to RTSP-stream eg: rtsp://rtsp:12345678@192.168.1.123:554/av_stream/ch0</param>
		///<param name="entity">Camera entity eg: camera.generic_stream</param>
		///<param name="openLimit">How many times a link can be opened (0 - unlimit) eg: 1</param>
		///<param name="timeToLive">How many seconds will the link live (0 - unlimit) eg: 60</param>
		public void CreateLink(string @linkId, string? @url = null, string? @entity = null, long? @openLimit = null, long? @timeToLive = null)
		{
			_haContext.CallService("webrtc", "create_link", null, new WebrtcCreateLinkParameters{LinkId = @linkId, Url = @url, Entity = @entity, OpenLimit = @openLimit, TimeToLive = @timeToLive});
		}

		///<summary>Cast stream to Chromecast device via DashCast application</summary>
		public void DashCast(WebrtcDashCastParameters data)
		{
			_haContext.CallService("webrtc", "dash_cast", null, data);
		}

		///<summary>Cast stream to Chromecast device via DashCast application</summary>
		///<param name="entityId">Media player entity eg: media_player.mibox4</param>
		///<param name="url">Link to RTSP-stream eg: rtsp://rtsp:12345678@192.168.1.123:554/av_stream/ch0</param>
		///<param name="entity">Camera entity eg: camera.generic_stream</param>
		public void DashCast(string @entityId, string? @url = null, string? @entity = null)
		{
			_haContext.CallService("webrtc", "dash_cast", null, new WebrtcDashCastParameters{EntityId = @entityId, Url = @url, Entity = @entity});
		}
	}

	public record WebrtcCreateLinkParameters
	{
		///<summary>Create a random or permanent ID for your link eg: fd0a53ca-e9ab-4e7a-86a2-441642b16ae1</summary>
		[JsonPropertyName("link_id")]
		public string? LinkId { get; init; }

		///<summary>Link to RTSP-stream eg: rtsp://rtsp:12345678@192.168.1.123:554/av_stream/ch0</summary>
		[JsonPropertyName("url")]
		public string? Url { get; init; }

		///<summary>Camera entity eg: camera.generic_stream</summary>
		[JsonPropertyName("entity")]
		public string? Entity { get; init; }

		///<summary>How many times a link can be opened (0 - unlimit) eg: 1</summary>
		[JsonPropertyName("open_limit")]
		public long? OpenLimit { get; init; }

		///<summary>How many seconds will the link live (0 - unlimit) eg: 60</summary>
		[JsonPropertyName("time_to_live")]
		public long? TimeToLive { get; init; }
	}

	public record WebrtcDashCastParameters
	{
		///<summary>Media player entity eg: media_player.mibox4</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Link to RTSP-stream eg: rtsp://rtsp:12345678@192.168.1.123:554/av_stream/ch0</summary>
		[JsonPropertyName("url")]
		public string? Url { get; init; }

		///<summary>Camera entity eg: camera.generic_stream</summary>
		[JsonPropertyName("entity")]
		public string? Entity { get; init; }
	}

	public class XiaomiCloudMapExtractorServices
	{
		private readonly IHaContext _haContext;
		public XiaomiCloudMapExtractorServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all entities of Xiaomi Cloud Map Extractor platform</summary>
		public void Reload()
		{
			_haContext.CallService("xiaomi_cloud_map_extractor", "reload", null);
		}
	}

	public class XiaomiMiioServices
	{
		private readonly IHaContext _haContext;
		public XiaomiMiioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumCleanSegment(ServiceTarget target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The target for this service call</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public void VacuumCleanSegment(ServiceTarget target, object? @segments = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumCleanZone(ServiceTarget target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public void VacuumCleanZone(ServiceTarget target, object? @zone = null, long? @repeats = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumGoto(ServiceTarget target, XiaomiMiioVacuumGotoParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, data);
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public void VacuumGoto(ServiceTarget target, string? @xCoord = null, string? @yCoord = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlMove(ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public void VacuumRemoteControlMove(ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlMoveStep(ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public void VacuumRemoteControlMoveStep(ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlStart(ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_start", target);
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlStop(ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_stop", target);
		}
	}

	public record XiaomiMiioVacuumCleanSegmentParameters
	{
		///<summary>Segments. eg: [1,2]</summary>
		[JsonPropertyName("segments")]
		public object? Segments { get; init; }
	}

	public record XiaomiMiioVacuumCleanZoneParameters
	{
		///<summary>Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</summary>
		[JsonPropertyName("zone")]
		public object? Zone { get; init; }

		///<summary>Number of cleaning repeats for each zone.</summary>
		[JsonPropertyName("repeats")]
		public long? Repeats { get; init; }
	}

	public record XiaomiMiioVacuumGotoParameters
	{
		///<summary>x-coordinate. eg: 27500</summary>
		[JsonPropertyName("x_coord")]
		public string? XCoord { get; init; }

		///<summary>y-coordinate. eg: 32000</summary>
		[JsonPropertyName("y_coord")]
		public string? YCoord { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveParameters
	{
		///<summary>Speed.</summary>
		[JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		///<summary>Rotation, between -179 degrees and 179 degrees.</summary>
		[JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		///<summary>Duration of the movement.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveStepParameters
	{
		///<summary>Speed.</summary>
		[JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		///<summary>Rotation.</summary>
		[JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		///<summary>Duration of the movement.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public class ZoneServices
	{
		private readonly IHaContext _haContext;
		public ZoneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the YAML-based zone configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public static class AlarmControlPanelEntityExtensionMethods
	{
		///<summary>Send the alarm the command for arm away.</summary>
		public static void AlarmArmAway(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			target.CallService("alarm_arm_away", data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		public static void AlarmArmAway(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			target.CallService("alarm_arm_away", data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public static void AlarmArmAway(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_away", new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public static void AlarmArmAway(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_away", new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			target.CallService("alarm_arm_custom_bypass", data);
		}

		///<summary>Send arm custom bypass command.</summary>
		public static void AlarmArmCustomBypass(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			target.CallService("alarm_arm_custom_bypass", data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_custom_bypass", new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public static void AlarmArmCustomBypass(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_custom_bypass", new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		public static void AlarmArmHome(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			target.CallService("alarm_arm_home", data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		public static void AlarmArmHome(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			target.CallService("alarm_arm_home", data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public static void AlarmArmHome(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_home", new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public static void AlarmArmHome(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_home", new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		public static void AlarmArmNight(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmNightParameters data)
		{
			target.CallService("alarm_arm_night", data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		public static void AlarmArmNight(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmNightParameters data)
		{
			target.CallService("alarm_arm_night", data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public static void AlarmArmNight(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_night", new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public static void AlarmArmNight(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_night", new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		public static void AlarmArmVacation(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			target.CallService("alarm_arm_vacation", data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		public static void AlarmArmVacation(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			target.CallService("alarm_arm_vacation", data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public static void AlarmArmVacation(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_vacation", new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public static void AlarmArmVacation(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_vacation", new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		public static void AlarmDisarm(this AlarmControlPanelEntity target, AlarmControlPanelAlarmDisarmParameters data)
		{
			target.CallService("alarm_disarm", data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		public static void AlarmDisarm(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmDisarmParameters data)
		{
			target.CallService("alarm_disarm", data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public static void AlarmDisarm(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_disarm", new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public static void AlarmDisarm(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_disarm", new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		public static void AlarmTrigger(this AlarmControlPanelEntity target, AlarmControlPanelAlarmTriggerParameters data)
		{
			target.CallService("alarm_trigger", data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		public static void AlarmTrigger(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmTriggerParameters data)
		{
			target.CallService("alarm_trigger", data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public static void AlarmTrigger(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_trigger", new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public static void AlarmTrigger(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_trigger", new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public static class ButtonEntityExtensionMethods
	{
		///<summary>Press the button entity.</summary>
		public static void Press(this ButtonEntity target)
		{
			target.CallService("press");
		}

		///<summary>Press the button entity.</summary>
		public static void Press(this IEnumerable<ButtonEntity> target)
		{
			target.CallService("press");
		}
	}

	public static class CalendarEntityExtensionMethods
	{
		///<summary>Add a new calendar event.</summary>
		public static void CreateEvent(this CalendarEntity target, CalendarCreateEventParameters data)
		{
			target.CallService("create_event", data);
		}

		///<summary>Add a new calendar event.</summary>
		public static void CreateEvent(this IEnumerable<CalendarEntity> target, CalendarCreateEventParameters data)
		{
			target.CallService("create_event", data);
		}

		///<summary>Add a new calendar event.</summary>
		///<param name="target">The CalendarEntity to call this service for</param>
		///<param name="summary">Defines the short summary or subject for the event eg: Department Party</param>
		///<param name="description">A more complete description of the event than that provided by the summary. eg: Meeting to provide technical review for 'Phoenix' design.</param>
		///<param name="startDateTime">The date and time the event should start. eg: 2022-03-22 20:00:00</param>
		///<param name="endDateTime">The date and time the event should end. eg: 2022-03-22 22:00:00</param>
		///<param name="startDate">The date the all-day event should start. eg: 2022-03-22</param>
		///<param name="endDate">The date the all-day event should end (exclusive). eg: 2022-03-23</param>
		///<param name="in">Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</param>
		public static void CreateEvent(this CalendarEntity target, string @summary, string? @description = null, object? @startDateTime = null, object? @endDateTime = null, object? @startDate = null, object? @endDate = null, object? @in = null)
		{
			target.CallService("create_event", new CalendarCreateEventParameters{Summary = @summary, Description = @description, StartDateTime = @startDateTime, EndDateTime = @endDateTime, StartDate = @startDate, EndDate = @endDate, In = @in});
		}

		///<summary>Add a new calendar event.</summary>
		///<param name="target">The IEnumerable<CalendarEntity> to call this service for</param>
		///<param name="summary">Defines the short summary or subject for the event eg: Department Party</param>
		///<param name="description">A more complete description of the event than that provided by the summary. eg: Meeting to provide technical review for 'Phoenix' design.</param>
		///<param name="startDateTime">The date and time the event should start. eg: 2022-03-22 20:00:00</param>
		///<param name="endDateTime">The date and time the event should end. eg: 2022-03-22 22:00:00</param>
		///<param name="startDate">The date the all-day event should start. eg: 2022-03-22</param>
		///<param name="endDate">The date the all-day event should end (exclusive). eg: 2022-03-23</param>
		///<param name="in">Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</param>
		public static void CreateEvent(this IEnumerable<CalendarEntity> target, string @summary, string? @description = null, object? @startDateTime = null, object? @endDateTime = null, object? @startDate = null, object? @endDate = null, object? @in = null)
		{
			target.CallService("create_event", new CalendarCreateEventParameters{Summary = @summary, Description = @description, StartDateTime = @startDateTime, EndDateTime = @endDateTime, StartDate = @startDate, EndDate = @endDate, In = @in});
		}
	}

	public static class CameraEntityExtensionMethods
	{
		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this CameraEntity target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this CameraEntity target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this CameraEntity target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this IEnumerable<CameraEntity> target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this CameraEntity target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this IEnumerable<CameraEntity> target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this CameraEntity target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this IEnumerable<CameraEntity> target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this CameraEntity target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this IEnumerable<CameraEntity> target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this CameraEntity target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this IEnumerable<CameraEntity> target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this CameraEntity target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this IEnumerable<CameraEntity> target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this CameraEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this CameraEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this ClimateEntity target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this ClimateEntity target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this ClimateEntity target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this ClimateEntity target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this ClimateEntity target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this ClimateEntity target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this ClimateEntity target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this ClimateEntity target, object? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, object? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this ClimateEntity target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this ClimateEntity target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this ClimateEntity target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this ClimateEntity target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this ClimateEntity target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this ClimateEntity target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this ClimateEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this ClimateEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class CounterEntityExtensionMethods
	{
		///<summary>Change counter parameters.</summary>
		public static void Configure(this CounterEntity target, CounterConfigureParameters data)
		{
			target.CallService("configure", data);
		}

		///<summary>Change counter parameters.</summary>
		public static void Configure(this IEnumerable<CounterEntity> target, CounterConfigureParameters data)
		{
			target.CallService("configure", data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The CounterEntity to call this service for</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public static void Configure(this CounterEntity target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			target.CallService("configure", new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The IEnumerable<CounterEntity> to call this service for</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public static void Configure(this IEnumerable<CounterEntity> target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			target.CallService("configure", new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		public static void Decrement(this CounterEntity target)
		{
			target.CallService("decrement");
		}

		///<summary>Decrement a counter.</summary>
		public static void Decrement(this IEnumerable<CounterEntity> target)
		{
			target.CallService("decrement");
		}

		///<summary>Increment a counter.</summary>
		public static void Increment(this CounterEntity target)
		{
			target.CallService("increment");
		}

		///<summary>Increment a counter.</summary>
		public static void Increment(this IEnumerable<CounterEntity> target)
		{
			target.CallService("increment");
		}

		///<summary>Reset a counter.</summary>
		public static void Reset(this CounterEntity target)
		{
			target.CallService("reset");
		}

		///<summary>Reset a counter.</summary>
		public static void Reset(this IEnumerable<CounterEntity> target)
		{
			target.CallService("reset");
		}
	}

	public static class CoverEntityExtensionMethods
	{
		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this CoverEntity target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this CoverEntity target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this CoverEntity target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this CoverEntity target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this CoverEntity target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this CoverEntity target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this CoverEntity target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this CoverEntity target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this CoverEntity target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this CoverEntity target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this CoverEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this CoverEntity target)
		{
			target.CallService("toggle_cover_tilt");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle_cover_tilt");
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this InputBooleanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this InputBooleanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this InputBooleanEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class InputNumberEntityExtensionMethods
	{
		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this InputNumberEntity target)
		{
			target.CallService("decrement");
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("decrement");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this InputNumberEntity target)
		{
			target.CallService("increment");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("increment");
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this InputNumberEntity target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The InputNumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this InputNumberEntity target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The IEnumerable<InputNumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}
	}

	public static class InputSelectEntityExtensionMethods
	{
		///<summary>Select the first option of an input select entity.</summary>
		public static void SelectFirst(this InputSelectEntity target)
		{
			target.CallService("select_first");
		}

		///<summary>Select the first option of an input select entity.</summary>
		public static void SelectFirst(this IEnumerable<InputSelectEntity> target)
		{
			target.CallService("select_first");
		}

		///<summary>Select the last option of an input select entity.</summary>
		public static void SelectLast(this InputSelectEntity target)
		{
			target.CallService("select_last");
		}

		///<summary>Select the last option of an input select entity.</summary>
		public static void SelectLast(this IEnumerable<InputSelectEntity> target)
		{
			target.CallService("select_last");
		}

		///<summary>Select the next options of an input select entity.</summary>
		public static void SelectNext(this InputSelectEntity target, InputSelectSelectNextParameters data)
		{
			target.CallService("select_next", data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		public static void SelectNext(this IEnumerable<InputSelectEntity> target, InputSelectSelectNextParameters data)
		{
			target.CallService("select_next", data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public static void SelectNext(this InputSelectEntity target, bool? @cycle = null)
		{
			target.CallService("select_next", new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public static void SelectNext(this IEnumerable<InputSelectEntity> target, bool? @cycle = null)
		{
			target.CallService("select_next", new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		public static void SelectOption(this InputSelectEntity target, InputSelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an input select entity.</summary>
		public static void SelectOption(this IEnumerable<InputSelectEntity> target, InputSelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this InputSelectEntity target, string @option)
		{
			target.CallService("select_option", new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<InputSelectEntity> target, string @option)
		{
			target.CallService("select_option", new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		public static void SelectPrevious(this InputSelectEntity target, InputSelectSelectPreviousParameters data)
		{
			target.CallService("select_previous", data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		public static void SelectPrevious(this IEnumerable<InputSelectEntity> target, InputSelectSelectPreviousParameters data)
		{
			target.CallService("select_previous", data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public static void SelectPrevious(this InputSelectEntity target, bool? @cycle = null)
		{
			target.CallService("select_previous", new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public static void SelectPrevious(this IEnumerable<InputSelectEntity> target, bool? @cycle = null)
		{
			target.CallService("select_previous", new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		public static void SetOptions(this InputSelectEntity target, InputSelectSetOptionsParameters data)
		{
			target.CallService("set_options", data);
		}

		///<summary>Set the options of an input select entity.</summary>
		public static void SetOptions(this IEnumerable<InputSelectEntity> target, InputSelectSetOptionsParameters data)
		{
			target.CallService("set_options", data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The InputSelectEntity to call this service for</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public static void SetOptions(this InputSelectEntity target, object @options)
		{
			target.CallService("set_options", new InputSelectSetOptionsParameters{Options = @options});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The IEnumerable<InputSelectEntity> to call this service for</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public static void SetOptions(this IEnumerable<InputSelectEntity> target, object @options)
		{
			target.CallService("set_options", new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public static class InputTextEntityExtensionMethods
	{
		///<summary>Set the value of an input text entity.</summary>
		public static void SetValue(this InputTextEntity target, InputTextSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input text entity.</summary>
		public static void SetValue(this IEnumerable<InputTextEntity> target, InputTextSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The InputTextEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public static void SetValue(this InputTextEntity target, string @value)
		{
			target.CallService("set_value", new InputTextSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The IEnumerable<InputTextEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public static void SetValue(this IEnumerable<InputTextEntity> target, string @value)
		{
			target.CallService("set_value", new InputTextSetValueParameters{Value = @value});
		}
	}

	public static class LightEntityExtensionMethods
	{
		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this LightEntity target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this IEnumerable<LightEntity> target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this LightEntity target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this IEnumerable<LightEntity> target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this LightEntity target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this IEnumerable<LightEntity> target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this LightEntity target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this IEnumerable<LightEntity> target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public static class LockEntityExtensionMethods
	{
		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this LockEntity target, LockLockParameters data)
		{
			target.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this IEnumerable<LockEntity> target, LockLockParameters data)
		{
			target.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this LockEntity target, string? @code = null)
		{
			target.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this LockEntity target, LockOpenParameters data)
		{
			target.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this IEnumerable<LockEntity> target, LockOpenParameters data)
		{
			target.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this LockEntity target, string? @code = null)
		{
			target.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this LockEntity target, LockUnlockParameters data)
		{
			target.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this IEnumerable<LockEntity> target, LockUnlockParameters data)
		{
			target.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this LockEntity target, string? @code = null)
		{
			target.CallService("unlock", new LockUnlockParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("unlock", new LockUnlockParameters{Code = @code});
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this MediaPlayerEntity target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this MediaPlayerEntity target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: - media_player.multiroom_player2 - media_player.multiroom_player3 </param>
		public static void Join(this MediaPlayerEntity target, string @groupMembers)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: - media_player.multiroom_player2 - media_player.multiroom_player3 </param>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, string @groupMembers)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this MediaPlayerEntity target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this MediaPlayerEntity target)
		{
			target.CallService("media_play");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this MediaPlayerEntity target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this MediaPlayerEntity target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this MediaPlayerEntity target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this MediaPlayerEntity target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this MediaPlayerEntity target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this MediaPlayerEntity target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this MediaPlayerEntity target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this MediaPlayerEntity target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this MediaPlayerEntity target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this MediaPlayerEntity target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this MediaPlayerEntity target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this MediaPlayerEntity target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this MediaPlayerEntity target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this MediaPlayerEntity target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this MediaPlayerEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this MediaPlayerEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this MediaPlayerEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_on");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this MediaPlayerEntity target)
		{
			target.CallService("unjoin");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("unjoin");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this MediaPlayerEntity target)
		{
			target.CallService("volume_down");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_down");
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this MediaPlayerEntity target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this MediaPlayerEntity target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this MediaPlayerEntity target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this MediaPlayerEntity target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this MediaPlayerEntity target)
		{
			target.CallService("volume_up");
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_up");
		}
	}

	public static class NumberEntityExtensionMethods
	{
		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this NumberEntity target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this IEnumerable<NumberEntity> target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The NumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this NumberEntity target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The IEnumerable<NumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this IEnumerable<NumberEntity> target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}
	}

	public static class O365EntityExtensionMethods
	{
		///<summary>Create new calendar event</summary>
		public static void CreateCalendarEvent(this CalendarEntity target, O365CreateCalendarEventParameters data)
		{
			target.CallService("create_calendar_event", data);
		}

		///<summary>Create new calendar event</summary>
		public static void CreateCalendarEvent(this IEnumerable<CalendarEntity> target, O365CreateCalendarEventParameters data)
		{
			target.CallService("create_calendar_event", data);
		}

		///<summary>Create new calendar event</summary>
		///<param name="target">The CalendarEntity to call this service for</param>
		///<param name="subject">The subject of the created event eg: Clean up the garage</param>
		///<param name="start">The start time of the event eg: 2023-01-01T12:00:00+0000</param>
		///<param name="end">The end time of the event eg: 2023-01-01T12:30:00+0000</param>
		///<param name="body">The body text for the event (optional) eg: Remember to also clean out the gutters</param>
		///<param name="location">The location for the event (optional) eg: 1600 Pennsylvania Ave Nw, Washington, DC 20500</param>
		///<param name="categories">list of categories for the event (optional)</param>
		///<param name="sensitivity">The sensitivity for the event (optional) [Normal, Personal, Private, Confidential] eg: normal</param>
		///<param name="showAs">Show event as (optional) [Free, Tentative, Busy, Oof, WorkingElsewhere, Unknown] eg: busy</param>
		///<param name="isAllDay">Set whether event is all day (optional) eg: False</param>
		///<param name="attendees">list of attendees formatted as email: example@example.com type: Required, Optional, or Resource (optional)</param>
		public static void CreateCalendarEvent(this CalendarEntity target, string @subject, string @start, string @end, string? @body = null, string? @location = null, string? @categories = null, object? @sensitivity = null, object? @showAs = null, bool? @isAllDay = null, object? @attendees = null)
		{
			target.CallService("create_calendar_event", new O365CreateCalendarEventParameters{Subject = @subject, Start = @start, End = @end, Body = @body, Location = @location, Categories = @categories, Sensitivity = @sensitivity, ShowAs = @showAs, IsAllDay = @isAllDay, Attendees = @attendees});
		}

		///<summary>Create new calendar event</summary>
		///<param name="target">The IEnumerable<CalendarEntity> to call this service for</param>
		///<param name="subject">The subject of the created event eg: Clean up the garage</param>
		///<param name="start">The start time of the event eg: 2023-01-01T12:00:00+0000</param>
		///<param name="end">The end time of the event eg: 2023-01-01T12:30:00+0000</param>
		///<param name="body">The body text for the event (optional) eg: Remember to also clean out the gutters</param>
		///<param name="location">The location for the event (optional) eg: 1600 Pennsylvania Ave Nw, Washington, DC 20500</param>
		///<param name="categories">list of categories for the event (optional)</param>
		///<param name="sensitivity">The sensitivity for the event (optional) [Normal, Personal, Private, Confidential] eg: normal</param>
		///<param name="showAs">Show event as (optional) [Free, Tentative, Busy, Oof, WorkingElsewhere, Unknown] eg: busy</param>
		///<param name="isAllDay">Set whether event is all day (optional) eg: False</param>
		///<param name="attendees">list of attendees formatted as email: example@example.com type: Required, Optional, or Resource (optional)</param>
		public static void CreateCalendarEvent(this IEnumerable<CalendarEntity> target, string @subject, string @start, string @end, string? @body = null, string? @location = null, string? @categories = null, object? @sensitivity = null, object? @showAs = null, bool? @isAllDay = null, object? @attendees = null)
		{
			target.CallService("create_calendar_event", new O365CreateCalendarEventParameters{Subject = @subject, Start = @start, End = @end, Body = @body, Location = @location, Categories = @categories, Sensitivity = @sensitivity, ShowAs = @showAs, IsAllDay = @isAllDay, Attendees = @attendees});
		}

		///<summary>Delete a new task/ToDo</summary>
		public static void DeleteTask(this SensorEntity target, O365DeleteTaskParameters data)
		{
			target.CallService("delete_task", data);
		}

		///<summary>Delete a new task/ToDo</summary>
		public static void DeleteTask(this IEnumerable<SensorEntity> target, O365DeleteTaskParameters data)
		{
			target.CallService("delete_task", data);
		}

		///<summary>Delete a new task/ToDo</summary>
		///<param name="target">The SensorEntity to call this service for</param>
		///<param name="taskId">ID for the task, can be found as an attribute on your task eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		public static void DeleteTask(this SensorEntity target, string @taskId)
		{
			target.CallService("delete_task", new O365DeleteTaskParameters{TaskId = @taskId});
		}

		///<summary>Delete a new task/ToDo</summary>
		///<param name="target">The IEnumerable<SensorEntity> to call this service for</param>
		///<param name="taskId">ID for the task, can be found as an attribute on your task eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		public static void DeleteTask(this IEnumerable<SensorEntity> target, string @taskId)
		{
			target.CallService("delete_task", new O365DeleteTaskParameters{TaskId = @taskId});
		}

		///<summary>Modify existing calendar event, all properties except event_id are optional.</summary>
		public static void ModifyCalendarEvent(this CalendarEntity target, O365ModifyCalendarEventParameters data)
		{
			target.CallService("modify_calendar_event", data);
		}

		///<summary>Modify existing calendar event, all properties except event_id are optional.</summary>
		public static void ModifyCalendarEvent(this IEnumerable<CalendarEntity> target, O365ModifyCalendarEventParameters data)
		{
			target.CallService("modify_calendar_event", data);
		}

		///<summary>Modify existing calendar event, all properties except event_id are optional.</summary>
		///<param name="target">The CalendarEntity to call this service for</param>
		///<param name="eventId">ID for the event, can be found as an attribute on you calendar entity's events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		///<param name="subject">The subject of the created event eg: Clean up the garage</param>
		///<param name="start">The start time of the event eg: 2023-01-01T12:00:00+0000</param>
		///<param name="end">The end time of the event eg: 2023-01-01T12:30:00+0000</param>
		///<param name="body">The body text for the event eg: Remember to also clean out the gutters</param>
		///<param name="location">The location for the event eg: 1600 Pennsylvania Ave Nw, Washington, DC 20500</param>
		///<param name="categories">list of categories for the event</param>
		///<param name="sensitivity">The sensitivity for the event[Normal, Personal, Private, Confidential] eg: normal</param>
		///<param name="showAs">Show event as [Free, Tentative, Busy, Oof, WorkingElsewhere, Unknown] eg: busy</param>
		///<param name="isAllDay">Set whether event is all day eg: False</param>
		///<param name="attendees">list of attendees formatted as email: example@example.com type: Required, Optional, or Resource</param>
		public static void ModifyCalendarEvent(this CalendarEntity target, string @eventId, string? @subject = null, string? @start = null, string? @end = null, string? @body = null, string? @location = null, string? @categories = null, object? @sensitivity = null, object? @showAs = null, bool? @isAllDay = null, object? @attendees = null)
		{
			target.CallService("modify_calendar_event", new O365ModifyCalendarEventParameters{EventId = @eventId, Subject = @subject, Start = @start, End = @end, Body = @body, Location = @location, Categories = @categories, Sensitivity = @sensitivity, ShowAs = @showAs, IsAllDay = @isAllDay, Attendees = @attendees});
		}

		///<summary>Modify existing calendar event, all properties except event_id are optional.</summary>
		///<param name="target">The IEnumerable<CalendarEntity> to call this service for</param>
		///<param name="eventId">ID for the event, can be found as an attribute on you calendar entity's events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		///<param name="subject">The subject of the created event eg: Clean up the garage</param>
		///<param name="start">The start time of the event eg: 2023-01-01T12:00:00+0000</param>
		///<param name="end">The end time of the event eg: 2023-01-01T12:30:00+0000</param>
		///<param name="body">The body text for the event eg: Remember to also clean out the gutters</param>
		///<param name="location">The location for the event eg: 1600 Pennsylvania Ave Nw, Washington, DC 20500</param>
		///<param name="categories">list of categories for the event</param>
		///<param name="sensitivity">The sensitivity for the event[Normal, Personal, Private, Confidential] eg: normal</param>
		///<param name="showAs">Show event as [Free, Tentative, Busy, Oof, WorkingElsewhere, Unknown] eg: busy</param>
		///<param name="isAllDay">Set whether event is all day eg: False</param>
		///<param name="attendees">list of attendees formatted as email: example@example.com type: Required, Optional, or Resource</param>
		public static void ModifyCalendarEvent(this IEnumerable<CalendarEntity> target, string @eventId, string? @subject = null, string? @start = null, string? @end = null, string? @body = null, string? @location = null, string? @categories = null, object? @sensitivity = null, object? @showAs = null, bool? @isAllDay = null, object? @attendees = null)
		{
			target.CallService("modify_calendar_event", new O365ModifyCalendarEventParameters{EventId = @eventId, Subject = @subject, Start = @start, End = @end, Body = @body, Location = @location, Categories = @categories, Sensitivity = @sensitivity, ShowAs = @showAs, IsAllDay = @isAllDay, Attendees = @attendees});
		}

		///<summary>Create a new task/ToDo</summary>
		public static void NewTask(this SensorEntity target, O365NewTaskParameters data)
		{
			target.CallService("new_task", data);
		}

		///<summary>Create a new task/ToDo</summary>
		public static void NewTask(this IEnumerable<SensorEntity> target, O365NewTaskParameters data)
		{
			target.CallService("new_task", data);
		}

		///<summary>Create a new task/ToDo</summary>
		///<param name="target">The SensorEntity to call this service for</param>
		///<param name="subject">The subject of the task eg: Pick up the mail</param>
		///<param name="description">Description of the task eg: Walk to the post box and collect the mail</param>
		///<param name="due">When the task is due by eg: YYYY-MM-DD</param>
		///<param name="reminder">When a reminder is needed eg: 2023-01-01T12:00:00+0000</param>
		public static void NewTask(this SensorEntity target, string @subject, string? @description = null, object? @due = null, string? @reminder = null)
		{
			target.CallService("new_task", new O365NewTaskParameters{Subject = @subject, Description = @description, Due = @due, Reminder = @reminder});
		}

		///<summary>Create a new task/ToDo</summary>
		///<param name="target">The IEnumerable<SensorEntity> to call this service for</param>
		///<param name="subject">The subject of the task eg: Pick up the mail</param>
		///<param name="description">Description of the task eg: Walk to the post box and collect the mail</param>
		///<param name="due">When the task is due by eg: YYYY-MM-DD</param>
		///<param name="reminder">When a reminder is needed eg: 2023-01-01T12:00:00+0000</param>
		public static void NewTask(this IEnumerable<SensorEntity> target, string @subject, string? @description = null, object? @due = null, string? @reminder = null)
		{
			target.CallService("new_task", new O365NewTaskParameters{Subject = @subject, Description = @description, Due = @due, Reminder = @reminder});
		}

		///<summary>Delete calendar event</summary>
		public static void RemoveCalendarEvent(this CalendarEntity target, O365RemoveCalendarEventParameters data)
		{
			target.CallService("remove_calendar_event", data);
		}

		///<summary>Delete calendar event</summary>
		public static void RemoveCalendarEvent(this IEnumerable<CalendarEntity> target, O365RemoveCalendarEventParameters data)
		{
			target.CallService("remove_calendar_event", data);
		}

		///<summary>Delete calendar event</summary>
		///<param name="target">The CalendarEntity to call this service for</param>
		///<param name="eventId">ID for the event, can be found as an attribute on you calendar entity's events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		public static void RemoveCalendarEvent(this CalendarEntity target, string @eventId)
		{
			target.CallService("remove_calendar_event", new O365RemoveCalendarEventParameters{EventId = @eventId});
		}

		///<summary>Delete calendar event</summary>
		///<param name="target">The IEnumerable<CalendarEntity> to call this service for</param>
		///<param name="eventId">ID for the event, can be found as an attribute on you calendar entity's events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		public static void RemoveCalendarEvent(this IEnumerable<CalendarEntity> target, string @eventId)
		{
			target.CallService("remove_calendar_event", new O365RemoveCalendarEventParameters{EventId = @eventId});
		}

		///<summary>Respond to calendar event/invite</summary>
		public static void RespondCalendarEvent(this CalendarEntity target, O365RespondCalendarEventParameters data)
		{
			target.CallService("respond_calendar_event", data);
		}

		///<summary>Respond to calendar event/invite</summary>
		public static void RespondCalendarEvent(this IEnumerable<CalendarEntity> target, O365RespondCalendarEventParameters data)
		{
			target.CallService("respond_calendar_event", data);
		}

		///<summary>Respond to calendar event/invite</summary>
		///<param name="target">The CalendarEntity to call this service for</param>
		///<param name="eventId">ID for event, can be found as an attribute on you calendar entity's events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		///<param name="response">The response to the invite [Accept, Tentative, Decline] eg: Decline</param>
		///<param name="message">The response message to the invite (Optional) eg: I cannot attend this meeting</param>
		///<param name="sendResponse">Send the response to the organizer (Optional) eg: True</param>
		public static void RespondCalendarEvent(this CalendarEntity target, string @eventId, string @response, string? @message = null, bool? @sendResponse = null)
		{
			target.CallService("respond_calendar_event", new O365RespondCalendarEventParameters{EventId = @eventId, Response = @response, Message = @message, SendResponse = @sendResponse});
		}

		///<summary>Respond to calendar event/invite</summary>
		///<param name="target">The IEnumerable<CalendarEntity> to call this service for</param>
		///<param name="eventId">ID for event, can be found as an attribute on you calendar entity's events eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		///<param name="response">The response to the invite [Accept, Tentative, Decline] eg: Decline</param>
		///<param name="message">The response message to the invite (Optional) eg: I cannot attend this meeting</param>
		///<param name="sendResponse">Send the response to the organizer (Optional) eg: True</param>
		public static void RespondCalendarEvent(this IEnumerable<CalendarEntity> target, string @eventId, string @response, string? @message = null, bool? @sendResponse = null)
		{
			target.CallService("respond_calendar_event", new O365RespondCalendarEventParameters{EventId = @eventId, Response = @response, Message = @message, SendResponse = @sendResponse});
		}

		///<summary>Update a new task/ToDo</summary>
		public static void UpdateTask(this SensorEntity target, O365UpdateTaskParameters data)
		{
			target.CallService("update_task", data);
		}

		///<summary>Update a new task/ToDo</summary>
		public static void UpdateTask(this IEnumerable<SensorEntity> target, O365UpdateTaskParameters data)
		{
			target.CallService("update_task", data);
		}

		///<summary>Update a new task/ToDo</summary>
		///<param name="target">The SensorEntity to call this service for</param>
		///<param name="taskId">ID for the task, can be found as an attribute on your task eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		///<param name="subject">The subject of the task eg: Pick up the mail</param>
		///<param name="description">Description of the task eg: Walk to the post box and collect the mail</param>
		///<param name="due">When the task is due by eg: 2023-01-01</param>
		///<param name="reminder">When a reminder is needed eg: 2023-01-01T12:00:00+0000</param>
		public static void UpdateTask(this SensorEntity target, string @taskId, string? @subject = null, string? @description = null, object? @due = null, string? @reminder = null)
		{
			target.CallService("update_task", new O365UpdateTaskParameters{TaskId = @taskId, Subject = @subject, Description = @description, Due = @due, Reminder = @reminder});
		}

		///<summary>Update a new task/ToDo</summary>
		///<param name="target">The IEnumerable<SensorEntity> to call this service for</param>
		///<param name="taskId">ID for the task, can be found as an attribute on your task eg: xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</param>
		///<param name="subject">The subject of the task eg: Pick up the mail</param>
		///<param name="description">Description of the task eg: Walk to the post box and collect the mail</param>
		///<param name="due">When the task is due by eg: 2023-01-01</param>
		///<param name="reminder">When a reminder is needed eg: 2023-01-01T12:00:00+0000</param>
		public static void UpdateTask(this IEnumerable<SensorEntity> target, string @taskId, string? @subject = null, string? @description = null, object? @due = null, string? @reminder = null)
		{
			target.CallService("update_task", new O365UpdateTaskParameters{TaskId = @taskId, Subject = @subject, Description = @description, Due = @due, Reminder = @reminder});
		}
	}

	public static class RemoteEntityExtensionMethods
	{
		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this RemoteEntity target, RemoteDeleteCommandParameters data)
		{
			target.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this IEnumerable<RemoteEntity> target, RemoteDeleteCommandParameters data)
		{
			target.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this RemoteEntity target, object @command, string? @device = null)
		{
			target.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this IEnumerable<RemoteEntity> target, object @command, string? @device = null)
		{
			target.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this RemoteEntity target, RemoteLearnCommandParameters data)
		{
			target.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this IEnumerable<RemoteEntity> target, RemoteLearnCommandParameters data)
		{
			target.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this RemoteEntity target, string? @device = null, object? @command = null, object? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			target.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this IEnumerable<RemoteEntity> target, string? @device = null, object? @command = null, object? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			target.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this RemoteEntity target, RemoteSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this IEnumerable<RemoteEntity> target, RemoteSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this RemoteEntity target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			target.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this IEnumerable<RemoteEntity> target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			target.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this RemoteEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this RemoteEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this RemoteEntity target, RemoteTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this IEnumerable<RemoteEntity> target, RemoteTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this RemoteEntity target, string? @activity = null)
		{
			target.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this IEnumerable<RemoteEntity> target, string? @activity = null)
		{
			target.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public static class SelectEntityExtensionMethods
	{
		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this SelectEntity target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this IEnumerable<SelectEntity> target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The SelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this SelectEntity target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The IEnumerable<SelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<SelectEntity> target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		///<summary>Toggles a switch state</summary>
		public static void Toggle(this SwitchEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a switch state</summary>
		public static void Toggle(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this SwitchEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this SwitchEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class TimerEntityExtensionMethods
	{
		///<summary>Cancel a timer.</summary>
		public static void Cancel(this TimerEntity target)
		{
			target.CallService("cancel");
		}

		///<summary>Cancel a timer.</summary>
		public static void Cancel(this IEnumerable<TimerEntity> target)
		{
			target.CallService("cancel");
		}

		///<summary>Finish a timer.</summary>
		public static void Finish(this TimerEntity target)
		{
			target.CallService("finish");
		}

		///<summary>Finish a timer.</summary>
		public static void Finish(this IEnumerable<TimerEntity> target)
		{
			target.CallService("finish");
		}

		///<summary>Pause a timer.</summary>
		public static void Pause(this TimerEntity target)
		{
			target.CallService("pause");
		}

		///<summary>Pause a timer.</summary>
		public static void Pause(this IEnumerable<TimerEntity> target)
		{
			target.CallService("pause");
		}

		///<summary>Start a timer</summary>
		public static void Start(this TimerEntity target, TimerStartParameters data)
		{
			target.CallService("start", data);
		}

		///<summary>Start a timer</summary>
		public static void Start(this IEnumerable<TimerEntity> target, TimerStartParameters data)
		{
			target.CallService("start", data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The TimerEntity to call this service for</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public static void Start(this TimerEntity target, string? @duration = null)
		{
			target.CallService("start", new TimerStartParameters{Duration = @duration});
		}

		///<summary>Start a timer</summary>
		///<param name="target">The IEnumerable<TimerEntity> to call this service for</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public static void Start(this IEnumerable<TimerEntity> target, string? @duration = null)
		{
			target.CallService("start", new TimerStartParameters{Duration = @duration});
		}
	}

	public static class UpdateEntityExtensionMethods
	{
		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this UpdateEntity target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this UpdateEntity target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this IEnumerable<UpdateEntity> target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The UpdateEntity to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this UpdateEntity target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The IEnumerable<UpdateEntity> to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this IEnumerable<UpdateEntity> target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this UpdateEntity target)
		{
			target.CallService("skip");
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("skip");
		}
	}

	public static class VacuumEntityExtensionMethods
	{
		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this VacuumEntity target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this VacuumEntity target)
		{
			target.CallService("locate");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("locate");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this VacuumEntity target)
		{
			target.CallService("pause");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("pause");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this VacuumEntity target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this VacuumEntity target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this VacuumEntity target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this VacuumEntity target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this VacuumEntity target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this VacuumEntity target)
		{
			target.CallService("start");
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this VacuumEntity target)
		{
			target.CallService("start_pause");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start_pause");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this VacuumEntity target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this VacuumEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this VacuumEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class XiaomiMiioEntityExtensionMethods
	{
		///<summary>Start cleaning of the specified segment(s).</summary>
		public static void VacuumCleanSegment(this VacuumEntity target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			target.CallService("vacuum_clean_segment", data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		public static void VacuumCleanSegment(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			target.CallService("vacuum_clean_segment", data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public static void VacuumCleanSegment(this VacuumEntity target, object? @segments = null)
		{
			target.CallService("vacuum_clean_segment", new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public static void VacuumCleanSegment(this IEnumerable<VacuumEntity> target, object? @segments = null)
		{
			target.CallService("vacuum_clean_segment", new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		public static void VacuumCleanZone(this VacuumEntity target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			target.CallService("vacuum_clean_zone", data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		public static void VacuumCleanZone(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			target.CallService("vacuum_clean_zone", data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public static void VacuumCleanZone(this VacuumEntity target, object? @zone = null, long? @repeats = null)
		{
			target.CallService("vacuum_clean_zone", new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public static void VacuumCleanZone(this IEnumerable<VacuumEntity> target, object? @zone = null, long? @repeats = null)
		{
			target.CallService("vacuum_clean_zone", new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Go to the specified coordinates.</summary>
		public static void VacuumGoto(this VacuumEntity target, XiaomiMiioVacuumGotoParameters data)
		{
			target.CallService("vacuum_goto", data);
		}

		///<summary>Go to the specified coordinates.</summary>
		public static void VacuumGoto(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumGotoParameters data)
		{
			target.CallService("vacuum_goto", data);
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public static void VacuumGoto(this VacuumEntity target, string? @xCoord = null, string? @yCoord = null)
		{
			target.CallService("vacuum_goto", new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public static void VacuumGoto(this IEnumerable<VacuumEntity> target, string? @xCoord = null, string? @yCoord = null)
		{
			target.CallService("vacuum_goto", new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		public static void VacuumRemoteControlMove(this VacuumEntity target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			target.CallService("vacuum_remote_control_move", data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		public static void VacuumRemoteControlMove(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			target.CallService("vacuum_remote_control_move", data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMove(this VacuumEntity target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move", new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMove(this IEnumerable<VacuumEntity> target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move", new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		public static void VacuumRemoteControlMoveStep(this VacuumEntity target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			target.CallService("vacuum_remote_control_move_step", data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		public static void VacuumRemoteControlMoveStep(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			target.CallService("vacuum_remote_control_move_step", data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMoveStep(this VacuumEntity target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move_step", new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMoveStep(this IEnumerable<VacuumEntity> target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move_step", new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		public static void VacuumRemoteControlStart(this VacuumEntity target)
		{
			target.CallService("vacuum_remote_control_start");
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		public static void VacuumRemoteControlStart(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("vacuum_remote_control_start");
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		public static void VacuumRemoteControlStop(this VacuumEntity target)
		{
			target.CallService("vacuum_remote_control_stop");
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		public static void VacuumRemoteControlStop(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("vacuum_remote_control_stop");
		}
	}
}