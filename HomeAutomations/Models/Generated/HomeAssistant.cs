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

		InputTextEntities InputText { get; }

		LightEntities Light { get; }

		MediaPlayerEntities MediaPlayer { get; }

		PersistentNotificationEntities PersistentNotification { get; }

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
		public InputTextEntities InputText => new(_haContext);
		public LightEntities Light => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public PersistentNotificationEntities PersistentNotification => new(_haContext);
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

		///<summary>Intrusion Detection System</summary>
		public AlarmControlPanelEntity IntrusionDetectionSystem => new(_haContext, "alarm_control_panel.intrusion_detection_system");
	}

	public class BinarySensorEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public BinarySensorEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>0x00158d0007bcae5d occupancy</summary>
		public BinarySensorEntity E0x00158d0007bcae5dOccupancy => new(_haContext, "binary_sensor.0x00158d0007bcae5d_occupancy");
		///<summary>Balkontür links</summary>
		public BinarySensorEntity BalkonturLinks => new(_haContext, "binary_sensor.balkontur_links");
		///<summary>Balkontür links Battery</summary>
		public BinarySensorEntity BalkonturLinksBattery => new(_haContext, "binary_sensor.balkontur_links_battery");
		///<summary>Balkontür rechts</summary>
		public BinarySensorEntity BalkonturRechts => new(_haContext, "binary_sensor.balkontur_rechts");
		///<summary>Balkontür rechts Battery</summary>
		public BinarySensorEntity BalkonturRechtsBattery => new(_haContext, "binary_sensor.balkontur_rechts_battery");
		///<summary>DesktopFabienne</summary>
		public BinarySensorEntity Desktopfabienne => new(_haContext, "binary_sensor.desktopfabienne");
		///<summary>DesktopPhilipp</summary>
		public BinarySensorEntity Desktopphilipp => new(_haContext, "binary_sensor.desktopphilipp");
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
		///<summary>iphone_philipp Focus</summary>
		public BinarySensorEntity IphonePhilippFocus => new(_haContext, "binary_sensor.iphone_philipp_focus");
		///<summary>LaptopFabienne</summary>
		public BinarySensorEntity Laptopfabienne => new(_haContext, "binary_sensor.laptopfabienne");
		///<summary>LaptopPhilipp</summary>
		public BinarySensorEntity Laptopphilipp => new(_haContext, "binary_sensor.laptopphilipp");
		///<summary>sleep_mode</summary>
		public BinarySensorEntity Nodered34b1e88b368528 => new(_haContext, "binary_sensor.nodered_34b1e88b_368528");
		///<summary>PupsStation Drive 1 Below Min Remaining Life</summary>
		public BinarySensorEntity PupsstationDrive1BelowMinRemainingLife => new(_haContext, "binary_sensor.pupsstation_drive_1_below_min_remaining_life");
		///<summary>PupsStation Drive 1 Exceeded Max Bad Sectors</summary>
		public BinarySensorEntity PupsstationDrive1ExceededMaxBadSectors => new(_haContext, "binary_sensor.pupsstation_drive_1_exceeded_max_bad_sectors");
		///<summary>PupsStation Drive 2 Below Min Remaining Life</summary>
		public BinarySensorEntity PupsstationDrive2BelowMinRemainingLife => new(_haContext, "binary_sensor.pupsstation_drive_2_below_min_remaining_life");
		///<summary>PupsStation Drive 2 Exceeded Max Bad Sectors</summary>
		public BinarySensorEntity PupsstationDrive2ExceededMaxBadSectors => new(_haContext, "binary_sensor.pupsstation_drive_2_exceeded_max_bad_sectors");
		///<summary>PupsStation Security status</summary>
		public BinarySensorEntity PupsstationSecurityStatus => new(_haContext, "binary_sensor.pupsstation_security_status");
		///<summary>PupsStation Update available</summary>
		public BinarySensorEntity PupsstationUpdateAvailable => new(_haContext, "binary_sensor.pupsstation_update_available");
		///<summary>Thermostat Arbeitszimmer Battery</summary>
		public BinarySensorEntity ThermostatArbeitszimmerBattery => new(_haContext, "binary_sensor.thermostat_arbeitszimmer_battery");
		///<summary>Thermostat Badezimmer Battery</summary>
		public BinarySensorEntity ThermostatBadezimmerBattery => new(_haContext, "binary_sensor.thermostat_badezimmer_battery");
		///<summary>Thermostat Schlafzimmer Battery</summary>
		public BinarySensorEntity ThermostatSchlafzimmerBattery => new(_haContext, "binary_sensor.thermostat_schlafzimmer_battery");
		///<summary>Thermostat Wohnzimmer Battery</summary>
		public BinarySensorEntity ThermostatWohnzimmerBattery => new(_haContext, "binary_sensor.thermostat_wohnzimmer_battery");
		///<summary>trash_bio</summary>
		public BinarySensorEntity TrashBio => new(_haContext, "binary_sensor.trash_bio");
		///<summary>trash_glass</summary>
		public BinarySensorEntity TrashGlass => new(_haContext, "binary_sensor.trash_glass");
		///<summary>trash_paper</summary>
		public BinarySensorEntity TrashPaper => new(_haContext, "binary_sensor.trash_paper");
		///<summary>trash_recycling</summary>
		public BinarySensorEntity TrashRecycling => new(_haContext, "binary_sensor.trash_recycling");
		///<summary>trash_waste</summary>
		public BinarySensorEntity TrashWaste => new(_haContext, "binary_sensor.trash_waste");
		///<summary>Updater</summary>
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
	}

	public class CalendarEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CalendarEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Abfallleerungen</summary>
		public CalendarEntity Abfallleerungen => new(_haContext, "calendar.abfallleerungen");
		///<summary>Birthdays</summary>
		public CalendarEntity Birthdays => new(_haContext, "calendar.birthdays");
		///<summary>christoph680@gmx.de</summary>
		public CalendarEntity Christoph680GmxDe => new(_haContext, "calendar.christoph680_gmx_de");
		///<summary>Family</summary>
		public CalendarEntity Family => new(_haContext, "calendar.family");
		///<summary>Feiertage in Deutschland</summary>
		public CalendarEntity FeiertageInDeutschland => new(_haContext, "calendar.feiertage_in_deutschland");
	}

	public class CameraEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CameraEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Fantenrüssel_Map</summary>
		public CameraEntity FantenrusselMap => new(_haContext, "camera.fantenrussel_map");
		///<summary>Wohnzimmer Camera</summary>
		public CameraEntity WohnzimmerCamera => new(_haContext, "camera.wohnzimmer_camera");
	}

	public class ClimateEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ClimateEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Room Climate Arbeitszimmer</summary>
		public ClimateEntity RoomClimateArbeitszimmer => new(_haContext, "climate.room_climate_arbeitszimmer");
		///<summary>Room Climate Badezimmer</summary>
		public ClimateEntity RoomClimateBadezimmer => new(_haContext, "climate.room_climate_badezimmer");
		///<summary>Room Climate Schlafzimmer</summary>
		public ClimateEntity RoomClimateSchlafzimmer => new(_haContext, "climate.room_climate_schlafzimmer");
		///<summary>Room Climate Wohnzimmer</summary>
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

		///<summary>🐘 FantenPhone 🐘</summary>
		public DeviceTrackerEntity Fabienne => new(_haContext, "device_tracker.fabienne");
		///<summary>Fantenpad</summary>
		public DeviceTrackerEntity IpadVonFabienne => new(_haContext, "device_tracker.ipad_von_fabienne");
		///<summary>philipp</summary>
		public DeviceTrackerEntity Philipp2b775363D7b348719abc6f36aa202757 => new(_haContext, "device_tracker.philipp_2b775363_d7b3_4871_9abc_6f36aa202757");
		///<summary>Philipp’s iPhone</summary>
		public DeviceTrackerEntity PhilippsIphone2 => new(_haContext, "device_tracker.philipps_iphone_2");
		///<summary>iphone_philipp</summary>
		public DeviceTrackerEntity PhilippsIphone3 => new(_haContext, "device_tracker.philipps_iphone_3");
	}

	public class GroupEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public GroupEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alle Fenster</summary>
		public GroupEntity Allwindows => new(_haContext, "group.allwindows");
	}

	public class InputBooleanEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputBooleanEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Barcode scanner connected?</summary>
		public InputBooleanEntity BarcodeScannerConnected => new(_haContext, "input_boolean.barcode_scanner_connected");
		///<summary>Meditation active?</summary>
		public InputBooleanEntity MeditationActive => new(_haContext, "input_boolean.meditation_active");
		///<summary>Bio</summary>
		public InputBooleanEntity TrashBio => new(_haContext, "input_boolean.trash_bio");
		///<summary>Glas</summary>
		public InputBooleanEntity TrashGlass => new(_haContext, "input_boolean.trash_glass");
		///<summary>Papier</summary>
		public InputBooleanEntity TrashPaper => new(_haContext, "input_boolean.trash_paper");
		///<summary>Gelber Sack</summary>
		public InputBooleanEntity TrashRecycling => new(_haContext, "input_boolean.trash_recycling");
		///<summary>Restmüll</summary>
		public InputBooleanEntity TrashWaste => new(_haContext, "input_boolean.trash_waste");
	}

	public class InputNumberEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputNumberEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Daily kratom intake</summary>
		public InputNumberEntity KratomIntakeDaily => new(_haContext, "input_number.kratom_intake_daily");
		///<summary>Rasuren bis zum Klingenwechsel</summary>
		public InputNumberEntity MaxShavesBeforeChange => new(_haContext, "input_number.max_shaves_before_change");
		///<summary>Meditation timer (minutes)</summary>
		public InputNumberEntity MeditationTimerMinutes => new(_haContext, "input_number.meditation_timer_minutes");
		///<summary>Bewegungsmelder Aktivierungsdauer (Sekunden)</summary>
		public InputNumberEntity MotionSensorIdleSecs => new(_haContext, "input_number.motion_sensor_idle_secs");
	}

	public class InputSelectEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputSelectEntities(NetDaemon.HassModel.Common.IHaContext haContext)
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

	public class InputTextEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public InputTextEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Kitchen scale search term</summary>
		public InputTextEntity KitchenScaleSearchTerm => new(_haContext, "input_text.kitchen_scale_search_term");
		///<summary>Vacuum State Test</summary>
		public InputTextEntity VacuumStateTest => new(_haContext, "input_text.vacuum_state_test");
	}

	public class LightEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public LightEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Stehlampe</summary>
		public LightEntity E31322600840d8ebd93a7 => new(_haContext, "light.31322600840d8ebd93a7");
		///<summary>TV Lightstrip</summary>
		public LightEntity Bf86d365c4be26b921xfsz => new(_haContext, "light.bf86d365c4be26b921xfsz");
		///<summary>Küchendecke</summary>
		public LightEntity Bfb81fd992b98475f8tc6r => new(_haContext, "light.bfb81fd992b98475f8tc6r");
		///<summary>Licht Nachttisch Fup</summary>
		public LightEntity NachttischFup => new(_haContext, "light.nachttisch_fup");
		///<summary>Licht Nachttisch Pup</summary>
		public LightEntity NachttischPup => new(_haContext, "light.nachttisch_pup");
	}

	public class MediaPlayerEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public MediaPlayerEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>master_bedroom_speaker</summary>
		public MediaPlayerEntity MasterBedroomSpeaker => new(_haContext, "media_player.master_bedroom_speaker");
		///<summary>Spotify Philipp Christoph</summary>
		public MediaPlayerEntity SpotifyPhilippChristoph => new(_haContext, "media_player.spotify_philipp_christoph");
	}

	public class PersistentNotificationEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public PersistentNotificationEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>New devices discovered</summary>
		public PersistentNotificationEntity ConfigEntryDiscovery => new(_haContext, "persistent_notification.config_entry_discovery");
		///<summary>Login attempt failed</summary>
		public PersistentNotificationEntity HttpLogin => new(_haContext, "persistent_notification.http_login");
	}

	public class PersonEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public PersonEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Philipp</summary>
		public PersonEntity Philipp => new(_haContext, "person.philipp");
		///<summary>Philipp</summary>
		public PersonEntity Philipp2 => new(_haContext, "person.philipp_2");
	}

	public class RemoteEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public RemoteEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Harmony Hub</summary>
		public RemoteEntity HarmonyHub => new(_haContext, "remote.harmony_hub");
	}

	public class SensorEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SensorEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>0x00158d0006268613 action</summary>
		public SensorEntity E0x00158d0006268613Action => new(_haContext, "sensor.0x00158d0006268613_action");
		///<summary>0x00158d0006268613 click</summary>
		public SensorEntity E0x00158d0006268613Click => new(_haContext, "sensor.0x00158d0006268613_click");
		///<summary>0x00158d0006269246 action</summary>
		public SensorEntity E0x00158d0006269246Action => new(_haContext, "sensor.0x00158d0006269246_action");
		///<summary>0x00158d0006269246 click</summary>
		public SensorEntity E0x00158d0006269246Click => new(_haContext, "sensor.0x00158d0006269246_click");
		///<summary>0x00158d0006397c0f action</summary>
		public SensorEntity E0x00158d0006397c0fAction => new(_haContext, "sensor.0x00158d0006397c0f_action");
		///<summary>0x00158d0006397c0f click</summary>
		public SensorEntity E0x00158d0006397c0fClick => new(_haContext, "sensor.0x00158d0006397c0f_click");
		///<summary>0x00158d000678ed45 action</summary>
		public SensorEntity E0x00158d000678ed45Action => new(_haContext, "sensor.0x00158d000678ed45_action");
		///<summary>0x00158d000678ed45 click</summary>
		public SensorEntity E0x00158d000678ed45Click => new(_haContext, "sensor.0x00158d000678ed45_click");
		///<summary>0x00158d0006792498 action</summary>
		public SensorEntity E0x00158d0006792498Action => new(_haContext, "sensor.0x00158d0006792498_action");
		///<summary>0x00158d0006792498 click</summary>
		public SensorEntity E0x00158d0006792498Click => new(_haContext, "sensor.0x00158d0006792498_click");
		///<summary>0x54ef441000035f82 illuminance</summary>
		public SensorEntity E0x54ef441000035f82Illuminance => new(_haContext, "sensor.0x54ef441000035f82_illuminance");
		///<summary>Barcode scanner connected</summary>
		public SensorEntity BarcodeScannerConnected => new(_haContext, "sensor.barcode_scanner_connected");
		///<summary>cat_food_counter</summary>
		public SensorEntity CatFoodCounter2 => new(_haContext, "sensor.cat_food_counter_2");
		///<summary>fabienne_herion_last_update</summary>
		public SensorEntity FabienneHerionLastUpdate => new(_haContext, "sensor.fabienne_herion_last_update");
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
		///<summary>🐘 FantenPhone 🐘 Activity</summary>
		public SensorEntity FantenphoneActivity => new(_haContext, "sensor.fantenphone_activity");
		///<summary>🐘 FantenPhone 🐘 Battery State</summary>
		public SensorEntity FantenphoneBatteryState => new(_haContext, "sensor.fantenphone_battery_state");
		///<summary>🐘 FantenPhone 🐘 BSSID</summary>
		public SensorEntity FantenphoneBssid => new(_haContext, "sensor.fantenphone_bssid");
		///<summary>🐘 FantenPhone 🐘 Connection Type</summary>
		public SensorEntity FantenphoneConnectionType => new(_haContext, "sensor.fantenphone_connection_type");
		///<summary>🐘 FantenPhone 🐘 Geocoded Location</summary>
		public SensorEntity FantenphoneGeocodedLocation => new(_haContext, "sensor.fantenphone_geocoded_location");
		///<summary>🐘 FantenPhone 🐘 Last Update Trigger</summary>
		public SensorEntity FantenphoneLastUpdateTrigger => new(_haContext, "sensor.fantenphone_last_update_trigger");
		///<summary>🐘 FantenPhone 🐘 SIM 1</summary>
		public SensorEntity FantenphoneSim1 => new(_haContext, "sensor.fantenphone_sim_1");
		///<summary>🐘 FantenPhone 🐘 SIM 2</summary>
		public SensorEntity FantenphoneSim2 => new(_haContext, "sensor.fantenphone_sim_2");
		///<summary>🐘 FantenPhone 🐘 SSID</summary>
		public SensorEntity FantenphoneSsid => new(_haContext, "sensor.fantenphone_ssid");
		///<summary>icloud_photos_downloader_fabienne</summary>
		public SensorEntity IcloudPhotosDownloaderFabienne => new(_haContext, "sensor.icloud_photos_downloader_fabienne");
		///<summary>icloud_photos_downloader_philipp</summary>
		public SensorEntity IcloudPhotosDownloaderPhilipp => new(_haContext, "sensor.icloud_photos_downloader_philipp");
		///<summary>iphone_philipp Activity</summary>
		public SensorEntity IphonePhilippActivity => new(_haContext, "sensor.iphone_philipp_activity");
		///<summary>iphone_philipp Battery State</summary>
		public SensorEntity IphonePhilippBatteryState => new(_haContext, "sensor.iphone_philipp_battery_state");
		///<summary>iphone_philipp BSSID</summary>
		public SensorEntity IphonePhilippBssid => new(_haContext, "sensor.iphone_philipp_bssid");
		///<summary>iphone_philipp Connection Type</summary>
		public SensorEntity IphonePhilippConnectionType => new(_haContext, "sensor.iphone_philipp_connection_type");
		///<summary>iphone_philipp Geocoded Location</summary>
		public SensorEntity IphonePhilippGeocodedLocation => new(_haContext, "sensor.iphone_philipp_geocoded_location");
		///<summary>iphone_philipp Last Update Trigger</summary>
		public SensorEntity IphonePhilippLastUpdateTrigger => new(_haContext, "sensor.iphone_philipp_last_update_trigger");
		///<summary>iphone_philipp SIM 1</summary>
		public SensorEntity IphonePhilippSim1 => new(_haContext, "sensor.iphone_philipp_sim_1");
		///<summary>iphone_philipp SSID</summary>
		public SensorEntity IphonePhilippSsid => new(_haContext, "sensor.iphone_philipp_ssid");
		///<summary>Kitchen scale</summary>
		public SensorEntity KitchenScale => new(_haContext, "sensor.kitchen_scale");
		///<summary>netdaemon_status</summary>
		public SensorEntity NetdaemonStatus => new(_haContext, "sensor.netdaemon_status");
		///<summary>trash_collection_days</summary>
		public SensorEntity Nodered92b5910e7f5ff => new(_haContext, "sensor.nodered_92b5910e_7f5ff");
		///<summary>openwindows_count</summary>
		public SensorEntity OpenwindowsCount => new(_haContext, "sensor.openwindows_count");
		///<summary>p90x_workout</summary>
		public SensorEntity P90xWorkoutToday => new(_haContext, "sensor.p90x_workout_today");
		///<summary>PupsStation Drive 1 Status</summary>
		public SensorEntity PupsstationDrive1Status => new(_haContext, "sensor.pupsstation_drive_1_status");
		///<summary>PupsStation Drive 2 Status</summary>
		public SensorEntity PupsstationDrive2Status => new(_haContext, "sensor.pupsstation_drive_2_status");
		///<summary>PupsStation Volume 1 Status</summary>
		public SensorEntity PupsstationVolume1Status => new(_haContext, "sensor.pupsstation_volume_1_status");
		///<summary>Thermostat Arbeitszimmer</summary>
		public SensorEntity ThermostatArbeitszimmer => new(_haContext, "sensor.thermostat_arbeitszimmer");
		///<summary>Thermostat Arbeitszimmer Temperature</summary>
		public SensorEntity ThermostatArbeitszimmerTemperature => new(_haContext, "sensor.thermostat_arbeitszimmer_temperature");
		///<summary>Thermostat Arbeitszimmer Valvetappet</summary>
		public SensorEntity ThermostatArbeitszimmerValvetappet => new(_haContext, "sensor.thermostat_arbeitszimmer_valvetappet");
		///<summary>Thermostat Badezimmer</summary>
		public SensorEntity ThermostatBadezimmer => new(_haContext, "sensor.thermostat_badezimmer");
		///<summary>Thermostat Badezimmer Temperature</summary>
		public SensorEntity ThermostatBadezimmerTemperature => new(_haContext, "sensor.thermostat_badezimmer_temperature");
		///<summary>Thermostat Badezimmer Valvetappet</summary>
		public SensorEntity ThermostatBadezimmerValvetappet => new(_haContext, "sensor.thermostat_badezimmer_valvetappet");
		///<summary>Thermostat Schlafzimmer</summary>
		public SensorEntity ThermostatSchlafzimmer => new(_haContext, "sensor.thermostat_schlafzimmer");
		///<summary>Thermostat Schlafzimmer Temperature</summary>
		public SensorEntity ThermostatSchlafzimmerTemperature => new(_haContext, "sensor.thermostat_schlafzimmer_temperature");
		///<summary>Thermostat Schlafzimmer Valvetappet</summary>
		public SensorEntity ThermostatSchlafzimmerValvetappet => new(_haContext, "sensor.thermostat_schlafzimmer_valvetappet");
		///<summary>Thermostat Wohnzimmer</summary>
		public SensorEntity ThermostatWohnzimmer => new(_haContext, "sensor.thermostat_wohnzimmer");
		///<summary>Thermostat Wohnzimmer Temperature</summary>
		public SensorEntity ThermostatWohnzimmerTemperature => new(_haContext, "sensor.thermostat_wohnzimmer_temperature");
		///<summary>Thermostat Wohnzimmer Valvetappet</summary>
		public SensorEntity ThermostatWohnzimmerValvetappet => new(_haContext, "sensor.thermostat_wohnzimmer_valvetappet");
		///<summary>0x00158d0006268613 battery</summary>
		public NumericSensorEntity E0x00158d0006268613Battery => new(_haContext, "sensor.0x00158d0006268613_battery");
		///<summary>0x00158d0006268613 linkquality</summary>
		public NumericSensorEntity E0x00158d0006268613Linkquality => new(_haContext, "sensor.0x00158d0006268613_linkquality");
		///<summary>0x00158d0006268613 voltage</summary>
		public NumericSensorEntity E0x00158d0006268613Voltage => new(_haContext, "sensor.0x00158d0006268613_voltage");
		///<summary>0x00158d0006269246 battery</summary>
		public NumericSensorEntity E0x00158d0006269246Battery => new(_haContext, "sensor.0x00158d0006269246_battery");
		///<summary>0x00158d0006269246 linkquality</summary>
		public NumericSensorEntity E0x00158d0006269246Linkquality => new(_haContext, "sensor.0x00158d0006269246_linkquality");
		///<summary>0x00158d0006269246 voltage</summary>
		public NumericSensorEntity E0x00158d0006269246Voltage => new(_haContext, "sensor.0x00158d0006269246_voltage");
		///<summary>0x00158d0006397c0f battery</summary>
		public NumericSensorEntity E0x00158d0006397c0fBattery => new(_haContext, "sensor.0x00158d0006397c0f_battery");
		///<summary>0x00158d0006397c0f linkquality</summary>
		public NumericSensorEntity E0x00158d0006397c0fLinkquality => new(_haContext, "sensor.0x00158d0006397c0f_linkquality");
		///<summary>0x00158d0006397c0f voltage</summary>
		public NumericSensorEntity E0x00158d0006397c0fVoltage => new(_haContext, "sensor.0x00158d0006397c0f_voltage");
		///<summary>0x00158d000678ed45 battery</summary>
		public NumericSensorEntity E0x00158d000678ed45Battery => new(_haContext, "sensor.0x00158d000678ed45_battery");
		///<summary>0x00158d000678ed45 linkquality</summary>
		public NumericSensorEntity E0x00158d000678ed45Linkquality => new(_haContext, "sensor.0x00158d000678ed45_linkquality");
		///<summary>0x00158d000678ed45 voltage</summary>
		public NumericSensorEntity E0x00158d000678ed45Voltage => new(_haContext, "sensor.0x00158d000678ed45_voltage");
		///<summary>0x00158d0006792498 battery</summary>
		public NumericSensorEntity E0x00158d0006792498Battery => new(_haContext, "sensor.0x00158d0006792498_battery");
		///<summary>0x00158d0006792498 linkquality</summary>
		public NumericSensorEntity E0x00158d0006792498Linkquality => new(_haContext, "sensor.0x00158d0006792498_linkquality");
		///<summary>0x00158d0006792498 voltage</summary>
		public NumericSensorEntity E0x00158d0006792498Voltage => new(_haContext, "sensor.0x00158d0006792498_voltage");
		///<summary>0x00158d0007bcae5d battery</summary>
		public NumericSensorEntity E0x00158d0007bcae5dBattery => new(_haContext, "sensor.0x00158d0007bcae5d_battery");
		///<summary>0x00158d0007bcae5d illuminance</summary>
		public NumericSensorEntity E0x00158d0007bcae5dIlluminance => new(_haContext, "sensor.0x00158d0007bcae5d_illuminance");
		///<summary>0x00158d0007bcae5d illuminance lux</summary>
		public NumericSensorEntity E0x00158d0007bcae5dIlluminanceLux => new(_haContext, "sensor.0x00158d0007bcae5d_illuminance_lux");
		///<summary>0x00158d0007bcae5d linkquality</summary>
		public NumericSensorEntity E0x00158d0007bcae5dLinkquality => new(_haContext, "sensor.0x00158d0007bcae5d_linkquality");
		///<summary>0x00158d0007bcae5d temperature</summary>
		public NumericSensorEntity E0x00158d0007bcae5dTemperature => new(_haContext, "sensor.0x00158d0007bcae5d_temperature");
		///<summary>0x00158d0007bcae5d voltage</summary>
		public NumericSensorEntity E0x00158d0007bcae5dVoltage => new(_haContext, "sensor.0x00158d0007bcae5d_voltage");
		///<summary>0x54ef441000035f82 battery</summary>
		public NumericSensorEntity E0x54ef441000035f82Battery => new(_haContext, "sensor.0x54ef441000035f82_battery");
		///<summary>0x54ef441000035f82 illuminance lux</summary>
		public NumericSensorEntity E0x54ef441000035f82IlluminanceLux => new(_haContext, "sensor.0x54ef441000035f82_illuminance_lux");
		///<summary>0x54ef441000035f82 linkquality</summary>
		public NumericSensorEntity E0x54ef441000035f82Linkquality => new(_haContext, "sensor.0x54ef441000035f82_linkquality");
		///<summary>AMC Entertainment Holdings Inc</summary>
		public NumericSensorEntity AmcEntertainmentHoldingsInc => new(_haContext, "sensor.amc_entertainment_holdings_inc");
		///<summary>BlackBerry Ltd</summary>
		public NumericSensorEntity BlackberryLtd => new(_haContext, "sensor.blackberry_ltd");
		///<summary>Core DAX</summary>
		public NumericSensorEntity CoreDax => new(_haContext, "sensor.core_dax");
		///<summary>Fantenpad Battery Level</summary>
		public NumericSensorEntity FantenpadBatteryLevel => new(_haContext, "sensor.fantenpad_battery_level");
		///<summary>Fantenpad Storage</summary>
		public NumericSensorEntity FantenpadStorage => new(_haContext, "sensor.fantenpad_storage");
		///<summary>🐘 FantenPhone 🐘 Average Active Pace</summary>
		public NumericSensorEntity FantenphoneAverageActivePace => new(_haContext, "sensor.fantenphone_average_active_pace");
		///<summary>🐘 FantenPhone 🐘 Battery Level</summary>
		public NumericSensorEntity FantenphoneBatteryLevel => new(_haContext, "sensor.fantenphone_battery_level");
		///<summary>🐘 FantenPhone 🐘 Distance</summary>
		public NumericSensorEntity FantenphoneDistance => new(_haContext, "sensor.fantenphone_distance");
		///<summary>🐘 FantenPhone 🐘 Floors Ascended</summary>
		public NumericSensorEntity FantenphoneFloorsAscended => new(_haContext, "sensor.fantenphone_floors_ascended");
		///<summary>🐘 FantenPhone 🐘 Floors Descended</summary>
		public NumericSensorEntity FantenphoneFloorsDescended => new(_haContext, "sensor.fantenphone_floors_descended");
		///<summary>🐘 FantenPhone 🐘 Steps</summary>
		public NumericSensorEntity FantenphoneSteps => new(_haContext, "sensor.fantenphone_steps");
		///<summary>🐘 FantenPhone 🐘 Storage</summary>
		public NumericSensorEntity FantenphoneStorage => new(_haContext, "sensor.fantenphone_storage");
		///<summary>GameStop Corp</summary>
		public NumericSensorEntity GamestopCorp => new(_haContext, "sensor.gamestop_corp");
		///<summary>Glances acpitz 1 Temperature</summary>
		public NumericSensorEntity GlancesAcpitz1Temperature => new(_haContext, "sensor.glances_acpitz_1_temperature");
		///<summary>Glances acpitz 2 Temperature</summary>
		public NumericSensorEntity GlancesAcpitz2Temperature => new(_haContext, "sensor.glances_acpitz_2_temperature");
		///<summary>Glances  Containers active</summary>
		public NumericSensorEntity GlancesContainersActive => new(_haContext, "sensor.glances_containers_active");
		///<summary>Glances  Containers CPU used</summary>
		public NumericSensorEntity GlancesContainersCpuUsed => new(_haContext, "sensor.glances_containers_cpu_used");
		///<summary>Glances  Containers RAM used</summary>
		public NumericSensorEntity GlancesContainersRamUsed => new(_haContext, "sensor.glances_containers_ram_used");
		///<summary>Glances Core 0 Temperature</summary>
		public NumericSensorEntity GlancesCore0Temperature => new(_haContext, "sensor.glances_core_0_temperature");
		///<summary>Glances Core 1 Temperature</summary>
		public NumericSensorEntity GlancesCore1Temperature => new(_haContext, "sensor.glances_core_1_temperature");
		///<summary>Glances Core 2 Temperature</summary>
		public NumericSensorEntity GlancesCore2Temperature => new(_haContext, "sensor.glances_core_2_temperature");
		///<summary>Glances Core 3 Temperature</summary>
		public NumericSensorEntity GlancesCore3Temperature => new(_haContext, "sensor.glances_core_3_temperature");
		///<summary>Glances  CPU load</summary>
		public NumericSensorEntity GlancesCpuLoad => new(_haContext, "sensor.glances_cpu_load");
		///<summary>Glances  CPU used</summary>
		public NumericSensorEntity GlancesCpuUsed => new(_haContext, "sensor.glances_cpu_used");
		///<summary>Glances / free</summary>
		public NumericSensorEntity GlancesFree => new(_haContext, "sensor.glances_free");
		///<summary>Glances Package id 0 Temperature</summary>
		public NumericSensorEntity GlancesPackageId0Temperature => new(_haContext, "sensor.glances_package_id_0_temperature");
		///<summary>Glances  RAM free</summary>
		public NumericSensorEntity GlancesRamFree => new(_haContext, "sensor.glances_ram_free");
		///<summary>Glances  RAM used</summary>
		public NumericSensorEntity GlancesRamUsed => new(_haContext, "sensor.glances_ram_used");
		///<summary>Glances  RAM used percent</summary>
		public NumericSensorEntity GlancesRamUsedPercent => new(_haContext, "sensor.glances_ram_used_percent");
		///<summary>Glances /run/containerd/runc/k8s.io/597ab5f9106dd9b17e218178c69425b4ac1041e03757dbecf6821d6f19afbffd/runc.FECEfF free</summary>
		public NumericSensorEntity GlancesRunContainerdRuncK8sIo597ab5f9106dd9b17e218178c69425b4ac1041e03757dbecf6821d6f19afbffdRuncFeceffFree => new(_haContext, "sensor.glances_run_containerd_runc_k8s_io_597ab5f9106dd9b17e218178c69425b4ac1041e03757dbecf6821d6f19afbffd_runc_feceff_free");
		///<summary>Glances /run/containerd/runc/k8s.io/597ab5f9106dd9b17e218178c69425b4ac1041e03757dbecf6821d6f19afbffd/runc.FECEfF used</summary>
		public NumericSensorEntity GlancesRunContainerdRuncK8sIo597ab5f9106dd9b17e218178c69425b4ac1041e03757dbecf6821d6f19afbffdRuncFeceffUsed => new(_haContext, "sensor.glances_run_containerd_runc_k8s_io_597ab5f9106dd9b17e218178c69425b4ac1041e03757dbecf6821d6f19afbffd_runc_feceff_used");
		///<summary>Glances /run/containerd/runc/k8s.io/597ab5f9106dd9b17e218178c69425b4ac1041e03757dbecf6821d6f19afbffd/runc.FECEfF used percent</summary>
		public NumericSensorEntity GlancesRunContainerdRuncK8sIo597ab5f9106dd9b17e218178c69425b4ac1041e03757dbecf6821d6f19afbffdRuncFeceffUsedPercent => new(_haContext, "sensor.glances_run_containerd_runc_k8s_io_597ab5f9106dd9b17e218178c69425b4ac1041e03757dbecf6821d6f19afbffd_runc_feceff_used_percent");
		///<summary>Glances /run/containerd/runc/k8s.io/86d0b71ba34961234e5051f779dce240648a24096b67f9be7f2d020f03a6b97c/runc.gmcHaE free</summary>
		public NumericSensorEntity GlancesRunContainerdRuncK8sIo86d0b71ba34961234e5051f779dce240648a24096b67f9be7f2d020f03a6b97cRuncGmchaeFree => new(_haContext, "sensor.glances_run_containerd_runc_k8s_io_86d0b71ba34961234e5051f779dce240648a24096b67f9be7f2d020f03a6b97c_runc_gmchae_free");
		///<summary>Glances /run/containerd/runc/k8s.io/86d0b71ba34961234e5051f779dce240648a24096b67f9be7f2d020f03a6b97c/runc.gmcHaE used</summary>
		public NumericSensorEntity GlancesRunContainerdRuncK8sIo86d0b71ba34961234e5051f779dce240648a24096b67f9be7f2d020f03a6b97cRuncGmchaeUsed => new(_haContext, "sensor.glances_run_containerd_runc_k8s_io_86d0b71ba34961234e5051f779dce240648a24096b67f9be7f2d020f03a6b97c_runc_gmchae_used");
		///<summary>Glances /run/containerd/runc/k8s.io/86d0b71ba34961234e5051f779dce240648a24096b67f9be7f2d020f03a6b97c/runc.gmcHaE used percent</summary>
		public NumericSensorEntity GlancesRunContainerdRuncK8sIo86d0b71ba34961234e5051f779dce240648a24096b67f9be7f2d020f03a6b97cRuncGmchaeUsedPercent => new(_haContext, "sensor.glances_run_containerd_runc_k8s_io_86d0b71ba34961234e5051f779dce240648a24096b67f9be7f2d020f03a6b97c_runc_gmchae_used_percent");
		///<summary>Glances  Running</summary>
		public NumericSensorEntity GlancesRunning => new(_haContext, "sensor.glances_running");
		///<summary>Glances  Sleeping</summary>
		public NumericSensorEntity GlancesSleeping => new(_haContext, "sensor.glances_sleeping");
		///<summary>Glances  Swap free</summary>
		public NumericSensorEntity GlancesSwapFree => new(_haContext, "sensor.glances_swap_free");
		///<summary>Glances  Swap used</summary>
		public NumericSensorEntity GlancesSwapUsed => new(_haContext, "sensor.glances_swap_used");
		///<summary>Glances  Swap used percent</summary>
		public NumericSensorEntity GlancesSwapUsedPercent => new(_haContext, "sensor.glances_swap_used_percent");
		///<summary>Glances  Thread</summary>
		public NumericSensorEntity GlancesThread => new(_haContext, "sensor.glances_thread");
		///<summary>Glances  Total</summary>
		public NumericSensorEntity GlancesTotal => new(_haContext, "sensor.glances_total");
		///<summary>Glances / used</summary>
		public NumericSensorEntity GlancesUsed => new(_haContext, "sensor.glances_used");
		///<summary>Glances / used percent</summary>
		public NumericSensorEntity GlancesUsedPercent => new(_haContext, "sensor.glances_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/007aa4c8-2a8b-49c8-a65e-b6ed355f1b5a/volume-subpaths/config/mariadb/1 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods007aa4c82a8b49c8A65eB6ed355f1b5aVolumeSubpathsConfigMariadb1Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_007aa4c8_2a8b_49c8_a65e_b6ed355f1b5a_volume_subpaths_config_mariadb_1_free");
		///<summary>Glances /var/lib/kubelet/pods/007aa4c8-2a8b-49c8-a65e-b6ed355f1b5a/volume-subpaths/config/mariadb/1 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods007aa4c82a8b49c8A65eB6ed355f1b5aVolumeSubpathsConfigMariadb1Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_007aa4c8_2a8b_49c8_a65e_b6ed355f1b5a_volume_subpaths_config_mariadb_1_used");
		///<summary>Glances /var/lib/kubelet/pods/007aa4c8-2a8b-49c8-a65e-b6ed355f1b5a/volume-subpaths/config/mariadb/1 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods007aa4c82a8b49c8A65eB6ed355f1b5aVolumeSubpathsConfigMariadb1UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_007aa4c8_2a8b_49c8_a65e_b6ed355f1b5a_volume_subpaths_config_mariadb_1_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/04b77e41-a738-4e78-bd65-160022a13dba/volume-subpaths/mosquitto-config/mosquitto/0 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods04b77e41A7384e78Bd65160022a13dbaVolumeSubpathsMosquittoConfigMosquitto0Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_04b77e41_a738_4e78_bd65_160022a13dba_volume_subpaths_mosquitto_config_mosquitto_0_free");
		///<summary>Glances /var/lib/kubelet/pods/04b77e41-a738-4e78-bd65-160022a13dba/volume-subpaths/mosquitto-config/mosquitto/0 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods04b77e41A7384e78Bd65160022a13dbaVolumeSubpathsMosquittoConfigMosquitto0Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_04b77e41_a738_4e78_bd65_160022a13dba_volume_subpaths_mosquitto_config_mosquitto_0_used");
		///<summary>Glances /var/lib/kubelet/pods/04b77e41-a738-4e78-bd65-160022a13dba/volume-subpaths/mosquitto-config/mosquitto/0 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods04b77e41A7384e78Bd65160022a13dbaVolumeSubpathsMosquittoConfigMosquitto0UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_04b77e41_a738_4e78_bd65_160022a13dba_volume_subpaths_mosquitto_config_mosquitto_0_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/18b3903e-69e2-44c0-aebc-a44d4e7ace1a/volume-subpaths/mosquitto-config/mosquitto/0 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods18b3903e69e244c0AebcA44d4e7ace1aVolumeSubpathsMosquittoConfigMosquitto0Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_18b3903e_69e2_44c0_aebc_a44d4e7ace1a_volume_subpaths_mosquitto_config_mosquitto_0_free");
		///<summary>Glances /var/lib/kubelet/pods/18b3903e-69e2-44c0-aebc-a44d4e7ace1a/volume-subpaths/mosquitto-config/mosquitto/0 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods18b3903e69e244c0AebcA44d4e7ace1aVolumeSubpathsMosquittoConfigMosquitto0Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_18b3903e_69e2_44c0_aebc_a44d4e7ace1a_volume_subpaths_mosquitto_config_mosquitto_0_used");
		///<summary>Glances /var/lib/kubelet/pods/18b3903e-69e2-44c0-aebc-a44d4e7ace1a/volume-subpaths/mosquitto-config/mosquitto/0 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods18b3903e69e244c0AebcA44d4e7ace1aVolumeSubpathsMosquittoConfigMosquitto0UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_18b3903e_69e2_44c0_aebc_a44d4e7ace1a_volume_subpaths_mosquitto_config_mosquitto_0_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/2e2aa072-12a2-4277-b113-868eb10fbf2c/volume-subpaths/config/wg-access-server/2 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods2e2aa07212a24277B113868eb10fbf2cVolumeSubpathsConfigWgAccessServer2Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_2e2aa072_12a2_4277_b113_868eb10fbf2c_volume_subpaths_config_wg_access_server_2_free");
		///<summary>Glances /var/lib/kubelet/pods/2e2aa072-12a2-4277-b113-868eb10fbf2c/volume-subpaths/config/wg-access-server/2 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods2e2aa07212a24277B113868eb10fbf2cVolumeSubpathsConfigWgAccessServer2Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_2e2aa072_12a2_4277_b113_868eb10fbf2c_volume_subpaths_config_wg_access_server_2_used");
		///<summary>Glances /var/lib/kubelet/pods/2e2aa072-12a2-4277-b113-868eb10fbf2c/volume-subpaths/config/wg-access-server/2 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods2e2aa07212a24277B113868eb10fbf2cVolumeSubpathsConfigWgAccessServer2UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_2e2aa072_12a2_4277_b113_868eb10fbf2c_volume_subpaths_config_wg_access_server_2_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/342f66bf-9ab4-4881-baf5-f6e0e59eb645/volume-subpaths/config/mariadb/1 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods342f66bf9ab44881Baf5F6e0e59eb645VolumeSubpathsConfigMariadb1Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_342f66bf_9ab4_4881_baf5_f6e0e59eb645_volume_subpaths_config_mariadb_1_free");
		///<summary>Glances /var/lib/kubelet/pods/342f66bf-9ab4-4881-baf5-f6e0e59eb645/volume-subpaths/config/mariadb/1 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods342f66bf9ab44881Baf5F6e0e59eb645VolumeSubpathsConfigMariadb1Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_342f66bf_9ab4_4881_baf5_f6e0e59eb645_volume_subpaths_config_mariadb_1_used");
		///<summary>Glances /var/lib/kubelet/pods/342f66bf-9ab4-4881-baf5-f6e0e59eb645/volume-subpaths/config/mariadb/1 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods342f66bf9ab44881Baf5F6e0e59eb645VolumeSubpathsConfigMariadb1UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_342f66bf_9ab4_4881_baf5_f6e0e59eb645_volume_subpaths_config_mariadb_1_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/398e4258-495a-4a4f-82bd-9fec6d33d680/volume-subpaths/config/wg-access-server/2 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods398e4258495a4a4f82bd9fec6d33d680VolumeSubpathsConfigWgAccessServer2Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_398e4258_495a_4a4f_82bd_9fec6d33d680_volume_subpaths_config_wg_access_server_2_free");
		///<summary>Glances /var/lib/kubelet/pods/398e4258-495a-4a4f-82bd-9fec6d33d680/volume-subpaths/config/wg-access-server/2 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods398e4258495a4a4f82bd9fec6d33d680VolumeSubpathsConfigWgAccessServer2Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_398e4258_495a_4a4f_82bd_9fec6d33d680_volume_subpaths_config_wg_access_server_2_used");
		///<summary>Glances /var/lib/kubelet/pods/398e4258-495a-4a4f-82bd-9fec6d33d680/volume-subpaths/config/wg-access-server/2 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods398e4258495a4a4f82bd9fec6d33d680VolumeSubpathsConfigWgAccessServer2UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_398e4258_495a_4a4f_82bd_9fec6d33d680_volume_subpaths_config_wg_access_server_2_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/62ec3bb3-ea40-4faf-b4b2-35f55ed48f7e/volume-subpaths/zigbee2mqtt-settings/zigbee2mqtt/1 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods62ec3bb3Ea404fafB4b235f55ed48f7eVolumeSubpathsZigbee2mqttSettingsZigbee2mqtt1Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_62ec3bb3_ea40_4faf_b4b2_35f55ed48f7e_volume_subpaths_zigbee2mqtt_settings_zigbee2mqtt_1_free");
		///<summary>Glances /var/lib/kubelet/pods/62ec3bb3-ea40-4faf-b4b2-35f55ed48f7e/volume-subpaths/zigbee2mqtt-settings/zigbee2mqtt/1 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods62ec3bb3Ea404fafB4b235f55ed48f7eVolumeSubpathsZigbee2mqttSettingsZigbee2mqtt1Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_62ec3bb3_ea40_4faf_b4b2_35f55ed48f7e_volume_subpaths_zigbee2mqtt_settings_zigbee2mqtt_1_used");
		///<summary>Glances /var/lib/kubelet/pods/62ec3bb3-ea40-4faf-b4b2-35f55ed48f7e/volume-subpaths/zigbee2mqtt-settings/zigbee2mqtt/1 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods62ec3bb3Ea404fafB4b235f55ed48f7eVolumeSubpathsZigbee2mqttSettingsZigbee2mqtt1UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_62ec3bb3_ea40_4faf_b4b2_35f55ed48f7e_volume_subpaths_zigbee2mqtt_settings_zigbee2mqtt_1_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/b15d5229-96da-4d86-942c-7f6b686797ce/volume-subpaths/config/mariadb/1 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsB15d522996da4d86942c7f6b686797ceVolumeSubpathsConfigMariadb1Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_b15d5229_96da_4d86_942c_7f6b686797ce_volume_subpaths_config_mariadb_1_free");
		///<summary>Glances /var/lib/kubelet/pods/b15d5229-96da-4d86-942c-7f6b686797ce/volume-subpaths/config/mariadb/1 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsB15d522996da4d86942c7f6b686797ceVolumeSubpathsConfigMariadb1Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_b15d5229_96da_4d86_942c_7f6b686797ce_volume_subpaths_config_mariadb_1_used");
		///<summary>Glances /var/lib/kubelet/pods/b15d5229-96da-4d86-942c-7f6b686797ce/volume-subpaths/config/mariadb/1 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsB15d522996da4d86942c7f6b686797ceVolumeSubpathsConfigMariadb1UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_b15d5229_96da_4d86_942c_7f6b686797ce_volume_subpaths_config_mariadb_1_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/be367489-0ac4-4bd9-8691-24a58dafa130/volume-subpaths/config/nginx/0 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsBe3674890ac44bd9869124a58dafa130VolumeSubpathsConfigNginx0Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_be367489_0ac4_4bd9_8691_24a58dafa130_volume_subpaths_config_nginx_0_free");
		///<summary>Glances /var/lib/kubelet/pods/be367489-0ac4-4bd9-8691-24a58dafa130/volume-subpaths/config/nginx/0 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsBe3674890ac44bd9869124a58dafa130VolumeSubpathsConfigNginx0Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_be367489_0ac4_4bd9_8691_24a58dafa130_volume_subpaths_config_nginx_0_used");
		///<summary>Glances /var/lib/kubelet/pods/be367489-0ac4-4bd9-8691-24a58dafa130/volume-subpaths/config/nginx/0 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsBe3674890ac44bd9869124a58dafa130VolumeSubpathsConfigNginx0UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_be367489_0ac4_4bd9_8691_24a58dafa130_volume_subpaths_config_nginx_0_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/c17d0aa0-0f24-47ac-983b-1df58ce3a448/volume-subpaths/config/mariadb/1 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsC17d0aa00f2447ac983b1df58ce3a448VolumeSubpathsConfigMariadb1Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_c17d0aa0_0f24_47ac_983b_1df58ce3a448_volume_subpaths_config_mariadb_1_free");
		///<summary>Glances /var/lib/kubelet/pods/c17d0aa0-0f24-47ac-983b-1df58ce3a448/volume-subpaths/config/mariadb/1 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsC17d0aa00f2447ac983b1df58ce3a448VolumeSubpathsConfigMariadb1Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_c17d0aa0_0f24_47ac_983b_1df58ce3a448_volume_subpaths_config_mariadb_1_used");
		///<summary>Glances /var/lib/kubelet/pods/c17d0aa0-0f24-47ac-983b-1df58ce3a448/volume-subpaths/config/mariadb/1 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsC17d0aa00f2447ac983b1df58ce3a448VolumeSubpathsConfigMariadb1UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_c17d0aa0_0f24_47ac_983b_1df58ce3a448_volume_subpaths_config_mariadb_1_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/c64bb4ee-7171-4163-927c-029b3b6de914/volume-subpaths/mosquitto-config/mosquitto/0 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsC64bb4ee71714163927c029b3b6de914VolumeSubpathsMosquittoConfigMosquitto0Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_c64bb4ee_7171_4163_927c_029b3b6de914_volume_subpaths_mosquitto_config_mosquitto_0_free");
		///<summary>Glances /var/lib/kubelet/pods/c64bb4ee-7171-4163-927c-029b3b6de914/volume-subpaths/mosquitto-config/mosquitto/0 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsC64bb4ee71714163927c029b3b6de914VolumeSubpathsMosquittoConfigMosquitto0Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_c64bb4ee_7171_4163_927c_029b3b6de914_volume_subpaths_mosquitto_config_mosquitto_0_used");
		///<summary>Glances /var/lib/kubelet/pods/c64bb4ee-7171-4163-927c-029b3b6de914/volume-subpaths/mosquitto-config/mosquitto/0 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsC64bb4ee71714163927c029b3b6de914VolumeSubpathsMosquittoConfigMosquitto0UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_c64bb4ee_7171_4163_927c_029b3b6de914_volume_subpaths_mosquitto_config_mosquitto_0_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/d4c4af8e-817b-4674-936c-502d2b34ceaa/volume-subpaths/mosquitto-config/mosquitto/0 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsD4c4af8e817b4674936c502d2b34ceaaVolumeSubpathsMosquittoConfigMosquitto0Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_d4c4af8e_817b_4674_936c_502d2b34ceaa_volume_subpaths_mosquitto_config_mosquitto_0_free");
		///<summary>Glances /var/lib/kubelet/pods/d4c4af8e-817b-4674-936c-502d2b34ceaa/volume-subpaths/mosquitto-config/mosquitto/0 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsD4c4af8e817b4674936c502d2b34ceaaVolumeSubpathsMosquittoConfigMosquitto0Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_d4c4af8e_817b_4674_936c_502d2b34ceaa_volume_subpaths_mosquitto_config_mosquitto_0_used");
		///<summary>Glances /var/lib/kubelet/pods/d4c4af8e-817b-4674-936c-502d2b34ceaa/volume-subpaths/mosquitto-config/mosquitto/0 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsD4c4af8e817b4674936c502d2b34ceaaVolumeSubpathsMosquittoConfigMosquitto0UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_d4c4af8e_817b_4674_936c_502d2b34ceaa_volume_subpaths_mosquitto_config_mosquitto_0_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/e176eb38-327d-4505-b9aa-284bbc1c13e8/volume-subpaths/config/wg-access-server/2 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsE176eb38327d4505B9aa284bbc1c13e8VolumeSubpathsConfigWgAccessServer2Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_e176eb38_327d_4505_b9aa_284bbc1c13e8_volume_subpaths_config_wg_access_server_2_free");
		///<summary>Glances /var/lib/kubelet/pods/e176eb38-327d-4505-b9aa-284bbc1c13e8/volume-subpaths/config/wg-access-server/2 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsE176eb38327d4505B9aa284bbc1c13e8VolumeSubpathsConfigWgAccessServer2Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_e176eb38_327d_4505_b9aa_284bbc1c13e8_volume_subpaths_config_wg_access_server_2_used");
		///<summary>Glances /var/lib/kubelet/pods/e176eb38-327d-4505-b9aa-284bbc1c13e8/volume-subpaths/config/wg-access-server/2 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsE176eb38327d4505B9aa284bbc1c13e8VolumeSubpathsConfigWgAccessServer2UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_e176eb38_327d_4505_b9aa_284bbc1c13e8_volume_subpaths_config_wg_access_server_2_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/f0edab55-3def-49c1-833c-4f1788b40431/volume-subpaths/config/mariadb/1 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsF0edab553def49c1833c4f1788b40431VolumeSubpathsConfigMariadb1Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_f0edab55_3def_49c1_833c_4f1788b40431_volume_subpaths_config_mariadb_1_free");
		///<summary>Glances /var/lib/kubelet/pods/f0edab55-3def-49c1-833c-4f1788b40431/volume-subpaths/config/mariadb/1 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsF0edab553def49c1833c4f1788b40431VolumeSubpathsConfigMariadb1Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_f0edab55_3def_49c1_833c_4f1788b40431_volume_subpaths_config_mariadb_1_used");
		///<summary>Glances /var/lib/kubelet/pods/f0edab55-3def-49c1-833c-4f1788b40431/volume-subpaths/config/mariadb/1 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsF0edab553def49c1833c4f1788b40431VolumeSubpathsConfigMariadb1UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_f0edab55_3def_49c1_833c_4f1788b40431_volume_subpaths_config_mariadb_1_used_percent");
		///<summary>hacs</summary>
		public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
		///<summary>iphone_philipp Average Active Pace</summary>
		public NumericSensorEntity IphonePhilippAverageActivePace => new(_haContext, "sensor.iphone_philipp_average_active_pace");
		///<summary>iphone_philipp Battery Level</summary>
		public NumericSensorEntity IphonePhilippBatteryLevel => new(_haContext, "sensor.iphone_philipp_battery_level");
		///<summary>iphone_philipp Distance</summary>
		public NumericSensorEntity IphonePhilippDistance => new(_haContext, "sensor.iphone_philipp_distance");
		///<summary>iphone_philipp Floors Ascended</summary>
		public NumericSensorEntity IphonePhilippFloorsAscended => new(_haContext, "sensor.iphone_philipp_floors_ascended");
		///<summary>iphone_philipp Floors Descended</summary>
		public NumericSensorEntity IphonePhilippFloorsDescended => new(_haContext, "sensor.iphone_philipp_floors_descended");
		///<summary>iphone_philipp Steps</summary>
		public NumericSensorEntity IphonePhilippSteps => new(_haContext, "sensor.iphone_philipp_steps");
		///<summary>iphone_philipp Storage</summary>
		public NumericSensorEntity IphonePhilippStorage => new(_haContext, "sensor.iphone_philipp_storage");
		///<summary>Lufthansa</summary>
		public NumericSensorEntity Lufthansa => new(_haContext, "sensor.lufthansa");
		///<summary>METRO AG</summary>
		public NumericSensorEntity MetroAg => new(_haContext, "sensor.metro_ag");
		///<summary>Total</summary>
		public NumericSensorEntity MyBitcoins2 => new(_haContext, "sensor.my_bitcoins_2");
		///<summary>Profit</summary>
		public NumericSensorEntity MyBitcoins3 => new(_haContext, "sensor.my_bitcoins_3");
		///<summary>Total</summary>
		public NumericSensorEntity MyDogecoinsNodered => new(_haContext, "sensor.my_dogecoins_nodered");
		///<summary>Profit</summary>
		public NumericSensorEntity MyDogecoinsProfitNodered => new(_haContext, "sensor.my_dogecoins_profit_nodered");
		///<summary>PupsStation CPU Load Average (15 min)</summary>
		public NumericSensorEntity PupsstationCpuLoad15Min => new(_haContext, "sensor.pupsstation_cpu_load_15_min");
		///<summary>PupsStation CPU Load Average (5 min)</summary>
		public NumericSensorEntity PupsstationCpuLoad5Min => new(_haContext, "sensor.pupsstation_cpu_load_5_min");
		///<summary>PupsStation CPU Utilization (Total)</summary>
		public NumericSensorEntity PupsstationCpuLoadTotal => new(_haContext, "sensor.pupsstation_cpu_load_total");
		///<summary>PupsStation CPU Utilization (User)</summary>
		public NumericSensorEntity PupsstationCpuLoadUser => new(_haContext, "sensor.pupsstation_cpu_load_user");
		///<summary>PupsStation Drive 1 Temperature</summary>
		public NumericSensorEntity PupsstationDrive1Temperature => new(_haContext, "sensor.pupsstation_drive_1_temperature");
		///<summary>PupsStation Drive 2 Temperature</summary>
		public NumericSensorEntity PupsstationDrive2Temperature => new(_haContext, "sensor.pupsstation_drive_2_temperature");
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
		///<summary>PupsStation Network Down</summary>
		public NumericSensorEntity PupsstationNetworkDown => new(_haContext, "sensor.pupsstation_network_down");
		///<summary>PupsStation Network Up</summary>
		public NumericSensorEntity PupsstationNetworkUp => new(_haContext, "sensor.pupsstation_network_up");
		///<summary>PupsStation temperature</summary>
		public NumericSensorEntity PupsstationTemperature => new(_haContext, "sensor.pupsstation_temperature");
		///<summary>PupsStation Volume 1 Average Disk Temp</summary>
		public NumericSensorEntity PupsstationVolume1AverageDiskTemp => new(_haContext, "sensor.pupsstation_volume_1_average_disk_temp");
		///<summary>PupsStation Volume 1 Used Space</summary>
		public NumericSensorEntity PupsstationVolume1UsedSpace => new(_haContext, "sensor.pupsstation_volume_1_used_space");
		///<summary>PupsStation Volume 1 Volume Used</summary>
		public NumericSensorEntity PupsstationVolume1VolumeUsed => new(_haContext, "sensor.pupsstation_volume_1_volume_used");
		///<summary>shaves_count</summary>
		public NumericSensorEntity ShavesCount => new(_haContext, "sensor.shaves_count");
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
	}

	public class SunEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SunEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public class SwitchEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SwitchEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>TWTYH Diorama</summary>
		public SwitchEntity E20007146c4dd57098e9d => new(_haContext, "switch.20007146c4dd57098e9d");
		///<summary>Buddha-Brunnen 2</summary>
		public SwitchEntity E22763158600194a53716 => new(_haContext, "switch.22763158600194a53716");
		///<summary>Lightbar</summary>
		public SwitchEntity E22763158c44f3380a92c => new(_haContext, "switch.22763158c44f3380a92c");
		///<summary>Neon-Uhr</summary>
		public SwitchEntity E62663300c4dd570e60ad => new(_haContext, "switch.62663300c4dd570e60ad");
		///<summary>Vertragslicht </summary>
		public SwitchEntity Bf18f10fc6c9cac58d4c0a => new(_haContext, "switch.bf18f10fc6c9cac58d4c0a");
		///<summary>Sternen-Lichterkette</summary>
		public SwitchEntity Bfb8ec2dac052e231ax6tg => new(_haContext, "switch.bfb8ec2dac052e231ax6tg");
		///<summary>enable_chrome_control_lights</summary>
		public SwitchEntity EnableChromeControlLights => new(_haContext, "switch.enable_chrome_control_lights");
		///<summary>enable_chrome_media_playback</summary>
		public SwitchEntity EnableChromeMediaPlayback => new(_haContext, "switch.enable_chrome_media_playback");
		///<summary>enable_chrome_media_playback</summary>
		public SwitchEntity EnableChromeMediaPlayback10 => new(_haContext, "switch.enable_chrome_media_playback_10");
		///<summary>enable_chrome_media_playback</summary>
		public SwitchEntity EnableChromeMediaPlayback11 => new(_haContext, "switch.enable_chrome_media_playback_11");
		///<summary>enable_chrome_media_playback</summary>
		public SwitchEntity EnableChromeMediaPlayback12 => new(_haContext, "switch.enable_chrome_media_playback_12");
		///<summary>enable_chrome_media_playback</summary>
		public SwitchEntity EnableChromeMediaPlayback13 => new(_haContext, "switch.enable_chrome_media_playback_13");
		///<summary>enable_chrome_media_playback</summary>
		public SwitchEntity EnableChromeMediaPlayback4 => new(_haContext, "switch.enable_chrome_media_playback_4");
		///<summary>enable_chrome_media_playback</summary>
		public SwitchEntity EnableChromeMediaPlayback5 => new(_haContext, "switch.enable_chrome_media_playback_5");
		///<summary>enable_chrome_media_playback</summary>
		public SwitchEntity EnableChromeMediaPlayback6 => new(_haContext, "switch.enable_chrome_media_playback_6");
		///<summary>enable_chrome_media_playback</summary>
		public SwitchEntity EnableChromeMediaPlayback7 => new(_haContext, "switch.enable_chrome_media_playback_7");
		///<summary>enable_chrome_media_playback</summary>
		public SwitchEntity EnableChromeMediaPlayback8 => new(_haContext, "switch.enable_chrome_media_playback_8");
		///<summary>enable_chrome_media_playback</summary>
		public SwitchEntity EnableChromeMediaPlayback9 => new(_haContext, "switch.enable_chrome_media_playback_9");
		///<summary>Harmony Hub Kino 2</summary>
		public SwitchEntity HarmonyHubKino2 => new(_haContext, "switch.harmony_hub_kino_2");
		///<summary>Harmony Hub Kino</summary>
		public SwitchEntity HarmonyHubKinoLaptopFup => new(_haContext, "switch.harmony_hub_kino_laptop_fup");
		///<summary>Harmony Hub Listen to Music</summary>
		public SwitchEntity HarmonyHubListenToMusic => new(_haContext, "switch.harmony_hub_listen_to_music");
		///<summary>Harmony Hub PlayStation</summary>
		public SwitchEntity HarmonyHubPlaystation => new(_haContext, "switch.harmony_hub_playstation");
		///<summary>Harmony Hub Spiel streamen</summary>
		public SwitchEntity HarmonyHubSpielStreamen => new(_haContext, "switch.harmony_hub_spiel_streamen");
		///<summary>Lautsprecher Pup</summary>
		public SwitchEntity LoudspeakerPup => new(_haContext, "switch.loudspeaker_pup");
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
		///<summary>Schedule #4e40b2</summary>
		public SwitchEntity Schedule4e40b2 => new(_haContext, "switch.schedule_4e40b2");
		///<summary>Schedule #5132c8</summary>
		public SwitchEntity Schedule5132c8 => new(_haContext, "switch.schedule_5132c8");
		///<summary>Schedule #f18168</summary>
		public SwitchEntity ScheduleF18168 => new(_haContext, "switch.schedule_f18168");
		///<summary>toggle_chrome_media_playback</summary>
		public SwitchEntity ToggleChromeMediaPlayback => new(_haContext, "switch.toggle_chrome_media_playback");
		///<summary>toggle_chrome_media_playback</summary>
		public SwitchEntity ToggleChromeMediaPlayback10 => new(_haContext, "switch.toggle_chrome_media_playback_10");
		///<summary>toggle_chrome_media_playback</summary>
		public SwitchEntity ToggleChromeMediaPlayback11 => new(_haContext, "switch.toggle_chrome_media_playback_11");
		///<summary>toggle_chrome_media_playback</summary>
		public SwitchEntity ToggleChromeMediaPlayback12 => new(_haContext, "switch.toggle_chrome_media_playback_12");
		///<summary>toggle_chrome_media_playback</summary>
		public SwitchEntity ToggleChromeMediaPlayback13 => new(_haContext, "switch.toggle_chrome_media_playback_13");
		///<summary>toggle_chrome_media_playback</summary>
		public SwitchEntity ToggleChromeMediaPlayback4 => new(_haContext, "switch.toggle_chrome_media_playback_4");
		///<summary>toggle_chrome_media_playback</summary>
		public SwitchEntity ToggleChromeMediaPlayback5 => new(_haContext, "switch.toggle_chrome_media_playback_5");
		///<summary>toggle_chrome_media_playback</summary>
		public SwitchEntity ToggleChromeMediaPlayback6 => new(_haContext, "switch.toggle_chrome_media_playback_6");
		///<summary>toggle_chrome_media_playback</summary>
		public SwitchEntity ToggleChromeMediaPlayback7 => new(_haContext, "switch.toggle_chrome_media_playback_7");
		///<summary>toggle_chrome_media_playback</summary>
		public SwitchEntity ToggleChromeMediaPlayback8 => new(_haContext, "switch.toggle_chrome_media_playback_8");
		///<summary>toggle_chrome_media_playback</summary>
		public SwitchEntity ToggleChromeMediaPlayback9 => new(_haContext, "switch.toggle_chrome_media_playback_9");
		///<summary>toggle_kino_playback</summary>
		public SwitchEntity ToggleKinoPlayback => new(_haContext, "switch.toggle_kino_playback");
		///<summary>windows</summary>
		public SwitchEntity Windows => new(_haContext, "switch.windows");
		///<summary>windowswol</summary>
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

		///<summary>Fantenrüssel</summary>
		public VacuumEntity Fantenrussel => new(_haContext, "vacuum.fantenrussel");
	}

	public class VarEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public VarEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Verfügbare Spiele auf Desktop Fabienne</summary>
		public VarEntity MoonlightAvailableGamesDesktopFabienne => new(_haContext, "var.moonlight_available_games_desktop_fabienne");
		///<summary>Verfügbare Spiele auf Desktop Philipp</summary>
		public VarEntity MoonlightAvailableGamesDesktopPhilipp => new(_haContext, "var.moonlight_available_games_desktop_philipp");
		///<summary>Spiel läuft</summary>
		public VarEntity MoonlightIsRunning => new(_haContext, "var.moonlight_is_running");
	}

	public class WeatherEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public WeatherEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Zuhause</summary>
		public WeatherEntity Zuhause => new(_haContext, "weather.zuhause");
	}

	public class ZoneEntities
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public ZoneEntities(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Zuhause</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
	}

	public record AlarmControlPanelEntity : NetDaemon.HassModel.Entities.Entity<AlarmControlPanelEntity, NetDaemon.HassModel.Entities.EntityState<AlarmControlPanelAttributes>, AlarmControlPanelAttributes>
	{
		public AlarmControlPanelEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AlarmControlPanelEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorEntity : NetDaemon.HassModel.Entities.Entity<BinarySensorEntity, NetDaemon.HassModel.Entities.EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record CalendarEntity : NetDaemon.HassModel.Entities.Entity<CalendarEntity, NetDaemon.HassModel.Entities.EntityState<CalendarAttributes>, CalendarAttributes>
	{
		public CalendarEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CalendarEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record CameraEntity : NetDaemon.HassModel.Entities.Entity<CameraEntity, NetDaemon.HassModel.Entities.EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CameraEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record ClimateEntity : NetDaemon.HassModel.Entities.Entity<ClimateEntity, NetDaemon.HassModel.Entities.EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ClimateEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record CounterEntity : NetDaemon.HassModel.Entities.Entity<CounterEntity, NetDaemon.HassModel.Entities.EntityState<CounterAttributes>, CounterAttributes>
	{
		public CounterEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CounterEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerEntity : NetDaemon.HassModel.Entities.Entity<DeviceTrackerEntity, NetDaemon.HassModel.Entities.EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record GroupEntity : NetDaemon.HassModel.Entities.Entity<GroupEntity, NetDaemon.HassModel.Entities.EntityState<GroupAttributes>, GroupAttributes>
	{
		public GroupEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public GroupEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record InputBooleanEntity : NetDaemon.HassModel.Entities.Entity<InputBooleanEntity, NetDaemon.HassModel.Entities.EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputBooleanEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record InputNumberEntity : NetDaemon.HassModel.Entities.NumericEntity<InputNumberEntity, NetDaemon.HassModel.Entities.NumericEntityState<InputNumberAttributes>, InputNumberAttributes>
	{
		public InputNumberEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputNumberEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record InputSelectEntity : NetDaemon.HassModel.Entities.Entity<InputSelectEntity, NetDaemon.HassModel.Entities.EntityState<InputSelectAttributes>, InputSelectAttributes>
	{
		public InputSelectEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputSelectEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record InputTextEntity : NetDaemon.HassModel.Entities.Entity<InputTextEntity, NetDaemon.HassModel.Entities.EntityState<InputTextAttributes>, InputTextAttributes>
	{
		public InputTextEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputTextEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record LightEntity : NetDaemon.HassModel.Entities.Entity<LightEntity, NetDaemon.HassModel.Entities.EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerEntity : NetDaemon.HassModel.Entities.Entity<MediaPlayerEntity, NetDaemon.HassModel.Entities.EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record PersistentNotificationEntity : NetDaemon.HassModel.Entities.Entity<PersistentNotificationEntity, NetDaemon.HassModel.Entities.EntityState<PersistentNotificationAttributes>, PersistentNotificationAttributes>
	{
		public PersistentNotificationEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersistentNotificationEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record PersonEntity : NetDaemon.HassModel.Entities.Entity<PersonEntity, NetDaemon.HassModel.Entities.EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record RemoteEntity : NetDaemon.HassModel.Entities.Entity<RemoteEntity, NetDaemon.HassModel.Entities.EntityState<RemoteAttributes>, RemoteAttributes>
	{
		public RemoteEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public RemoteEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record SensorEntity : NetDaemon.HassModel.Entities.Entity<SensorEntity, NetDaemon.HassModel.Entities.EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorEntity : NetDaemon.HassModel.Entities.NumericEntity<NumericSensorEntity, NetDaemon.HassModel.Entities.NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record SunEntity : NetDaemon.HassModel.Entities.Entity<SunEntity, NetDaemon.HassModel.Entities.EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record SwitchEntity : NetDaemon.HassModel.Entities.Entity<SwitchEntity, NetDaemon.HassModel.Entities.EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record TimerEntity : NetDaemon.HassModel.Entities.Entity<TimerEntity, NetDaemon.HassModel.Entities.EntityState<TimerAttributes>, TimerAttributes>
	{
		public TimerEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public TimerEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record VacuumEntity : NetDaemon.HassModel.Entities.Entity<VacuumEntity, NetDaemon.HassModel.Entities.EntityState<VacuumAttributes>, VacuumAttributes>
	{
		public VacuumEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VacuumEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record VarEntity : NetDaemon.HassModel.Entities.Entity<VarEntity, NetDaemon.HassModel.Entities.EntityState<VarAttributes>, VarAttributes>
	{
		public VarEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VarEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record WeatherEntity : NetDaemon.HassModel.Entities.Entity<WeatherEntity, NetDaemon.HassModel.Entities.EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public WeatherEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
		{
		}
	}

	public record ZoneEntity : NetDaemon.HassModel.Entities.Entity<ZoneEntity, NetDaemon.HassModel.Entities.EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
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

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("battery")]
		public double? Battery { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device")]
		public object? Device { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
		public string? DeviceClass { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance")]
		public double? Illuminance { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last_seen")]
		public string? LastSeen { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("linkquality")]
		public double? Linkquality { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("malware")]
		public string? Malware { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("network")]
		public string? Network { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("newest_version")]
		public string? NewestVersion { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("occupancy")]
		public bool? Occupancy { get; init; }

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

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
		public double? Temperature { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("update")]
		public string? Update { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("userInfo")]
		public string? UserInfo { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("voltage")]
		public double? Voltage { get; init; }
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

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool? Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("step")]
		public double? Step { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
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

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool? Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
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
		public object? Initial { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("max")]
		public double? Max { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("min")]
		public double? Min { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
		public string? Mode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool? Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("step")]
		public double? Step { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
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

	public record InputTextAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
		public bool? Editable { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("max")]
		public double? Max { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("min")]
		public double? Min { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
		public string? Mode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("pattern")]
		public object? Pattern { get; init; }
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

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("hs_color")]
		public object? HsColor { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("max_mireds")]
		public double? MaxMireds { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("min_mireds")]
		public double? MinMireds { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("rgb_color")]
		public object? RgbColor { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_color_modes")]
		public object? SupportedColorModes { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("xy_color")]
		public object? XyColor { get; init; }
	}

	public record MediaPlayerAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool? Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("source_list")]
		public object? SourceList { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record PersistentNotificationAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("message")]
		public string? Message { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("title")]
		public string? Title { get; init; }
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

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool? Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("source")]
		public string? Source { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }

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
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("action")]
		public object? Action { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Administrative Area")]
		public string? AdministrativeArea { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Allows VoIP")]
		public bool? AllowsVoIP { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Areas Of Interest")]
		public object? AreasOfInterest { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("attribution")]
		public string? Attribution { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("battery")]
		public double? Battery { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Carrier ID")]
		public string? CarrierID { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Carrier Name")]
		public string? CarrierName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("click")]
		public string? Click { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("color")]
		public string? Color { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Confidence")]
		public string? Confidence { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Country")]
		public string? Country { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Current Radio Technology")]
		public string? CurrentRadioTechnology { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device")]
		public object? Device { get; init; }

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

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance")]
		public double? Illuminance { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Inland Water")]
		public string? InlandWater { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("integration")]
		public string? Integration { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("ISO Country Code")]
		public string? ISOCountryCode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last_seen")]
		public string? LastSeen { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("lastupdate")]
		public string? Lastupdate { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("lastworkout_title")]
		public string? LastworkoutTitle { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("lastworkout_url")]
		public string? LastworkoutUrl { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("linkquality")]
		public double? Linkquality { get; init; }

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

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Name")]
		public string? Name { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("number_of_loaded_apps")]
		public double? NumberOfLoadedApps { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("number_of_running_apps")]
		public double? NumberOfRunningApps { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Ocean")]
		public string? Ocean { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Postal Code")]
		public string? PostalCode { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool? Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Administrative Area")]
		public string? SubAdministrativeArea { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Locality")]
		public string? SubLocality { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Thoroughfare")]
		public string? SubThoroughfare { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("text")]
		public string? Text { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Thoroughfare")]
		public string? Thoroughfare { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Time Zone")]
		public string? TimeZone { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Types")]
		public object? Types { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("valve_tappet_state")]
		public string? ValveTappetState { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
		public string? Version { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("voltage")]
		public double? Voltage { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Zones")]
		public object? Zones { get; init; }
	}

	public record NumericSensorAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("action")]
		public object? Action { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("attribution")]
		public string? Attribution { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Available")]
		public string? Available { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Available (Important)")]
		public string? AvailableImportant { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("Available (Opportunistic)")]
		public string? AvailableOpportunistic { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("battery")]
		public double? Battery { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("bytes_received")]
		public double? BytesReceived { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("bytes_sent")]
		public double? BytesSent { get; init; }

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

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("click")]
		public string? Click { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device")]
		public object? Device { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
		public string? DeviceClass { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
		public string? FriendlyName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
		public string? Icon { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance")]
		public double? Illuminance { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("last_seen")]
		public string? LastSeen { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("linkquality")]
		public double? Linkquality { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("name")]
		public string? Name { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("occupancy")]
		public bool? Occupancy { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("profitLoss")]
		public double? ProfitLoss { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("profitLossPercentage")]
		public double? ProfitLossPercentage { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("purchasePrice")]
		public double? PurchasePrice { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("repositories")]
		public object? Repositories { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool? Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("server_country")]
		public string? ServerCountry { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("server_id")]
		public string? ServerId { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("server_name")]
		public string? ServerName { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("shares")]
		public double? Shares { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
		public double? Temperature { get; init; }

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

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("voltage")]
		public double? Voltage { get; init; }
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

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool? Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("tags")]
		public object? Tags { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("times")]
		public object? Times { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("weekdays")]
		public object? Weekdays { get; init; }
	}

	public record TimerAttributes
	{
		[System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
		public bool? Restored { get; init; }

		[System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
		public double? SupportedFeatures { get; init; }
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

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmAway(NetDaemon.HassModel.Entities.ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public void AlarmArmAway(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmCustomBypass(NetDaemon.HassModel.Entities.ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public void AlarmArmCustomBypass(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmHome(NetDaemon.HassModel.Entities.ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public void AlarmArmHome(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmNight(NetDaemon.HassModel.Entities.ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public void AlarmArmNight(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmDisarm(NetDaemon.HassModel.Entities.ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public void AlarmDisarm(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmTrigger(NetDaemon.HassModel.Entities.ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public void AlarmTrigger(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public record AlarmControlPanelAlarmArmAwayParameters
	{
		///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmCustomBypassParameters
	{
		///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmHomeParameters
	{
		///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmNightParameters
	{
		///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmDisarmParameters
	{
		///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmTriggerParameters
	{
		///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
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

		///<summary>Reload the automation configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Trigger(NetDaemon.HassModel.Entities.ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public void Trigger(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		///<summary>Whether or not the conditions will be skipped.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("skipCondition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		///<summary>Stop currently running actions.</summary>
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

		///<summary>Triggers a custom alarm state on a smoke detector.</summary>
		public void SmokedetectorAlarmstate(BoschShcSmokedetectorAlarmstateParameters data)
		{
			_haContext.CallService("bosch_shc", "smokedetector_alarmstate", null, data);
		}

		///<summary>Triggers a custom alarm state on a smoke detector.</summary>
		///<param name="entityId">Name of the smoke detector entity to set eg: binary_sensor.smokedetector_living_room</param>
		///<param name="command">Command string to send to the smoke detector. eg: CUSTOM_COMMAND</param>
		public void SmokedetectorAlarmstate(string? @entityId = null, string? @command = null)
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
		public void SmokedetectorCheck(string? @entityId = null)
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
		public void TriggerScenario(string? @name = null)
		{
			_haContext.CallService("bosch_shc", "trigger_scenario", null, new BoschShcTriggerScenarioParameters{Name = @name});
		}
	}

	public record BoschShcSmokedetectorAlarmstateParameters
	{
		///<summary>Name of the smoke detector entity to set eg: binary_sensor.smokedetector_living_room</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		///<summary>Command string to send to the smoke detector. eg: CUSTOM_COMMAND</summary>
		[System.Text.Json.Serialization.JsonPropertyName("command")]
		public string? Command { get; init; }
	}

	public record BoschShcSmokedetectorCheckParameters
	{
		///<summary>Name of the smoke detector entity to set eg: binary_sensor.smokedetector_living_room</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }
	}

	public record BoschShcTriggerScenarioParameters
	{
		///<summary>Name of the scenario to trigger eg: Scenario Name</summary>
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

		///<summary>Disable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void DisableMotionDetection(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		///<summary>Enable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void EnableMotionDetection(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayStream(NetDaemon.HassModel.Entities.ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public void PlayStream(NetDaemon.HassModel.Entities.ServiceTarget target, string @mediaPlayer, string? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		public void Record(NetDaemon.HassModel.Entities.ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public void Record(NetDaemon.HassModel.Entities.ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Snapshot(NetDaemon.HassModel.Entities.ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public void Snapshot(NetDaemon.HassModel.Entities.ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		///<summary>Turn on camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		///<summary>Name(s) of media player to stream to.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("mediaPlayer")]
		public string? MediaPlayer { get; init; }

		///<summary>Stream format supported by media player.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("format")]
		public string? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
		[System.Text.Json.Serialization.JsonPropertyName("filename")]
		public string? Filename { get; init; }

		///<summary>Target recording length.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
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
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		///<summary>The URL path of the Lovelace dashboard to show. eg: lovelace-cast</summary>
		[System.Text.Json.Serialization.JsonPropertyName("dashboardPath")]
		public string? DashboardPath { get; init; }

		///<summary>The path of the Lovelace view to show. eg: downstairs</summary>
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

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAuxHeat(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public void SetAuxHeat(NetDaemon.HassModel.Entities.ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public void SetHumidity(NetDaemon.HassModel.Entities.ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHvacMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public void SetHvacMode(NetDaemon.HassModel.Entities.ServiceTarget target, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public void SetPresetMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSwingMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public void SetSwingMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public void SetTemperature(NetDaemon.HassModel.Entities.ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		///<summary>Turn climate device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		///<summary>New value of auxiliary heater.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("auxHeat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[System.Text.Json.Serialization.JsonPropertyName("fanMode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		///<summary>New target humidity for climate device.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		///<summary>New value of operation mode.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("hvacMode")]
		public string? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: away</summary>
		[System.Text.Json.Serialization.JsonPropertyName("presetMode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		///<summary>New value of swing mode. eg: horizontal</summary>
		[System.Text.Json.Serialization.JsonPropertyName("swingMode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		///<summary>New target temperature for HVAC.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New target high temperature for HVAC.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("targetTempHigh")]
		public double? TargetTempHigh { get; init; }

		///<summary>New target low temperature for HVAC.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("targetTempLow")]
		public double? TargetTempLow { get; init; }

		///<summary>HVAC operation mode to set temperature to.</summary>
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

	public class CounterServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public CounterServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		public void Configure(NetDaemon.HassModel.Entities.ServiceTarget target, CounterConfigureParameters data)
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
		public void Configure(NetDaemon.HassModel.Entities.ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		///<summary>Increment a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		///<summary>Reset a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		///<summary>New minimum value for the counter or None to remove minimum.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		///<summary>New maximum value for the counter or None to remove maximum.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		///<summary>New value for step.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("step")]
		public long? Step { get; init; }

		///<summary>New value for initial.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("initial")]
		public long? Initial { get; init; }

		///<summary>New state value.</summary>
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

		///<summary>Close all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCover(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		///<summary>Close all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		///<summary>Open all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCover(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		///<summary>Open all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverPosition(NetDaemon.HassModel.Entities.ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="position">Position of the cover</param>
		public void SetCoverPosition(NetDaemon.HassModel.Entities.ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverTiltPosition(NetDaemon.HassModel.Entities.ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public void SetCoverTiltPosition(NetDaemon.HassModel.Entities.ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCover(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		///<summary>Toggle a cover open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void ToggleCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		///<summary>Position of the cover</summary>
		[System.Text.Json.Serialization.JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		///<summary>Tilt position of the cover.</summary>
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
		[System.Text.Json.Serialization.JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
		[System.Text.Json.Serialization.JsonPropertyName("devId")]
		public string? DevId { get; init; }

		///<summary>Hostname of device eg: Dave</summary>
		[System.Text.Json.Serialization.JsonPropertyName("hostName")]
		public string? HostName { get; init; }

		///<summary>Name of location where device is located (not_home is away). eg: home</summary>
		[System.Text.Json.Serialization.JsonPropertyName("locationName")]
		public string? LocationName { get; init; }

		///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("gps")]
		public object? Gps { get; init; }

		///<summary>Accuracy of GPS coordinates.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("gpsAccuracy")]
		public long? GpsAccuracy { get; init; }

		///<summary>Battery level of device.</summary>
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
		///<param name="name">Name of a predefined theme, 'default' or 'none'. eg: default</param>
		///<param name="mode">The mode the theme is for.</param>
		public void SetTheme(string @name, string? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters{Name = @name, Mode = @mode});
		}
	}

	public record FrontendSetThemeParameters
	{
		///<summary>Name of a predefined theme, 'default' or 'none'. eg: default</summary>
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>The mode the theme is for.</summary>
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

		///<summary>Add a new calendar event.</summary>
		public void AddEvent(GoogleAddEventParameters data)
		{
			_haContext.CallService("google", "add_event", null, data);
		}

		///<summary>Add a new calendar event.</summary>
		///<param name="calendarId">The id of the calendar you want. eg: Your email</param>
		///<param name="summary">Acts as the title of the event. eg: Bowling</param>
		///<param name="description">The description of the event. Optional. eg: Birthday bowling</param>
		///<param name="startDateTime">The date and time the event should start. eg: 2019-03-22 20:00:00</param>
		///<param name="endDateTime">The date and time the event should end. eg: 2019-03-22 22:00:00</param>
		///<param name="startDate">The date the whole day event should start. eg: 2019-03-10</param>
		///<param name="endDate">The date the whole day event should end. eg: 2019-03-11</param>
		///<param name="in">Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</param>
		public void AddEvent(string @calendarId, string @summary, string? @description = null, string? @startDateTime = null, string? @endDateTime = null, string? @startDate = null, string? @endDate = null, object? @in = null)
		{
			_haContext.CallService("google", "add_event", null, new GoogleAddEventParameters{CalendarId = @calendarId, Summary = @summary, Description = @description, StartDateTime = @startDateTime, EndDateTime = @endDateTime, StartDate = @startDate, EndDate = @endDate, In = @in});
		}

		///<summary>Add calendar if it has not been already discovered.</summary>
		public void FoundCalendar()
		{
			_haContext.CallService("google", "found_calendar", null);
		}

		///<summary>Scan for new calendars.</summary>
		public void ScanForCalendars()
		{
			_haContext.CallService("google", "scan_for_calendars", null);
		}
	}

	public record GoogleAddEventParameters
	{
		///<summary>The id of the calendar you want. eg: Your email</summary>
		[System.Text.Json.Serialization.JsonPropertyName("calendarId")]
		public string? CalendarId { get; init; }

		///<summary>Acts as the title of the event. eg: Bowling</summary>
		[System.Text.Json.Serialization.JsonPropertyName("summary")]
		public string? Summary { get; init; }

		///<summary>The description of the event. Optional. eg: Birthday bowling</summary>
		[System.Text.Json.Serialization.JsonPropertyName("description")]
		public string? Description { get; init; }

		///<summary>The date and time the event should start. eg: 2019-03-22 20:00:00</summary>
		[System.Text.Json.Serialization.JsonPropertyName("startDateTime")]
		public string? StartDateTime { get; init; }

		///<summary>The date and time the event should end. eg: 2019-03-22 22:00:00</summary>
		[System.Text.Json.Serialization.JsonPropertyName("endDateTime")]
		public string? EndDateTime { get; init; }

		///<summary>The date the whole day event should start. eg: 2019-03-10</summary>
		[System.Text.Json.Serialization.JsonPropertyName("startDate")]
		public string? StartDate { get; init; }

		///<summary>The date the whole day event should end. eg: 2019-03-11</summary>
		[System.Text.Json.Serialization.JsonPropertyName("endDate")]
		public string? EndDate { get; init; }

		///<summary>Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</summary>
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
		///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
		public void Set(string @objectId, string? @name = null, string? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all});
		}
	}

	public record GroupRemoveParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[System.Text.Json.Serialization.JsonPropertyName("objectId")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[System.Text.Json.Serialization.JsonPropertyName("objectId")]
		public string? ObjectId { get; init; }

		///<summary>Name of group eg: My test group</summary>
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Name of icon for the group. eg: mdi:camera</summary>
		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string? Icon { get; init; }

		///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[System.Text.Json.Serialization.JsonPropertyName("addEntities")]
		public object? AddEntities { get; init; }

		///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
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

		///<summary>Sends change channel command to the Harmony HUB</summary>
		///<param name="target">The target for this service call</param>
		public void ChangeChannel(NetDaemon.HassModel.Entities.ServiceTarget target, HarmonyChangeChannelParameters data)
		{
			_haContext.CallService("harmony", "change_channel", target, data);
		}

		///<summary>Sends change channel command to the Harmony HUB</summary>
		///<param name="target">The target for this service call</param>
		///<param name="channel">Channel number to change to</param>
		public void ChangeChannel(NetDaemon.HassModel.Entities.ServiceTarget target, long @channel)
		{
			_haContext.CallService("harmony", "change_channel", target, new HarmonyChangeChannelParameters{Channel = @channel});
		}

		///<summary>Syncs the remote's configuration.</summary>
		///<param name="target">The target for this service call</param>
		public void Sync(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("harmony", "sync", target);
		}
	}

	public record HarmonyChangeChannelParameters
	{
		///<summary>Channel number to change to</summary>
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

		///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		public void ReloadConfigEntry(NetDaemon.HassModel.Entities.ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
		public void ReloadConfigEntry(NetDaemon.HassModel.Entities.ServiceTarget target, string? @entryId = null)
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
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		///<summary>Generic service to turn devices off under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		///<summary>Generic service to turn devices on under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		///<summary>Force one or more entities to update its data</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateEntity(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entryId")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		///<summary>Latitude of your location. eg: 32,87336</summary>
		[System.Text.Json.Serialization.JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		///<summary>Longitude of your location. eg: 117,22743</summary>
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

		///<summary>Reload the input_boolean configuration</summary>
		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		///<summary>Toggle an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		///<summary>Turn off an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		///<summary>Turn on an input boolean</summary>
		///<param name="target">The target for this service call</param>
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

		///<summary>Reload the input_datetime configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDatetime(NetDaemon.HassModel.Entities.ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public void SetDatetime(NetDaemon.HassModel.Entities.ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
		[System.Text.Json.Serialization.JsonPropertyName("date")]
		public string? Date { get; init; }

		///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
		[System.Text.Json.Serialization.JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
		[System.Text.Json.Serialization.JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
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

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(NetDaemon.HassModel.Entities.ServiceTarget target)
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
		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to.</param>
		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters{Value = @value});
		}
	}

	public record InputNumberSetValueParameters
	{
		///<summary>The target value the entity should be set to.</summary>
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

		///<summary>Reload the input_select configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		///<summary>Select the first option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectFirst(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		///<summary>Select the last option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectLast(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectNext(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public void SelectNext(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectPrevious(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public void SelectPrevious(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOptions(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public void SetOptions(NetDaemon.HassModel.Entities.ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public record InputSelectSelectNextParameters
	{
		///<summary>If the option should cycle from the last to the first.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[System.Text.Json.Serialization.JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		///<summary>If the option should cycle from the first to the last.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
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

		///<summary>Reload the input_text configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters{Value = @value});
		}
	}

	public record InputTextSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: This is an example text</summary>
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

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target, LightToggleParameters data)
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
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null, string? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
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
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public record LightToggleParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("rgbColor")]
		public object? RgbColor { get; init; }

		///<summary>A human readable color name.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("colorName")]
		public string? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("hsColor")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("xyColor")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("colorTemp")]
		public long? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating level of white.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("whiteValue")]
		public long? WhiteValue { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("brightnessPct")]
		public long? BrightnessPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[System.Text.Json.Serialization.JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("flash")]
		public string? Flash { get; init; }

		///<summary>Light effect.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>If the light should flash.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("flash")]
		public string? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("rgbColor")]
		public object? RgbColor { get; init; }

		///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("rgbwColor")]
		public object? RgbwColor { get; init; }

		///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("rgbwwColor")]
		public object? RgbwwColor { get; init; }

		///<summary>A human readable color name.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("colorName")]
		public string? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("hsColor")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("xyColor")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("colorTemp")]
		public long? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("brightnessPct")]
		public long? BrightnessPct { get; init; }

		///<summary>Change brightness by an amount.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("brightnessStep")]
		public long? BrightnessStep { get; init; }

		///<summary>Change brightness by a percentage.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("brightnessStepPct")]
		public long? BrightnessStepPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[System.Text.Json.Serialization.JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("flash")]
		public string? Flash { get; init; }

		///<summary>Light effect.</summary>
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
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Message of the custom logbook entry. eg: is being used</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Entity to reference in custom logbook entry.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
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

		///<summary>Set the default log level for integrations.</summary>
		public void SetDefaultLevel(LoggerSetDefaultLevelParameters data)
		{
			_haContext.CallService("logger", "set_default_level", null, data);
		}

		///<summary>Set the default log level for integrations.</summary>
		///<param name="level">Default severity level for all integrations.</param>
		public void SetDefaultLevel(string? @level = null)
		{
			_haContext.CallService("logger", "set_default_level", null, new LoggerSetDefaultLevelParameters{Level = @level});
		}

		///<summary>Set log level for integrations.</summary>
		public void SetLevel(LoggerSetLevelParameters data)
		{
			_haContext.CallService("logger", "set_level", null, data);
		}

		///<summary>Set log level for integrations.</summary>
		///<param name="homeassistantcore">Example on how to change the logging level for a Home Assistant Core integrations.</param>
		///<param name="homeassistantcomponentsmqtt">Example on how to change the logging level for an Integration.</param>
		///<param name="customComponentsmyIntegration">Example on how to change the logging level for a Custom Integration.</param>
		///<param name="aiohttp">Example on how to change the logging level for a Python module.</param>
		public void SetLevel(string? @homeassistantcore = null, string? @homeassistantcomponentsmqtt = null, string? @customComponentsmyIntegration = null, string? @aiohttp = null)
		{
			_haContext.CallService("logger", "set_level", null, new LoggerSetLevelParameters{Homeassistantcore = @homeassistantcore, Homeassistantcomponentsmqtt = @homeassistantcomponentsmqtt, CustomComponentsmyIntegration = @customComponentsmyIntegration, Aiohttp = @aiohttp});
		}
	}

	public record LoggerSetDefaultLevelParameters
	{
		///<summary>Default severity level for all integrations.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("level")]
		public string? Level { get; init; }
	}

	public record LoggerSetLevelParameters
	{
		///<summary>Example on how to change the logging level for a Home Assistant Core integrations.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("homeassistantcore")]
		public string? Homeassistantcore { get; init; }

		///<summary>Example on how to change the logging level for an Integration.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("homeassistantcomponentsmqtt")]
		public string? Homeassistantcomponentsmqtt { get; init; }

		///<summary>Example on how to change the logging level for a Custom Integration.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("customComponentsmyIntegration")]
		public string? CustomComponentsmyIntegration { get; init; }

		///<summary>Example on how to change the logging level for a Python module.</summary>
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

		///<summary>Send the media player the command to clear players playlist.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearPlaylist(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Join(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</param>
		public void Join(NetDaemon.HassModel.Entities.ServiceTarget target, object? @groupMembers = null)
		{
			_haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaNextTrack(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		///<summary>Send the media player the command for pause.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		///<summary>Send the media player the command for play.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlay(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		///<summary>Toggle media player play/pause state.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlayPause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		///<summary>Send the media player the command for previous track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPreviousTrack(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaSeek(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public void MediaSeek(NetDaemon.HassModel.Entities.ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaStop(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public void PlayMedia(NetDaemon.HassModel.Entities.ServiceTarget target, string @mediaContentId, string @mediaContentType)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		public void RepeatSet(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="repeat">Repeat mode to set.</param>
		public void RepeatSet(NetDaemon.HassModel.Entities.ServiceTarget target, string @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSoundMode(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public void SelectSoundMode(NetDaemon.HassModel.Entities.ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSource(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public void SelectSource(NetDaemon.HassModel.Entities.ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		public void ShuffleSet(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public void ShuffleSet(NetDaemon.HassModel.Entities.ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		///<summary>Turn a media player power off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		///<summary>Turn a media player power on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		///<summary>Turn a media player volume down.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeDown(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeMute(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public void VolumeMute(NetDaemon.HassModel.Entities.ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeSet(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public void VolumeSet(NetDaemon.HassModel.Entities.ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeUp(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		///<summary>The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("groupMembers")]
		public object? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		///<summary>Position to seek to. The format is platform dependent.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("seekPosition")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
		[System.Text.Json.Serialization.JsonPropertyName("mediaContentId")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
		[System.Text.Json.Serialization.JsonPropertyName("mediaContentType")]
		public string? MediaContentType { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		///<summary>Repeat mode to set.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("repeat")]
		public string? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		///<summary>Name of the sound mode to switch to. eg: Music</summary>
		[System.Text.Json.Serialization.JsonPropertyName("soundMode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
		[System.Text.Json.Serialization.JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		///<summary>True/false for enabling/disabling shuffle.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		///<summary>True/false for mute/unmute.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("isVolumeMuted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		///<summary>Volume level to set as float.</summary>
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
		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, string? @qos = null, bool? @retain = null)
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
		[System.Text.Json.Serialization.JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>how long we should listen for messages in seconds</summary>
		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
		[System.Text.Json.Serialization.JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>Payload to publish. eg: This is great</summary>
		[System.Text.Json.Serialization.JsonPropertyName("payload")]
		public string? Payload { get; init; }

		///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
		[System.Text.Json.Serialization.JsonPropertyName("payloadTemplate")]
		public object? PayloadTemplate { get; init; }

		///<summary>Quality of Service to use.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("qos")]
		public string? Qos { get; init; }

		///<summary>If message should have the retain flag set.</summary>
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
		///<param name="attributes">The attributes of the entity</param>
		public void EntityCreate(string? @entityId = null, string? @state = null, string? @icon = null, string? @unit = null, string? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_create", null, new NetdaemonEntityCreateParameters{EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Attributes = @attributes});
		}

		///<summary>Remove an entity</summary>
		public void EntityRemove(NetdaemonEntityRemoveParameters data)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, data);
		}

		///<summary>Remove an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		public void EntityRemove(string? @entityId = null)
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
		///<param name="attributes">The attributes of the entity</param>
		public void EntityUpdate(string? @entityId = null, string? @state = null, string? @icon = null, string? @unit = null, string? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_update", null, new NetdaemonEntityUpdateParameters{EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Attributes = @attributes});
		}

		///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
		public void RegisterService(NetdaemonRegisterServiceParameters data)
		{
			_haContext.CallService("netdaemon", "register_service", null, data);
		}

		///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
		///<param name="class">The class that implements the service call</param>
		///<param name="method">The method to call</param>
		public void RegisterService(string? @class = null, string? @method = null)
		{
			_haContext.CallService("netdaemon", "register_service", null, new NetdaemonRegisterServiceParameters{Class = @class, Method = @method});
		}

		public void ReloadApps()
		{
			_haContext.CallService("netdaemon", "reload_apps", null);
		}
	}

	public record NetdaemonEntityCreateParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		///<summary>The state of the entity eg: Lorem ipsum</summary>
		[System.Text.Json.Serialization.JsonPropertyName("state")]
		public string? State { get; init; }

		///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string? Icon { get; init; }

		///<summary>The unit of measurement for the entity</summary>
		[System.Text.Json.Serialization.JsonPropertyName("unit")]
		public string? Unit { get; init; }

		///<summary>The attributes of the entity</summary>
		[System.Text.Json.Serialization.JsonPropertyName("attributes")]
		public string? Attributes { get; init; }
	}

	public record NetdaemonEntityRemoveParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }
	}

	public record NetdaemonEntityUpdateParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		///<summary>The state of the entity eg: Lorem ipsum</summary>
		[System.Text.Json.Serialization.JsonPropertyName("state")]
		public string? State { get; init; }

		///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string? Icon { get; init; }

		///<summary>The unit of measurement for the entity</summary>
		[System.Text.Json.Serialization.JsonPropertyName("unit")]
		public string? Unit { get; init; }

		///<summary>The attributes of the entity</summary>
		[System.Text.Json.Serialization.JsonPropertyName("attributes")]
		public string? Attributes { get; init; }
	}

	public record NetdaemonRegisterServiceParameters
	{
		///<summary>The class that implements the service call</summary>
		[System.Text.Json.Serialization.JsonPropertyName("class")]
		public string? Class { get; init; }

		///<summary>The method to call</summary>
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

		///<summary>Trigger a Node-RED Node</summary>
		public void Trigger(NoderedTriggerParameters data)
		{
			_haContext.CallService("nodered", "trigger", null, data);
		}

		///<summary>Trigger a Node-RED Node</summary>
		///<param name="entityId">Entity Id of the Node-RED switch eg: switch.nodered_motion</param>
		///<param name="triggerEntityId">Entity Id to trigger the event node with. Only needed if the node is not triggered by a single entity. eg: sun.sun</param>
		///<param name="skipCondition">Skip conditions of the node (defaults to false) eg: True</param>
		///<param name="outputPath">Which output of the node to use (defaults to true, the top output). Only used when skip_condition is set to true. eg: True</param>
		///<param name="payload">The payload the node will output when triggered. Work only when triggering a entity node not an event node.</param>
		public void Trigger(string? @entityId = null, string? @triggerEntityId = null, string? @skipCondition = null, string? @outputPath = null, string? @payload = null)
		{
			_haContext.CallService("nodered", "trigger", null, new NoderedTriggerParameters{EntityId = @entityId, TriggerEntityId = @triggerEntityId, SkipCondition = @skipCondition, OutputPath = @outputPath, Payload = @payload});
		}
	}

	public record NoderedTriggerParameters
	{
		///<summary>Entity Id of the Node-RED switch eg: switch.nodered_motion</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		///<summary>Entity Id to trigger the event node with. Only needed if the node is not triggered by a single entity. eg: sun.sun</summary>
		[System.Text.Json.Serialization.JsonPropertyName("triggerEntityId")]
		public string? TriggerEntityId { get; init; }

		///<summary>Skip conditions of the node (defaults to false) eg: True</summary>
		[System.Text.Json.Serialization.JsonPropertyName("skipCondition")]
		public string? SkipCondition { get; init; }

		///<summary>Which output of the node to use (defaults to true, the top output). Only used when skip_condition is set to true. eg: True</summary>
		[System.Text.Json.Serialization.JsonPropertyName("outputPath")]
		public string? OutputPath { get; init; }

		///<summary>The payload the node will output when triggered. Work only when triggering a entity node not an event node.</summary>
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

		///<summary>Sends a notification to the visible in the front-end.</summary>
		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		///<summary>Sends a notification to the visible in the front-end.</summary>
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
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppFantenphoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppIphonePhilippParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[System.Text.Json.Serialization.JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
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
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
		[System.Text.Json.Serialization.JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("notificationId")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
		[System.Text.Json.Serialization.JsonPropertyName("notificationId")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
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

		///<summary>Reload the person configuration.</summary>
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

		///<summary>Reload all ping entities.</summary>
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
		public void PurgeEntities(NetDaemon.HassModel.Entities.ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
		///<param name="entityGlobs">List the regular expressions to select entities for removal from the recorder database. eg: domain*.object_id*</param>
		public void PurgeEntities(NetDaemon.HassModel.Entities.ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters{Domains = @domains, EntityGlobs = @entityGlobs});
		}
	}

	public record RecorderPurgeParameters
	{
		///<summary>Number of history days to keep in database after purge.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("keepDays")]
		public long? KeepDays { get; init; }

		///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("applyFilter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
		[System.Text.Json.Serialization.JsonPropertyName("domains")]
		public object? Domains { get; init; }

		///<summary>List the regular expressions to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
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

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		public void DeleteCommand(NetDaemon.HassModel.Entities.ServiceTarget target, RemoteDeleteCommandParameters data)
		{
			_haContext.CallService("remote", "delete_command", target, data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public void DeleteCommand(NetDaemon.HassModel.Entities.ServiceTarget target, object @command, string? @device = null)
		{
			_haContext.CallService("remote", "delete_command", target, new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		public void LearnCommand(NetDaemon.HassModel.Entities.ServiceTarget target, RemoteLearnCommandParameters data)
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
		public void LearnCommand(NetDaemon.HassModel.Entities.ServiceTarget target, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			_haContext.CallService("remote", "learn_command", target, new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(NetDaemon.HassModel.Entities.ServiceTarget target, RemoteSendCommandParameters data)
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
		public void SendCommand(NetDaemon.HassModel.Entities.ServiceTarget target, string @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			_haContext.CallService("remote", "send_command", target, new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("remote", "toggle", target);
		}

		///<summary>Sends the Power Off Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("remote", "turn_off", target);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, RemoteTurnOnParameters data)
		{
			_haContext.CallService("remote", "turn_on", target, data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, string? @activity = null)
		{
			_haContext.CallService("remote", "turn_on", target, new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public record RemoteDeleteCommandParameters
	{
		///<summary>Name of the device from which commands will be deleted. eg: television</summary>
		[System.Text.Json.Serialization.JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to delete. eg: Mute</summary>
		[System.Text.Json.Serialization.JsonPropertyName("command")]
		public object? Command { get; init; }
	}

	public record RemoteLearnCommandParameters
	{
		///<summary>Device ID to learn command from. eg: television</summary>
		[System.Text.Json.Serialization.JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to learn. eg: Turn on</summary>
		[System.Text.Json.Serialization.JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The type of command to be learned.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("commandType")]
		public string? CommandType { get; init; }

		///<summary>If code must be stored as alternative (useful for discrete remotes).</summary>
		[System.Text.Json.Serialization.JsonPropertyName("alternative")]
		public bool? Alternative { get; init; }

		///<summary>Timeout for the command to be learned.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("timeout")]
		public long? Timeout { get; init; }
	}

	public record RemoteSendCommandParameters
	{
		///<summary>Device ID to send command to. eg: 32756745</summary>
		[System.Text.Json.Serialization.JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to send. eg: Play</summary>
		[System.Text.Json.Serialization.JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>The number of times you want to repeat the command(s).</summary>
		[System.Text.Json.Serialization.JsonPropertyName("numRepeats")]
		public long? NumRepeats { get; init; }

		///<summary>The time you want to wait in between repeated commands.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("delaySecs")]
		public double? DelaySecs { get; init; }

		///<summary>The time you want to have it held before the release is send.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("holdSecs")]
		public double? HoldSecs { get; init; }
	}

	public record RemoteTurnOnParameters
	{
		///<summary>Activity ID or Activity Name to start. eg: BedroomTV</summary>
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

		///<summary>Activate a scene with configuration.</summary>
		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		///<summary>Activate a scene with configuration.</summary>
		///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen": "on", "light.ceiling": {"state": "on", "brightness": 80}}</param>
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
		///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light": "on", "light.ceiling": {"state": "on", "brightness": 200}}</param>
		///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling", "light.kitchen"]</param>
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
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public record SceneApplyParameters
	{
		///<summary>The entities and the state that they need to be. eg: {"light.kitchen": "on", "light.ceiling": {"state": "on", "brightness": 80}}</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		///<summary>The entity_id of the new scene. eg: all_lights</summary>
		[System.Text.Json.Serialization.JsonPropertyName("sceneId")]
		public string? SceneId { get; init; }

		///<summary>The entities to control with the scene. eg: {"light.tv_back_light": "on", "light.ceiling": {"state": "on", "brightness": 200}}</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling", "light.kitchen"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("snapshotEntities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
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

		///<summary>Create a new schedule entity</summary>
		public void Add(SchedulerAddParameters data)
		{
			_haContext.CallService("scheduler", "add", null, data);
		}

		///<summary>Create a new schedule entity</summary>
		///<param name="weekdays">Days of the week for which the schedule should be repeated eg: ["daily"]</param>
		///<param name="startDate">Date from which schedule should be executed eg: ["2021-01-01"]</param>
		///<param name="endDate">Date until which schedule should be executed eg: ["2021-12-31"]</param>
		///<param name="timeslots">list of timeslots with their actions and optionally conditions (should be kept the same for all timeslots) eg: [{start: "12:00", stop: "13:00", actions: [{service: "light.turn_on", entity_id: "light.my_lamp", service_data: {brightness: 200}}]}]</param>
		///<param name="repeatType">Control what happens after the schedule is triggered eg: "repeat"</param>
		///<param name="name">Friendly name for the schedule eg: My schedule</param>
		public void Add(object @timeslots, string @repeatType, object? @weekdays = null, object? @startDate = null, object? @endDate = null, string? @name = null)
		{
			_haContext.CallService("scheduler", "add", null, new SchedulerAddParameters{Weekdays = @weekdays, StartDate = @startDate, EndDate = @endDate, Timeslots = @timeslots, RepeatType = @repeatType, Name = @name});
		}

		///<summary>Duplicate a schedule entity</summary>
		public void Copy(SchedulerCopyParameters data)
		{
			_haContext.CallService("scheduler", "copy", null, data);
		}

		///<summary>Duplicate a schedule entity</summary>
		///<param name="entityId">Identifier of the scheduler entity. eg: switch.schedule_abcdef</param>
		///<param name="name">Friendly name for the copied schedule eg: My schedule</param>
		public void Copy(string @entityId, string? @name = null)
		{
			_haContext.CallService("scheduler", "copy", null, new SchedulerCopyParameters{EntityId = @entityId, Name = @name});
		}

		///<summary>Edit a schedule entity</summary>
		public void Edit(SchedulerEditParameters data)
		{
			_haContext.CallService("scheduler", "edit", null, data);
		}

		///<summary>Edit a schedule entity</summary>
		///<param name="entityId">Identifier of the scheduler entity. eg: switch.schedule_abcdef</param>
		///<param name="weekdays">Days of the week for which the schedule should be repeated eg: ["daily"]</param>
		///<param name="startDate">Date from which schedule should be executed eg: ["2021-01-01"]</param>
		///<param name="endDate">Date until which schedule should be executed eg: ["2021-12-31"]</param>
		///<param name="timeslots">list of timeslots with their actions and optionally conditions (should be kept the same for all timeslots) eg: [{start: "12:00", stop: "13:00", actions: [{service: "light.turn_on", entity_id: "light.my_lamp", service_data: {brightness: 200}}]}]</param>
		///<param name="repeatType">Control what happens after the schedule is triggered eg: "repeat"</param>
		///<param name="name">Friendly name for the schedule eg: My schedule</param>
		public void Edit(string @entityId, object @timeslots, string @repeatType, object? @weekdays = null, object? @startDate = null, object? @endDate = null, string? @name = null)
		{
			_haContext.CallService("scheduler", "edit", null, new SchedulerEditParameters{EntityId = @entityId, Weekdays = @weekdays, StartDate = @startDate, EndDate = @endDate, Timeslots = @timeslots, RepeatType = @repeatType, Name = @name});
		}

		///<summary>Remove a schedule entity</summary>
		public void Remove(SchedulerRemoveParameters data)
		{
			_haContext.CallService("scheduler", "remove", null, data);
		}

		///<summary>Remove a schedule entity</summary>
		///<param name="entityId">Identifier of the scheduler entity. eg: switch.schedule_abcdef</param>
		public void Remove(string @entityId)
		{
			_haContext.CallService("scheduler", "remove", null, new SchedulerRemoveParameters{EntityId = @entityId});
		}

		///<summary>Execute the action of a schedule, optionally at a given time.</summary>
		public void RunAction(SchedulerRunActionParameters data)
		{
			_haContext.CallService("scheduler", "run_action", null, data);
		}

		///<summary>Execute the action of a schedule, optionally at a given time.</summary>
		///<param name="entityId">Identifier of the scheduler entity. eg: switch.schedule_abcdef</param>
		///<param name="time">Time for which to evaluate the action (only useful for schedules with multiple timeslot) eg: "12:00"</param>
		public void RunAction(string @entityId, DateTime? @time = null)
		{
			_haContext.CallService("scheduler", "run_action", null, new SchedulerRunActionParameters{EntityId = @entityId, Time = @time});
		}
	}

	public record SchedulerAddParameters
	{
		///<summary>Days of the week for which the schedule should be repeated eg: ["daily"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("weekdays")]
		public object? Weekdays { get; init; }

		///<summary>Date from which schedule should be executed eg: ["2021-01-01"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("startDate")]
		public object? StartDate { get; init; }

		///<summary>Date until which schedule should be executed eg: ["2021-12-31"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("endDate")]
		public object? EndDate { get; init; }

		///<summary>list of timeslots with their actions and optionally conditions (should be kept the same for all timeslots) eg: [{start: "12:00", stop: "13:00", actions: [{service: "light.turn_on", entity_id: "light.my_lamp", service_data: {brightness: 200}}]}]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("timeslots")]
		public object? Timeslots { get; init; }

		///<summary>Control what happens after the schedule is triggered eg: "repeat"</summary>
		[System.Text.Json.Serialization.JsonPropertyName("repeatType")]
		public string? RepeatType { get; init; }

		///<summary>Friendly name for the schedule eg: My schedule</summary>
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record SchedulerCopyParameters
	{
		///<summary>Identifier of the scheduler entity. eg: switch.schedule_abcdef</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		///<summary>Friendly name for the copied schedule eg: My schedule</summary>
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record SchedulerEditParameters
	{
		///<summary>Identifier of the scheduler entity. eg: switch.schedule_abcdef</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		///<summary>Days of the week for which the schedule should be repeated eg: ["daily"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("weekdays")]
		public object? Weekdays { get; init; }

		///<summary>Date from which schedule should be executed eg: ["2021-01-01"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("startDate")]
		public object? StartDate { get; init; }

		///<summary>Date until which schedule should be executed eg: ["2021-12-31"]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("endDate")]
		public object? EndDate { get; init; }

		///<summary>list of timeslots with their actions and optionally conditions (should be kept the same for all timeslots) eg: [{start: "12:00", stop: "13:00", actions: [{service: "light.turn_on", entity_id: "light.my_lamp", service_data: {brightness: 200}}]}]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("timeslots")]
		public object? Timeslots { get; init; }

		///<summary>Control what happens after the schedule is triggered eg: "repeat"</summary>
		[System.Text.Json.Serialization.JsonPropertyName("repeatType")]
		public string? RepeatType { get; init; }

		///<summary>Friendly name for the schedule eg: My schedule</summary>
		[System.Text.Json.Serialization.JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record SchedulerRemoveParameters
	{
		///<summary>Identifier of the scheduler entity. eg: switch.schedule_abcdef</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }
	}

	public record SchedulerRunActionParameters
	{
		///<summary>Identifier of the scheduler entity. eg: switch.schedule_abcdef</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		///<summary>Time for which to evaluate the action (only useful for schedules with multiple timeslot) eg: "12:00"</summary>
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

		///<summary>Reload all the available scripts</summary>
		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		///<summary>Toggle script</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		///<summary>Turn off script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		///<summary>Turn on script</summary>
		///<param name="target">The target for this service call</param>
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

		///<summary>Immediately execute a speed test with Speedtest.net</summary>
		public void Speedtest()
		{
			_haContext.CallService("speedtestdotnet", "speedtest", null);
		}
	}

	public class SwitchServices
	{
		private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
		public SwitchServices(NetDaemon.HassModel.Common.IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a switch state</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		///<summary>Turn a switch off</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		///<summary>Turn a switch on</summary>
		///<param name="target">The target for this service call</param>
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

		///<summary>Reboot the NAS.</summary>
		public void Reboot(SynologyDsmRebootParameters data)
		{
			_haContext.CallService("synology_dsm", "reboot", null, data);
		}

		///<summary>Reboot the NAS.</summary>
		///<param name="serial">serial of the NAS to reboot; required when multiple NAS are configured. eg: 1NDVC86409</param>
		public void Reboot(string? @serial = null)
		{
			_haContext.CallService("synology_dsm", "reboot", null, new SynologyDsmRebootParameters{Serial = @serial});
		}

		///<summary>Shutdown the NAS.</summary>
		public void Shutdown(SynologyDsmShutdownParameters data)
		{
			_haContext.CallService("synology_dsm", "shutdown", null, data);
		}

		///<summary>Shutdown the NAS.</summary>
		///<param name="serial">serial of the NAS to shutdown; required when multiple NAS are configured. eg: 1NDVC86409</param>
		public void Shutdown(string? @serial = null)
		{
			_haContext.CallService("synology_dsm", "shutdown", null, new SynologyDsmShutdownParameters{Serial = @serial});
		}
	}

	public record SynologyDsmRebootParameters
	{
		///<summary>serial of the NAS to reboot; required when multiple NAS are configured. eg: 1NDVC86409</summary>
		[System.Text.Json.Serialization.JsonPropertyName("serial")]
		public string? Serial { get; init; }
	}

	public record SynologyDsmShutdownParameters
	{
		///<summary>serial of the NAS to shutdown; required when multiple NAS are configured. eg: 1NDVC86409</summary>
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
		public void Write(string @message, string? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new SystemLogWriteParameters{Message = @message, Level = @level, Logger = @logger});
		}
	}

	public record SystemLogWriteParameters
	{
		///<summary>Message to log. eg: Something went wrong</summary>
		[System.Text.Json.Serialization.JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Log level.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("level")]
		public string? Level { get; init; }

		///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
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

		///<summary>Reload all template entities.</summary>
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

		///<summary>Cancel a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Cancel(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		///<summary>Finish a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Finish(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		///<summary>Pause a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		public void Start(NetDaemon.HassModel.Entities.ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public void Start(NetDaemon.HassModel.Entities.ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new TimerStartParameters{Duration = @duration});
		}
	}

	public record TimerStartParameters
	{
		///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
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

		///<summary>Force all Tuya devices to pull data.</summary>
		public void ForceUpdate()
		{
			_haContext.CallService("tuya", "force_update", null);
		}

		///<summary>Pull device list from Tuya server.</summary>
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

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		///<param name="target">The target for this service call</param>
		public void CleanSpot(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		///<param name="target">The target for this service call</param>
		public void Locate(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		///<summary>Pause the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		///<param name="target">The target for this service call</param>
		public void ReturnToBase(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(NetDaemon.HassModel.Entities.ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public void SendCommand(NetDaemon.HassModel.Entities.ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanSpeed(NetDaemon.HassModel.Entities.ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public void SetFanSpeed(NetDaemon.HassModel.Entities.ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Start(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void StartPause(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		///<summary>Stop the current cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Stop(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		///<summary>Start a new cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		///<summary>Command to execute. eg: set_dnd_timer</summary>
		[System.Text.Json.Serialization.JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>Parameters for the command. eg: { "key": "value" }</summary>
		[System.Text.Json.Serialization.JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
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

		///<summary>Set attributes of a variable entity.</summary>
		public void Set(VarSetParameters data)
		{
			_haContext.CallService("var", "set", null, data);
		}

		///<summary>Set attributes of a variable entity.</summary>
		///<param name="entityId">Entity id of the variable whose value will be set. eg: var.x</param>
		///<param name="value">The new value for the variable entity. eg: 13</param>
		///<param name="valueTemplate">The new value template for the variable entity. eg: {{ input_boolean.foo }}</param>
		///<param name="trackedEntityId">The new list of entities for the variable entity to track. eg: input_boolean.bar</param>
		///<param name="trackedEventType">The new list of event types for the variable entity to track. eg: sunset</param>
		///<param name="query">An SQL QUERY string, should return 1 result at most. eg: SELECT COUNT(*) AS todays_diaper_count FROM events WHERE event_type = 'diaper_event' AND time_fired BETWEEN DATETIME('now', 'start of day') and DATETIME('now');</param>
		///<param name="column">The SQL COLUMN to select from the result of the SQL QUERY. eg: todays_diaper_count</param>
		///<param name="restore">The new restore value for the variable entity. eg: False</param>
		///<param name="forceUpdate">The new force_update value for the variable entity. eg: True</param>
		///<param name="unitOfMeasurement">The new unit of measurement for the variable entity. eg: ounces</param>
		///<param name="icon">The new icon for the variable entity. eg: mdi:baby-bottle-outline</param>
		///<param name="iconTemplate">The new icon template for the variable entity.</param>
		///<param name="entityPicture">The new picture for the variable entity. eg: local/pic.png</param>
		///<param name="entityPictureTemplate">The new picture template for the variable entity.</param>
		public void Set(string? @entityId = null, string? @value = null, string? @valueTemplate = null, string? @trackedEntityId = null, string? @trackedEventType = null, string? @query = null, string? @column = null, string? @restore = null, string? @forceUpdate = null, string? @unitOfMeasurement = null, string? @icon = null, string? @iconTemplate = null, string? @entityPicture = null, string? @entityPictureTemplate = null)
		{
			_haContext.CallService("var", "set", null, new VarSetParameters{EntityId = @entityId, Value = @value, ValueTemplate = @valueTemplate, TrackedEntityId = @trackedEntityId, TrackedEventType = @trackedEventType, Query = @query, Column = @column, Restore = @restore, ForceUpdate = @forceUpdate, UnitOfMeasurement = @unitOfMeasurement, Icon = @icon, IconTemplate = @iconTemplate, EntityPicture = @entityPicture, EntityPictureTemplate = @entityPictureTemplate});
		}

		///<summary>Force a variable to update its state and atttributes.</summary>
		public void Update(VarUpdateParameters data)
		{
			_haContext.CallService("var", "update", null, data);
		}

		///<summary>Force a variable to update its state and atttributes.</summary>
		///<param name="entityId">Entity id of the variable that will be updated. eg: var.x</param>
		public void Update(string? @entityId = null)
		{
			_haContext.CallService("var", "update", null, new VarUpdateParameters{EntityId = @entityId});
		}
	}

	public record VarSetParameters
	{
		///<summary>Entity id of the variable whose value will be set. eg: var.x</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityId")]
		public string? EntityId { get; init; }

		///<summary>The new value for the variable entity. eg: 13</summary>
		[System.Text.Json.Serialization.JsonPropertyName("value")]
		public string? Value { get; init; }

		///<summary>The new value template for the variable entity. eg: {{ input_boolean.foo }}</summary>
		[System.Text.Json.Serialization.JsonPropertyName("valueTemplate")]
		public string? ValueTemplate { get; init; }

		///<summary>The new list of entities for the variable entity to track. eg: input_boolean.bar</summary>
		[System.Text.Json.Serialization.JsonPropertyName("trackedEntityId")]
		public string? TrackedEntityId { get; init; }

		///<summary>The new list of event types for the variable entity to track. eg: sunset</summary>
		[System.Text.Json.Serialization.JsonPropertyName("trackedEventType")]
		public string? TrackedEventType { get; init; }

		///<summary>An SQL QUERY string, should return 1 result at most. eg: SELECT COUNT(*) AS todays_diaper_count FROM events WHERE event_type = 'diaper_event' AND time_fired BETWEEN DATETIME('now', 'start of day') and DATETIME('now');</summary>
		[System.Text.Json.Serialization.JsonPropertyName("query")]
		public string? Query { get; init; }

		///<summary>The SQL COLUMN to select from the result of the SQL QUERY. eg: todays_diaper_count</summary>
		[System.Text.Json.Serialization.JsonPropertyName("column")]
		public string? Column { get; init; }

		///<summary>The new restore value for the variable entity. eg: False</summary>
		[System.Text.Json.Serialization.JsonPropertyName("restore")]
		public string? Restore { get; init; }

		///<summary>The new force_update value for the variable entity. eg: True</summary>
		[System.Text.Json.Serialization.JsonPropertyName("forceUpdate")]
		public string? ForceUpdate { get; init; }

		///<summary>The new unit of measurement for the variable entity. eg: ounces</summary>
		[System.Text.Json.Serialization.JsonPropertyName("unitOfMeasurement")]
		public string? UnitOfMeasurement { get; init; }

		///<summary>The new icon for the variable entity. eg: mdi:baby-bottle-outline</summary>
		[System.Text.Json.Serialization.JsonPropertyName("icon")]
		public string? Icon { get; init; }

		///<summary>The new icon template for the variable entity.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("iconTemplate")]
		public string? IconTemplate { get; init; }

		///<summary>The new picture for the variable entity. eg: local/pic.png</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityPicture")]
		public string? EntityPicture { get; init; }

		///<summary>The new picture template for the variable entity.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("entityPictureTemplate")]
		public string? EntityPictureTemplate { get; init; }
	}

	public record VarUpdateParameters
	{
		///<summary>Entity id of the variable that will be updated. eg: var.x</summary>
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
		[System.Text.Json.Serialization.JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Broadcast IP where to send the magic packet. eg: 192.168.255.255</summary>
		[System.Text.Json.Serialization.JsonPropertyName("broadcastAddress")]
		public string? BroadcastAddress { get; init; }

		///<summary>Port where to send the magic packet.</summary>
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

		///<summary>Reload all entities of Xiaomi Cloud Map Extractor platform</summary>
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

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumCleanSegment(NetDaemon.HassModel.Entities.ServiceTarget target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The target for this service call</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public void VacuumCleanSegment(NetDaemon.HassModel.Entities.ServiceTarget target, object? @segments = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumCleanZone(NetDaemon.HassModel.Entities.ServiceTarget target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public void VacuumCleanZone(NetDaemon.HassModel.Entities.ServiceTarget target, object? @zone = null, long? @repeats = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumGoto(NetDaemon.HassModel.Entities.ServiceTarget target, XiaomiMiioVacuumGotoParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, data);
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public void VacuumGoto(NetDaemon.HassModel.Entities.ServiceTarget target, string? @xCoord = null, string? @yCoord = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlMove(NetDaemon.HassModel.Entities.ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public void VacuumRemoteControlMove(NetDaemon.HassModel.Entities.ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlMoveStep(NetDaemon.HassModel.Entities.ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public void VacuumRemoteControlMoveStep(NetDaemon.HassModel.Entities.ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlStart(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_start", target);
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlStop(NetDaemon.HassModel.Entities.ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_stop", target);
		}
	}

	public record XiaomiMiioVacuumCleanSegmentParameters
	{
		///<summary>Segments. eg: [1,2]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("segments")]
		public object? Segments { get; init; }
	}

	public record XiaomiMiioVacuumCleanZoneParameters
	{
		///<summary>Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</summary>
		[System.Text.Json.Serialization.JsonPropertyName("zone")]
		public object? Zone { get; init; }

		///<summary>Number of cleaning repeats for each zone.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("repeats")]
		public long? Repeats { get; init; }
	}

	public record XiaomiMiioVacuumGotoParameters
	{
		///<summary>x-coordinate. eg: 27500</summary>
		[System.Text.Json.Serialization.JsonPropertyName("xCoord")]
		public string? XCoord { get; init; }

		///<summary>y-coordinate. eg: 32000</summary>
		[System.Text.Json.Serialization.JsonPropertyName("yCoord")]
		public string? YCoord { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveParameters
	{
		///<summary>Speed.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		///<summary>Rotation, between -179 degrees and 179 degrees.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		///<summary>Duration of the movement.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveStepParameters
	{
		///<summary>Speed.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		///<summary>Rotation.</summary>
		[System.Text.Json.Serialization.JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		///<summary>Duration of the movement.</summary>
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

		///<summary>Reload the YAML-based zone configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public static class AlarmControlPanelEntityExtensionMethods
	{
		///<summary>Send the alarm the command for arm away.</summary>
		public static void AlarmArmAway(this AlarmControlPanelEntity entity, AlarmControlPanelAlarmArmAwayParameters data)
		{
			entity.CallService("alarm_arm_away", data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="entity">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public static void AlarmArmAway(this AlarmControlPanelEntity entity, string? @code = null)
		{
			entity.CallService("alarm_arm_away", new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity entity, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			entity.CallService("alarm_arm_custom_bypass", data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="entity">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity entity, string? @code = null)
		{
			entity.CallService("alarm_arm_custom_bypass", new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		public static void AlarmArmHome(this AlarmControlPanelEntity entity, AlarmControlPanelAlarmArmHomeParameters data)
		{
			entity.CallService("alarm_arm_home", data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="entity">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public static void AlarmArmHome(this AlarmControlPanelEntity entity, string? @code = null)
		{
			entity.CallService("alarm_arm_home", new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		public static void AlarmArmNight(this AlarmControlPanelEntity entity, AlarmControlPanelAlarmArmNightParameters data)
		{
			entity.CallService("alarm_arm_night", data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="entity">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public static void AlarmArmNight(this AlarmControlPanelEntity entity, string? @code = null)
		{
			entity.CallService("alarm_arm_night", new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		public static void AlarmDisarm(this AlarmControlPanelEntity entity, AlarmControlPanelAlarmDisarmParameters data)
		{
			entity.CallService("alarm_disarm", data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="entity">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public static void AlarmDisarm(this AlarmControlPanelEntity entity, string? @code = null)
		{
			entity.CallService("alarm_disarm", new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		public static void AlarmTrigger(this AlarmControlPanelEntity entity, AlarmControlPanelAlarmTriggerParameters data)
		{
			entity.CallService("alarm_trigger", data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="entity">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public static void AlarmTrigger(this AlarmControlPanelEntity entity, string? @code = null)
		{
			entity.CallService("alarm_trigger", new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public static class CameraEntityExtensionMethods
	{
		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this CameraEntity entity)
		{
			entity.CallService("disable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this CameraEntity entity)
		{
			entity.CallService("enable_motion_detection");
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this CameraEntity entity, CameraPlayStreamParameters data)
		{
			entity.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="entity">The CameraEntity to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this CameraEntity entity, string @mediaPlayer, string? @format = null)
		{
			entity.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this CameraEntity entity, CameraRecordParameters data)
		{
			entity.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="entity">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this CameraEntity entity, string @filename, long? @duration = null, long? @lookback = null)
		{
			entity.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this CameraEntity entity, CameraSnapshotParameters data)
		{
			entity.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="entity">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this CameraEntity entity, string @filename)
		{
			entity.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this CameraEntity entity)
		{
			entity.CallService("turn_off");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this CameraEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this ClimateEntity entity, ClimateSetAuxHeatParameters data)
		{
			entity.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this ClimateEntity entity, bool @auxHeat)
		{
			entity.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this ClimateEntity entity, ClimateSetFanModeParameters data)
		{
			entity.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this ClimateEntity entity, string @fanMode)
		{
			entity.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this ClimateEntity entity, ClimateSetHumidityParameters data)
		{
			entity.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this ClimateEntity entity, long @humidity)
		{
			entity.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this ClimateEntity entity, ClimateSetHvacModeParameters data)
		{
			entity.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this ClimateEntity entity, string? @hvacMode = null)
		{
			entity.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this ClimateEntity entity, ClimateSetPresetModeParameters data)
		{
			entity.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this ClimateEntity entity, string @presetMode)
		{
			entity.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this ClimateEntity entity, ClimateSetSwingModeParameters data)
		{
			entity.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this ClimateEntity entity, string @swingMode)
		{
			entity.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this ClimateEntity entity, ClimateSetTemperatureParameters data)
		{
			entity.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="entity">The ClimateEntity to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this ClimateEntity entity, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			entity.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this ClimateEntity entity)
		{
			entity.CallService("turn_off");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this ClimateEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class CounterEntityExtensionMethods
	{
		///<summary>Change counter parameters.</summary>
		public static void Configure(this CounterEntity entity, CounterConfigureParameters data)
		{
			entity.CallService("configure", data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="entity">The CounterEntity to call this service for</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public static void Configure(this CounterEntity entity, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			entity.CallService("configure", new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		public static void Decrement(this CounterEntity entity)
		{
			entity.CallService("decrement");
		}

		///<summary>Increment a counter.</summary>
		public static void Increment(this CounterEntity entity)
		{
			entity.CallService("increment");
		}

		///<summary>Reset a counter.</summary>
		public static void Reset(this CounterEntity entity)
		{
			entity.CallService("reset");
		}
	}

	public static class HarmonyEntityExtensionMethods
	{
		///<summary>Sends change channel command to the Harmony HUB</summary>
		public static void ChangeChannel(this RemoteEntity entity, HarmonyChangeChannelParameters data)
		{
			entity.CallService("change_channel", data);
		}

		///<summary>Sends change channel command to the Harmony HUB</summary>
		///<param name="entity">The RemoteEntity to call this service for</param>
		///<param name="channel">Channel number to change to</param>
		public static void ChangeChannel(this RemoteEntity entity, long @channel)
		{
			entity.CallService("change_channel", new HarmonyChangeChannelParameters{Channel = @channel});
		}

		///<summary>Syncs the remote's configuration.</summary>
		public static void Sync(this RemoteEntity entity)
		{
			entity.CallService("sync");
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this InputBooleanEntity entity)
		{
			entity.CallService("toggle");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this InputBooleanEntity entity)
		{
			entity.CallService("turn_off");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this InputBooleanEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class InputNumberEntityExtensionMethods
	{
		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this InputNumberEntity entity)
		{
			entity.CallService("decrement");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this InputNumberEntity entity)
		{
			entity.CallService("increment");
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this InputNumberEntity entity, InputNumberSetValueParameters data)
		{
			entity.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="entity">The InputNumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this InputNumberEntity entity, double @value)
		{
			entity.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}
	}

	public static class InputSelectEntityExtensionMethods
	{
		///<summary>Select the first option of an input select entity.</summary>
		public static void SelectFirst(this InputSelectEntity entity)
		{
			entity.CallService("select_first");
		}

		///<summary>Select the last option of an input select entity.</summary>
		public static void SelectLast(this InputSelectEntity entity)
		{
			entity.CallService("select_last");
		}

		///<summary>Select the next options of an input select entity.</summary>
		public static void SelectNext(this InputSelectEntity entity, InputSelectSelectNextParameters data)
		{
			entity.CallService("select_next", data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="entity">The InputSelectEntity to call this service for</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public static void SelectNext(this InputSelectEntity entity, bool? @cycle = null)
		{
			entity.CallService("select_next", new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		public static void SelectOption(this InputSelectEntity entity, InputSelectSelectOptionParameters data)
		{
			entity.CallService("select_option", data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="entity">The InputSelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this InputSelectEntity entity, string @option)
		{
			entity.CallService("select_option", new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		public static void SelectPrevious(this InputSelectEntity entity, InputSelectSelectPreviousParameters data)
		{
			entity.CallService("select_previous", data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="entity">The InputSelectEntity to call this service for</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public static void SelectPrevious(this InputSelectEntity entity, bool? @cycle = null)
		{
			entity.CallService("select_previous", new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		public static void SetOptions(this InputSelectEntity entity, InputSelectSetOptionsParameters data)
		{
			entity.CallService("set_options", data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="entity">The InputSelectEntity to call this service for</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public static void SetOptions(this InputSelectEntity entity, object @options)
		{
			entity.CallService("set_options", new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public static class InputTextEntityExtensionMethods
	{
		///<summary>Set the value of an input text entity.</summary>
		public static void SetValue(this InputTextEntity entity, InputTextSetValueParameters data)
		{
			entity.CallService("set_value", data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="entity">The InputTextEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public static void SetValue(this InputTextEntity entity, string @value)
		{
			entity.CallService("set_value", new InputTextSetValueParameters{Value = @value});
		}
	}

	public static class LightEntityExtensionMethods
	{
		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this LightEntity entity, LightToggleParameters data)
		{
			entity.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="entity">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this LightEntity entity, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			entity.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this LightEntity entity, LightTurnOffParameters data)
		{
			entity.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="entity">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this LightEntity entity, long? @transition = null, string? @flash = null)
		{
			entity.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this LightEntity entity, LightTurnOnParameters data)
		{
			entity.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="entity">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
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
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this LightEntity entity, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			entity.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this MediaPlayerEntity entity)
		{
			entity.CallService("clear_playlist");
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this MediaPlayerEntity entity, MediaPlayerJoinParameters data)
		{
			entity.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</param>
		public static void Join(this MediaPlayerEntity entity, object? @groupMembers = null)
		{
			entity.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this MediaPlayerEntity entity)
		{
			entity.CallService("media_next_track");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this MediaPlayerEntity entity)
		{
			entity.CallService("media_pause");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this MediaPlayerEntity entity)
		{
			entity.CallService("media_play");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this MediaPlayerEntity entity)
		{
			entity.CallService("media_play_pause");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this MediaPlayerEntity entity)
		{
			entity.CallService("media_previous_track");
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this MediaPlayerEntity entity, MediaPlayerMediaSeekParameters data)
		{
			entity.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this MediaPlayerEntity entity, double @seekPosition)
		{
			entity.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this MediaPlayerEntity entity)
		{
			entity.CallService("media_stop");
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this MediaPlayerEntity entity, MediaPlayerPlayMediaParameters data)
		{
			entity.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public static void PlayMedia(this MediaPlayerEntity entity, string @mediaContentId, string @mediaContentType)
		{
			entity.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this MediaPlayerEntity entity, MediaPlayerRepeatSetParameters data)
		{
			entity.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this MediaPlayerEntity entity, string @repeat)
		{
			entity.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this MediaPlayerEntity entity, MediaPlayerSelectSoundModeParameters data)
		{
			entity.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this MediaPlayerEntity entity, string? @soundMode = null)
		{
			entity.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this MediaPlayerEntity entity, MediaPlayerSelectSourceParameters data)
		{
			entity.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this MediaPlayerEntity entity, string @source)
		{
			entity.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this MediaPlayerEntity entity, MediaPlayerShuffleSetParameters data)
		{
			entity.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this MediaPlayerEntity entity, bool @shuffle)
		{
			entity.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this MediaPlayerEntity entity)
		{
			entity.CallService("toggle");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this MediaPlayerEntity entity)
		{
			entity.CallService("turn_off");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this MediaPlayerEntity entity)
		{
			entity.CallService("turn_on");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this MediaPlayerEntity entity)
		{
			entity.CallService("unjoin");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this MediaPlayerEntity entity)
		{
			entity.CallService("volume_down");
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this MediaPlayerEntity entity, MediaPlayerVolumeMuteParameters data)
		{
			entity.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this MediaPlayerEntity entity, bool @isVolumeMuted)
		{
			entity.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this MediaPlayerEntity entity, MediaPlayerVolumeSetParameters data)
		{
			entity.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="entity">The MediaPlayerEntity to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this MediaPlayerEntity entity, double @volumeLevel)
		{
			entity.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this MediaPlayerEntity entity)
		{
			entity.CallService("volume_up");
		}
	}

	public static class RemoteEntityExtensionMethods
	{
		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this RemoteEntity entity, RemoteDeleteCommandParameters data)
		{
			entity.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="entity">The RemoteEntity to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this RemoteEntity entity, object @command, string? @device = null)
		{
			entity.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this RemoteEntity entity, RemoteLearnCommandParameters data)
		{
			entity.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="entity">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this RemoteEntity entity, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			entity.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this RemoteEntity entity, RemoteSendCommandParameters data)
		{
			entity.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="entity">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this RemoteEntity entity, string @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			entity.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this RemoteEntity entity)
		{
			entity.CallService("toggle");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this RemoteEntity entity)
		{
			entity.CallService("turn_off");
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this RemoteEntity entity, RemoteTurnOnParameters data)
		{
			entity.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="entity">The RemoteEntity to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this RemoteEntity entity, string? @activity = null)
		{
			entity.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		///<summary>Toggles a switch state</summary>
		public static void Toggle(this SwitchEntity entity)
		{
			entity.CallService("toggle");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this SwitchEntity entity)
		{
			entity.CallService("turn_off");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this SwitchEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class TimerEntityExtensionMethods
	{
		///<summary>Cancel a timer.</summary>
		public static void Cancel(this TimerEntity entity)
		{
			entity.CallService("cancel");
		}

		///<summary>Finish a timer.</summary>
		public static void Finish(this TimerEntity entity)
		{
			entity.CallService("finish");
		}

		///<summary>Pause a timer.</summary>
		public static void Pause(this TimerEntity entity)
		{
			entity.CallService("pause");
		}

		///<summary>Start a timer</summary>
		public static void Start(this TimerEntity entity, TimerStartParameters data)
		{
			entity.CallService("start", data);
		}

		///<summary>Start a timer</summary>
		///<param name="entity">The TimerEntity to call this service for</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public static void Start(this TimerEntity entity, string? @duration = null)
		{
			entity.CallService("start", new TimerStartParameters{Duration = @duration});
		}
	}

	public static class VacuumEntityExtensionMethods
	{
		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this VacuumEntity entity)
		{
			entity.CallService("clean_spot");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this VacuumEntity entity)
		{
			entity.CallService("locate");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this VacuumEntity entity)
		{
			entity.CallService("pause");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this VacuumEntity entity)
		{
			entity.CallService("return_to_base");
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this VacuumEntity entity, VacuumSendCommandParameters data)
		{
			entity.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="entity">The VacuumEntity to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this VacuumEntity entity, string @command, object? @params = null)
		{
			entity.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this VacuumEntity entity, VacuumSetFanSpeedParameters data)
		{
			entity.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="entity">The VacuumEntity to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this VacuumEntity entity, string @fanSpeed)
		{
			entity.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this VacuumEntity entity)
		{
			entity.CallService("start");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this VacuumEntity entity)
		{
			entity.CallService("start_pause");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this VacuumEntity entity)
		{
			entity.CallService("stop");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this VacuumEntity entity)
		{
			entity.CallService("turn_off");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this VacuumEntity entity)
		{
			entity.CallService("turn_on");
		}
	}

	public static class XiaomiMiioEntityExtensionMethods
	{
		///<summary>Start cleaning of the specified segment(s).</summary>
		public static void VacuumCleanSegment(this VacuumEntity entity, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			entity.CallService("vacuum_clean_segment", data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="entity">The VacuumEntity to call this service for</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public static void VacuumCleanSegment(this VacuumEntity entity, object? @segments = null)
		{
			entity.CallService("vacuum_clean_segment", new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		public static void VacuumCleanZone(this VacuumEntity entity, XiaomiMiioVacuumCleanZoneParameters data)
		{
			entity.CallService("vacuum_clean_zone", data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="entity">The VacuumEntity to call this service for</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public static void VacuumCleanZone(this VacuumEntity entity, object? @zone = null, long? @repeats = null)
		{
			entity.CallService("vacuum_clean_zone", new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Go to the specified coordinates.</summary>
		public static void VacuumGoto(this VacuumEntity entity, XiaomiMiioVacuumGotoParameters data)
		{
			entity.CallService("vacuum_goto", data);
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="entity">The VacuumEntity to call this service for</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public static void VacuumGoto(this VacuumEntity entity, string? @xCoord = null, string? @yCoord = null)
		{
			entity.CallService("vacuum_goto", new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		public static void VacuumRemoteControlMove(this VacuumEntity entity, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			entity.CallService("vacuum_remote_control_move", data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="entity">The VacuumEntity to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMove(this VacuumEntity entity, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			entity.CallService("vacuum_remote_control_move", new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		public static void VacuumRemoteControlMoveStep(this VacuumEntity entity, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			entity.CallService("vacuum_remote_control_move_step", data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="entity">The VacuumEntity to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMoveStep(this VacuumEntity entity, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			entity.CallService("vacuum_remote_control_move_step", new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		public static void VacuumRemoteControlStart(this VacuumEntity entity)
		{
			entity.CallService("vacuum_remote_control_start");
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		public static void VacuumRemoteControlStop(this VacuumEntity entity)
		{
			entity.CallService("vacuum_remote_control_stop");
		}
	}
}