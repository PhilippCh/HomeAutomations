using System;
using System.Collections.Generic;

namespace HomeAssistantGenerated
{
	public interface IEntities
	{
		AlarmControlPanelEntities AlarmControlPanel { get; }

		BinarySensorEntities BinarySensor { get; }

		CalendarEntities Calendar { get; }

		CameraEntities Camera { get; }

		ClimateEntities Climate { get; }

		CounterEntities Counter { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		GroupEntities Group { get; }

		InputBooleanEntities InputBoolean { get; }

		InputNumberEntities InputNumber { get; }

		InputSelectEntities InputSelect { get; }

		LightEntities Light { get; }

		MediaPlayerEntities MediaPlayer { get; }

		PersonEntities Person { get; }

		RemoteEntities Remote { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		TimerEntities Timer { get; }

		VacuumEntities Vacuum { get; }

		VarEntities Var { get; }

		WeatherEntities Weather { get; }

		ZoneEntities Zone { get; }
	}

	public class Entities : IEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public Entities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelEntities AlarmControlPanel => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public CalendarEntities Calendar => new(_haContext);
		public CameraEntities Camera => new(_haContext);
		public ClimateEntities Climate => new(_haContext);
		public CounterEntities Counter => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public GroupEntities Group => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public InputNumberEntities InputNumber => new(_haContext);
		public InputSelectEntities InputSelect => new(_haContext);
		public LightEntities Light => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public RemoteEntities Remote => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public TimerEntities Timer => new(_haContext);
		public VacuumEntities Vacuum => new(_haContext);
		public VarEntities Var => new(_haContext);
		public WeatherEntities Weather => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public class AlarmControlPanelEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public AlarmControlPanelEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelEntity IntrusionDetectionSystem => new(_haContext, "alarm_control_panel.intrusion_detection_system");
	}

	public class BinarySensorEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public BinarySensorEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public BinarySensorEntity BalkonturLinks => new(_haContext, "binary_sensor.balkontur_links");
		public BinarySensorEntity BalkonturLinksBattery => new(_haContext, "binary_sensor.balkontur_links_battery");
		public BinarySensorEntity BalkonturRechts => new(_haContext, "binary_sensor.balkontur_rechts");
		public BinarySensorEntity BalkonturRechtsBattery => new(_haContext, "binary_sensor.balkontur_rechts_battery");
		public BinarySensorEntity Desktopfabienne => new(_haContext, "binary_sensor.desktopfabienne");
		public BinarySensorEntity Desktopphilipp => new(_haContext, "binary_sensor.desktopphilipp");
		public BinarySensorEntity FensterArbeitszimmer => new(_haContext, "binary_sensor.fenster_arbeitszimmer");
		public BinarySensorEntity FensterArbeitszimmerBattery => new(_haContext, "binary_sensor.fenster_arbeitszimmer_battery");
		public BinarySensorEntity FensterBadezimmer => new(_haContext, "binary_sensor.fenster_badezimmer");
		public BinarySensorEntity FensterBadezimmerBattery => new(_haContext, "binary_sensor.fenster_badezimmer_battery");
		public BinarySensorEntity FensterSchlafzimmer => new(_haContext, "binary_sensor.fenster_schlafzimmer");
		public BinarySensorEntity FensterSchlafzimmerBattery => new(_haContext, "binary_sensor.fenster_schlafzimmer_battery");
		public BinarySensorEntity IphonePhilippFocus => new(_haContext, "binary_sensor.iphone_philipp_focus");
		public BinarySensorEntity Laptopfabienne => new(_haContext, "binary_sensor.laptopfabienne");
		public BinarySensorEntity Laptopphilipp => new(_haContext, "binary_sensor.laptopphilipp");
		public BinarySensorEntity Motionsensorbedroom => new(_haContext, "binary_sensor.motionsensorbedroom");
		public BinarySensorEntity Nodered34b1e88b368528 => new(_haContext, "binary_sensor.nodered_34b1e88b_368528");
		public BinarySensorEntity PupsstationDrive1BelowMinRemainingLife => new(_haContext, "binary_sensor.pupsstation_drive_1_below_min_remaining_life");
		public BinarySensorEntity PupsstationDrive1ExceededMaxBadSectors => new(_haContext, "binary_sensor.pupsstation_drive_1_exceeded_max_bad_sectors");
		public BinarySensorEntity PupsstationDrive2BelowMinRemainingLife => new(_haContext, "binary_sensor.pupsstation_drive_2_below_min_remaining_life");
		public BinarySensorEntity PupsstationDrive2ExceededMaxBadSectors => new(_haContext, "binary_sensor.pupsstation_drive_2_exceeded_max_bad_sectors");
		public BinarySensorEntity PupsstationSecurityStatus => new(_haContext, "binary_sensor.pupsstation_security_status");
		public BinarySensorEntity PupsstationUpdateAvailable => new(_haContext, "binary_sensor.pupsstation_update_available");
		public BinarySensorEntity ThermostatArbeitszimmerBattery => new(_haContext, "binary_sensor.thermostat_arbeitszimmer_battery");
		public BinarySensorEntity ThermostatBadezimmerBattery => new(_haContext, "binary_sensor.thermostat_badezimmer_battery");
		public BinarySensorEntity ThermostatSchlafzimmerBattery => new(_haContext, "binary_sensor.thermostat_schlafzimmer_battery");
		public BinarySensorEntity ThermostatWohnzimmerBattery => new(_haContext, "binary_sensor.thermostat_wohnzimmer_battery");
		public BinarySensorEntity TrashBio => new(_haContext, "binary_sensor.trash_bio");
		public BinarySensorEntity TrashGlass => new(_haContext, "binary_sensor.trash_glass");
		public BinarySensorEntity TrashPaper => new(_haContext, "binary_sensor.trash_paper");
		public BinarySensorEntity TrashRecycling => new(_haContext, "binary_sensor.trash_recycling");
		public BinarySensorEntity TrashWaste => new(_haContext, "binary_sensor.trash_waste");
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
	}

	public class CalendarEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CalendarEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public CalendarEntity Abfallleerungen => new(_haContext, "calendar.abfallleerungen");
		public CalendarEntity Birthdays => new(_haContext, "calendar.birthdays");
		public CalendarEntity Christoph680GmxDe => new(_haContext, "calendar.christoph680_gmx_de");
		public CalendarEntity Family => new(_haContext, "calendar.family");
		public CalendarEntity FeiertageInDeutschland => new(_haContext, "calendar.feiertage_in_deutschland");
	}

	public class CameraEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CameraEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public CameraEntity FantenrusselMap => new(_haContext, "camera.fantenrussel_map");
		public CameraEntity WohnzimmerCamera => new(_haContext, "camera.wohnzimmer_camera");
	}

	public class ClimateEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ClimateEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public ClimateEntity RoomClimateArbeitszimmer => new(_haContext, "climate.room_climate_arbeitszimmer");
		public ClimateEntity RoomClimateBadezimmer => new(_haContext, "climate.room_climate_badezimmer");
		public ClimateEntity RoomClimateSchlafzimmer => new(_haContext, "climate.room_climate_schlafzimmer");
		public ClimateEntity RoomClimateWohnzimmer => new(_haContext, "climate.room_climate_wohnzimmer");
	}

	public class CounterEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CounterEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public CounterEntity KratomIntakeDay => new(_haContext, "counter.kratom_intake_day");
		public CounterEntity MeditationMinutesWeek => new(_haContext, "counter.meditation_minutes_week");
	}

	public class DeviceTrackerEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public DeviceTrackerEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public DeviceTrackerEntity Fabienne => new(_haContext, "device_tracker.fabienne");
		public DeviceTrackerEntity IpadVonFabienne => new(_haContext, "device_tracker.ipad_von_fabienne");
		public DeviceTrackerEntity Philipp2b775363D7b348719abc6f36aa202757 => new(_haContext, "device_tracker.philipp_2b775363_d7b3_4871_9abc_6f36aa202757");
		public DeviceTrackerEntity PhilippsIphone2 => new(_haContext, "device_tracker.philipps_iphone_2");
		public DeviceTrackerEntity PhilippsIphone3 => new(_haContext, "device_tracker.philipps_iphone_3");
	}

	public class GroupEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public GroupEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public GroupEntity Allwindows => new(_haContext, "group.allwindows");
	}

	public class InputBooleanEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputBooleanEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public InputBooleanEntity BarcodeScannerConnected => new(_haContext, "input_boolean.barcode_scanner_connected");
		public InputBooleanEntity MeditationActive => new(_haContext, "input_boolean.meditation_active");
	}

	public class InputNumberEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputNumberEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public InputNumberEntity KratomIntakeDaily => new(_haContext, "input_number.kratom_intake_daily");
		public InputNumberEntity MaxShavesBeforeChange => new(_haContext, "input_number.max_shaves_before_change");
		public InputNumberEntity MeditationTimerMinutes => new(_haContext, "input_number.meditation_timer_minutes");
	}

	public class InputSelectEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputSelectEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public InputSelectEntity ChromeRemoteMediaControlDevices => new(_haContext, "input_select.chrome_remote_media_control_devices");
		public InputSelectEntity MoonlightSelectedGame => new(_haContext, "input_select.moonlight_selected_game");
		public InputSelectEntity MoonlightSelectedHost => new(_haContext, "input_select.moonlight_selected_host");
	}

	public class LightEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LightEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public LightEntity E31322600840d8ebd93a7 => new(_haContext, "light.31322600840d8ebd93a7");
		public LightEntity Bf86d365c4be26b921xfsz => new(_haContext, "light.bf86d365c4be26b921xfsz");
		public LightEntity Bfb81fd992b98475f8tc6r => new(_haContext, "light.bfb81fd992b98475f8tc6r");
		public LightEntity NachttischFup => new(_haContext, "light.nachttisch_fup");
		public LightEntity NachttischPup => new(_haContext, "light.nachttisch_pup");
	}

	public class MediaPlayerEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public MediaPlayerEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public MediaPlayerEntity MasterBedroomSpeaker => new(_haContext, "media_player.master_bedroom_speaker");
		public MediaPlayerEntity SpotifyPhilippChristoph => new(_haContext, "media_player.spotify_philipp_christoph");
	}

	public class PersonEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public PersonEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public PersonEntity Philipp => new(_haContext, "person.philipp");
	}

	public class RemoteEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public RemoteEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public RemoteEntity HarmonyHub => new(_haContext, "remote.harmony_hub");
	}

	public class SensorEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SensorEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public SensorEntity E0x00158d0006269246Action => new(_haContext, "sensor.0x00158d0006269246_action");
		public SensorEntity E0x00158d0006269246Battery => new(_haContext, "sensor.0x00158d0006269246_battery");
		public SensorEntity E0x00158d0006269246Click => new(_haContext, "sensor.0x00158d0006269246_click");
		public SensorEntity E0x00158d0006269246Linkquality => new(_haContext, "sensor.0x00158d0006269246_linkquality");
		public SensorEntity E0x00158d0006269246Voltage => new(_haContext, "sensor.0x00158d0006269246_voltage");
		public SensorEntity E0x00158d0006397c0fAction => new(_haContext, "sensor.0x00158d0006397c0f_action");
		public SensorEntity E0x00158d0006397c0fBattery => new(_haContext, "sensor.0x00158d0006397c0f_battery");
		public SensorEntity E0x00158d0006397c0fClick => new(_haContext, "sensor.0x00158d0006397c0f_click");
		public SensorEntity E0x00158d0006397c0fLinkquality => new(_haContext, "sensor.0x00158d0006397c0f_linkquality");
		public SensorEntity E0x00158d0006397c0fVoltage => new(_haContext, "sensor.0x00158d0006397c0f_voltage");
		public SensorEntity E0x00158d000678ed45Action => new(_haContext, "sensor.0x00158d000678ed45_action");
		public SensorEntity E0x00158d000678ed45Battery => new(_haContext, "sensor.0x00158d000678ed45_battery");
		public SensorEntity E0x00158d000678ed45Click => new(_haContext, "sensor.0x00158d000678ed45_click");
		public SensorEntity E0x00158d000678ed45Linkquality => new(_haContext, "sensor.0x00158d000678ed45_linkquality");
		public SensorEntity E0x00158d000678ed45Voltage => new(_haContext, "sensor.0x00158d000678ed45_voltage");
		public SensorEntity E0x54ef441000035f82Battery => new(_haContext, "sensor.0x54ef441000035f82_battery");
		public SensorEntity E0x54ef441000035f82Illuminance => new(_haContext, "sensor.0x54ef441000035f82_illuminance");
		public SensorEntity E0x54ef441000035f82IlluminanceLux => new(_haContext, "sensor.0x54ef441000035f82_illuminance_lux");
		public SensorEntity E0x54ef441000035f82Linkquality => new(_haContext, "sensor.0x54ef441000035f82_linkquality");
		public SensorEntity AmcEntertainmentHoldingsInc => new(_haContext, "sensor.amc_entertainment_holdings_inc");
		public SensorEntity BarcodeScannerConnected => new(_haContext, "sensor.barcode_scanner_connected");
		public SensorEntity BlackberryLtd => new(_haContext, "sensor.blackberry_ltd");
		public SensorEntity CatFoodCounter2 => new(_haContext, "sensor.cat_food_counter_2");
		public SensorEntity CoreDax => new(_haContext, "sensor.core_dax");
		public SensorEntity FabienneHerionLastUpdate => new(_haContext, "sensor.fabienne_herion_last_update");
		public SensorEntity FantenpadActivity => new(_haContext, "sensor.fantenpad_activity");
		public SensorEntity FantenpadBatteryLevel => new(_haContext, "sensor.fantenpad_battery_level");
		public SensorEntity FantenpadBatteryState => new(_haContext, "sensor.fantenpad_battery_state");
		public SensorEntity FantenpadBssid => new(_haContext, "sensor.fantenpad_bssid");
		public SensorEntity FantenpadConnectionType => new(_haContext, "sensor.fantenpad_connection_type");
		public SensorEntity FantenpadGeocodedLocation => new(_haContext, "sensor.fantenpad_geocoded_location");
		public SensorEntity FantenpadLastUpdateTrigger => new(_haContext, "sensor.fantenpad_last_update_trigger");
		public SensorEntity FantenpadSsid => new(_haContext, "sensor.fantenpad_ssid");
		public SensorEntity FantenpadStorage => new(_haContext, "sensor.fantenpad_storage");
		public SensorEntity FantenphoneActivity => new(_haContext, "sensor.fantenphone_activity");
		public SensorEntity FantenphoneAverageActivePace => new(_haContext, "sensor.fantenphone_average_active_pace");
		public SensorEntity FantenphoneBatteryLevel => new(_haContext, "sensor.fantenphone_battery_level");
		public SensorEntity FantenphoneBatteryState => new(_haContext, "sensor.fantenphone_battery_state");
		public SensorEntity FantenphoneBssid => new(_haContext, "sensor.fantenphone_bssid");
		public SensorEntity FantenphoneConnectionType => new(_haContext, "sensor.fantenphone_connection_type");
		public SensorEntity FantenphoneDistance => new(_haContext, "sensor.fantenphone_distance");
		public SensorEntity FantenphoneFloorsAscended => new(_haContext, "sensor.fantenphone_floors_ascended");
		public SensorEntity FantenphoneFloorsDescended => new(_haContext, "sensor.fantenphone_floors_descended");
		public SensorEntity FantenphoneGeocodedLocation => new(_haContext, "sensor.fantenphone_geocoded_location");
		public SensorEntity FantenphoneLastUpdateTrigger => new(_haContext, "sensor.fantenphone_last_update_trigger");
		public SensorEntity FantenphoneSim1 => new(_haContext, "sensor.fantenphone_sim_1");
		public SensorEntity FantenphoneSim2 => new(_haContext, "sensor.fantenphone_sim_2");
		public SensorEntity FantenphoneSsid => new(_haContext, "sensor.fantenphone_ssid");
		public SensorEntity FantenphoneSteps => new(_haContext, "sensor.fantenphone_steps");
		public SensorEntity FantenphoneStorage => new(_haContext, "sensor.fantenphone_storage");
		public SensorEntity GamestopCorp => new(_haContext, "sensor.gamestop_corp");
		public SensorEntity GlancesAcpitz1Temperature => new(_haContext, "sensor.glances_acpitz_1_temperature");
		public SensorEntity GlancesAcpitz2Temperature => new(_haContext, "sensor.glances_acpitz_2_temperature");
		public SensorEntity GlancesContainersActive => new(_haContext, "sensor.glances_containers_active");
		public SensorEntity GlancesContainersCpuUsed => new(_haContext, "sensor.glances_containers_cpu_used");
		public SensorEntity GlancesContainersRamUsed => new(_haContext, "sensor.glances_containers_ram_used");
		public SensorEntity GlancesCore0Temperature => new(_haContext, "sensor.glances_core_0_temperature");
		public SensorEntity GlancesCore1Temperature => new(_haContext, "sensor.glances_core_1_temperature");
		public SensorEntity GlancesCore2Temperature => new(_haContext, "sensor.glances_core_2_temperature");
		public SensorEntity GlancesCore3Temperature => new(_haContext, "sensor.glances_core_3_temperature");
		public SensorEntity GlancesCpuLoad => new(_haContext, "sensor.glances_cpu_load");
		public SensorEntity GlancesCpuUsed => new(_haContext, "sensor.glances_cpu_used");
		public SensorEntity GlancesFree => new(_haContext, "sensor.glances_free");
		public SensorEntity GlancesPackageId0Temperature => new(_haContext, "sensor.glances_package_id_0_temperature");
		public SensorEntity GlancesRamFree => new(_haContext, "sensor.glances_ram_free");
		public SensorEntity GlancesRamUsed => new(_haContext, "sensor.glances_ram_used");
		public SensorEntity GlancesRamUsedPercent => new(_haContext, "sensor.glances_ram_used_percent");
		public SensorEntity GlancesRunning => new(_haContext, "sensor.glances_running");
		public SensorEntity GlancesSleeping => new(_haContext, "sensor.glances_sleeping");
		public SensorEntity GlancesSwapFree => new(_haContext, "sensor.glances_swap_free");
		public SensorEntity GlancesSwapUsed => new(_haContext, "sensor.glances_swap_used");
		public SensorEntity GlancesSwapUsedPercent => new(_haContext, "sensor.glances_swap_used_percent");
		public SensorEntity GlancesThread => new(_haContext, "sensor.glances_thread");
		public SensorEntity GlancesTotal => new(_haContext, "sensor.glances_total");
		public SensorEntity GlancesUsed => new(_haContext, "sensor.glances_used");
		public SensorEntity GlancesUsedPercent => new(_haContext, "sensor.glances_used_percent");
		public SensorEntity GlancesVarLibKubeletPods007aa4c82a8b49c8A65eB6ed355f1b5aVolumeSubpathsConfigMariadb1Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_007aa4c8_2a8b_49c8_a65e_b6ed355f1b5a_volume_subpaths_config_mariadb_1_free");
		public SensorEntity GlancesVarLibKubeletPods007aa4c82a8b49c8A65eB6ed355f1b5aVolumeSubpathsConfigMariadb1Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_007aa4c8_2a8b_49c8_a65e_b6ed355f1b5a_volume_subpaths_config_mariadb_1_used");
		public SensorEntity GlancesVarLibKubeletPods007aa4c82a8b49c8A65eB6ed355f1b5aVolumeSubpathsConfigMariadb1UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_007aa4c8_2a8b_49c8_a65e_b6ed355f1b5a_volume_subpaths_config_mariadb_1_used_percent");
		public SensorEntity GlancesVarLibKubeletPods04b77e41A7384e78Bd65160022a13dbaVolumeSubpathsMosquittoConfigMosquitto0Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_04b77e41_a738_4e78_bd65_160022a13dba_volume_subpaths_mosquitto_config_mosquitto_0_free");
		public SensorEntity GlancesVarLibKubeletPods04b77e41A7384e78Bd65160022a13dbaVolumeSubpathsMosquittoConfigMosquitto0Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_04b77e41_a738_4e78_bd65_160022a13dba_volume_subpaths_mosquitto_config_mosquitto_0_used");
		public SensorEntity GlancesVarLibKubeletPods04b77e41A7384e78Bd65160022a13dbaVolumeSubpathsMosquittoConfigMosquitto0UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_04b77e41_a738_4e78_bd65_160022a13dba_volume_subpaths_mosquitto_config_mosquitto_0_used_percent");
		public SensorEntity GlancesVarLibKubeletPodsF0edab553def49c1833c4f1788b40431VolumeSubpathsConfigMariadb1Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_f0edab55_3def_49c1_833c_4f1788b40431_volume_subpaths_config_mariadb_1_free");
		public SensorEntity GlancesVarLibKubeletPodsF0edab553def49c1833c4f1788b40431VolumeSubpathsConfigMariadb1Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_f0edab55_3def_49c1_833c_4f1788b40431_volume_subpaths_config_mariadb_1_used");
		public SensorEntity GlancesVarLibKubeletPodsF0edab553def49c1833c4f1788b40431VolumeSubpathsConfigMariadb1UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_f0edab55_3def_49c1_833c_4f1788b40431_volume_subpaths_config_mariadb_1_used_percent");
		public SensorEntity Hacs => new(_haContext, "sensor.hacs");
		public SensorEntity IphonePhilippActivity => new(_haContext, "sensor.iphone_philipp_activity");
		public SensorEntity IphonePhilippAverageActivePace => new(_haContext, "sensor.iphone_philipp_average_active_pace");
		public SensorEntity IphonePhilippBatteryLevel => new(_haContext, "sensor.iphone_philipp_battery_level");
		public SensorEntity IphonePhilippBatteryState => new(_haContext, "sensor.iphone_philipp_battery_state");
		public SensorEntity IphonePhilippBssid => new(_haContext, "sensor.iphone_philipp_bssid");
		public SensorEntity IphonePhilippConnectionType => new(_haContext, "sensor.iphone_philipp_connection_type");
		public SensorEntity IphonePhilippDistance => new(_haContext, "sensor.iphone_philipp_distance");
		public SensorEntity IphonePhilippFloorsAscended => new(_haContext, "sensor.iphone_philipp_floors_ascended");
		public SensorEntity IphonePhilippFloorsDescended => new(_haContext, "sensor.iphone_philipp_floors_descended");
		public SensorEntity IphonePhilippGeocodedLocation => new(_haContext, "sensor.iphone_philipp_geocoded_location");
		public SensorEntity IphonePhilippLastUpdateTrigger => new(_haContext, "sensor.iphone_philipp_last_update_trigger");
		public SensorEntity IphonePhilippSim1 => new(_haContext, "sensor.iphone_philipp_sim_1");
		public SensorEntity IphonePhilippSsid => new(_haContext, "sensor.iphone_philipp_ssid");
		public SensorEntity IphonePhilippSteps => new(_haContext, "sensor.iphone_philipp_steps");
		public SensorEntity IphonePhilippStorage => new(_haContext, "sensor.iphone_philipp_storage");
		public SensorEntity Lufthansa => new(_haContext, "sensor.lufthansa");
		public SensorEntity MetroAg => new(_haContext, "sensor.metro_ag");
		public SensorEntity MyBitcoins2 => new(_haContext, "sensor.my_bitcoins_2");
		public SensorEntity MyBitcoins3 => new(_haContext, "sensor.my_bitcoins_3");
		public SensorEntity MyDogecoinsNodered => new(_haContext, "sensor.my_dogecoins_nodered");
		public SensorEntity MyDogecoinsProfitNodered => new(_haContext, "sensor.my_dogecoins_profit_nodered");
		public SensorEntity NetdaemonStatus => new(_haContext, "sensor.netdaemon_status");
		public SensorEntity OpenwindowsCount => new(_haContext, "sensor.openwindows_count");
		public SensorEntity P90xWorkoutToday => new(_haContext, "sensor.p90x_workout_today");
		public SensorEntity PupsstationCpuLoad15Min => new(_haContext, "sensor.pupsstation_cpu_load_15_min");
		public SensorEntity PupsstationCpuLoad5Min => new(_haContext, "sensor.pupsstation_cpu_load_5_min");
		public SensorEntity PupsstationCpuLoadTotal => new(_haContext, "sensor.pupsstation_cpu_load_total");
		public SensorEntity PupsstationCpuLoadUser => new(_haContext, "sensor.pupsstation_cpu_load_user");
		public SensorEntity PupsstationDrive1Status => new(_haContext, "sensor.pupsstation_drive_1_status");
		public SensorEntity PupsstationDrive1Temperature => new(_haContext, "sensor.pupsstation_drive_1_temperature");
		public SensorEntity PupsstationDrive2Status => new(_haContext, "sensor.pupsstation_drive_2_status");
		public SensorEntity PupsstationDrive2Temperature => new(_haContext, "sensor.pupsstation_drive_2_temperature");
		public SensorEntity PupsstationMemoryAvailableReal => new(_haContext, "sensor.pupsstation_memory_available_real");
		public SensorEntity PupsstationMemoryAvailableSwap => new(_haContext, "sensor.pupsstation_memory_available_swap");
		public SensorEntity PupsstationMemoryTotalReal => new(_haContext, "sensor.pupsstation_memory_total_real");
		public SensorEntity PupsstationMemoryTotalSwap => new(_haContext, "sensor.pupsstation_memory_total_swap");
		public SensorEntity PupsstationMemoryUsageReal => new(_haContext, "sensor.pupsstation_memory_usage_real");
		public SensorEntity PupsstationNetworkDown => new(_haContext, "sensor.pupsstation_network_down");
		public SensorEntity PupsstationNetworkUp => new(_haContext, "sensor.pupsstation_network_up");
		public SensorEntity PupsstationTemperature => new(_haContext, "sensor.pupsstation_temperature");
		public SensorEntity PupsstationVolume1AverageDiskTemp => new(_haContext, "sensor.pupsstation_volume_1_average_disk_temp");
		public SensorEntity PupsstationVolume1Status => new(_haContext, "sensor.pupsstation_volume_1_status");
		public SensorEntity PupsstationVolume1UsedSpace => new(_haContext, "sensor.pupsstation_volume_1_used_space");
		public SensorEntity PupsstationVolume1VolumeUsed => new(_haContext, "sensor.pupsstation_volume_1_volume_used");
		public SensorEntity ShavesCount => new(_haContext, "sensor.shaves_count");
		public SensorEntity SpeedtestDownload => new(_haContext, "sensor.speedtest_download");
		public SensorEntity SpeedtestPing => new(_haContext, "sensor.speedtest_ping");
		public SensorEntity SpeedtestUpload => new(_haContext, "sensor.speedtest_upload");
		public SensorEntity StockBlackberryLtdProfit => new(_haContext, "sensor.stock_blackberry_ltd_profit");
		public SensorEntity StockBlackberryLtdShareprice => new(_haContext, "sensor.stock_blackberry_ltd_shareprice");
		public SensorEntity StockBlackberryLtdTotalvalue => new(_haContext, "sensor.stock_blackberry_ltd_totalvalue");
		public SensorEntity StockCoreDaxProfit => new(_haContext, "sensor.stock_core_dax_profit");
		public SensorEntity StockCoreDaxShareprice => new(_haContext, "sensor.stock_core_dax_shareprice");
		public SensorEntity StockCoreDaxTotalvalue => new(_haContext, "sensor.stock_core_dax_totalvalue");
		public SensorEntity StockGamestopProfit => new(_haContext, "sensor.stock_gamestop_profit");
		public SensorEntity StockGamestopShareprice => new(_haContext, "sensor.stock_gamestop_shareprice");
		public SensorEntity StockGamestopTotalvalue => new(_haContext, "sensor.stock_gamestop_totalvalue");
		public SensorEntity StockLufthansaProfit => new(_haContext, "sensor.stock_lufthansa_profit");
		public SensorEntity StockLufthansaShareprice => new(_haContext, "sensor.stock_lufthansa_shareprice");
		public SensorEntity StockLufthansaTotalvalue => new(_haContext, "sensor.stock_lufthansa_totalvalue");
		public SensorEntity StockMetroAgProfit => new(_haContext, "sensor.stock_metro_ag_profit");
		public SensorEntity StockMetroAgShareprice => new(_haContext, "sensor.stock_metro_ag_shareprice");
		public SensorEntity StockMetroAgTotalvalue => new(_haContext, "sensor.stock_metro_ag_totalvalue");
		public SensorEntity ThermostatArbeitszimmerTemperature => new(_haContext, "sensor.thermostat_arbeitszimmer_temperature");
		public SensorEntity ThermostatArbeitszimmerValvetappet => new(_haContext, "sensor.thermostat_arbeitszimmer_valvetappet");
		public SensorEntity ThermostatBadezimmerTemperature => new(_haContext, "sensor.thermostat_badezimmer_temperature");
		public SensorEntity ThermostatBadezimmerValvetappet => new(_haContext, "sensor.thermostat_badezimmer_valvetappet");
		public SensorEntity ThermostatSchlafzimmerTemperature => new(_haContext, "sensor.thermostat_schlafzimmer_temperature");
		public SensorEntity ThermostatSchlafzimmerValvetappet => new(_haContext, "sensor.thermostat_schlafzimmer_valvetappet");
		public SensorEntity ThermostatWohnzimmerTemperature => new(_haContext, "sensor.thermostat_wohnzimmer_temperature");
		public SensorEntity ThermostatWohnzimmerValvetappet => new(_haContext, "sensor.thermostat_wohnzimmer_valvetappet");
	}

	public class SunEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SunEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public class SwitchEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SwitchEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public SwitchEntity E20007146c4dd57098e9d => new(_haContext, "switch.20007146c4dd57098e9d");
		public SwitchEntity E22763158600194a53716 => new(_haContext, "switch.22763158600194a53716");
		public SwitchEntity E22763158c44f3380a92c => new(_haContext, "switch.22763158c44f3380a92c");
		public SwitchEntity E62663300c4dd570e60ad => new(_haContext, "switch.62663300c4dd570e60ad");
		public SwitchEntity Bf18f10fc6c9cac58d4c0a => new(_haContext, "switch.bf18f10fc6c9cac58d4c0a");
		public SwitchEntity Bfb8ec2dac052e231ax6tg => new(_haContext, "switch.bfb8ec2dac052e231ax6tg");
		public SwitchEntity EnableChromeControlLights => new(_haContext, "switch.enable_chrome_control_lights");
		public SwitchEntity EnableChromeMediaPlayback => new(_haContext, "switch.enable_chrome_media_playback");
		public SwitchEntity HarmonyHubKino2 => new(_haContext, "switch.harmony_hub_kino_2");
		public SwitchEntity HarmonyHubKinoLaptopFup => new(_haContext, "switch.harmony_hub_kino_laptop_fup");
		public SwitchEntity HarmonyHubListenToMusic => new(_haContext, "switch.harmony_hub_listen_to_music");
		public SwitchEntity HarmonyHubPlaystation => new(_haContext, "switch.harmony_hub_playstation");
		public SwitchEntity HarmonyHubSpielStreamen => new(_haContext, "switch.harmony_hub_spiel_streamen");
		public SwitchEntity Kino => new(_haContext, "switch.kino");
		public SwitchEntity LoudspeakerPup => new(_haContext, "switch.loudspeaker_pup");
		public SwitchEntity Music => new(_haContext, "switch.music");
		public SwitchEntity NetdaemonMoonlightinputselectupdater => new(_haContext, "switch.netdaemon_moonlightinputselectupdater");
		public SwitchEntity Pc => new(_haContext, "switch.pc");
		public SwitchEntity Playstation => new(_haContext, "switch.playstation");
		public SwitchEntity Schedule4e40b2 => new(_haContext, "switch.schedule_4e40b2");
		public SwitchEntity Schedule5132c8 => new(_haContext, "switch.schedule_5132c8");
		public SwitchEntity ScheduleF18168 => new(_haContext, "switch.schedule_f18168");
		public SwitchEntity ToggleChromeMediaPlayback => new(_haContext, "switch.toggle_chrome_media_playback");
		public SwitchEntity ToggleMeditationSession => new(_haContext, "switch.toggle_meditation_session");
		public SwitchEntity Windows => new(_haContext, "switch.windows");
		public SwitchEntity Windowswol => new(_haContext, "switch.windowswol");
	}

	public class TimerEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public TimerEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public TimerEntity Meditation => new(_haContext, "timer.meditation");
	}

	public class VacuumEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public VacuumEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public VacuumEntity Fantenrussel => new(_haContext, "vacuum.fantenrussel");
	}

	public class VarEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public VarEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public VarEntity MoonlightAvailableGamesDesktopFabienne => new(_haContext, "var.moonlight_available_games_desktop_fabienne");
		public VarEntity MoonlightAvailableGamesDesktopPhilipp => new(_haContext, "var.moonlight_available_games_desktop_philipp");
		public VarEntity MoonlightIsRunning => new(_haContext, "var.moonlight_is_running");
	}

	public class WeatherEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public WeatherEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public WeatherEntity Zuhause => new(_haContext, "weather.zuhause");
	}

	public class ZoneEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ZoneEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public ZoneEntity Home => new(_haContext, "zone.home");
	}

	public record AlarmControlPanelEntity : NetDaemon.HassModel.Entities.Entity<AlarmControlPanelEntity, NetDaemon.HassModel.Entities.EntityState<AlarmControlPanelAttributes>, AlarmControlPanelAttributes>
	{
		public AlarmControlPanelEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record BinarySensorEntity : NetDaemon.HassModel.Entities.Entity<BinarySensorEntity, NetDaemon.HassModel.Entities.EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record CalendarEntity : NetDaemon.HassModel.Entities.Entity<CalendarEntity, NetDaemon.HassModel.Entities.EntityState<CalendarAttributes>, CalendarAttributes>
	{
		public CalendarEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record CameraEntity : NetDaemon.HassModel.Entities.Entity<CameraEntity, NetDaemon.HassModel.Entities.EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record ClimateEntity : NetDaemon.HassModel.Entities.Entity<ClimateEntity, NetDaemon.HassModel.Entities.EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record CounterEntity : NetDaemon.HassModel.Entities.Entity<CounterEntity, NetDaemon.HassModel.Entities.EntityState<CounterAttributes>, CounterAttributes>
	{
		public CounterEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record DeviceTrackerEntity : NetDaemon.HassModel.Entities.Entity<DeviceTrackerEntity, NetDaemon.HassModel.Entities.EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record GroupEntity : NetDaemon.HassModel.Entities.Entity<GroupEntity, NetDaemon.HassModel.Entities.EntityState<GroupAttributes>, GroupAttributes>
	{
		public GroupEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record InputBooleanEntity : NetDaemon.HassModel.Entities.Entity<InputBooleanEntity, NetDaemon.HassModel.Entities.EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record InputNumberEntity : NetDaemon.HassModel.Entities.Entity<InputNumberEntity, NetDaemon.HassModel.Entities.EntityState<InputNumberAttributes>, InputNumberAttributes>
	{
		public InputNumberEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record InputSelectEntity : NetDaemon.HassModel.Entities.Entity<InputSelectEntity, NetDaemon.HassModel.Entities.EntityState<InputSelectAttributes>, InputSelectAttributes>
	{
		public InputSelectEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record LightEntity : NetDaemon.HassModel.Entities.Entity<LightEntity, NetDaemon.HassModel.Entities.EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record MediaPlayerEntity : NetDaemon.HassModel.Entities.Entity<MediaPlayerEntity, NetDaemon.HassModel.Entities.EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record PersonEntity : NetDaemon.HassModel.Entities.Entity<PersonEntity, NetDaemon.HassModel.Entities.EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record RemoteEntity : NetDaemon.HassModel.Entities.Entity<RemoteEntity, NetDaemon.HassModel.Entities.EntityState<RemoteAttributes>, RemoteAttributes>
	{
		public RemoteEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record SensorEntity : NetDaemon.HassModel.Entities.Entity<SensorEntity, NetDaemon.HassModel.Entities.EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record SunEntity : NetDaemon.HassModel.Entities.Entity<SunEntity, NetDaemon.HassModel.Entities.EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record SwitchEntity : NetDaemon.HassModel.Entities.Entity<SwitchEntity, NetDaemon.HassModel.Entities.EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record TimerEntity : NetDaemon.HassModel.Entities.Entity<TimerEntity, NetDaemon.HassModel.Entities.EntityState<TimerAttributes>, TimerAttributes>
	{
		public TimerEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record VacuumEntity : NetDaemon.HassModel.Entities.Entity<VacuumEntity, NetDaemon.HassModel.Entities.EntityState<VacuumAttributes>, VacuumAttributes>
	{
		public VacuumEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record VarEntity : NetDaemon.HassModel.Entities.Entity<VarEntity, NetDaemon.HassModel.Entities.EntityState<VarAttributes>, VarAttributes>
	{
		public VarEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record WeatherEntity : NetDaemon.HassModel.Entities.Entity<WeatherEntity, NetDaemon.HassModel.Entities.EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record ZoneEntity : NetDaemon.HassModel.Entities.Entity<ZoneEntity, NetDaemon.HassModel.Entities.EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}
	}

	public record AlarmControlPanelAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changed_by")]
		public object? ChangedBy { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("code_arm_required")]
		public bool? CodeArmRequired { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("code_format")]
		public object? CodeFormat { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record BinarySensorAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("attribution")]
		public string? Attribution { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
		public string? DeviceClass { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("malware")]
		public string? Malware { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("network")]
		public string? Network { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("newest_version")]
		public string? NewestVersion { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("release_notes")]
		public string? ReleaseNotes { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("round_trip_time_avg")]
		public double? RoundTripTimeAvg { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("round_trip_time_max")]
		public double? RoundTripTimeMax { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("round_trip_time_mdev")]
		public string? RoundTripTimeMdev { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("round_trip_time_min")]
		public double? RoundTripTimeMin { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("securitySetting")]
		public string? SecuritySetting { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("systemCheck")]
		public string? SystemCheck { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("update")]
		public string? Update { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("userInfo")]
		public string? UserInfo { get; init; }
	}

	public record CalendarAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("all_day")]
		public bool? AllDay { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
		public string? Description { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("end_time")]
		public string? EndTime { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("location")]
		public string? Location { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("message")]
		public string? Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("offset_reached")]
		public bool? OffsetReached { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("start_time")]
		public string? StartTime { get; init; }
	}

	public record CameraAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("access_token")]
		public string? AccessToken { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("calibration_points")]
		public object? CalibrationPoints { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_picture")]
		public string? EntityPicture { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("model")]
		public string? Model { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("used_api")]
		public string? UsedApi { get; init; }
	}

	public record ClimateAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("current_temperature")]
		public double? CurrentTemperature { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("hvac_modes")]
		public object? HvacModes { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("max_temp")]
		public double? MaxTemp { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("min_temp")]
		public double? MinTemp { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("preset_mode")]
		public string? PresetMode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("preset_modes")]
		public object? PresetModes { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("target_temp_step")]
		public double? TargetTempStep { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
		public double? Temperature { get; init; }
	}

	public record CounterAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool? Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("initial")]
		public double? Initial { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("step")]
		public double? Step { get; init; }
	}

	public record DeviceTrackerAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("altitude")]
		public double? Altitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("battery_level")]
		public double? BatteryLevel { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("course")]
		public double? Course { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
		public double? Latitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
		public double? Longitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("source_type")]
		public string? SourceType { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("speed")]
		public double? Speed { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("vertical_accuracy")]
		public double? VerticalAccuracy { get; init; }
	}

	public record GroupAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_id")]
		public object? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("order")]
		public double? Order { get; init; }
	}

	public record InputBooleanAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool? Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }
	}

	public record InputNumberAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool? Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("initial")]
		public double? Initial { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("max")]
		public double? Max { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("min")]
		public double? Min { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
		public string? Mode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("step")]
		public double? Step { get; init; }
	}

	public record InputSelectAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool? Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("options")]
		public object? Options { get; init; }
	}

	public record LightAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("brightness")]
		public double? Brightness { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("color_mode")]
		public string? ColorMode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("color_temp")]
		public double? ColorTemp { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("max_mireds")]
		public double? MaxMireds { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("min_mireds")]
		public double? MinMireds { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_color_modes")]
		public object? SupportedColorModes { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record MediaPlayerAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("media_content_type")]
		public string? MediaContentType { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("shuffle")]
		public bool? Shuffle { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("source_list")]
		public object? SourceList { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public record PersonAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool? Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_picture")]
		public string? EntityPicture { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
		public string? Id { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
		public double? Latitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
		public double? Longitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("source")]
		public string? Source { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("user_id")]
		public string? UserId { get; init; }
	}

	public record RemoteAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("activity_list")]
		public object? ActivityList { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("activity_starting")]
		public object? ActivityStarting { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("current_activity")]
		public string? CurrentActivity { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("devices_list")]
		public object? DevicesList { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last_activity")]
		public string? LastActivity { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record SensorAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Administrative Area")]
		public string? AdministrativeArea { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Allows VoIP")]
		public bool? AllowsVoIP { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Areas Of Interest")]
		public object? AreasOfInterest { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("attribution")]
		public string? Attribution { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Available")]
		public string? Available { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Available (Important)")]
		public string? AvailableImportant { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Available (Opportunistic)")]
		public string? AvailableOpportunistic { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Carrier ID")]
		public string? CarrierID { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Carrier Name")]
		public string? CarrierName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("change")]
		public double? Change { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changeCurrentYear")]
		public double? ChangeCurrentYear { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changeFiveYears")]
		public object? ChangeFiveYears { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changeOneMonth")]
		public double? ChangeOneMonth { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changeOneWeek")]
		public double? ChangeOneWeek { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changeOneYear")]
		public double? ChangeOneYear { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changePercent")]
		public double? ChangePercent { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changePercentCurrentYear")]
		public double? ChangePercentCurrentYear { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changePercentFiveYears")]
		public object? ChangePercentFiveYears { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changePercentOneMonth")]
		public double? ChangePercentOneMonth { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changePercentOneWeek")]
		public double? ChangePercentOneWeek { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changePercentOneYear")]
		public double? ChangePercentOneYear { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changePercentSixMonths")]
		public double? ChangePercentSixMonths { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changePercentThreeMonths")]
		public double? ChangePercentThreeMonths { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changePercentThreeYears")]
		public object? ChangePercentThreeYears { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changeSixMonths")]
		public double? ChangeSixMonths { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changeThreeMonths")]
		public double? ChangeThreeMonths { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("changeThreeYears")]
		public object? ChangeThreeYears { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("color")]
		public string? Color { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Confidence")]
		public string? Confidence { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Country")]
		public string? Country { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Current Radio Technology")]
		public string? CurrentRadioTechnology { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
		public string? DeviceClass { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("firstworkout_title")]
		public string? FirstworkoutTitle { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("firstworkout_url")]
		public string? FirstworkoutUrl { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Inland Water")]
		public string? InlandWater { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("integration")]
		public string? Integration { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("ISO Country Code")]
		public string? ISOCountryCode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("lastupdate")]
		public string? Lastupdate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("lastworkout_title")]
		public string? LastworkoutTitle { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("lastworkout_url")]
		public string? LastworkoutUrl { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Locality")]
		public string? Locality { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Location")]
		public object? Location { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Low Power Mode")]
		public bool? LowPowerMode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Mobile Country Code")]
		public string? MobileCountryCode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Mobile Network Code")]
		public string? MobileNetworkCode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
		public string? Name_0 { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Name")]
		public string? Name_1 { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("number_of_loaded_apps")]
		public double? NumberOfLoadedApps { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("number_of_running_apps")]
		public double? NumberOfRunningApps { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Ocean")]
		public string? Ocean { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Postal Code")]
		public string? PostalCode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("profitLoss")]
		public double? ProfitLoss { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("profitLossPercentage")]
		public double? ProfitLossPercentage { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("purchasePrice")]
		public double? PurchasePrice { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("repositories")]
		public object? Repositories { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("shares")]
		public double? Shares { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Administrative Area")]
		public string? SubAdministrativeArea { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Locality")]
		public string? SubLocality { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Thoroughfare")]
		public string? SubThoroughfare { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("text")]
		public string? Text { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Thoroughfare")]
		public string? Thoroughfare { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Time Zone")]
		public string? TimeZone { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Total")]
		public string? Total { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("totalChange")]
		public double? TotalChange { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("totalChangeCurrentYear")]
		public double? TotalChangeCurrentYear { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("totalChangeFiveYears")]
		public object? TotalChangeFiveYears { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("totalChangeOneMonth")]
		public double? TotalChangeOneMonth { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("totalChangeOneWeek")]
		public double? TotalChangeOneWeek { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("totalChangeOneYear")]
		public double? TotalChangeOneYear { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("totalChangeSixMonths")]
		public double? TotalChangeSixMonths { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("totalChangeThreeMonths")]
		public double? TotalChangeThreeMonths { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("totalChangeThreeYears")]
		public object? TotalChangeThreeYears { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("totalProfitLoss")]
		public double? TotalProfitLoss { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("totalValue")]
		public double? TotalValue { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Types")]
		public object? Types { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("valve_tappet_state")]
		public string? ValveTappetState { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
		public string? Version { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Zones")]
		public object? Zones { get; init; }
	}

	public record SunAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("azimuth")]
		public double? Azimuth { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("elevation")]
		public double? Elevation { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_dawn")]
		public string? NextDawn { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_dusk")]
		public string? NextDusk { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_midnight")]
		public string? NextMidnight { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_noon")]
		public string? NextNoon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_rising")]
		public string? NextRising { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_setting")]
		public string? NextSetting { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("rising")]
		public bool? Rising { get; init; }
	}

	public record SwitchAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("actions")]
		public object? Actions { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("assumed_state")]
		public bool? AssumedState { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("current_slot")]
		public double? CurrentSlot { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("integration")]
		public string? Integration { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_slot")]
		public double? NextSlot { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("next_trigger")]
		public string? NextTrigger { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("tags")]
		public object? Tags { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("times")]
		public object? Times { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("weekdays")]
		public object? Weekdays { get; init; }
	}

	public record TimerAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
		public string? Duration { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool? Editable { get; init; }
	}

	public record VacuumAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("battery_icon")]
		public string? BatteryIcon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("battery_level")]
		public double? BatteryLevel { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("cleaned_area")]
		public double? CleanedArea { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("cleaning_count")]
		public double? CleaningCount { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("cleaning_time")]
		public double? CleaningTime { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("clean_start")]
		public string? CleanStart { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("clean_stop")]
		public string? CleanStop { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("do_not_disturb")]
		public string? DoNotDisturb { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("do_not_disturb_end")]
		public string? DoNotDisturbEnd { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("do_not_disturb_start")]
		public string? DoNotDisturbStart { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("fan_speed")]
		public string? FanSpeed { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("fan_speed_list")]
		public object? FanSpeedList { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("filter_left")]
		public double? FilterLeft { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("main_brush_left")]
		public double? MainBrushLeft { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mop_attached")]
		public bool? MopAttached { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("sensor_dirty_left")]
		public double? SensorDirtyLeft { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("side_brush_left")]
		public double? SideBrushLeft { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("status")]
		public string? Status { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("total_cleaned_area")]
		public double? TotalCleanedArea { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("total_cleaning_time")]
		public double? TotalCleaningTime { get; init; }
	}

	public record VarAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }
	}

	public record WeatherAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("attribution")]
		public string? Attribution { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("forecast")]
		public object? Forecast { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("humidity")]
		public double? Humidity { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("pressure")]
		public double? Pressure { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
		public double? Temperature { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("wind_bearing")]
		public double? WindBearing { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("wind_speed")]
		public double? WindSpeed { get; init; }
	}

	public record ZoneAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool? Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
		public double? Latitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
		public double? Longitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("passive")]
		public bool? Passive { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AlarmControlPanelServices AlarmControlPanel { get; }

		AutomationServices Automation { get; }

		BoschShcServices BoschShc { get; }

		CameraServices Camera { get; }

		CastServices Cast { get; }

		ClimateServices Climate { get; }

		CloudServices Cloud { get; }

		CommandLineServices CommandLine { get; }

		CounterServices Counter { get; }

		CoverServices Cover { get; }

		DeviceTrackerServices DeviceTracker { get; }

		FrontendServices Frontend { get; }

		GoogleServices Google { get; }

		GroupServices Group { get; }

		HarmonyServices Harmony { get; }

		HomeassistantServices Homeassistant { get; }

		InputBooleanServices InputBoolean { get; }

		InputDatetimeServices InputDatetime { get; }

		InputNumberServices InputNumber { get; }

		InputSelectServices InputSelect { get; }

		InputTextServices InputText { get; }

		LightServices Light { get; }

		LogbookServices Logbook { get; }

		LoggerServices Logger { get; }

		MediaPlayerServices MediaPlayer { get; }

		MqttServices Mqtt { get; }

		NetdaemonServices Netdaemon { get; }

		NoderedServices Nodered { get; }

		NotifyServices Notify { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		PingServices Ping { get; }

		RecorderServices Recorder { get; }

		RemoteServices Remote { get; }

		SceneServices Scene { get; }

		SchedulerServices Scheduler { get; }

		ScriptServices Script { get; }

		SpeedtestdotnetServices Speedtestdotnet { get; }

		SpotcastServices Spotcast { get; }

		SwitchServices Switch { get; }

		SynologyDsmServices SynologyDsm { get; }

		SystemLogServices SystemLog { get; }

		TemplateServices Template { get; }

		TimerServices Timer { get; }

		TuyaServices Tuya { get; }

		VacuumServices Vacuum { get; }

		VarServices Var { get; }

		WakeOnLanServices WakeOnLan { get; }

		XiaomiCloudMapExtractorServices XiaomiCloudMapExtractor { get; }

		XiaomiMiioServices XiaomiMiio { get; }

		ZoneServices Zone { get; }
	}

	public class Services : IServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public Services(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
		public AutomationServices Automation => new(_haContext);
		public BoschShcServices BoschShc => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public CastServices Cast => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CloudServices Cloud => new(_haContext);
		public CommandLineServices CommandLine => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public CoverServices Cover => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GoogleServices Google => new(_haContext);
		public GroupServices Group => new(_haContext);
		public HarmonyServices Harmony => new(_haContext);
		public HomeassistantServices Homeassistant => new(_haContext);
		public InputBooleanServices InputBoolean => new(_haContext);
		public InputDatetimeServices InputDatetime => new(_haContext);
		public InputNumberServices InputNumber => new(_haContext);
		public InputSelectServices InputSelect => new(_haContext);
		public InputTextServices InputText => new(_haContext);
		public LightServices Light => new(_haContext);
		public LogbookServices Logbook => new(_haContext);
		public LoggerServices Logger => new(_haContext);
		public MediaPlayerServices MediaPlayer => new(_haContext);
		public MqttServices Mqtt => new(_haContext);
		public NetdaemonServices Netdaemon => new(_haContext);
		public NoderedServices Nodered => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public PingServices Ping => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public RemoteServices Remote => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public SchedulerServices Scheduler => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public SpeedtestdotnetServices Speedtestdotnet => new(_haContext);
		public SpotcastServices Spotcast => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SynologyDsmServices SynologyDsm => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TemplateServices Template => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public TuyaServices Tuya => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public VarServices Var => new(_haContext);
		public WakeOnLanServices WakeOnLan => new(_haContext);
		public XiaomiCloudMapExtractorServices XiaomiCloudMapExtractor => new(_haContext);
		public XiaomiMiioServices XiaomiMiio => new(_haContext);
		public ZoneServices Zone => new(_haContext);
	}

	public class AlarmControlPanelServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public AlarmControlPanelServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void AlarmArmAway(NetDaemon.HassModel.Entities.ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
		}

		public void AlarmArmAway(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new
			{
			@code
			}

			);
		}

		public void AlarmArmCustomBypass(NetDaemon.HassModel.Entities.ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
		}

		public void AlarmArmCustomBypass(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new
			{
			@code
			}

			);
		}

		public void AlarmArmHome(NetDaemon.HassModel.Entities.ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
		}

		public void AlarmArmHome(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new
			{
			@code
			}

			);
		}

		public void AlarmArmNight(NetDaemon.HassModel.Entities.ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
		}

		public void AlarmArmNight(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new
			{
			@code
			}

			);
		}

		public void AlarmDisarm(NetDaemon.HassModel.Entities.ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
		}

		public void AlarmDisarm(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, new
			{
			@code
			}

			);
		}

		public void AlarmTrigger(NetDaemon.HassModel.Entities.ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
		}

		public void AlarmTrigger(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, new
			{
			@code
			}

			);
		}
	}

	public record AlarmControlPanelAlarmArmAwayParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmCustomBypassParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmHomeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmNightParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmDisarmParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmTriggerParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class AutomationServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public AutomationServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		public void Trigger(NetDaemon.HassModel.Entities.ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		public void Trigger(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new
			{
			@skip_condition = @skipCondition
			}

			);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new
			{
			@stop_actions = @stopActions
			}

			);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("skipCondition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("stopActions")]
		public bool? StopActions { get; init; }
	}

	public class BoschShcServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public BoschShcServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void SmokedetectorAlarmstate(BoschShcSmokedetectorAlarmstateParameters data)
		{
			_haContext.CallService("bosch_shc", "smokedetector_alarmstate", null, data);
		}

		public void SmokedetectorAlarmstate(string? @entityId = null, string? @command = null)
		{
			_haContext.CallService("bosch_shc", "smokedetector_alarmstate", null, new
			{
			@entity_id = @entityId, @command
			}

			);
		}

		public void SmokedetectorCheck(BoschShcSmokedetectorCheckParameters data)
		{
			_haContext.CallService("bosch_shc", "smokedetector_check", null, data);
		}

		public void SmokedetectorCheck(string? @entityId = null)
		{
			_haContext.CallService("bosch_shc", "smokedetector_check", null, new
			{
			@entity_id = @entityId
			}

			);
		}

		public void TriggerScenario(BoschShcTriggerScenarioParameters data)
		{
			_haContext.CallService("bosch_shc", "trigger_scenario", null, data);
		}

		public void TriggerScenario(string? @name = null)
		{
			_haContext.CallService("bosch_shc", "trigger_scenario", null, new
			{
			@name
			}

			);
		}
	}

	public record BoschShcSmokedetectorAlarmstateParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("command")]
		public string? Command { get; init; }
	}

	public record BoschShcSmokedetectorCheckParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }
	}

	public record BoschShcTriggerScenarioParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public class CameraServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CameraServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void DisableMotionDetection(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		public void EnableMotionDetection(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		public void PlayStream(NetDaemon.HassModel.Entities.ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		public void PlayStream(NetDaemon.HassModel.Entities.ServiceTarget target, string @mediaPlayer, string? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new
			{
			@media_player = @mediaPlayer, @format
			}

			);
		}

		public void Record(NetDaemon.HassModel.Entities.ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		public void Record(NetDaemon.HassModel.Entities.ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new
			{
			@filename, @duration, @lookback
			}

			);
		}

		public void Snapshot(NetDaemon.HassModel.Entities.ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		public void Snapshot(NetDaemon.HassModel.Entities.ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new
			{
			@filename
			}

			);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("mediaPlayer")]
		public string? MediaPlayer { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("format")]
		public string? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("filename")]
		public string? Filename { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public long? Duration { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("filename")]
		public string? Filename { get; init; }
	}

	public class CastServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CastServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void ShowLovelaceView(CastShowLovelaceViewParameters data)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, data);
		}

		public void ShowLovelaceView(string @entityId, string @dashboardPath, string? @viewPath = null)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, new
			{
			@entity_id = @entityId, @dashboard_path = @dashboardPath, @view_path = @viewPath
			}

			);
		}
	}

	public record CastShowLovelaceViewParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("dashboardPath")]
		public string? DashboardPath { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("viewPath")]
		public string? ViewPath { get; init; }
	}

	public class ClimateServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ClimateServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void SetAuxHeat(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		public void SetAuxHeat(NetDaemon.HassModel.Entities.ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new
			{
			@aux_heat = @auxHeat
			}

			);
		}

		public void SetFanMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		public void SetFanMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new
			{
			@fan_mode = @fanMode
			}

			);
		}

		public void SetHumidity(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		public void SetHumidity(NetDaemon.HassModel.Entities.ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new
			{
			@humidity
			}

			);
		}

		public void SetHvacMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		public void SetHvacMode(NetDaemon.HassModel.Entities.ServiceTarget target, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new
			{
			@hvac_mode = @hvacMode
			}

			);
		}

		public void SetPresetMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		public void SetPresetMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new
			{
			@preset_mode = @presetMode
			}

			);
		}

		public void SetSwingMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		public void SetSwingMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new
			{
			@swing_mode = @swingMode
			}

			);
		}

		public void SetTemperature(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		public void SetTemperature(NetDaemon.HassModel.Entities.ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new
			{
			@temperature, @target_temp_high = @targetTempHigh, @target_temp_low = @targetTempLow, @hvac_mode = @hvacMode
			}

			);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("auxHeat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("fanMode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("hvacMode")]
		public string? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("presetMode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("swingMode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("targetTempHigh")]
		public double? TargetTempHigh { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("targetTempLow")]
		public double? TargetTempLow { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("hvacMode")]
		public string? HvacMode { get; init; }
	}

	public class CloudServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CloudServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void RemoteConnect()
		{
			_haContext.CallService("cloud", "remote_connect", null);
		}

		public void RemoteDisconnect()
		{
			_haContext.CallService("cloud", "remote_disconnect", null);
		}
	}

	public class CommandLineServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CommandLineServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("command_line", "reload", null);
		}
	}

	public class CounterServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CounterServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Configure(NetDaemon.HassModel.Entities.ServiceTarget target, CounterConfigureParameters data)
		{
			_haContext.CallService("counter", "configure", target, data);
		}

		public void Configure(NetDaemon.HassModel.Entities.ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new
			{
			@minimum, @maximum, @step, @initial, @value
			}

			);
		}

		public void Decrement(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		public void Increment(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		public void Reset(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("step")]
		public long? Step { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("initial")]
		public long? Initial { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public long? Value { get; init; }
	}

	public class CoverServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CoverServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void CloseCover(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		public void CloseCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		public void OpenCover(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		public void OpenCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		public void SetCoverPosition(NetDaemon.HassModel.Entities.ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		public void SetCoverPosition(NetDaemon.HassModel.Entities.ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new
			{
			@position
			}

			);
		}

		public void SetCoverTiltPosition(NetDaemon.HassModel.Entities.ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		public void SetCoverTiltPosition(NetDaemon.HassModel.Entities.ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new
			{
			@tilt_position = @tiltPosition
			}

			);
		}

		public void StopCover(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		public void StopCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		public void ToggleCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("tiltPosition")]
		public long? TiltPosition { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public DeviceTrackerServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void See(DeviceTrackerSeeParameters data)
		{
			_haContext.CallService("device_tracker", "see", null, data);
		}

		public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
		{
			_haContext.CallService("device_tracker", "see", null, new
			{
			@mac, @dev_id = @devId, @host_name = @hostName, @location_name = @locationName, @gps, @gps_accuracy = @gpsAccuracy, @battery
			}

			);
		}
	}

	public record DeviceTrackerSeeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("mac")]
		public string? Mac { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("devId")]
		public string? DevId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("hostName")]
		public string? HostName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("locationName")]
		public string? LocationName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("gps")]
		public object? Gps { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("gpsAccuracy")]
		public long? GpsAccuracy { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("battery")]
		public long? Battery { get; init; }
	}

	public class FrontendServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public FrontendServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void ReloadThemes()
		{
			_haContext.CallService("frontend", "reload_themes", null);
		}

		public void SetTheme(FrontendSetThemeParameters data)
		{
			_haContext.CallService("frontend", "set_theme", null, data);
		}

		public void SetTheme(string @name, string? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new
			{
			@name, @mode
			}

			);
		}
	}

	public record FrontendSetThemeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class GoogleServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public GoogleServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void AddEvent(GoogleAddEventParameters data)
		{
			_haContext.CallService("google", "add_event", null, data);
		}

		public void AddEvent(string @calendarId, string @summary, string? @description = null, string? @startDateTime = null, string? @endDateTime = null, string? @startDate = null, string? @endDate = null, object? @in = null)
		{
			_haContext.CallService("google", "add_event", null, new
			{
			@calendar_id = @calendarId, @summary, @description, @start_date_time = @startDateTime, @end_date_time = @endDateTime, @start_date = @startDate, @end_date = @endDate, @in
			}

			);
		}

		public void FoundCalendar()
		{
			_haContext.CallService("google", "found_calendar", null);
		}

		public void ScanForCalendars()
		{
			_haContext.CallService("google", "scan_for_calendars", null);
		}
	}

	public record GoogleAddEventParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("calendarId")]
		public string? CalendarId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("summary")]
		public string? Summary { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("description")]
		public string? Description { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("startDateTime")]
		public string? StartDateTime { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("endDateTime")]
		public string? EndDateTime { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("startDate")]
		public string? StartDate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("endDate")]
		public string? EndDate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("in")]
		public object? In { get; init; }
	}

	public class GroupServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public GroupServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("group", "reload", null);
		}

		public void Remove(GroupRemoveParameters data)
		{
			_haContext.CallService("group", "remove", null, data);
		}

		public void Remove(object @objectId)
		{
			_haContext.CallService("group", "remove", null, new
			{
			@object_id = @objectId
			}

			);
		}

		public void Set(GroupSetParameters data)
		{
			_haContext.CallService("group", "set", null, data);
		}

		public void Set(string @objectId, string? @name = null, string? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new
			{
			@object_id = @objectId, @name, @icon, @entities, @add_entities = @addEntities, @all
			}

			);
		}
	}

	public record GroupRemoveParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("objectId")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("objectId")]
		public string? ObjectId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("entities")]
		public object? Entities { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("addEntities")]
		public object? AddEntities { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("all")]
		public bool? All { get; init; }
	}

	public class HarmonyServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public HarmonyServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void ChangeChannel(NetDaemon.HassModel.Entities.ServiceTarget target, HarmonyChangeChannelParameters data)
		{
			_haContext.CallService("harmony", "change_channel", target, data);
		}

		public void ChangeChannel(NetDaemon.HassModel.Entities.ServiceTarget target, long @channel)
		{
			_haContext.CallService("harmony", "change_channel", target, new
			{
			@channel
			}

			);
		}

		public void Sync(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("harmony", "sync", target);
		}
	}

	public record HarmonyChangeChannelParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("channel")]
		public long? Channel { get; init; }
	}

	public class HomeassistantServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public HomeassistantServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		public void ReloadConfigEntry(NetDaemon.HassModel.Entities.ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		public void ReloadConfigEntry(NetDaemon.HassModel.Entities.ServiceTarget target, string? @entryId = null)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, new
			{
			@entry_id = @entryId
			}

			);
		}

		public void ReloadCoreConfig()
		{
			_haContext.CallService("homeassistant", "reload_core_config", null);
		}

		public void Restart()
		{
			_haContext.CallService("homeassistant", "restart", null);
		}

		public void SetLocation(HomeassistantSetLocationParameters data)
		{
			_haContext.CallService("homeassistant", "set_location", null, data);
		}

		public void SetLocation(string @latitude, string @longitude)
		{
			_haContext.CallService("homeassistant", "set_location", null, new
			{
			@latitude, @longitude
			}

			);
		}

		public void Stop()
		{
			_haContext.CallService("homeassistant", "stop", null);
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		public void UpdateEntity(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entryId")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("longitude")]
		public string? Longitude { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputBooleanServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputDatetimeServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputDatetimeServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		public void SetDatetime(NetDaemon.HassModel.Entities.ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		public void SetDatetime(NetDaemon.HassModel.Entities.ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new
			{
			@date, @time, @datetime, @timestamp
			}

			);
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("date")]
		public string? Date { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputNumberServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Decrement(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		public void Increment(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_number", "increment", target);
		}

		public void Reload()
		{
			_haContext.CallService("input_number", "reload", null);
		}

		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new
			{
			@value
			}

			);
		}
	}

	public record InputNumberSetValueParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public double? Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputSelectServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		public void SelectFirst(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		public void SelectLast(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		public void SelectNext(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		public void SelectNext(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new
			{
			@cycle
			}

			);
		}

		public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new
			{
			@option
			}

			);
		}

		public void SelectPrevious(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		public void SelectPrevious(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new
			{
			@cycle
			}

			);
		}

		public void SetOptions(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		public void SetOptions(NetDaemon.HassModel.Entities.ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new
			{
			@options
			}

			);
		}
	}

	public record InputSelectSelectNextParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputTextServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new
			{
			@value
			}

			);
		}
	}

	public record InputTextSetValueParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class LightServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LightServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target, LightToggleParameters data)
		{
			_haContext.CallService("light", "toggle", target, data);
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new
			{
			@transition, @rgb_color = @rgbColor, @color_name = @colorName, @hs_color = @hsColor, @xy_color = @xyColor, @color_temp = @colorTemp, @kelvin, @white_value = @whiteValue, @brightness, @brightness_pct = @brightnessPct, @profile, @flash, @effect
			}

			);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null, string? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new
			{
			@transition, @flash
			}

			);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new
			{
			@transition, @rgb_color = @rgbColor, @rgbw_color = @rgbwColor, @rgbww_color = @rgbwwColor, @color_name = @colorName, @hs_color = @hsColor, @xy_color = @xyColor, @color_temp = @colorTemp, @kelvin, @brightness, @brightness_pct = @brightnessPct, @brightness_step = @brightnessStep, @brightness_step_pct = @brightnessStepPct, @profile, @flash, @effect
			}

			);
		}
	}

	public record LightToggleParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("rgbColor")]
		public object? RgbColor { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("colorName")]
		public string? ColorName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("hsColor")]
		public object? HsColor { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("xyColor")]
		public object? XyColor { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("colorTemp")]
		public long? ColorTemp { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("whiteValue")]
		public long? WhiteValue { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("brightnessPct")]
		public long? BrightnessPct { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("profile")]
		public string? Profile { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("flash")]
		public string? Flash { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("flash")]
		public string? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("rgbColor")]
		public object? RgbColor { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("rgbwColor")]
		public object? RgbwColor { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("rgbwwColor")]
		public object? RgbwwColor { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("colorName")]
		public string? ColorName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("hsColor")]
		public object? HsColor { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("xyColor")]
		public object? XyColor { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("colorTemp")]
		public long? ColorTemp { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("brightnessPct")]
		public long? BrightnessPct { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("brightnessStep")]
		public long? BrightnessStep { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("brightnessStepPct")]
		public long? BrightnessStepPct { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("profile")]
		public string? Profile { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("flash")]
		public string? Flash { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public class LogbookServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LogbookServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Log(LogbookLogParameters data)
		{
			_haContext.CallService("logbook", "log", null, data);
		}

		public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
		{
			_haContext.CallService("logbook", "log", null, new
			{
			@name, @message, @entity_id = @entityId, @domain
			}

			);
		}
	}

	public record LogbookLogParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("domain")]
		public string? Domain { get; init; }
	}

	public class LoggerServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LoggerServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void SetDefaultLevel(LoggerSetDefaultLevelParameters data)
		{
			_haContext.CallService("logger", "set_default_level", null, data);
		}

		public void SetDefaultLevel(string? @level = null)
		{
			_haContext.CallService("logger", "set_default_level", null, new
			{
			@level
			}

			);
		}

		public void SetLevel(LoggerSetLevelParameters data)
		{
			_haContext.CallService("logger", "set_level", null, data);
		}
	}

	public record LoggerSetDefaultLevelParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("level")]
		public string? Level { get; init; }
	}

	public record LoggerSetLevelParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("homeassistantcore")]
		public string? Homeassistantcore { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("homeassistantcomponentsmqtt")]
		public string? Homeassistantcomponentsmqtt { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("customComponentsmyIntegration")]
		public string? CustomComponentsmyIntegration { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("aiohttp")]
		public string? Aiohttp { get; init; }
	}

	public class MediaPlayerServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public MediaPlayerServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void ClearPlaylist(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		public void Join(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		public void Join(NetDaemon.HassModel.Entities.ServiceTarget target, object? @groupMembers = null)
		{
			_haContext.CallService("media_player", "join", target, new
			{
			@group_members = @groupMembers
			}

			);
		}

		public void MediaNextTrack(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		public void MediaPause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		public void MediaPlay(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		public void MediaPlayPause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		public void MediaPreviousTrack(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		public void MediaSeek(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		public void MediaSeek(NetDaemon.HassModel.Entities.ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new
			{
			@seek_position = @seekPosition
			}

			);
		}

		public void MediaStop(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		public void PlayMedia(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		public void PlayMedia(NetDaemon.HassModel.Entities.ServiceTarget target, string @mediaContentId, string @mediaContentType)
		{
			_haContext.CallService("media_player", "play_media", target, new
			{
			@media_content_id = @mediaContentId, @media_content_type = @mediaContentType
			}

			);
		}

		public void RepeatSet(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		public void RepeatSet(NetDaemon.HassModel.Entities.ServiceTarget target, string @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new
			{
			@repeat
			}

			);
		}

		public void SelectSoundMode(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		public void SelectSoundMode(NetDaemon.HassModel.Entities.ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new
			{
			@sound_mode = @soundMode
			}

			);
		}

		public void SelectSource(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		public void SelectSource(NetDaemon.HassModel.Entities.ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new
			{
			@source
			}

			);
		}

		public void ShuffleSet(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		public void ShuffleSet(NetDaemon.HassModel.Entities.ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new
			{
			@shuffle
			}

			);
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		public void Unjoin(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		public void VolumeDown(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		public void VolumeMute(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		public void VolumeMute(NetDaemon.HassModel.Entities.ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new
			{
			@is_volume_muted = @isVolumeMuted
			}

			);
		}

		public void VolumeSet(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		public void VolumeSet(NetDaemon.HassModel.Entities.ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new
			{
			@volume_level = @volumeLevel
			}

			);
		}

		public void VolumeUp(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("groupMembers")]
		public object? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("seekPosition")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("mediaContentId")]
		public string? MediaContentId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("mediaContentType")]
		public string? MediaContentType { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("repeat")]
		public string? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("soundMode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("isVolumeMuted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("volumeLevel")]
		public double? VolumeLevel { get; init; }
	}

	public class MqttServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public MqttServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Dump(MqttDumpParameters data)
		{
			_haContext.CallService("mqtt", "dump", null, data);
		}

		public void Dump(string? @topic = null, long? @duration = null)
		{
			_haContext.CallService("mqtt", "dump", null, new
			{
			@topic, @duration
			}

			);
		}

		public void Publish(MqttPublishParameters data)
		{
			_haContext.CallService("mqtt", "publish", null, data);
		}

		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, string? @qos = null, bool? @retain = null)
		{
			_haContext.CallService("mqtt", "publish", null, new
			{
			@topic, @payload, @payload_template = @payloadTemplate, @qos, @retain
			}

			);
		}
	}

	public record MqttDumpParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("topic")]
		public string? Topic { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("topic")]
		public string? Topic { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("payload")]
		public string? Payload { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("payloadTemplate")]
		public object? PayloadTemplate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("qos")]
		public string? Qos { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("retain")]
		public bool? Retain { get; init; }
	}

	public class NetdaemonServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public NetdaemonServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void EntityCreate(NetdaemonEntityCreateParameters data)
		{
			_haContext.CallService("netdaemon", "entity_create", null, data);
		}

		public void EntityCreate(string? @entityId = null, string? @state = null, string? @icon = null, string? @unit = null, string? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_create", null, new
			{
			@entity_id = @entityId, @state, @icon, @unit, @attributes
			}

			);
		}

		public void EntityRemove(NetdaemonEntityRemoveParameters data)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, data);
		}

		public void EntityRemove(string? @entityId = null)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, new
			{
			@entity_id = @entityId
			}

			);
		}

		public void EntityUpdate(NetdaemonEntityUpdateParameters data)
		{
			_haContext.CallService("netdaemon", "entity_update", null, data);
		}

		public void EntityUpdate(string? @entityId = null, string? @state = null, string? @icon = null, string? @unit = null, string? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_update", null, new
			{
			@entity_id = @entityId, @state, @icon, @unit, @attributes
			}

			);
		}

		public void RegisterService(NetdaemonRegisterServiceParameters data)
		{
			_haContext.CallService("netdaemon", "register_service", null, data);
		}

		public void RegisterService(string? @class = null, string? @method = null)
		{
			_haContext.CallService("netdaemon", "register_service", null, new
			{
			@class, @method
			}

			);
		}

		public void ReloadApps()
		{
			_haContext.CallService("netdaemon", "reload_apps", null);
		}
	}

	public record NetdaemonEntityCreateParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("state")]
		public string? State { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("unit")]
		public string? Unit { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("attributes")]
		public string? Attributes { get; init; }
	}

	public record NetdaemonEntityRemoveParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }
	}

	public record NetdaemonEntityUpdateParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("state")]
		public string? State { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("unit")]
		public string? Unit { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("attributes")]
		public string? Attributes { get; init; }
	}

	public record NetdaemonRegisterServiceParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("class")]
		public string? Class { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("method")]
		public string? Method { get; init; }
	}

	public class NoderedServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public NoderedServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Trigger(NoderedTriggerParameters data)
		{
			_haContext.CallService("nodered", "trigger", null, data);
		}

		public void Trigger(string? @entityId = null, string? @triggerEntityId = null, string? @skipCondition = null, string? @outputPath = null, string? @payload = null)
		{
			_haContext.CallService("nodered", "trigger", null, new
			{
			@entity_id = @entityId, @trigger_entity_id = @triggerEntityId, @skip_condition = @skipCondition, @output_path = @outputPath, @payload
			}

			);
		}
	}

	public record NoderedTriggerParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("triggerEntityId")]
		public string? TriggerEntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("skipCondition")]
		public string? SkipCondition { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("outputPath")]
		public string? OutputPath { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("payload")]
		public string? Payload { get; init; }
	}

	public class NotifyServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public NotifyServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void MobileAppFantenpad(NotifyMobileAppFantenpadParameters data)
		{
			_haContext.CallService("notify", "mobile_app_fantenpad", null, data);
		}

		public void MobileAppFantenpad(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_fantenpad", null, new
			{
			@message, @title, @target, @data
			}

			);
		}

		public void MobileAppFantenphone(NotifyMobileAppFantenphoneParameters data)
		{
			_haContext.CallService("notify", "mobile_app_fantenphone", null, data);
		}

		public void MobileAppFantenphone(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_fantenphone", null, new
			{
			@message, @title, @target, @data
			}

			);
		}

		public void MobileAppIphonePhilipp(NotifyMobileAppIphonePhilippParameters data)
		{
			_haContext.CallService("notify", "mobile_app_iphone_philipp", null, data);
		}

		public void MobileAppIphonePhilipp(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_iphone_philipp", null, new
			{
			@message, @title, @target, @data
			}

			);
		}

		public void Notify(NotifyNotifyParameters data)
		{
			_haContext.CallService("notify", "notify", null, data);
		}

		public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "notify", null, new
			{
			@message, @title, @target, @data
			}

			);
		}

		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new
			{
			@message, @title
			}

			);
		}
	}

	public record NotifyMobileAppFantenpadParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object? Target { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppFantenphoneParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object? Target { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppIphonePhilippParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object? Target { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object? Target { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public PersistentNotificationServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Create(PersistentNotificationCreateParameters data)
		{
			_haContext.CallService("persistent_notification", "create", null, data);
		}

		public void Create(string @message, string? @title = null, string? @notificationId = null)
		{
			_haContext.CallService("persistent_notification", "create", null, new
			{
			@message, @title, @notification_id = @notificationId
			}

			);
		}

		public void Dismiss(PersistentNotificationDismissParameters data)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, data);
		}

		public void Dismiss(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, new
			{
			@notification_id = @notificationId
			}

			);
		}

		public void MarkRead(PersistentNotificationMarkReadParameters data)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, data);
		}

		public void MarkRead(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, new
			{
			@notification_id = @notificationId
			}

			);
		}
	}

	public record PersistentNotificationCreateParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("notificationId")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("notificationId")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("notificationId")]
		public string? NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public PersonServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("person", "reload", null);
		}
	}

	public class PingServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public PingServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("ping", "reload", null);
		}
	}

	public class RecorderServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public RecorderServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Disable()
		{
			_haContext.CallService("recorder", "disable", null);
		}

		public void Enable()
		{
			_haContext.CallService("recorder", "enable", null);
		}

		public void Purge(RecorderPurgeParameters data)
		{
			_haContext.CallService("recorder", "purge", null, data);
		}

		public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
		{
			_haContext.CallService("recorder", "purge", null, new
			{
			@keep_days = @keepDays, @repack, @apply_filter = @applyFilter
			}

			);
		}

		public void PurgeEntities(NetDaemon.HassModel.Entities.ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		public void PurgeEntities(NetDaemon.HassModel.Entities.ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new
			{
			@domains, @entity_globs = @entityGlobs
			}

			);
		}
	}

	public record RecorderPurgeParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("keepDays")]
		public long? KeepDays { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("applyFilter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("domains")]
		public object? Domains { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("entityGlobs")]
		public object? EntityGlobs { get; init; }
	}

	public class RemoteServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public RemoteServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void DeleteCommand(NetDaemon.HassModel.Entities.ServiceTarget target, RemoteDeleteCommandParameters data)
		{
			_haContext.CallService("remote", "delete_command", target, data);
		}

		public void DeleteCommand(NetDaemon.HassModel.Entities.ServiceTarget target, object @command, string? @device = null)
		{
			_haContext.CallService("remote", "delete_command", target, new
			{
			@device, @command
			}

			);
		}

		public void LearnCommand(NetDaemon.HassModel.Entities.ServiceTarget target, RemoteLearnCommandParameters data)
		{
			_haContext.CallService("remote", "learn_command", target, data);
		}

		public void LearnCommand(NetDaemon.HassModel.Entities.ServiceTarget target, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			_haContext.CallService("remote", "learn_command", target, new
			{
			@device, @command, @command_type = @commandType, @alternative, @timeout
			}

			);
		}

		public void SendCommand(NetDaemon.HassModel.Entities.ServiceTarget target, RemoteSendCommandParameters data)
		{
			_haContext.CallService("remote", "send_command", target, data);
		}

		public void SendCommand(NetDaemon.HassModel.Entities.ServiceTarget target, string @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			_haContext.CallService("remote", "send_command", target, new
			{
			@device, @command, @num_repeats = @numRepeats, @delay_secs = @delaySecs, @hold_secs = @holdSecs
			}

			);
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("remote", "toggle", target);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("remote", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, RemoteTurnOnParameters data)
		{
			_haContext.CallService("remote", "turn_on", target, data);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, string? @activity = null)
		{
			_haContext.CallService("remote", "turn_on", target, new
			{
			@activity
			}

			);
		}
	}

	public record RemoteDeleteCommandParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("device")]
		public string? Device { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("command")]
		public object? Command { get; init; }
	}

	public record RemoteLearnCommandParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("device")]
		public string? Device { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("command")]
		public object? Command { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("commandType")]
		public string? CommandType { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("alternative")]
		public bool? Alternative { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("timeout")]
		public long? Timeout { get; init; }
	}

	public record RemoteSendCommandParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("device")]
		public string? Device { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("command")]
		public string? Command { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("numRepeats")]
		public long? NumRepeats { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("delaySecs")]
		public double? DelaySecs { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("holdSecs")]
		public double? HoldSecs { get; init; }
	}

	public record RemoteTurnOnParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("activity")]
		public string? Activity { get; init; }
	}

	public class SceneServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SceneServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		public void Apply(object @entities, long? @transition = null)
		{
			_haContext.CallService("scene", "apply", null, new
			{
			@entities, @transition
			}

			);
		}

		public void Create(SceneCreateParameters data)
		{
			_haContext.CallService("scene", "create", null, data);
		}

		public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
		{
			_haContext.CallService("scene", "create", null, new
			{
			@scene_id = @sceneId, @entities, @snapshot_entities = @snapshotEntities
			}

			);
		}

		public void Reload()
		{
			_haContext.CallService("scene", "reload", null);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new
			{
			@transition
			}

			);
		}
	}

	public record SceneApplyParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entities")]
		public object? Entities { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("sceneId")]
		public string? SceneId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("entities")]
		public object? Entities { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("snapshotEntities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public class SchedulerServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SchedulerServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Add(SchedulerAddParameters data)
		{
			_haContext.CallService("scheduler", "add", null, data);
		}

		public void Add(object @timeslots, string @repeatType, object? @weekdays = null, object? @startDate = null, object? @endDate = null, string? @name = null)
		{
			_haContext.CallService("scheduler", "add", null, new
			{
			@weekdays, @start_date = @startDate, @end_date = @endDate, @timeslots, @repeat_type = @repeatType, @name
			}

			);
		}

		public void Copy(SchedulerCopyParameters data)
		{
			_haContext.CallService("scheduler", "copy", null, data);
		}

		public void Copy(string @entityId, string? @name = null)
		{
			_haContext.CallService("scheduler", "copy", null, new
			{
			@entity_id = @entityId, @name
			}

			);
		}

		public void Edit(SchedulerEditParameters data)
		{
			_haContext.CallService("scheduler", "edit", null, data);
		}

		public void Edit(string @entityId, object @timeslots, string @repeatType, object? @weekdays = null, object? @startDate = null, object? @endDate = null, string? @name = null)
		{
			_haContext.CallService("scheduler", "edit", null, new
			{
			@entity_id = @entityId, @weekdays, @start_date = @startDate, @end_date = @endDate, @timeslots, @repeat_type = @repeatType, @name
			}

			);
		}

		public void Remove(SchedulerRemoveParameters data)
		{
			_haContext.CallService("scheduler", "remove", null, data);
		}

		public void Remove(string @entityId)
		{
			_haContext.CallService("scheduler", "remove", null, new
			{
			@entity_id = @entityId
			}

			);
		}

		public void RunAction(SchedulerRunActionParameters data)
		{
			_haContext.CallService("scheduler", "run_action", null, data);
		}

		public void RunAction(string @entityId, DateTime? @time = null)
		{
			_haContext.CallService("scheduler", "run_action", null, new
			{
			@entity_id = @entityId, @time
			}

			);
		}
	}

	public record SchedulerAddParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("weekdays")]
		public object? Weekdays { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("startDate")]
		public object? StartDate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("endDate")]
		public object? EndDate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("timeslots")]
		public object? Timeslots { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("repeatType")]
		public string? RepeatType { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record SchedulerCopyParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record SchedulerEditParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("weekdays")]
		public object? Weekdays { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("startDate")]
		public object? StartDate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("endDate")]
		public object? EndDate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("timeslots")]
		public object? Timeslots { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("repeatType")]
		public string? RepeatType { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record SchedulerRemoveParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }
	}

	public record SchedulerRunActionParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("time")]
		public DateTime? Time { get; init; }
	}

	public class ScriptServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ScriptServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}
	}

	public class SpeedtestdotnetServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SpeedtestdotnetServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Speedtest()
		{
			_haContext.CallService("speedtestdotnet", "speedtest", null);
		}
	}

	public class SpotcastServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SpotcastServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Start(SpotcastStartParameters data)
		{
			_haContext.CallService("spotcast", "start", null, data);
		}

		public void Start(string? @deviceName = null, string? @spotifyDeviceId = null, string? @entityId = null, string? @uri = null, string? @search = null, string? @account = null, bool? @forcePlayback = null, bool? @randomSong = null, string? @repeat = null, bool? @shuffle = null, long? @offset = null, long? @startVolume = null, bool? @ignoreFullyPlayed = null)
		{
			_haContext.CallService("spotcast", "start", null, new
			{
			@device_name = @deviceName, @spotify_device_id = @spotifyDeviceId, @entity_id = @entityId, @uri, @search, @account, @force_playback = @forcePlayback, @random_song = @randomSong, @repeat, @shuffle, @offset, @start_volume = @startVolume, @ignore_fully_played = @ignoreFullyPlayed
			}

			);
		}
	}

	public record SpotcastStartParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("deviceName")]
		public string? DeviceName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("spotifyDeviceId")]
		public string? SpotifyDeviceId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("uri")]
		public string? Uri { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("search")]
		public string? Search { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("account")]
		public string? Account { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("forcePlayback")]
		public bool? ForcePlayback { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("randomSong")]
		public bool? RandomSong { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("repeat")]
		public string? Repeat { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("offset")]
		public long? Offset { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("startVolume")]
		public long? StartVolume { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("ignoreFullyPlayed")]
		public bool? IgnoreFullyPlayed { get; init; }
	}

	public class SwitchServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SwitchServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SynologyDsmServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SynologyDsmServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reboot(SynologyDsmRebootParameters data)
		{
			_haContext.CallService("synology_dsm", "reboot", null, data);
		}

		public void Reboot(string? @serial = null)
		{
			_haContext.CallService("synology_dsm", "reboot", null, new
			{
			@serial
			}

			);
		}

		public void Shutdown(SynologyDsmShutdownParameters data)
		{
			_haContext.CallService("synology_dsm", "shutdown", null, data);
		}

		public void Shutdown(string? @serial = null)
		{
			_haContext.CallService("synology_dsm", "shutdown", null, new
			{
			@serial
			}

			);
		}
	}

	public record SynologyDsmRebootParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("serial")]
		public string? Serial { get; init; }
	}

	public record SynologyDsmShutdownParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("serial")]
		public string? Serial { get; init; }
	}

	public class SystemLogServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SystemLogServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Clear()
		{
			_haContext.CallService("system_log", "clear", null);
		}

		public void Write(SystemLogWriteParameters data)
		{
			_haContext.CallService("system_log", "write", null, data);
		}

		public void Write(string @message, string? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new
			{
			@message, @level, @logger
			}

			);
		}
	}

	public record SystemLogWriteParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("level")]
		public string? Level { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("logger")]
		public string? Logger { get; init; }
	}

	public class TemplateServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public TemplateServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("template", "reload", null);
		}
	}

	public class TimerServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public TimerServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Cancel(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		public void Finish(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		public void Pause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		public void Start(NetDaemon.HassModel.Entities.ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		public void Start(NetDaemon.HassModel.Entities.ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new
			{
			@duration
			}

			);
		}
	}

	public record TimerStartParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class TuyaServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public TuyaServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void ForceUpdate()
		{
			_haContext.CallService("tuya", "force_update", null);
		}

		public void PullDevices()
		{
			_haContext.CallService("tuya", "pull_devices", null);
		}
	}

	public class VacuumServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public VacuumServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void CleanSpot(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		public void Locate(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		public void Pause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		public void ReturnToBase(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		public void SendCommand(NetDaemon.HassModel.Entities.ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		public void SendCommand(NetDaemon.HassModel.Entities.ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new
			{
			@command, @params
			}

			);
		}

		public void SetFanSpeed(NetDaemon.HassModel.Entities.ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		public void SetFanSpeed(NetDaemon.HassModel.Entities.ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new
			{
			@fan_speed = @fanSpeed
			}

			);
		}

		public void Start(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		public void StartPause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		public void Stop(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("command")]
		public string? Command { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("fanSpeed")]
		public string? FanSpeed { get; init; }
	}

	public class VarServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public VarServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Set(VarSetParameters data)
		{
			_haContext.CallService("var", "set", null, data);
		}

		public void Set(string? @entityId = null, string? @value = null, string? @valueTemplate = null, string? @trackedEntityId = null, string? @trackedEventType = null, string? @query = null, string? @column = null, string? @restore = null, string? @forceUpdate = null, string? @unitOfMeasurement = null, string? @icon = null, string? @iconTemplate = null, string? @entityPicture = null, string? @entityPictureTemplate = null)
		{
			_haContext.CallService("var", "set", null, new
			{
			@entity_id = @entityId, @value, @value_template = @valueTemplate, @tracked_entity_id = @trackedEntityId, @tracked_event_type = @trackedEventType, @query, @column, @restore, @force_update = @forceUpdate, @unit_of_measurement = @unitOfMeasurement, @icon, @icon_template = @iconTemplate, @entity_picture = @entityPicture, @entity_picture_template = @entityPictureTemplate
			}

			);
		}

		public void Update(VarUpdateParameters data)
		{
			_haContext.CallService("var", "update", null, data);
		}

		public void Update(string? @entityId = null)
		{
			_haContext.CallService("var", "update", null, new
			{
			@entity_id = @entityId
			}

			);
		}
	}

	public record VarSetParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public string? Value { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("valueTemplate")]
		public string? ValueTemplate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("trackedEntityId")]
		public string? TrackedEntityId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("trackedEventType")]
		public string? TrackedEventType { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("query")]
		public string? Query { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("column")]
		public string? Column { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("restore")]
		public string? Restore { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("forceUpdate")]
		public string? ForceUpdate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurement")]
		public string? UnitOfMeasurement { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("iconTemplate")]
		public string? IconTemplate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("entityPicture")]
		public string? EntityPicture { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("entityPictureTemplate")]
		public string? EntityPictureTemplate { get; init; }
	}

	public record VarUpdateParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }
	}

	public class WakeOnLanServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public WakeOnLanServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void SendMagicPacket(WakeOnLanSendMagicPacketParameters data)
		{
			_haContext.CallService("wake_on_lan", "send_magic_packet", null, data);
		}

		public void SendMagicPacket(string @mac, string? @broadcastAddress = null, long? @broadcastPort = null)
		{
			_haContext.CallService("wake_on_lan", "send_magic_packet", null, new
			{
			@mac, @broadcast_address = @broadcastAddress, @broadcast_port = @broadcastPort
			}

			);
		}
	}

	public record WakeOnLanSendMagicPacketParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("mac")]
		public string? Mac { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("broadcastAddress")]
		public string? BroadcastAddress { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("broadcastPort")]
		public long? BroadcastPort { get; init; }
	}

	public class XiaomiCloudMapExtractorServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public XiaomiCloudMapExtractorServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("xiaomi_cloud_map_extractor", "reload", null);
		}
	}

	public class XiaomiMiioServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public XiaomiMiioServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void VacuumCleanSegment(NetDaemon.HassModel.Entities.ServiceTarget target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, data);
		}

		public void VacuumCleanSegment(NetDaemon.HassModel.Entities.ServiceTarget target, object? @segments = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, new
			{
			@segments
			}

			);
		}

		public void VacuumCleanZone(NetDaemon.HassModel.Entities.ServiceTarget target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, data);
		}

		public void VacuumCleanZone(NetDaemon.HassModel.Entities.ServiceTarget target, object? @zone = null, long? @repeats = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, new
			{
			@zone, @repeats
			}

			);
		}

		public void VacuumGoto(NetDaemon.HassModel.Entities.ServiceTarget target, XiaomiMiioVacuumGotoParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, data);
		}

		public void VacuumGoto(NetDaemon.HassModel.Entities.ServiceTarget target, string? @xCoord = null, string? @yCoord = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, new
			{
			@x_coord = @xCoord, @y_coord = @yCoord
			}

			);
		}

		public void VacuumRemoteControlMove(NetDaemon.HassModel.Entities.ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, data);
		}

		public void VacuumRemoteControlMove(NetDaemon.HassModel.Entities.ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, new
			{
			@velocity, @rotation, @duration
			}

			);
		}

		public void VacuumRemoteControlMoveStep(NetDaemon.HassModel.Entities.ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, data);
		}

		public void VacuumRemoteControlMoveStep(NetDaemon.HassModel.Entities.ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, new
			{
			@velocity, @rotation, @duration
			}

			);
		}

		public void VacuumRemoteControlStart(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_start", target);
		}

		public void VacuumRemoteControlStop(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_stop", target);
		}
	}

	public record XiaomiMiioVacuumCleanSegmentParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("segments")]
		public object? Segments { get; init; }
	}

	public record XiaomiMiioVacuumCleanZoneParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("zone")]
		public object? Zone { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("repeats")]
		public long? Repeats { get; init; }
	}

	public record XiaomiMiioVacuumGotoParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("xCoord")]
		public string? XCoord { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("yCoord")]
		public string? YCoord { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveStepParameters
	{
		[System.Text.Json.Serialization.JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public class ZoneServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ZoneServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public static class AlarmControlPanelEntityExtensionMethods
	{
		public static void AlarmArmAway(this AlarmControlPanelEntity entity, AlarmControlPanelAlarmArmAwayParameters data)
		{
			entity.CallService("alarm_arm_away", data);
		}

		public static void AlarmArmAway(this AlarmControlPanelEntity entity, string? @code = null)
		{
			entity.CallService("alarm_arm_away", new
			{
			@code
			}

			);
		}

		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity entity, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			entity.CallService("alarm_arm_custom_bypass", data);
		}

		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity entity, string? @code = null)
		{
			entity.CallService("alarm_arm_custom_bypass", new
			{
			@code
			}

			);
		}

		public static void AlarmArmHome(this AlarmControlPanelEntity entity, AlarmControlPanelAlarmArmHomeParameters data)
		{
			entity.CallService("alarm_arm_home", data);
		}

		public static void AlarmArmHome(this AlarmControlPanelEntity entity, string? @code = null)
		{
			entity.CallService("alarm_arm_home", new
			{
			@code
			}

			);
		}

		public static void AlarmArmNight(this AlarmControlPanelEntity entity, AlarmControlPanelAlarmArmNightParameters data)
		{
			entity.CallService("alarm_arm_night", data);
		}

		public static void AlarmArmNight(this AlarmControlPanelEntity entity, string? @code = null)
		{
			entity.CallService("alarm_arm_night", new
			{
			@code
			}

			);
		}

		public static void AlarmDisarm(this AlarmControlPanelEntity entity, AlarmControlPanelAlarmDisarmParameters data)
		{
			entity.CallService("alarm_disarm", data);
		}

		public static void AlarmDisarm(this AlarmControlPanelEntity entity, string? @code = null)
		{
			entity.CallService("alarm_disarm", new
			{
			@code
			}

			);
		}

		public static void AlarmTrigger(this AlarmControlPanelEntity entity, AlarmControlPanelAlarmTriggerParameters data)
		{
			entity.CallService("alarm_trigger", data);
		}

		public static void AlarmTrigger(this AlarmControlPanelEntity entity, string? @code = null)
		{
			entity.CallService("alarm_trigger", new
			{
			@code
			}

			);
		}
	}

	public static class CameraEntityExtensionMethods
	{
		public static void DisableMotionDetection(this CameraEntity entity)
		{
			entity.CallService("disable_motion_detection");
		}

		public static void EnableMotionDetection(this CameraEntity entity)
		{
			entity.CallService("enable_motion_detection");
		}

		public static void PlayStream(this CameraEntity entity, CameraPlayStreamParameters data)
		{
			entity.CallService("play_stream", data);
		}

		public static void PlayStream(this CameraEntity entity, string @mediaPlayer, string? @format = null)
		{
			entity.CallService("play_stream", new
			{
			@media_player = @mediaPlayer, @format
			}

			);
		}

		public static void Record(this CameraEntity entity, CameraRecordParameters data)
		{
			entity.CallService("record", data);
		}

		public static void Record(this CameraEntity entity, string @filename, long? @duration = null, long? @lookback = null)
		{
			entity.CallService("record", new
			{
			@filename, @duration, @lookback
			}

			);
		}

		public static void Snapshot(this CameraEntity entity, CameraSnapshotParameters data)
		{
			entity.CallService("snapshot", data);
		}

		public static void Snapshot(this CameraEntity entity, string @filename)
		{
			entity.CallService("snapshot", new
			{
			@filename
			}

			);
		}

		public static void TurnOff(this CameraEntity entity)
		{
			entity.CallService("turn_off");
		}

		public static void TurnOn(this CameraEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		public static void SetAuxHeat(this ClimateEntity entity, ClimateSetAuxHeatParameters data)
		{
			entity.CallService("set_aux_heat", data);
		}

		public static void SetAuxHeat(this ClimateEntity entity, bool @auxHeat)
		{
			entity.CallService("set_aux_heat", new
			{
			@aux_heat = @auxHeat
			}

			);
		}

		public static void SetFanMode(this ClimateEntity entity, ClimateSetFanModeParameters data)
		{
			entity.CallService("set_fan_mode", data);
		}

		public static void SetFanMode(this ClimateEntity entity, string @fanMode)
		{
			entity.CallService("set_fan_mode", new
			{
			@fan_mode = @fanMode
			}

			);
		}

		public static void SetHumidity(this ClimateEntity entity, ClimateSetHumidityParameters data)
		{
			entity.CallService("set_humidity", data);
		}

		public static void SetHumidity(this ClimateEntity entity, long @humidity)
		{
			entity.CallService("set_humidity", new
			{
			@humidity
			}

			);
		}

		public static void SetHvacMode(this ClimateEntity entity, ClimateSetHvacModeParameters data)
		{
			entity.CallService("set_hvac_mode", data);
		}

		public static void SetHvacMode(this ClimateEntity entity, string? @hvacMode = null)
		{
			entity.CallService("set_hvac_mode", new
			{
			@hvac_mode = @hvacMode
			}

			);
		}

		public static void SetPresetMode(this ClimateEntity entity, ClimateSetPresetModeParameters data)
		{
			entity.CallService("set_preset_mode", data);
		}

		public static void SetPresetMode(this ClimateEntity entity, string @presetMode)
		{
			entity.CallService("set_preset_mode", new
			{
			@preset_mode = @presetMode
			}

			);
		}

		public static void SetSwingMode(this ClimateEntity entity, ClimateSetSwingModeParameters data)
		{
			entity.CallService("set_swing_mode", data);
		}

		public static void SetSwingMode(this ClimateEntity entity, string @swingMode)
		{
			entity.CallService("set_swing_mode", new
			{
			@swing_mode = @swingMode
			}

			);
		}

		public static void SetTemperature(this ClimateEntity entity, ClimateSetTemperatureParameters data)
		{
			entity.CallService("set_temperature", data);
		}

		public static void SetTemperature(this ClimateEntity entity, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			entity.CallService("set_temperature", new
			{
			@temperature, @target_temp_high = @targetTempHigh, @target_temp_low = @targetTempLow, @hvac_mode = @hvacMode
			}

			);
		}

		public static void TurnOff(this ClimateEntity entity)
		{
			entity.CallService("turn_off");
		}

		public static void TurnOn(this ClimateEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class CounterEntityExtensionMethods
	{
		public static void Configure(this CounterEntity entity, CounterConfigureParameters data)
		{
			entity.CallService("configure", data);
		}

		public static void Configure(this CounterEntity entity, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			entity.CallService("configure", new
			{
			@minimum, @maximum, @step, @initial, @value
			}

			);
		}

		public static void Decrement(this CounterEntity entity)
		{
			entity.CallService("decrement");
		}

		public static void Increment(this CounterEntity entity)
		{
			entity.CallService("increment");
		}

		public static void Reset(this CounterEntity entity)
		{
			entity.CallService("reset");
		}
	}

	public static class HarmonyEntityExtensionMethods
	{
		public static void ChangeChannel(this RemoteEntity entity, HarmonyChangeChannelParameters data)
		{
			entity.CallService("change_channel", data);
		}

		public static void ChangeChannel(this RemoteEntity entity, long @channel)
		{
			entity.CallService("change_channel", new
			{
			@channel
			}

			);
		}

		public static void Sync(this RemoteEntity entity)
		{
			entity.CallService("sync");
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		public static void Toggle(this InputBooleanEntity entity)
		{
			entity.CallService("toggle");
		}

		public static void TurnOff(this InputBooleanEntity entity)
		{
			entity.CallService("turn_off");
		}

		public static void TurnOn(this InputBooleanEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class InputNumberEntityExtensionMethods
	{
		public static void Decrement(this InputNumberEntity entity)
		{
			entity.CallService("decrement");
		}

		public static void Increment(this InputNumberEntity entity)
		{
			entity.CallService("increment");
		}

		public static void SetValue(this InputNumberEntity entity, InputNumberSetValueParameters data)
		{
			entity.CallService("set_value", data);
		}

		public static void SetValue(this InputNumberEntity entity, double @value)
		{
			entity.CallService("set_value", new
			{
			@value
			}

			);
		}
	}

	public static class InputSelectEntityExtensionMethods
	{
		public static void SelectFirst(this InputSelectEntity entity)
		{
			entity.CallService("select_first");
		}

		public static void SelectLast(this InputSelectEntity entity)
		{
			entity.CallService("select_last");
		}

		public static void SelectNext(this InputSelectEntity entity, InputSelectSelectNextParameters data)
		{
			entity.CallService("select_next", data);
		}

		public static void SelectNext(this InputSelectEntity entity, bool? @cycle = null)
		{
			entity.CallService("select_next", new
			{
			@cycle
			}

			);
		}

		public static void SelectOption(this InputSelectEntity entity, InputSelectSelectOptionParameters data)
		{
			entity.CallService("select_option", data);
		}

		public static void SelectOption(this InputSelectEntity entity, string @option)
		{
			entity.CallService("select_option", new
			{
			@option
			}

			);
		}

		public static void SelectPrevious(this InputSelectEntity entity, InputSelectSelectPreviousParameters data)
		{
			entity.CallService("select_previous", data);
		}

		public static void SelectPrevious(this InputSelectEntity entity, bool? @cycle = null)
		{
			entity.CallService("select_previous", new
			{
			@cycle
			}

			);
		}

		public static void SetOptions(this InputSelectEntity entity, InputSelectSetOptionsParameters data)
		{
			entity.CallService("set_options", data);
		}

		public static void SetOptions(this InputSelectEntity entity, object @options)
		{
			entity.CallService("set_options", new
			{
			@options
			}

			);
		}
	}

	public static class LightEntityExtensionMethods
	{
		public static void Toggle(this LightEntity entity, LightToggleParameters data)
		{
			entity.CallService("toggle", data);
		}

		public static void Toggle(this LightEntity entity, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			entity.CallService("toggle", new
			{
			@transition, @rgb_color = @rgbColor, @color_name = @colorName, @hs_color = @hsColor, @xy_color = @xyColor, @color_temp = @colorTemp, @kelvin, @white_value = @whiteValue, @brightness, @brightness_pct = @brightnessPct, @profile, @flash, @effect
			}

			);
		}

		public static void TurnOff(this LightEntity entity, LightTurnOffParameters data)
		{
			entity.CallService("turn_off", data);
		}

		public static void TurnOff(this LightEntity entity, long? @transition = null, string? @flash = null)
		{
			entity.CallService("turn_off", new
			{
			@transition, @flash
			}

			);
		}

		public static void TurnOn(this LightEntity entity, LightTurnOnParameters data)
		{
			entity.CallService("turn_on", data);
		}

		public static void TurnOn(this LightEntity entity, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			entity.CallService("turn_on", new
			{
			@transition, @rgb_color = @rgbColor, @rgbw_color = @rgbwColor, @rgbww_color = @rgbwwColor, @color_name = @colorName, @hs_color = @hsColor, @xy_color = @xyColor, @color_temp = @colorTemp, @kelvin, @brightness, @brightness_pct = @brightnessPct, @brightness_step = @brightnessStep, @brightness_step_pct = @brightnessStepPct, @profile, @flash, @effect
			}

			);
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		public static void ClearPlaylist(this MediaPlayerEntity entity)
		{
			entity.CallService("clear_playlist");
		}

		public static void Join(this MediaPlayerEntity entity, MediaPlayerJoinParameters data)
		{
			entity.CallService("join", data);
		}

		public static void Join(this MediaPlayerEntity entity, object? @groupMembers = null)
		{
			entity.CallService("join", new
			{
			@group_members = @groupMembers
			}

			);
		}

		public static void MediaNextTrack(this MediaPlayerEntity entity)
		{
			entity.CallService("media_next_track");
		}

		public static void MediaPause(this MediaPlayerEntity entity)
		{
			entity.CallService("media_pause");
		}

		public static void MediaPlay(this MediaPlayerEntity entity)
		{
			entity.CallService("media_play");
		}

		public static void MediaPlayPause(this MediaPlayerEntity entity)
		{
			entity.CallService("media_play_pause");
		}

		public static void MediaPreviousTrack(this MediaPlayerEntity entity)
		{
			entity.CallService("media_previous_track");
		}

		public static void MediaSeek(this MediaPlayerEntity entity, MediaPlayerMediaSeekParameters data)
		{
			entity.CallService("media_seek", data);
		}

		public static void MediaSeek(this MediaPlayerEntity entity, double @seekPosition)
		{
			entity.CallService("media_seek", new
			{
			@seek_position = @seekPosition
			}

			);
		}

		public static void MediaStop(this MediaPlayerEntity entity)
		{
			entity.CallService("media_stop");
		}

		public static void PlayMedia(this MediaPlayerEntity entity, MediaPlayerPlayMediaParameters data)
		{
			entity.CallService("play_media", data);
		}

		public static void PlayMedia(this MediaPlayerEntity entity, string @mediaContentId, string @mediaContentType)
		{
			entity.CallService("play_media", new
			{
			@media_content_id = @mediaContentId, @media_content_type = @mediaContentType
			}

			);
		}

		public static void RepeatSet(this MediaPlayerEntity entity, MediaPlayerRepeatSetParameters data)
		{
			entity.CallService("repeat_set", data);
		}

		public static void RepeatSet(this MediaPlayerEntity entity, string @repeat)
		{
			entity.CallService("repeat_set", new
			{
			@repeat
			}

			);
		}

		public static void SelectSoundMode(this MediaPlayerEntity entity, MediaPlayerSelectSoundModeParameters data)
		{
			entity.CallService("select_sound_mode", data);
		}

		public static void SelectSoundMode(this MediaPlayerEntity entity, string? @soundMode = null)
		{
			entity.CallService("select_sound_mode", new
			{
			@sound_mode = @soundMode
			}

			);
		}

		public static void SelectSource(this MediaPlayerEntity entity, MediaPlayerSelectSourceParameters data)
		{
			entity.CallService("select_source", data);
		}

		public static void SelectSource(this MediaPlayerEntity entity, string @source)
		{
			entity.CallService("select_source", new
			{
			@source
			}

			);
		}

		public static void ShuffleSet(this MediaPlayerEntity entity, MediaPlayerShuffleSetParameters data)
		{
			entity.CallService("shuffle_set", data);
		}

		public static void ShuffleSet(this MediaPlayerEntity entity, bool @shuffle)
		{
			entity.CallService("shuffle_set", new
			{
			@shuffle
			}

			);
		}

		public static void Toggle(this MediaPlayerEntity entity)
		{
			entity.CallService("toggle");
		}

		public static void TurnOff(this MediaPlayerEntity entity)
		{
			entity.CallService("turn_off");
		}

		public static void TurnOn(this MediaPlayerEntity entity)
		{
			entity.CallService("turn_on");
		}

		public static void Unjoin(this MediaPlayerEntity entity)
		{
			entity.CallService("unjoin");
		}

		public static void VolumeDown(this MediaPlayerEntity entity)
		{
			entity.CallService("volume_down");
		}

		public static void VolumeMute(this MediaPlayerEntity entity, MediaPlayerVolumeMuteParameters data)
		{
			entity.CallService("volume_mute", data);
		}

		public static void VolumeMute(this MediaPlayerEntity entity, bool @isVolumeMuted)
		{
			entity.CallService("volume_mute", new
			{
			@is_volume_muted = @isVolumeMuted
			}

			);
		}

		public static void VolumeSet(this MediaPlayerEntity entity, MediaPlayerVolumeSetParameters data)
		{
			entity.CallService("volume_set", data);
		}

		public static void VolumeSet(this MediaPlayerEntity entity, double @volumeLevel)
		{
			entity.CallService("volume_set", new
			{
			@volume_level = @volumeLevel
			}

			);
		}

		public static void VolumeUp(this MediaPlayerEntity entity)
		{
			entity.CallService("volume_up");
		}
	}

	public static class RemoteEntityExtensionMethods
	{
		public static void DeleteCommand(this RemoteEntity entity, RemoteDeleteCommandParameters data)
		{
			entity.CallService("delete_command", data);
		}

		public static void DeleteCommand(this RemoteEntity entity, object @command, string? @device = null)
		{
			entity.CallService("delete_command", new
			{
			@device, @command
			}

			);
		}

		public static void LearnCommand(this RemoteEntity entity, RemoteLearnCommandParameters data)
		{
			entity.CallService("learn_command", data);
		}

		public static void LearnCommand(this RemoteEntity entity, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			entity.CallService("learn_command", new
			{
			@device, @command, @command_type = @commandType, @alternative, @timeout
			}

			);
		}

		public static void SendCommand(this RemoteEntity entity, RemoteSendCommandParameters data)
		{
			entity.CallService("send_command", data);
		}

		public static void SendCommand(this RemoteEntity entity, string @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			entity.CallService("send_command", new
			{
			@device, @command, @num_repeats = @numRepeats, @delay_secs = @delaySecs, @hold_secs = @holdSecs
			}

			);
		}

		public static void Toggle(this RemoteEntity entity)
		{
			entity.CallService("toggle");
		}

		public static void TurnOff(this RemoteEntity entity)
		{
			entity.CallService("turn_off");
		}

		public static void TurnOn(this RemoteEntity entity, RemoteTurnOnParameters data)
		{
			entity.CallService("turn_on", data);
		}

		public static void TurnOn(this RemoteEntity entity, string? @activity = null)
		{
			entity.CallService("turn_on", new
			{
			@activity
			}

			);
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		public static void Toggle(this SwitchEntity entity)
		{
			entity.CallService("toggle");
		}

		public static void TurnOff(this SwitchEntity entity)
		{
			entity.CallService("turn_off");
		}

		public static void TurnOn(this SwitchEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class TimerEntityExtensionMethods
	{
		public static void Cancel(this TimerEntity entity)
		{
			entity.CallService("cancel");
		}

		public static void Finish(this TimerEntity entity)
		{
			entity.CallService("finish");
		}

		public static void Pause(this TimerEntity entity)
		{
			entity.CallService("pause");
		}

		public static void Start(this TimerEntity entity, TimerStartParameters data)
		{
			entity.CallService("start", data);
		}

		public static void Start(this TimerEntity entity, string? @duration = null)
		{
			entity.CallService("start", new
			{
			@duration
			}

			);
		}
	}

	public static class VacuumEntityExtensionMethods
	{
		public static void CleanSpot(this VacuumEntity entity)
		{
			entity.CallService("clean_spot");
		}

		public static void Locate(this VacuumEntity entity)
		{
			entity.CallService("locate");
		}

		public static void Pause(this VacuumEntity entity)
		{
			entity.CallService("pause");
		}

		public static void ReturnToBase(this VacuumEntity entity)
		{
			entity.CallService("return_to_base");
		}

		public static void SendCommand(this VacuumEntity entity, VacuumSendCommandParameters data)
		{
			entity.CallService("send_command", data);
		}

		public static void SendCommand(this VacuumEntity entity, string @command, object? @params = null)
		{
			entity.CallService("send_command", new
			{
			@command, @params
			}

			);
		}

		public static void SetFanSpeed(this VacuumEntity entity, VacuumSetFanSpeedParameters data)
		{
			entity.CallService("set_fan_speed", data);
		}

		public static void SetFanSpeed(this VacuumEntity entity, string @fanSpeed)
		{
			entity.CallService("set_fan_speed", new
			{
			@fan_speed = @fanSpeed
			}

			);
		}

		public static void Start(this VacuumEntity entity)
		{
			entity.CallService("start");
		}

		public static void StartPause(this VacuumEntity entity)
		{
			entity.CallService("start_pause");
		}

		public static void Stop(this VacuumEntity entity)
		{
			entity.CallService("stop");
		}

		public static void TurnOff(this VacuumEntity entity)
		{
			entity.CallService("turn_off");
		}

		public static void TurnOn(this VacuumEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class XiaomiMiioEntityExtensionMethods
	{
		public static void VacuumCleanSegment(this VacuumEntity entity, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			entity.CallService("vacuum_clean_segment", data);
		}

		public static void VacuumCleanSegment(this VacuumEntity entity, object? @segments = null)
		{
			entity.CallService("vacuum_clean_segment", new
			{
			@segments
			}

			);
		}

		public static void VacuumCleanZone(this VacuumEntity entity, XiaomiMiioVacuumCleanZoneParameters data)
		{
			entity.CallService("vacuum_clean_zone", data);
		}

		public static void VacuumCleanZone(this VacuumEntity entity, object? @zone = null, long? @repeats = null)
		{
			entity.CallService("vacuum_clean_zone", new
			{
			@zone, @repeats
			}

			);
		}

		public static void VacuumGoto(this VacuumEntity entity, XiaomiMiioVacuumGotoParameters data)
		{
			entity.CallService("vacuum_goto", data);
		}

		public static void VacuumGoto(this VacuumEntity entity, string? @xCoord = null, string? @yCoord = null)
		{
			entity.CallService("vacuum_goto", new
			{
			@x_coord = @xCoord, @y_coord = @yCoord
			}

			);
		}

		public static void VacuumRemoteControlMove(this VacuumEntity entity, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			entity.CallService("vacuum_remote_control_move", data);
		}

		public static void VacuumRemoteControlMove(this VacuumEntity entity, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			entity.CallService("vacuum_remote_control_move", new
			{
			@velocity, @rotation, @duration
			}

			);
		}

		public static void VacuumRemoteControlMoveStep(this VacuumEntity entity, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			entity.CallService("vacuum_remote_control_move_step", data);
		}

		public static void VacuumRemoteControlMoveStep(this VacuumEntity entity, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			entity.CallService("vacuum_remote_control_move_step", new
			{
			@velocity, @rotation, @duration
			}

			);
		}

		public static void VacuumRemoteControlStart(this VacuumEntity entity)
		{
			entity.CallService("vacuum_remote_control_start");
		}

		public static void VacuumRemoteControlStop(this VacuumEntity entity)
		{
			entity.CallService("vacuum_remote_control_stop");
		}
	}
}