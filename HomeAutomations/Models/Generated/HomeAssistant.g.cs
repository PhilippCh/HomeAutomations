using System;
using System.Collections.Generic;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
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

		DeviceTrackerEntities DeviceTracker { get; }

		GroupEntities Group { get; }

		InputBooleanEntities InputBoolean { get; }

		InputNumberEntities InputNumber { get; }

		InputSelectEntities InputSelect { get; }

		InputTextEntities InputText { get; }

		LightEntities Light { get; }

		LockEntities Lock { get; }

		MediaPlayerEntities MediaPlayer { get; }

		PersistentNotificationEntities PersistentNotification { get; }

		PersonEntities Person { get; }

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

	public class Entities : IEntities
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
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public GroupEntities Group => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public InputNumberEntities InputNumber => new(_haContext);
		public InputSelectEntities InputSelect => new(_haContext);
		public InputTextEntities InputText => new(_haContext);
		public LightEntities Light => new(_haContext);
		public LockEntities Lock => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public PersistentNotificationEntities PersistentNotification => new(_haContext);
		public PersonEntities Person => new(_haContext);
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

	public class AlarmControlPanelEntities
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Intrusion Detection System</summary>
		public AlarmControlPanelEntity IntrusionDetectionSystem => new(_haContext, "alarm_control_panel.intrusion_detection_system");
	}

	public class BinarySensorEntities
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
		///<summary>bedroom/motion_detector_occupancy</summary>
		public BinarySensorEntity BedroomMotionDetectorOccupancy => new(_haContext, "binary_sensor.bedroom_motion_detector_occupancy");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Focus</summary>
		public BinarySensorEntity BuyHodlGmeFocus => new(_haContext, "binary_sensor.buy_hodl_gme_focus");
		///<summary>DesktopFabienne</summary>
		public BinarySensorEntity Desktopfabienne => new(_haContext, "binary_sensor.desktopfabienne");
		///<summary>DesktopPhilipp</summary>
		public BinarySensorEntity Desktopphilipp => new(_haContext, "binary_sensor.desktopphilipp");
		///<summary>Fantenpad Focus</summary>
		public BinarySensorEntity FantenpadFocus => new(_haContext, "binary_sensor.fantenpad_focus");
		///<summary>🐘 FantenPhone 🐘 Focus</summary>
		public BinarySensorEntity FantenphoneFocus => new(_haContext, "binary_sensor.fantenphone_focus");
		///<summary>Fantenrüssel Mop Attached</summary>
		public BinarySensorEntity FantenrusselMopAttached => new(_haContext, "binary_sensor.fantenrussel_mop_attached");
		///<summary>Fantenrüssel Water Box Attached</summary>
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
		///<summary>guest_bath/zigbee_repeater_update_available</summary>
		public BinarySensorEntity GuestBathZigbeeRepeaterUpdateAvailable => new(_haContext, "binary_sensor.guest_bath_zigbee_repeater_update_available");
		///<summary>iPhone Philipp 2 Focus</summary>
		public BinarySensorEntity IphonePhilipp2Focus => new(_haContext, "binary_sensor.iphone_philipp_2_focus");
		///<summary>kitchen/motion_detector_occupancy</summary>
		public BinarySensorEntity KitchenMotionDetectorOccupancy => new(_haContext, "binary_sensor.kitchen_motion_detector_occupancy");
		///<summary>kitchen/neon_clock_update_available</summary>
		public BinarySensorEntity KitchenNeonClockUpdateAvailable2 => new(_haContext, "binary_sensor.kitchen_neon_clock_update_available_2");
		///<summary>LaptopFabienne</summary>
		public BinarySensorEntity Laptopfabienne => new(_haContext, "binary_sensor.laptopfabienne");
		///<summary>LaptopPhilipp</summary>
		public BinarySensorEntity Laptopphilipp => new(_haContext, "binary_sensor.laptopphilipp");
		///<summary>living_room/buddha_fountain_update_available</summary>
		public BinarySensorEntity LivingRoomBuddhaFountainUpdateAvailable => new(_haContext, "binary_sensor.living_room_buddha_fountain_update_available");
		///<summary>living_room/contract_light_update_available</summary>
		public BinarySensorEntity LivingRoomContractLightUpdateAvailable => new(_haContext, "binary_sensor.living_room_contract_light_update_available");
		///<summary>living_room/diorama_update_available</summary>
		public BinarySensorEntity LivingRoomDioramaUpdateAvailable => new(_haContext, "binary_sensor.living_room_diorama_update_available");
		///<summary>living_room/lightbar_update_available</summary>
		public BinarySensorEntity LivingRoomLightbarUpdateAvailable => new(_haContext, "binary_sensor.living_room_lightbar_update_available");
		///<summary>PupsStation Below Min Remaining Life</summary>
		public BinarySensorEntity PupsstationDrive1BelowMinRemainingLife => new(_haContext, "binary_sensor.pupsstation_drive_1_below_min_remaining_life");
		///<summary>PupsStation Exceeded Max Bad Sectors</summary>
		public BinarySensorEntity PupsstationDrive1ExceededMaxBadSectors => new(_haContext, "binary_sensor.pupsstation_drive_1_exceeded_max_bad_sectors");
		///<summary>PupsStation Below Min Remaining Life</summary>
		public BinarySensorEntity PupsstationDrive2BelowMinRemainingLife => new(_haContext, "binary_sensor.pupsstation_drive_2_below_min_remaining_life");
		///<summary>PupsStation Exceeded Max Bad Sectors</summary>
		public BinarySensorEntity PupsstationDrive2ExceededMaxBadSectors => new(_haContext, "binary_sensor.pupsstation_drive_2_exceeded_max_bad_sectors");
		///<summary>PupsStation Security Status</summary>
		public BinarySensorEntity PupsstationSecurityStatus => new(_haContext, "binary_sensor.pupsstation_security_status");
		///<summary>PupsStation Update Available</summary>
		public BinarySensorEntity PupsstationUpdateAvailable => new(_haContext, "binary_sensor.pupsstation_update_available");
		///<summary>switch.study_speakers_philipp_update_available</summary>
		public BinarySensorEntity SwitchStudySpeakersPhilippUpdateAvailable => new(_haContext, "binary_sensor.switch_study_speakers_philipp_update_available");
		///<summary>Thermostat Arbeitszimmer Battery</summary>
		public BinarySensorEntity ThermostatArbeitszimmerBattery => new(_haContext, "binary_sensor.thermostat_arbeitszimmer_battery");
		///<summary>Thermostat Badezimmer Battery</summary>
		public BinarySensorEntity ThermostatBadezimmerBattery => new(_haContext, "binary_sensor.thermostat_badezimmer_battery");
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

	public class ButtonEntities
	{
		private readonly IHaContext _haContext;
		public ButtonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>PupsStation Reboot</summary>
		public ButtonEntity PupsstationReboot => new(_haContext, "button.pupsstation_reboot");
		///<summary>PupsStation Shutdown</summary>
		public ButtonEntity PupsstationShutdown => new(_haContext, "button.pupsstation_shutdown");
	}

	public class CalendarEntities
	{
		private readonly IHaContext _haContext;
		public CalendarEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Abfallleerungen</summary>
		public CalendarEntity Abfallleerungen => new(_haContext, "calendar.abfallleerungen");
		///<summary> Aktien 💰</summary>
		public CalendarEntity Aktien => new(_haContext, "calendar.aktien");
		///<summary>Aufgaben</summary>
		public CalendarEntity Aufgaben => new(_haContext, "calendar.aufgaben");
		///<summary>Birthdays</summary>
		public CalendarEntity Birthdays => new(_haContext, "calendar.birthdays");
		///<summary>christoph680@gmx.de</summary>
		public CalendarEntity Christoph680GmxDe => new(_haContext, "calendar.christoph680_gmx_de");
		///<summary> Essen holen 🍱</summary>
		public CalendarEntity EssenHolen => new(_haContext, "calendar.essen_holen");
		///<summary>Family</summary>
		public CalendarEntity Family => new(_haContext, "calendar.family");
		///<summary>Feiertage in Deutschland</summary>
		public CalendarEntity FeiertageInDeutschland => new(_haContext, "calendar.feiertage_in_deutschland");
		///<summary>Game ideas</summary>
		public CalendarEntity GameIdeas => new(_haContext, "calendar.game_ideas");
		///<summary>Geschenke 🎁</summary>
		public CalendarEntity Geschenke => new(_haContext, "calendar.geschenke");
		///<summary>Haushaltstag</summary>
		public CalendarEntity Haushaltstag => new(_haContext, "calendar.haushaltstag");
		///<summary>Homelab</summary>
		public CalendarEntity Homelab => new(_haContext, "calendar.homelab");
		///<summary>National Park Chocolate</summary>
		public CalendarEntity NationalParkChocolate => new(_haContext, "calendar.national_park_chocolate");
		///<summary> Rundreise Neuseeland 🇳🇿</summary>
		public CalendarEntity RundreiseNeuseeland => new(_haContext, "calendar.rundreise_neuseeland");
		///<summary>Secret Santa</summary>
		public CalendarEntity SecretSanta => new(_haContext, "calendar.secret_santa");
		///<summary> The Millionaire’s Bucket List 💸</summary>
		public CalendarEntity TheMillionairesBucketList => new(_haContext, "calendar.the_millionaires_bucket_list");
		///<summary>The Shadows On Your Soul</summary>
		public CalendarEntity TheShadowsOnYourSoul => new(_haContext, "calendar.the_shadows_on_your_soul");
		///<summary>Unser Haus 🏠</summary>
		public CalendarEntity UnserHaus => new(_haContext, "calendar.unser_haus");
		///<summary> Urlaub Ibiza 🇪🇸</summary>
		public CalendarEntity UrlaubIbiza => new(_haContext, "calendar.urlaub_ibiza");
		///<summary> Urlaub Paris 🇫🇷</summary>
		public CalendarEntity UrlaubParis => new(_haContext, "calendar.urlaub_paris");
		///<summary> Urlaub Schottland 🏴󠁧󠁢󠁳󠁣󠁴󠁿</summary>
		public CalendarEntity UrlaubSchottland => new(_haContext, "calendar.urlaub_schottland");
		///<summary>Weihnachtsgeschenke</summary>
		public CalendarEntity Weihnachtsgeschenke => new(_haContext, "calendar.weihnachtsgeschenke");
		///<summary>Weihnachtswünsche</summary>
		public CalendarEntity Weihnachtswunsche => new(_haContext, "calendar.weihnachtswunsche");
	}

	public class CameraEntities
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

	public class ClimateEntities
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
		///<summary>Room Climate Schlafzimmer</summary>
		public ClimateEntity RoomClimateSchlafzimmer => new(_haContext, "climate.room_climate_schlafzimmer");
		///<summary>Room Climate Wohnzimmer</summary>
		public ClimateEntity RoomClimateWohnzimmer => new(_haContext, "climate.room_climate_wohnzimmer");
	}

	public class CounterEntities
	{
		private readonly IHaContext _haContext;
		public CounterEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public CounterEntity KratomIntakeDay => new(_haContext, "counter.kratom_intake_day");
		public CounterEntity MeditationMinutesWeek => new(_haContext, "counter.meditation_minutes_week");
	}

	public class DeviceTrackerEntities
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>🐘 FantenPhone 🐘</summary>
		public DeviceTrackerEntity Fabienne => new(_haContext, "device_tracker.fabienne");
		///<summary>Fantenpad</summary>
		public DeviceTrackerEntity IpadVonFabienne => new(_haContext, "device_tracker.ipad_von_fabienne");
		///<summary>Philipp</summary>
		public DeviceTrackerEntity IphonePhilipp => new(_haContext, "device_tracker.iphone_philipp");
		///<summary>iPhone Philipp 2</summary>
		public DeviceTrackerEntity IphonePhilipp2 => new(_haContext, "device_tracker.iphone_philipp_2");
		///<summary>iPhone Philipp</summary>
		public DeviceTrackerEntity IphonePhilipp3 => new(_haContext, "device_tracker.iphone_philipp_3");
		///<summary>philipp</summary>
		public DeviceTrackerEntity Philipp2b775363D7b348719abc6f36aa202757 => new(_haContext, "device_tracker.philipp_2b775363_d7b3_4871_9abc_6f36aa202757");
		///<summary>Philipp’s iPhone</summary>
		public DeviceTrackerEntity PhilippsIphone2 => new(_haContext, "device_tracker.philipps_iphone_2");
	}

	public class GroupEntities
	{
		private readonly IHaContext _haContext;
		public GroupEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alle Fenster</summary>
		public GroupEntity Allwindows => new(_haContext, "group.allwindows");
	}

	public class InputBooleanEntities
	{
		private readonly IHaContext _haContext;
		public InputBooleanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Barcode scanner connected?</summary>
		public InputBooleanEntity BarcodeScannerConnected => new(_haContext, "input_boolean.barcode_scanner_connected");
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
		///<summary>netdaemon_home_automations_apps_computer_speakers_computer_speakers</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsComputerSpeakersComputerSpeakers => new(_haContext, "input_boolean.netdaemon_home_automations_apps_computer_speakers_computer_speakers");
		///<summary>netdaemon_home_automations_apps_counters_kratom_counter_kratom_counter</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsCountersKratomCounterKratomCounter => new(_haContext, "input_boolean.netdaemon_home_automations_apps_counters_kratom_counter_kratom_counter");
		///<summary>netdaemon_home_automations_apps_counters_water_counter_water_counter</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsCountersWaterCounterWaterCounter => new(_haContext, "input_boolean.netdaemon_home_automations_apps_counters_water_counter_water_counter");
		///<summary>netdaemon_home_automations_apps_kitchen_light_kitchen_light</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsKitchenLightKitchenLight => new(_haContext, "input_boolean.netdaemon_home_automations_apps_kitchen_light_kitchen_light");
		///<summary>netdaemon_home_automations_apps_kite_reminder_kite_reminder</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsKiteReminderKiteReminder => new(_haContext, "input_boolean.netdaemon_home_automations_apps_kite_reminder_kite_reminder");
		///<summary>netdaemon_home_automations_apps_lights_schedule_lights_schedule</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsLightsScheduleLightsSchedule => new(_haContext, "input_boolean.netdaemon_home_automations_apps_lights_schedule_lights_schedule");
		///<summary>netdaemon_home_automations_apps_moonlight_remote_moonlight_remote</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsMoonlightRemoteMoonlightRemote => new(_haContext, "input_boolean.netdaemon_home_automations_apps_moonlight_remote_moonlight_remote");
		///<summary>netdaemon_home_automations_apps_movie_time_movie_time</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsMovieTimeMovieTime => new(_haContext, "input_boolean.netdaemon_home_automations_apps_movie_time_movie_time");
		///<summary>netdaemon_home_automations_apps_razor_blade_usage_razor_blade_usage</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsRazorBladeUsageRazorBladeUsage => new(_haContext, "input_boolean.netdaemon_home_automations_apps_razor_blade_usage_razor_blade_usage");
		///<summary>netdaemon_home_automations_apps_scales_kitchen_scale_kitchen_scale</summary>
		public InputBooleanEntity NetdaemonHomeAutomationsAppsScalesKitchenScaleKitchenScale => new(_haContext, "input_boolean.netdaemon_home_automations_apps_scales_kitchen_scale_kitchen_scale");
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

	public class InputSelectEntities
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

	public class InputTextEntities
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

	public class LightEntities
	{
		private readonly IHaContext _haContext;
		public LightEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>bedroom/bedside_light_fabienne</summary>
		public LightEntity BedroomBedsideLightFabienne => new(_haContext, "light.bedroom_bedside_light_fabienne");
		///<summary>bedroom/bedside_light_philipp</summary>
		public LightEntity BedroomBedsideLightPhilipp => new(_haContext, "light.bedroom_bedside_light_philipp");
		public LightEntity BrowserMod18a35fcc9cc51676 => new(_haContext, "light.browser_mod_18a35fcc_9cc51676");
		public LightEntity BrowserMod4dfe8c51C6acddb1 => new(_haContext, "light.browser_mod_4dfe8c51_c6acddb1");
		public LightEntity BrowserMod7605937aF7c5c1de => new(_haContext, "light.browser_mod_7605937a_f7c5c1de");
		public LightEntity BrowserMod83461556F7d0adba => new(_haContext, "light.browser_mod_83461556_f7d0adba");
		public LightEntity BrowserMod8ff90475F73ebe95 => new(_haContext, "light.browser_mod_8ff90475_f73ebe95");
		public LightEntity BrowserModCe5a5526823fbc7c => new(_haContext, "light.browser_mod_ce5a5526_823fbc7c");
		public LightEntity BrowserModFb34009b72400981 => new(_haContext, "light.browser_mod_fb34009b_72400981");
		///<summary>kitchen/neon_clock</summary>
		public LightEntity KitchenNeonClock => new(_haContext, "light.kitchen_neon_clock");
		///<summary>Küchendecke</summary>
		public LightEntity Kuchendecke => new(_haContext, "light.kuchendecke");
		///<summary>Licht Nachttisch Fup</summary>
		public LightEntity LichtNachttischFup => new(_haContext, "light.licht_nachttisch_fup");
		///<summary>Licht Nachttisch Pups</summary>
		public LightEntity LichtNachttischPups => new(_haContext, "light.licht_nachttisch_pups");
		///<summary>living_room/buddha_fountain</summary>
		public LightEntity LivingRoomBuddhaFountain => new(_haContext, "light.living_room_buddha_fountain");
		///<summary>living_room/contract_light</summary>
		public LightEntity LivingRoomContractLight => new(_haContext, "light.living_room_contract_light");
		///<summary>living_room/diorama</summary>
		public LightEntity LivingRoomDiorama => new(_haContext, "light.living_room_diorama");
		///<summary>living_room/lightbar</summary>
		public LightEntity LivingRoomLightbar => new(_haContext, "light.living_room_lightbar");
		///<summary>living_room/standard_lamp</summary>
		public LightEntity LivingRoomStandardLamp => new(_haContext, "light.living_room_standard_lamp");
		///<summary>Stehlampe</summary>
		public LightEntity Stehlampe => new(_haContext, "light.stehlampe");
		///<summary>TV Lightstrip</summary>
		public LightEntity TvLightstrip => new(_haContext, "light.tv_lightstrip");
	}

	public class LockEntities
	{
		private readonly IHaContext _haContext;
		public LockEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>guest_bath/zigbee_repeater_child_lock</summary>
		public LockEntity GuestBathZigbeeRepeaterChildLock => new(_haContext, "lock.guest_bath_zigbee_repeater_child_lock");
		///<summary>kitchen/neon_clock_child_lock</summary>
		public LockEntity KitchenNeonClockChildLock => new(_haContext, "lock.kitchen_neon_clock_child_lock");
		///<summary>living_room/buddha_fountain_child_lock</summary>
		public LockEntity LivingRoomBuddhaFountainChildLock => new(_haContext, "lock.living_room_buddha_fountain_child_lock");
		///<summary>living_room/contract_light_child_lock</summary>
		public LockEntity LivingRoomContractLightChildLock => new(_haContext, "lock.living_room_contract_light_child_lock");
		///<summary>living_room/diorama_child_lock</summary>
		public LockEntity LivingRoomDioramaChildLock => new(_haContext, "lock.living_room_diorama_child_lock");
		///<summary>living_room/lightbar_child_lock</summary>
		public LockEntity LivingRoomLightbarChildLock => new(_haContext, "lock.living_room_lightbar_child_lock");
		///<summary>switch.study_speakers_philipp_child_lock</summary>
		public LockEntity SwitchStudySpeakersPhilippChildLock => new(_haContext, "lock.switch_study_speakers_philipp_child_lock");
	}

	public class MediaPlayerEntities
	{
		private readonly IHaContext _haContext;
		public MediaPlayerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public MediaPlayerEntity BrowserMod18a35fcc9cc51676 => new(_haContext, "media_player.browser_mod_18a35fcc_9cc51676");
		public MediaPlayerEntity BrowserMod4dfe8c51C6acddb1 => new(_haContext, "media_player.browser_mod_4dfe8c51_c6acddb1");
		public MediaPlayerEntity BrowserMod7605937aF7c5c1de => new(_haContext, "media_player.browser_mod_7605937a_f7c5c1de");
		public MediaPlayerEntity BrowserMod83461556F7d0adba => new(_haContext, "media_player.browser_mod_83461556_f7d0adba");
		public MediaPlayerEntity BrowserMod8ff90475F73ebe95 => new(_haContext, "media_player.browser_mod_8ff90475_f73ebe95");
		public MediaPlayerEntity BrowserModCe5a5526823fbc7c => new(_haContext, "media_player.browser_mod_ce5a5526_823fbc7c");
		public MediaPlayerEntity BrowserModFb34009b72400981 => new(_haContext, "media_player.browser_mod_fb34009b_72400981");
		///<summary>master_bedroom_speaker</summary>
		public MediaPlayerEntity MasterBedroomSpeaker => new(_haContext, "media_player.master_bedroom_speaker");
		///<summary>Hall Display</summary>
		public MediaPlayerEntity Nesthub4ae6 => new(_haContext, "media_player.nesthub4ae6");
		///<summary>Spotify Philipp Christoph</summary>
		public MediaPlayerEntity SpotifyPhilippChristoph => new(_haContext, "media_player.spotify_philipp_christoph");
	}

	public class PersistentNotificationEntities
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>New devices discovered</summary>
		public PersistentNotificationEntity ConfigEntryDiscovery => new(_haContext, "persistent_notification.config_entry_discovery");
	}

	public class PersonEntities
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

	public class SelectEntities
	{
		private readonly IHaContext _haContext;
		public SelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>guest_bath/zigbee_repeater_indicator_mode</summary>
		public SelectEntity GuestBathZigbeeRepeaterIndicatorMode => new(_haContext, "select.guest_bath_zigbee_repeater_indicator_mode");
		///<summary>guest_bath/zigbee_repeater_power_outage_memory</summary>
		public SelectEntity GuestBathZigbeeRepeaterPowerOutageMemory => new(_haContext, "select.guest_bath_zigbee_repeater_power_outage_memory");
		///<summary>kitchen/neon_clock_indicator_mode</summary>
		public SelectEntity KitchenNeonClockIndicatorMode2 => new(_haContext, "select.kitchen_neon_clock_indicator_mode_2");
		///<summary>kitchen/neon_clock_power_outage_memory</summary>
		public SelectEntity KitchenNeonClockPowerOutageMemory2 => new(_haContext, "select.kitchen_neon_clock_power_outage_memory_2");
		///<summary>living_room/buddha_fountain_indicator_mode</summary>
		public SelectEntity LivingRoomBuddhaFountainIndicatorMode => new(_haContext, "select.living_room_buddha_fountain_indicator_mode");
		///<summary>living_room/buddha_fountain_power_outage_memory</summary>
		public SelectEntity LivingRoomBuddhaFountainPowerOutageMemory => new(_haContext, "select.living_room_buddha_fountain_power_outage_memory");
		///<summary>living_room/contract_light_indicator_mode</summary>
		public SelectEntity LivingRoomContractLightIndicatorMode => new(_haContext, "select.living_room_contract_light_indicator_mode");
		///<summary>living_room/contract_light_power_outage_memory</summary>
		public SelectEntity LivingRoomContractLightPowerOutageMemory => new(_haContext, "select.living_room_contract_light_power_outage_memory");
		///<summary>living_room/diorama_indicator_mode</summary>
		public SelectEntity LivingRoomDioramaIndicatorMode => new(_haContext, "select.living_room_diorama_indicator_mode");
		///<summary>living_room/diorama_power_outage_memory</summary>
		public SelectEntity LivingRoomDioramaPowerOutageMemory => new(_haContext, "select.living_room_diorama_power_outage_memory");
		///<summary>living_room/lightbar_indicator_mode</summary>
		public SelectEntity LivingRoomLightbarIndicatorMode => new(_haContext, "select.living_room_lightbar_indicator_mode");
		///<summary>living_room/lightbar_power_outage_memory</summary>
		public SelectEntity LivingRoomLightbarPowerOutageMemory => new(_haContext, "select.living_room_lightbar_power_outage_memory");
		///<summary>switch.study_speakers_philipp_indicator_mode</summary>
		public SelectEntity SwitchStudySpeakersPhilippIndicatorMode => new(_haContext, "select.switch_study_speakers_philipp_indicator_mode");
		///<summary>switch.study_speakers_philipp_power_outage_memory</summary>
		public SelectEntity SwitchStudySpeakersPhilippPowerOutageMemory => new(_haContext, "select.switch_study_speakers_philipp_power_outage_memory");
	}

	public class SensorEntities
	{
		private readonly IHaContext _haContext;
		public SensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>0x00158d0006792498 action</summary>
		public SensorEntity E0x00158d0006792498Action => new(_haContext, "sensor.0x00158d0006792498_action");
		///<summary>0x00158d0006792498 click</summary>
		public SensorEntity E0x00158d0006792498Click => new(_haContext, "sensor.0x00158d0006792498_click");
		///<summary>Base calories for fabienne</summary>
		public SensorEntity BaseCaloriesForFabienne => new(_haContext, "sensor.base_calories_for_fabienne");
		///<summary>Base calories for philipp</summary>
		public SensorEntity BaseCaloriesForPhilipp => new(_haContext, "sensor.base_calories_for_philipp");
		///<summary>bathroom/razor_blade_usage_action</summary>
		public SensorEntity BathroomRazorBladeUsageAction => new(_haContext, "sensor.bathroom_razor_blade_usage_action");
		///<summary>bathroom/razor_blade_usage_click</summary>
		public SensorEntity BathroomRazorBladeUsageClick => new(_haContext, "sensor.bathroom_razor_blade_usage_click");
		public SensorEntity BrowserMod18a35fcc9cc51676 => new(_haContext, "sensor.browser_mod_18a35fcc_9cc51676");
		public SensorEntity BrowserMod4dfe8c51C6acddb1 => new(_haContext, "sensor.browser_mod_4dfe8c51_c6acddb1");
		public SensorEntity BrowserMod7605937aF7c5c1de => new(_haContext, "sensor.browser_mod_7605937a_f7c5c1de");
		public SensorEntity BrowserMod83461556F7d0adba => new(_haContext, "sensor.browser_mod_83461556_f7d0adba");
		public SensorEntity BrowserMod8ff90475F73ebe95 => new(_haContext, "sensor.browser_mod_8ff90475_f73ebe95");
		public SensorEntity BrowserModCe5a5526823fbc7c => new(_haContext, "sensor.browser_mod_ce5a5526_823fbc7c");
		public SensorEntity BrowserModFb34009b72400981 => new(_haContext, "sensor.browser_mod_fb34009b_72400981");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Activity</summary>
		public SensorEntity BuyHodlGmeActivity => new(_haContext, "sensor.buy_hodl_gme_activity");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Battery State</summary>
		public SensorEntity BuyHodlGmeBatteryState2 => new(_haContext, "sensor.buy_hodl_gme_battery_state_2");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 BSSID</summary>
		public SensorEntity BuyHodlGmeBssid => new(_haContext, "sensor.buy_hodl_gme_bssid");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Connection Type</summary>
		public SensorEntity BuyHodlGmeConnectionType => new(_haContext, "sensor.buy_hodl_gme_connection_type");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Geocoded Location</summary>
		public SensorEntity BuyHodlGmeGeocodedLocation => new(_haContext, "sensor.buy_hodl_gme_geocoded_location");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Last Update Trigger</summary>
		public SensorEntity BuyHodlGmeLastUpdateTrigger => new(_haContext, "sensor.buy_hodl_gme_last_update_trigger");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 SIM 1</summary>
		public SensorEntity BuyHodlGmeSim1 => new(_haContext, "sensor.buy_hodl_gme_sim_1");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 SSID</summary>
		public SensorEntity BuyHodlGmeSsid => new(_haContext, "sensor.buy_hodl_gme_ssid");
		///<summary>Canon MX490 series</summary>
		public SensorEntity CanonMx490Series => new(_haContext, "sensor.canon_mx490_series");
		///<summary>Current training schedule</summary>
		public SensorEntity CurrentTrainingSchedule => new(_haContext, "sensor.current_training_schedule");
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
		///<summary>Fantenrüssel Last Clean End</summary>
		public SensorEntity FantenrusselLastCleanEnd => new(_haContext, "sensor.fantenrussel_last_clean_end");
		///<summary>Fantenrüssel Last Clean Start</summary>
		public SensorEntity FantenrusselLastCleanStart => new(_haContext, "sensor.fantenrussel_last_clean_start");
		///<summary>hallway Cluster Leader</summary>
		public SensorEntity HallwayClusterLeader => new(_haContext, "sensor.hallway_cluster_leader");
		public SensorEntity Icloud3EventLog => new(_haContext, "sensor.icloud3_event_log");
		///<summary>iPhone Philipp 2 Activity</summary>
		public SensorEntity IphonePhilipp2Activity => new(_haContext, "sensor.iphone_philipp_2_activity");
		///<summary>iPhone Philipp 2 Battery State</summary>
		public SensorEntity IphonePhilipp2BatteryState => new(_haContext, "sensor.iphone_philipp_2_battery_state");
		///<summary>iPhone Philipp 2 BSSID</summary>
		public SensorEntity IphonePhilipp2Bssid => new(_haContext, "sensor.iphone_philipp_2_bssid");
		///<summary>iPhone Philipp 2 Connection Type</summary>
		public SensorEntity IphonePhilipp2ConnectionType => new(_haContext, "sensor.iphone_philipp_2_connection_type");
		///<summary>iPhone Philipp 2 Geocoded Location</summary>
		public SensorEntity IphonePhilipp2GeocodedLocation => new(_haContext, "sensor.iphone_philipp_2_geocoded_location");
		///<summary>iPhone Philipp 2 Last Update Trigger</summary>
		public SensorEntity IphonePhilipp2LastUpdateTrigger => new(_haContext, "sensor.iphone_philipp_2_last_update_trigger");
		///<summary>iPhone Philipp 2 SIM 1</summary>
		public SensorEntity IphonePhilipp2Sim1 => new(_haContext, "sensor.iphone_philipp_2_sim_1");
		///<summary>iPhone Philipp 2 SSID</summary>
		public SensorEntity IphonePhilipp2Ssid => new(_haContext, "sensor.iphone_philipp_2_ssid");
		///<summary>Philipp</summary>
		public SensorEntity IphonePhilippBadge => new(_haContext, "sensor.iphone_philipp_badge");
		///<summary>iPhone-Philipp Direction</summary>
		public SensorEntity IphonePhilippDirOfTravel => new(_haContext, "sensor.iphone_philipp_dir_of_travel");
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
		///<summary>iPhone-Philipp Last Zone</summary>
		public SensorEntity IphonePhilippLastZone => new(_haContext, "sensor.iphone_philipp_last_zone");
		///<summary>iPhone-Philipp  Last Zone Fname</summary>
		public SensorEntity IphonePhilippLastZoneFname => new(_haContext, "sensor.iphone_philipp_last_zone_fname");
		///<summary>iPhone-Philipp Next Update</summary>
		public SensorEntity IphonePhilippNextUpdate => new(_haContext, "sensor.iphone_philipp_next_update");
		///<summary>iPhone-Philipp Poll Count</summary>
		public SensorEntity IphonePhilippPollCount => new(_haContext, "sensor.iphone_philipp_poll_count");
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
		///<summary>kitchen/kratom_counter_action</summary>
		public SensorEntity KitchenKratomCounterAction => new(_haContext, "sensor.kitchen_kratom_counter_action");
		///<summary>kitchen/kratom_counter_click</summary>
		public SensorEntity KitchenKratomCounterClick => new(_haContext, "sensor.kitchen_kratom_counter_click");
		///<summary>kitchen/light action</summary>
		public SensorEntity KitchenLightAction => new(_haContext, "sensor.kitchen_light_action");
		///<summary>kitchen/light click</summary>
		public SensorEntity KitchenLightClick => new(_haContext, "sensor.kitchen_light_click");
		///<summary>Kitchen scale</summary>
		public SensorEntity KitchenScale => new(_haContext, "sensor.kitchen_scale");
		///<summary>Daily kratom intake for fabienne</summary>
		public SensorEntity KratomIntakeFabienne => new(_haContext, "sensor.kratom_intake_fabienne");
		///<summary>Daily kratom intake target for fabienne</summary>
		public SensorEntity KratomIntakeFabienneTarget => new(_haContext, "sensor.kratom_intake_fabienne_target");
		///<summary>Daily kratom intake for philipp</summary>
		public SensorEntity KratomIntakePhilipp => new(_haContext, "sensor.kratom_intake_philipp");
		///<summary>Daily kratom intake target for philipp</summary>
		public SensorEntity KratomIntakePhilippTarget => new(_haContext, "sensor.kratom_intake_philipp_target");
		///<summary>netdaemon_status</summary>
		public SensorEntity NetdaemonStatus => new(_haContext, "sensor.netdaemon_status");
		///<summary>trash_collection_days</summary>
		public SensorEntity Nodered92b5910e7f5ff => new(_haContext, "sensor.nodered_92b5910e_7f5ff");
		///<summary>openwindows_count</summary>
		public SensorEntity OpenwindowsCount => new(_haContext, "sensor.openwindows_count");
		///<summary>PupsStation Status</summary>
		public SensorEntity PupsstationDrive1Status => new(_haContext, "sensor.pupsstation_drive_1_status");
		///<summary>PupsStation Status</summary>
		public SensorEntity PupsstationDrive2Status => new(_haContext, "sensor.pupsstation_drive_2_status");
		///<summary>PupsStation Status</summary>
		public SensorEntity PupsstationVolume1Status => new(_haContext, "sensor.pupsstation_volume_1_status");
		///<summary>Razor blade usage</summary>
		public SensorEntity RazorBladeUsage => new(_haContext, "sensor.razor_blade_usage");
		///<summary>Ist heute Haushaltstag?</summary>
		public SensorEntity ShowHouseholdDayTodo => new(_haContext, "sensor.show_household_day_todo");
		///<summary>Thermostat Arbeitszimmer</summary>
		public SensorEntity ThermostatArbeitszimmer => new(_haContext, "sensor.thermostat_arbeitszimmer");
		///<summary>Thermostat Badezimmer</summary>
		public SensorEntity ThermostatBadezimmer => new(_haContext, "sensor.thermostat_badezimmer");
		///<summary>Thermostat Schlafzimmer</summary>
		public SensorEntity ThermostatSchlafzimmer => new(_haContext, "sensor.thermostat_schlafzimmer");
		///<summary>Thermostat Wohnzimmer</summary>
		public SensorEntity ThermostatWohnzimmer => new(_haContext, "sensor.thermostat_wohnzimmer");
		///<summary>Daily water intake for fabienne</summary>
		public SensorEntity WaterIntakeFabienne => new(_haContext, "sensor.water_intake_fabienne");
		///<summary>Daily water intake target for fabienne</summary>
		public SensorEntity WaterIntakeFabienneTarget => new(_haContext, "sensor.water_intake_fabienne_target");
		///<summary>Daily water intake for philipp</summary>
		public SensorEntity WaterIntakePhilipp => new(_haContext, "sensor.water_intake_philipp");
		///<summary>Daily water intake target for philipp</summary>
		public SensorEntity WaterIntakePhilippTarget => new(_haContext, "sensor.water_intake_philipp_target");
		///<summary>0x00158d0006792498 battery</summary>
		public NumericSensorEntity E0x00158d0006792498Battery => new(_haContext, "sensor.0x00158d0006792498_battery");
		///<summary>0x00158d0006792498 linkquality</summary>
		public NumericSensorEntity E0x00158d0006792498Linkquality => new(_haContext, "sensor.0x00158d0006792498_linkquality");
		///<summary>0x00158d0006792498 voltage</summary>
		public NumericSensorEntity E0x00158d0006792498Voltage => new(_haContext, "sensor.0x00158d0006792498_voltage");
		///<summary>AMC Entertainment Holdings Inc</summary>
		public NumericSensorEntity AmcEntertainmentHoldingsInc => new(_haContext, "sensor.amc_entertainment_holdings_inc");
		///<summary>bathroom/razor_blade_usage_battery</summary>
		public NumericSensorEntity BathroomRazorBladeUsageBattery => new(_haContext, "sensor.bathroom_razor_blade_usage_battery");
		///<summary>bedroom/motion_detector_battery</summary>
		public NumericSensorEntity BedroomMotionDetectorBattery => new(_haContext, "sensor.bedroom_motion_detector_battery");
		///<summary>bedroom/motion_detector_illuminance_lux</summary>
		public NumericSensorEntity BedroomMotionDetectorIlluminanceLux => new(_haContext, "sensor.bedroom_motion_detector_illuminance_lux");
		///<summary>bedroom/motion_detector_temperature</summary>
		public NumericSensorEntity BedroomMotionDetectorTemperature => new(_haContext, "sensor.bedroom_motion_detector_temperature");
		///<summary>BlackBerry Ltd</summary>
		public NumericSensorEntity BlackberryLtd => new(_haContext, "sensor.blackberry_ltd");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Average Active Pace</summary>
		public NumericSensorEntity BuyHodlGmeAverageActivePace => new(_haContext, "sensor.buy_hodl_gme_average_active_pace");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Battery Level</summary>
		public NumericSensorEntity BuyHodlGmeBatteryLevel => new(_haContext, "sensor.buy_hodl_gme_battery_level");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Distance</summary>
		public NumericSensorEntity BuyHodlGmeDistance => new(_haContext, "sensor.buy_hodl_gme_distance");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Floors Ascended</summary>
		public NumericSensorEntity BuyHodlGmeFloorsAscended => new(_haContext, "sensor.buy_hodl_gme_floors_ascended");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Floors Descended</summary>
		public NumericSensorEntity BuyHodlGmeFloorsDescended => new(_haContext, "sensor.buy_hodl_gme_floors_descended");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Steps</summary>
		public NumericSensorEntity BuyHodlGmeSteps => new(_haContext, "sensor.buy_hodl_gme_steps");
		///<summary>🚀🚀🚀 BUY/HODL GME 🚀🚀🚀 Storage</summary>
		public NumericSensorEntity BuyHodlGmeStorage => new(_haContext, "sensor.buy_hodl_gme_storage");
		///<summary>Canon MX490 series Black</summary>
		public NumericSensorEntity CanonMx490SeriesBlack => new(_haContext, "sensor.canon_mx490_series_black");
		///<summary>Canon MX490 series Color</summary>
		public NumericSensorEntity CanonMx490SeriesColor => new(_haContext, "sensor.canon_mx490_series_color");
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
		///<summary>Fantenrüssel Current Clean Area</summary>
		public NumericSensorEntity FantenrusselCurrentCleanArea => new(_haContext, "sensor.fantenrussel_current_clean_area");
		///<summary>Fantenrüssel Current Clean Duration</summary>
		public NumericSensorEntity FantenrusselCurrentCleanDuration => new(_haContext, "sensor.fantenrussel_current_clean_duration");
		///<summary>Fantenrüssel Last Clean Area</summary>
		public NumericSensorEntity FantenrusselLastCleanArea => new(_haContext, "sensor.fantenrussel_last_clean_area");
		///<summary>Fantenrüssel Last Clean Duration</summary>
		public NumericSensorEntity FantenrusselLastCleanDuration => new(_haContext, "sensor.fantenrussel_last_clean_duration");
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
		///<summary>Glances /run/containerd/runc/k8s.io/a74d9cdc64bea1df2952208e7eacf04ddd1f84558b51e9c486b68ba8b767d8e6/runc.neLJOF free</summary>
		public NumericSensorEntity GlancesRunContainerdRuncK8sIoA74d9cdc64bea1df2952208e7eacf04ddd1f84558b51e9c486b68ba8b767d8e6RuncNeljofFree => new(_haContext, "sensor.glances_run_containerd_runc_k8s_io_a74d9cdc64bea1df2952208e7eacf04ddd1f84558b51e9c486b68ba8b767d8e6_runc_neljof_free");
		///<summary>Glances /run/containerd/runc/k8s.io/a74d9cdc64bea1df2952208e7eacf04ddd1f84558b51e9c486b68ba8b767d8e6/runc.neLJOF used</summary>
		public NumericSensorEntity GlancesRunContainerdRuncK8sIoA74d9cdc64bea1df2952208e7eacf04ddd1f84558b51e9c486b68ba8b767d8e6RuncNeljofUsed => new(_haContext, "sensor.glances_run_containerd_runc_k8s_io_a74d9cdc64bea1df2952208e7eacf04ddd1f84558b51e9c486b68ba8b767d8e6_runc_neljof_used");
		///<summary>Glances /run/containerd/runc/k8s.io/a74d9cdc64bea1df2952208e7eacf04ddd1f84558b51e9c486b68ba8b767d8e6/runc.neLJOF used percent</summary>
		public NumericSensorEntity GlancesRunContainerdRuncK8sIoA74d9cdc64bea1df2952208e7eacf04ddd1f84558b51e9c486b68ba8b767d8e6RuncNeljofUsedPercent => new(_haContext, "sensor.glances_run_containerd_runc_k8s_io_a74d9cdc64bea1df2952208e7eacf04ddd1f84558b51e9c486b68ba8b767d8e6_runc_neljof_used_percent");
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
		///<summary>Glances /var/lib/kubelet/pods/11aa4b7e-7aa3-4d96-8272-1a41454f4869/volume-subpaths/zigbee2mqtt-settings/zigbee2mqtt/1 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods11aa4b7e7aa34d9682721a41454f4869VolumeSubpathsZigbee2mqttSettingsZigbee2mqtt1Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_11aa4b7e_7aa3_4d96_8272_1a41454f4869_volume_subpaths_zigbee2mqtt_settings_zigbee2mqtt_1_free");
		///<summary>Glances /var/lib/kubelet/pods/11aa4b7e-7aa3-4d96-8272-1a41454f4869/volume-subpaths/zigbee2mqtt-settings/zigbee2mqtt/1 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods11aa4b7e7aa34d9682721a41454f4869VolumeSubpathsZigbee2mqttSettingsZigbee2mqtt1Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_11aa4b7e_7aa3_4d96_8272_1a41454f4869_volume_subpaths_zigbee2mqtt_settings_zigbee2mqtt_1_used");
		///<summary>Glances /var/lib/kubelet/pods/11aa4b7e-7aa3-4d96-8272-1a41454f4869/volume-subpaths/zigbee2mqtt-settings/zigbee2mqtt/1 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods11aa4b7e7aa34d9682721a41454f4869VolumeSubpathsZigbee2mqttSettingsZigbee2mqtt1UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_11aa4b7e_7aa3_4d96_8272_1a41454f4869_volume_subpaths_zigbee2mqtt_settings_zigbee2mqtt_1_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/14952757-0bd0-4d0b-9e20-a1c2cf67c711/volume-subpaths/adguard-home-config/adguard-home/0 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods149527570bd04d0b9e20A1c2cf67c711VolumeSubpathsAdguardHomeConfigAdguardHome0Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_14952757_0bd0_4d0b_9e20_a1c2cf67c711_volume_subpaths_adguard_home_config_adguard_home_0_free");
		///<summary>Glances /var/lib/kubelet/pods/14952757-0bd0-4d0b-9e20-a1c2cf67c711/volume-subpaths/adguard-home-config/adguard-home/0 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods149527570bd04d0b9e20A1c2cf67c711VolumeSubpathsAdguardHomeConfigAdguardHome0Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_14952757_0bd0_4d0b_9e20_a1c2cf67c711_volume_subpaths_adguard_home_config_adguard_home_0_used");
		///<summary>Glances /var/lib/kubelet/pods/14952757-0bd0-4d0b-9e20-a1c2cf67c711/volume-subpaths/adguard-home-config/adguard-home/0 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods149527570bd04d0b9e20A1c2cf67c711VolumeSubpathsAdguardHomeConfigAdguardHome0UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_14952757_0bd0_4d0b_9e20_a1c2cf67c711_volume_subpaths_adguard_home_config_adguard_home_0_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/14952757-0bd0-4d0b-9e20-a1c2cf67c711/volume-subpaths/adguard-home-config/copy-configmap/0 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods149527570bd04d0b9e20A1c2cf67c711VolumeSubpathsAdguardHomeConfigCopyConfigmap0Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_14952757_0bd0_4d0b_9e20_a1c2cf67c711_volume_subpaths_adguard_home_config_copy_configmap_0_free");
		///<summary>Glances /var/lib/kubelet/pods/14952757-0bd0-4d0b-9e20-a1c2cf67c711/volume-subpaths/adguard-home-config/copy-configmap/0 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods149527570bd04d0b9e20A1c2cf67c711VolumeSubpathsAdguardHomeConfigCopyConfigmap0Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_14952757_0bd0_4d0b_9e20_a1c2cf67c711_volume_subpaths_adguard_home_config_copy_configmap_0_used");
		///<summary>Glances /var/lib/kubelet/pods/14952757-0bd0-4d0b-9e20-a1c2cf67c711/volume-subpaths/adguard-home-config/copy-configmap/0 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods149527570bd04d0b9e20A1c2cf67c711VolumeSubpathsAdguardHomeConfigCopyConfigmap0UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_14952757_0bd0_4d0b_9e20_a1c2cf67c711_volume_subpaths_adguard_home_config_copy_configmap_0_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/18b3903e-69e2-44c0-aebc-a44d4e7ace1a/volume-subpaths/mosquitto-config/mosquitto/0 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods18b3903e69e244c0AebcA44d4e7ace1aVolumeSubpathsMosquittoConfigMosquitto0Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_18b3903e_69e2_44c0_aebc_a44d4e7ace1a_volume_subpaths_mosquitto_config_mosquitto_0_free");
		///<summary>Glances /var/lib/kubelet/pods/18b3903e-69e2-44c0-aebc-a44d4e7ace1a/volume-subpaths/mosquitto-config/mosquitto/0 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods18b3903e69e244c0AebcA44d4e7ace1aVolumeSubpathsMosquittoConfigMosquitto0Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_18b3903e_69e2_44c0_aebc_a44d4e7ace1a_volume_subpaths_mosquitto_config_mosquitto_0_used");
		///<summary>Glances /var/lib/kubelet/pods/18b3903e-69e2-44c0-aebc-a44d4e7ace1a/volume-subpaths/mosquitto-config/mosquitto/0 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPods18b3903e69e244c0AebcA44d4e7ace1aVolumeSubpathsMosquittoConfigMosquitto0UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_18b3903e_69e2_44c0_aebc_a44d4e7ace1a_volume_subpaths_mosquitto_config_mosquitto_0_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/f0edab55-3def-49c1-833c-4f1788b40431/volume-subpaths/config/mariadb/1 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsF0edab553def49c1833c4f1788b40431VolumeSubpathsConfigMariadb1Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_f0edab55_3def_49c1_833c_4f1788b40431_volume_subpaths_config_mariadb_1_free");
		///<summary>Glances /var/lib/kubelet/pods/f0edab55-3def-49c1-833c-4f1788b40431/volume-subpaths/config/mariadb/1 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsF0edab553def49c1833c4f1788b40431VolumeSubpathsConfigMariadb1Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_f0edab55_3def_49c1_833c_4f1788b40431_volume_subpaths_config_mariadb_1_used");
		///<summary>Glances /var/lib/kubelet/pods/f0edab55-3def-49c1-833c-4f1788b40431/volume-subpaths/config/mariadb/1 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsF0edab553def49c1833c4f1788b40431VolumeSubpathsConfigMariadb1UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_f0edab55_3def_49c1_833c_4f1788b40431_volume_subpaths_config_mariadb_1_used_percent");
		///<summary>Glances /var/lib/kubelet/pods/f8b2f25c-6be9-46e9-89e5-0303b04e4dc9/volume-subpaths/zigbee2mqtt-settings/zigbee2mqtt/1 free</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsF8b2f25c6be946e989e50303b04e4dc9VolumeSubpathsZigbee2mqttSettingsZigbee2mqtt1Free => new(_haContext, "sensor.glances_var_lib_kubelet_pods_f8b2f25c_6be9_46e9_89e5_0303b04e4dc9_volume_subpaths_zigbee2mqtt_settings_zigbee2mqtt_1_free");
		///<summary>Glances /var/lib/kubelet/pods/f8b2f25c-6be9-46e9-89e5-0303b04e4dc9/volume-subpaths/zigbee2mqtt-settings/zigbee2mqtt/1 used</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsF8b2f25c6be946e989e50303b04e4dc9VolumeSubpathsZigbee2mqttSettingsZigbee2mqtt1Used => new(_haContext, "sensor.glances_var_lib_kubelet_pods_f8b2f25c_6be9_46e9_89e5_0303b04e4dc9_volume_subpaths_zigbee2mqtt_settings_zigbee2mqtt_1_used");
		///<summary>Glances /var/lib/kubelet/pods/f8b2f25c-6be9-46e9-89e5-0303b04e4dc9/volume-subpaths/zigbee2mqtt-settings/zigbee2mqtt/1 used percent</summary>
		public NumericSensorEntity GlancesVarLibKubeletPodsF8b2f25c6be946e989e50303b04e4dc9VolumeSubpathsZigbee2mqttSettingsZigbee2mqtt1UsedPercent => new(_haContext, "sensor.glances_var_lib_kubelet_pods_f8b2f25c_6be9_46e9_89e5_0303b04e4dc9_volume_subpaths_zigbee2mqtt_settings_zigbee2mqtt_1_used_percent");
		///<summary>guest_bath/zigbee_repeater_energy</summary>
		public NumericSensorEntity GuestBathZigbeeRepeaterEnergy => new(_haContext, "sensor.guest_bath_zigbee_repeater_energy");
		///<summary>guest_bath/zigbee_repeater_power</summary>
		public NumericSensorEntity GuestBathZigbeeRepeaterPower => new(_haContext, "sensor.guest_bath_zigbee_repeater_power");
		///<summary>hacs</summary>
		public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
		///<summary>hallway Cluster Size</summary>
		public NumericSensorEntity HallwayClusterSize => new(_haContext, "sensor.hallway_cluster_size");
		///<summary>iPhone Philipp 2 Average Active Pace</summary>
		public NumericSensorEntity IphonePhilipp2AverageActivePace => new(_haContext, "sensor.iphone_philipp_2_average_active_pace");
		///<summary>iPhone Philipp 2 Battery Level</summary>
		public NumericSensorEntity IphonePhilipp2BatteryLevel => new(_haContext, "sensor.iphone_philipp_2_battery_level");
		///<summary>iPhone Philipp 2 Distance</summary>
		public NumericSensorEntity IphonePhilipp2Distance => new(_haContext, "sensor.iphone_philipp_2_distance");
		///<summary>iPhone Philipp 2 Floors Ascended</summary>
		public NumericSensorEntity IphonePhilipp2FloorsAscended => new(_haContext, "sensor.iphone_philipp_2_floors_ascended");
		///<summary>iPhone Philipp 2 Floors Descended</summary>
		public NumericSensorEntity IphonePhilipp2FloorsDescended => new(_haContext, "sensor.iphone_philipp_2_floors_descended");
		///<summary>iPhone Philipp 2 Steps</summary>
		public NumericSensorEntity IphonePhilipp2Steps => new(_haContext, "sensor.iphone_philipp_2_steps");
		///<summary>iPhone Philipp 2 Storage</summary>
		public NumericSensorEntity IphonePhilipp2Storage => new(_haContext, "sensor.iphone_philipp_2_storage");
		///<summary>iPhone-Philipp Battery</summary>
		public NumericSensorEntity IphonePhilippBattery => new(_haContext, "sensor.iphone_philipp_battery");
		///<summary>iPhone-Philipp Calc Dist</summary>
		public NumericSensorEntity IphonePhilippCalcDistance => new(_haContext, "sensor.iphone_philipp_calc_distance");
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
		///<summary>kitchen/kratom_counter_battery</summary>
		public NumericSensorEntity KitchenKratomCounterBattery => new(_haContext, "sensor.kitchen_kratom_counter_battery");
		///<summary>kitchen/light battery</summary>
		public NumericSensorEntity KitchenLightBattery => new(_haContext, "sensor.kitchen_light_battery");
		///<summary>kitchen/motion_detector_battery</summary>
		public NumericSensorEntity KitchenMotionDetectorBattery => new(_haContext, "sensor.kitchen_motion_detector_battery");
		///<summary>kitchen/motion_detector_illuminance_lux</summary>
		public NumericSensorEntity KitchenMotionDetectorIlluminanceLux => new(_haContext, "sensor.kitchen_motion_detector_illuminance_lux");
		///<summary>kitchen/motion_detector_temperature</summary>
		public NumericSensorEntity KitchenMotionDetectorTemperature => new(_haContext, "sensor.kitchen_motion_detector_temperature");
		///<summary>kitchen/neon_clock_energy</summary>
		public NumericSensorEntity KitchenNeonClockEnergy2 => new(_haContext, "sensor.kitchen_neon_clock_energy_2");
		///<summary>kitchen/neon_clock_power</summary>
		public NumericSensorEntity KitchenNeonClockPower2 => new(_haContext, "sensor.kitchen_neon_clock_power_2");
		///<summary>living_room/buddha_fountain_energy</summary>
		public NumericSensorEntity LivingRoomBuddhaFountainEnergy => new(_haContext, "sensor.living_room_buddha_fountain_energy");
		///<summary>living_room/buddha_fountain_power</summary>
		public NumericSensorEntity LivingRoomBuddhaFountainPower => new(_haContext, "sensor.living_room_buddha_fountain_power");
		///<summary>living_room/contract_light_energy</summary>
		public NumericSensorEntity LivingRoomContractLightEnergy => new(_haContext, "sensor.living_room_contract_light_energy");
		///<summary>living_room/contract_light_power</summary>
		public NumericSensorEntity LivingRoomContractLightPower => new(_haContext, "sensor.living_room_contract_light_power");
		///<summary>living_room/diorama_energy</summary>
		public NumericSensorEntity LivingRoomDioramaEnergy => new(_haContext, "sensor.living_room_diorama_energy");
		///<summary>living_room/diorama_power</summary>
		public NumericSensorEntity LivingRoomDioramaPower => new(_haContext, "sensor.living_room_diorama_power");
		///<summary>living_room/lightbar_energy</summary>
		public NumericSensorEntity LivingRoomLightbarEnergy => new(_haContext, "sensor.living_room_lightbar_energy");
		///<summary>living_room/lightbar_power</summary>
		public NumericSensorEntity LivingRoomLightbarPower => new(_haContext, "sensor.living_room_lightbar_power");
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
		///<summary>PupsStation Temperature</summary>
		public NumericSensorEntity PupsstationDrive1Temperature => new(_haContext, "sensor.pupsstation_drive_1_temperature");
		///<summary>PupsStation Temperature</summary>
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
		///<summary>PupsStation Download Throughput</summary>
		public NumericSensorEntity PupsstationNetworkDown => new(_haContext, "sensor.pupsstation_network_down");
		///<summary>PupsStation Upload Throughput</summary>
		public NumericSensorEntity PupsstationNetworkUp => new(_haContext, "sensor.pupsstation_network_up");
		///<summary>PupsStation Temperature</summary>
		public NumericSensorEntity PupsstationTemperature => new(_haContext, "sensor.pupsstation_temperature");
		///<summary>PupsStation Average Disk Temp</summary>
		public NumericSensorEntity PupsstationVolume1AverageDiskTemp => new(_haContext, "sensor.pupsstation_volume_1_average_disk_temp");
		///<summary>PupsStation Used Space</summary>
		public NumericSensorEntity PupsstationVolume1UsedSpace => new(_haContext, "sensor.pupsstation_volume_1_used_space");
		///<summary>PupsStation Volume Used</summary>
		public NumericSensorEntity PupsstationVolume1VolumeUsed => new(_haContext, "sensor.pupsstation_volume_1_volume_used");
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
		///<summary>switch.study_speakers_philipp_energy</summary>
		public NumericSensorEntity SwitchStudySpeakersPhilippEnergy => new(_haContext, "sensor.switch_study_speakers_philipp_energy");
		///<summary>switch.study_speakers_philipp_power</summary>
		public NumericSensorEntity SwitchStudySpeakersPhilippPower => new(_haContext, "sensor.switch_study_speakers_philipp_power");
		///<summary>Thermostat Arbeitszimmer Temperature</summary>
		public NumericSensorEntity ThermostatArbeitszimmerTemperature => new(_haContext, "sensor.thermostat_arbeitszimmer_temperature");
		///<summary>Thermostat Arbeitszimmer Valvetappet</summary>
		public NumericSensorEntity ThermostatArbeitszimmerValvetappet => new(_haContext, "sensor.thermostat_arbeitszimmer_valvetappet");
		///<summary>Thermostat Badezimmer Temperature</summary>
		public NumericSensorEntity ThermostatBadezimmerTemperature => new(_haContext, "sensor.thermostat_badezimmer_temperature");
		///<summary>Thermostat Badezimmer Valvetappet</summary>
		public NumericSensorEntity ThermostatBadezimmerValvetappet => new(_haContext, "sensor.thermostat_badezimmer_valvetappet");
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
	}

	public class SunEntities
	{
		private readonly IHaContext _haContext;
		public SunEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public class SwitchEntities
	{
		private readonly IHaContext _haContext;
		public SwitchEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Buddha-Brunnen 2 Socket 1</summary>
		public SwitchEntity BuddhaBrunnen2Socket1 => new(_haContext, "switch.buddha_brunnen_2_socket_1");
		///<summary>WOL switch for Desktop Philipp</summary>
		public SwitchEntity ComputerWolDesktopPhilipp => new(_haContext, "switch.computer_wol_desktop_philipp");
		///<summary>WOL switch for Desktop Philipp</summary>
		public SwitchEntity ComputerWolDesktopPhilipp2 => new(_haContext, "switch.computer_wol_desktop_philipp_2");
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
		///<summary>guest_bath/zigbee_repeater</summary>
		public SwitchEntity GuestBathZigbeeRepeater => new(_haContext, "switch.guest_bath_zigbee_repeater");
		///<summary>kitchen/neon_clock</summary>
		public SwitchEntity KitchenNeonClock2 => new(_haContext, "switch.kitchen_neon_clock_2");
		///<summary>Lautsprecher Pup Socket 1</summary>
		public SwitchEntity LautsprecherPupSocket1 => new(_haContext, "switch.lautsprecher_pup_socket_1");
		///<summary>Lightbar Socket 1</summary>
		public SwitchEntity LightbarSocket1 => new(_haContext, "switch.lightbar_socket_1");
		///<summary>living_room/buddha_fountain</summary>
		public SwitchEntity LivingRoomBuddhaFountain => new(_haContext, "switch.living_room_buddha_fountain");
		///<summary>living_room/contract_light</summary>
		public SwitchEntity LivingRoomContractLight => new(_haContext, "switch.living_room_contract_light");
		///<summary>living_room/diorama</summary>
		public SwitchEntity LivingRoomDiorama => new(_haContext, "switch.living_room_diorama");
		///<summary>living_room/lightbar</summary>
		public SwitchEntity LivingRoomLightbar => new(_haContext, "switch.living_room_lightbar");
		///<summary>Enable movie time light control.</summary>
		public SwitchEntity MovieTimeEnableLightControl => new(_haContext, "switch.movie_time_enable_light_control");
		///<summary>Neon-Uhr Socket 1</summary>
		public SwitchEntity NeonUhrSocket1 => new(_haContext, "switch.neon_uhr_socket_1");
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
		///<summary>Tablet Hallway Socket 1</summary>
		public SwitchEntity SternenLichterketteSocket1 => new(_haContext, "switch.sternen_lichterkette_socket_1");
		///<summary>switch.study_speakers_philipp</summary>
		public SwitchEntity SwitchStudySpeakersPhilipp => new(_haContext, "switch.switch_study_speakers_philipp");
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
		///<summary>TWTYH Diorama Socket 1</summary>
		public SwitchEntity TwtyhDioramaSocket1 => new(_haContext, "switch.twtyh_diorama_socket_1");
		///<summary>Vertragslicht  Socket 1</summary>
		public SwitchEntity VertragslichtSocket1 => new(_haContext, "switch.vertragslicht_socket_1");
		///<summary>windows</summary>
		public SwitchEntity Windows => new(_haContext, "switch.windows");
		///<summary>windowswol</summary>
		public SwitchEntity Windowswol => new(_haContext, "switch.windowswol");
	}

	public class TimerEntities
	{
		private readonly IHaContext _haContext;
		public TimerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public TimerEntity Meditation => new(_haContext, "timer.meditation");
	}

	public class UpdateEntities
	{
		private readonly IHaContext _haContext;
		public UpdateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>PupsStation DSM Update</summary>
		public UpdateEntity PupsstationDsmUpdate => new(_haContext, "update.pupsstation_dsm_update");
	}

	public class VacuumEntities
	{
		private readonly IHaContext _haContext;
		public VacuumEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Fantenrüssel</summary>
		public VacuumEntity Fantenrussel => new(_haContext, "vacuum.fantenrussel");
	}

	public class WeatherEntities
	{
		private readonly IHaContext _haContext;
		public WeatherEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Zuhause</summary>
		public WeatherEntity Zuhause => new(_haContext, "weather.zuhause");
	}

	public class ZoneEntities
	{
		private readonly IHaContext _haContext;
		public ZoneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Zuhause</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
		///<summary>iphone_philipp_stationary</summary>
		public ZoneEntity IphonePhilippStationary => new(_haContext, "zone.iphone_philipp_stationary");
	}

	public record AlarmControlPanelEntity : Entity<AlarmControlPanelEntity, EntityState<AlarmControlPanelAttributes>, AlarmControlPanelAttributes>
	{
		public AlarmControlPanelEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AlarmControlPanelEntity(Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ButtonEntity : Entity<ButtonEntity, EntityState<ButtonAttributes>, ButtonAttributes>
	{
		public ButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ButtonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CalendarEntity : Entity<CalendarEntity, EntityState<CalendarAttributes>, CalendarAttributes>
	{
		public CalendarEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CalendarEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CameraEntity : Entity<CameraEntity, EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CameraEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ClimateEntity : Entity<ClimateEntity, EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ClimateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CounterEntity : Entity<CounterEntity, EntityState<CounterAttributes>, CounterAttributes>
	{
		public CounterEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CounterEntity(Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record GroupEntity : Entity<GroupEntity, EntityState<GroupAttributes>, GroupAttributes>
	{
		public GroupEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public GroupEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputBooleanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputNumberEntity : NumericEntity<InputNumberEntity, NumericEntityState<InputNumberAttributes>, InputNumberAttributes>
	{
		public InputNumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputNumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputSelectEntity : Entity<InputSelectEntity, EntityState<InputSelectAttributes>, InputSelectAttributes>
	{
		public InputSelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputSelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputTextEntity : Entity<InputTextEntity, EntityState<InputTextAttributes>, InputTextAttributes>
	{
		public InputTextEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputTextEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LockEntity : Entity<LockEntity, EntityState<LockAttributes>, LockAttributes>
	{
		public LockEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LockEntity(Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerEntity : Entity<MediaPlayerEntity, EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersistentNotificationEntity : Entity<PersistentNotificationEntity, EntityState<PersistentNotificationAttributes>, PersistentNotificationAttributes>
	{
		public PersistentNotificationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersistentNotificationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SelectEntity : Entity<SelectEntity, EntityState<SelectAttributes>, SelectAttributes>
	{
		public SelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(Entity entity) : base(entity)
		{
		}
	}

	public record TimerEntity : Entity<TimerEntity, EntityState<TimerAttributes>, TimerAttributes>
	{
		public TimerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public TimerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record UpdateEntity : Entity<UpdateEntity, EntityState<UpdateAttributes>, UpdateAttributes>
	{
		public UpdateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public UpdateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record VacuumEntity : Entity<VacuumEntity, EntityState<VacuumAttributes>, VacuumAttributes>
	{
		public VacuumEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VacuumEntity(Entity entity) : base(entity)
		{
		}
	}

	public record WeatherEntity : Entity<WeatherEntity, EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public WeatherEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(Entity entity) : base(entity)
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

	public record BinarySensorAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

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

		[JsonPropertyName("illuminance")]
		public double? Illuminance { get; init; }

		[JsonPropertyName("illuminance_lux")]
		public double? IlluminanceLux { get; init; }

		[JsonPropertyName("indicator_mode")]
		public string? IndicatorMode { get; init; }

		[JsonPropertyName("installed_version")]
		public string? InstalledVersion { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("latest_available_version")]
		public string? LatestAvailableVersion { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("malware")]
		public string? Malware { get; init; }

		[JsonPropertyName("network")]
		public string? Network { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("power")]
		public double? Power { get; init; }

		[JsonPropertyName("power_outage_memory")]
		public object? PowerOutageMemory { get; init; }

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

		[JsonPropertyName("securitySetting")]
		public string? SecuritySetting { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("systemCheck")]
		public string? SystemCheck { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("userInfo")]
		public string? UserInfo { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
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

	public record CalendarAttributes
	{
		[JsonPropertyName("all_day")]
		public bool? AllDay { get; init; }

		[JsonPropertyName("all_tasks")]
		public object? AllTasks { get; init; }

		[JsonPropertyName("description")]
		public string? Description { get; init; }

		[JsonPropertyName("end_time")]
		public string? EndTime { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("location")]
		public string? Location { get; init; }

		[JsonPropertyName("message")]
		public string? Message { get; init; }

		[JsonPropertyName("offset_reached")]
		public bool? OffsetReached { get; init; }

		[JsonPropertyName("overdue_tasks")]
		public object? OverdueTasks { get; init; }

		[JsonPropertyName("start_time")]
		public string? StartTime { get; init; }
	}

	public record CameraAttributes
	{
		[JsonPropertyName("access_token")]
		public string? AccessToken { get; init; }

		[JsonPropertyName("calibration_points")]
		public object? CalibrationPoints { get; init; }

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

	public record ClimateAttributes
	{
		[JsonPropertyName("current_temperature")]
		public double? CurrentTemperature { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hvac_modes")]
		public object? HvacModes { get; init; }

		[JsonPropertyName("max_temp")]
		public double? MaxTemp { get; init; }

		[JsonPropertyName("min_temp")]
		public double? MinTemp { get; init; }

		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }

		[JsonPropertyName("preset_modes")]
		public object? PresetModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("target_temp_step")]
		public double? TargetTempStep { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
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

	public record GroupAttributes
	{
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("order")]
		public double? Order { get; init; }
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

	public record InputSelectAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("options")]
		public object? Options { get; init; }
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

	public record LightAttributes
	{
		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("device")]
		public object? Device { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("max_mireds")]
		public double? MaxMireds { get; init; }

		[JsonPropertyName("min_mireds")]
		public double? MinMireds { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_color_modes")]
		public object? SupportedColorModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
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
		public object? PowerOutageMemory { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
	}

	public record MediaPlayerAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }

		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("source_list")]
		public object? SourceList { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
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

	public record SelectAttributes
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

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("indicator_mode")]
		public string? IndicatorMode { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("options")]
		public object? Options { get; init; }

		[JsonPropertyName("power")]
		public double? Power { get; init; }

		[JsonPropertyName("power_outage_memory")]
		public object? PowerOutageMemory { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
	}

	public record SensorAttributes
	{
		[JsonPropertyName("action")]
		public object? Action { get; init; }

		[JsonPropertyName("Administrative Area")]
		public string? AdministrativeArea { get; init; }

		[JsonPropertyName("Allows VoIP")]
		public bool? AllowsVoIP { get; init; }

		[JsonPropertyName("Areas Of Interest")]
		public object? AreasOfInterest { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("Carrier ID")]
		public string? CarrierID { get; init; }

		[JsonPropertyName("Carrier Name")]
		public string? CarrierName { get; init; }

		[JsonPropertyName("Cellular Technology")]
		public string? CellularTechnology { get; init; }

		[JsonPropertyName("click")]
		public string? Click { get; init; }

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

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("filtername")]
		public string? Filtername { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("Inland Water")]
		public string? InlandWater { get; init; }

		[JsonPropertyName("integration")]
		public string? Integration { get; init; }

		[JsonPropertyName("ISO Country Code")]
		public string? ISOCountryCode { get; init; }

		[JsonPropertyName("last_seen")]
		public string? LastSeen { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("Locality")]
		public string? Locality { get; init; }

		[JsonPropertyName("Location")]
		public object? Location { get; init; }

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

		[JsonPropertyName("Name")]
		public string? Name { get; init; }

		[JsonPropertyName("names")]
		public object? Names { get; init; }

		[JsonPropertyName("number_of_loaded_apps")]
		public double? NumberOfLoadedApps { get; init; }

		[JsonPropertyName("number_of_running_apps")]
		public double? NumberOfRunningApps { get; init; }

		[JsonPropertyName("Ocean")]
		public string? Ocean { get; init; }

		[JsonPropertyName("Postal Code")]
		public string? PostalCode { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("Sub Administrative Area")]
		public string? SubAdministrativeArea { get; init; }

		[JsonPropertyName("Sub Locality")]
		public string? SubLocality { get; init; }

		[JsonPropertyName("Sub Thoroughfare")]
		public string? SubThoroughfare { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("Thoroughfare")]
		public string? Thoroughfare { get; init; }

		[JsonPropertyName("Time Zone")]
		public string? TimeZone { get; init; }

		[JsonPropertyName("Types")]
		public object? Types { get; init; }

		[JsonPropertyName("update_time")]
		public string? UpdateTime { get; init; }

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
		public object? Zones { get; init; }
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

		[JsonPropertyName("changePercentSixMonths")]
		public double? ChangePercentSixMonths { get; init; }

		[JsonPropertyName("changePercentThreeMonths")]
		public double? ChangePercentThreeMonths { get; init; }

		[JsonPropertyName("changePercentThreeYears")]
		public object? ChangePercentThreeYears { get; init; }

		[JsonPropertyName("changeSixMonths")]
		public double? ChangeSixMonths { get; init; }

		[JsonPropertyName("changeThreeMonths")]
		public double? ChangeThreeMonths { get; init; }

		[JsonPropertyName("changeThreeYears")]
		public object? ChangeThreeYears { get; init; }

		[JsonPropertyName("child_lock")]
		public string? ChildLock { get; init; }

		[JsonPropertyName("click")]
		public string? Click { get; init; }

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

		[JsonPropertyName("name")]
		public string? Name { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("power")]
		public double? Power { get; init; }

		[JsonPropertyName("power_outage_memory")]
		public object? PowerOutageMemory { get; init; }

		[JsonPropertyName("profitLoss")]
		public double? ProfitLoss { get; init; }

		[JsonPropertyName("profitLossPercentage")]
		public double? ProfitLossPercentage { get; init; }

		[JsonPropertyName("purchasePrice")]
		public double? PurchasePrice { get; init; }

		[JsonPropertyName("repositories")]
		public object? Repositories { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

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

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

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

		[JsonPropertyName("totalChangeSixMonths")]
		public double? TotalChangeSixMonths { get; init; }

		[JsonPropertyName("totalChangeThreeMonths")]
		public double? TotalChangeThreeMonths { get; init; }

		[JsonPropertyName("totalChangeThreeYears")]
		public object? TotalChangeThreeYears { get; init; }

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
		public object? PowerOutageMemory { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
	}

	public record TimerAttributes
	{
		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record UpdateAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("auto_update")]
		public bool? AutoUpdate { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("in_progress")]
		public bool? InProgress { get; init; }

		[JsonPropertyName("installed_version")]
		public string? InstalledVersion { get; init; }

		[JsonPropertyName("latest_version")]
		public string? LatestVersion { get; init; }

		[JsonPropertyName("release_summary")]
		public object? ReleaseSummary { get; init; }

		[JsonPropertyName("release_url")]
		public string? ReleaseUrl { get; init; }

		[JsonPropertyName("skipped_version")]
		public object? SkippedVersion { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public record VacuumAttributes
	{
		[JsonPropertyName("fan_speed_list")]
		public object? FanSpeedList { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record WeatherAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("forecast")]
		public object? Forecast { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("pressure")]
		public double? Pressure { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("wind_bearing")]
		public double? WindBearing { get; init; }

		[JsonPropertyName("wind_speed")]
		public double? WindSpeed { get; init; }
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

		[JsonPropertyName("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AlarmControlPanelServices AlarmControlPanel { get; }

		AutomationServices Automation { get; }

		BoschShcServices BoschShc { get; }

		BrowserModServices BrowserMod { get; }

		ButtonServices Button { get; }

		CameraServices Camera { get; }

		CastServices Cast { get; }

		ClimateServices Climate { get; }

		CloudServices Cloud { get; }

		CounterServices Counter { get; }

		CoverServices Cover { get; }

		DeviceTrackerServices DeviceTracker { get; }

		FanServices Fan { get; }

		FfmpegServices Ffmpeg { get; }

		FrontendServices Frontend { get; }

		GoogleServices Google { get; }

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

		MicrosoftTodoServices MicrosoftTodo { get; }

		MqttServices Mqtt { get; }

		NetdaemonServices Netdaemon { get; }

		NotifyServices Notify { get; }

		NumberServices Number { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		PingServices Ping { get; }

		RecorderServices Recorder { get; }

		RemoteServices Remote { get; }

		SceneServices Scene { get; }

		ScriptServices Script { get; }

		SelectServices Select { get; }

		SirenServices Siren { get; }

		SpeedtestdotnetServices Speedtestdotnet { get; }

		SpotcastServices Spotcast { get; }

		SwitchServices Switch { get; }

		SynologyDsmServices SynologyDsm { get; }

		SystemLogServices SystemLog { get; }

		TemplateServices Template { get; }

		TimerServices Timer { get; }

		UpdateServices Update { get; }

		VacuumServices Vacuum { get; }

		WakeOnLanServices WakeOnLan { get; }

		XiaomiCloudMapExtractorServices XiaomiCloudMapExtractor { get; }

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
		public BoschShcServices BoschShc => new(_haContext);
		public BrowserModServices BrowserMod => new(_haContext);
		public ButtonServices Button => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public CastServices Cast => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CloudServices Cloud => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public CoverServices Cover => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public FanServices Fan => new(_haContext);
		public FfmpegServices Ffmpeg => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GoogleServices Google => new(_haContext);
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
		public MicrosoftTodoServices MicrosoftTodo => new(_haContext);
		public MqttServices Mqtt => new(_haContext);
		public NetdaemonServices Netdaemon => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public NumberServices Number => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public PingServices Ping => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public RemoteServices Remote => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public SelectServices Select => new(_haContext);
		public SirenServices Siren => new(_haContext);
		public SpeedtestdotnetServices Speedtestdotnet => new(_haContext);
		public SpotcastServices Spotcast => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SynologyDsmServices SynologyDsm => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TemplateServices Template => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public UpdateServices Update => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public WakeOnLanServices WakeOnLan => new(_haContext);
		public XiaomiCloudMapExtractorServices XiaomiCloudMapExtractor => new(_haContext);
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

		///<summary>Cover screen in black until the mouse is moved or a key is pressed.</summary>
		public void Blackout(BrowserModBlackoutParameters data)
		{
			_haContext.CallService("browser_mod", "blackout", null, data);
		}

		///<summary>Cover screen in black until the mouse is moved or a key is pressed.</summary>
		///<param name="time">(optional) The blackout will turn on automatically after the specified number of seconds. It works kind of like a screensaver and will keep turning on until blackout is called again with time: -1. eg: 20</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Blackout(object? @time = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "blackout", null, new BrowserModBlackoutParameters{Time = @time, DeviceID = @deviceID});
		}

		public void CallService()
		{
			_haContext.CallService("browser_mod", "call_service", null);
		}

		public void CleanDevices()
		{
			_haContext.CallService("browser_mod", "clean_devices", null);
		}

		///<summary>Close all popups on all browsers.</summary>
		public void ClosePopup(BrowserModClosePopupParameters data)
		{
			_haContext.CallService("browser_mod", "close_popup", null, data);
		}

		///<summary>Close all popups on all browsers.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void ClosePopup(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "close_popup", null, new BrowserModClosePopupParameters{DeviceID = @deviceID});
		}

		///<summary>Send a command to a browser.</summary>
		public void Command(BrowserModCommandParameters data)
		{
			_haContext.CallService("browser_mod", "command", null, data);
		}

		///<summary>Send a command to a browser.</summary>
		///<param name="command">Command to send eg: navigate</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Command(object? @command = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "command", null, new BrowserModCommandParameters{Command = @command, DeviceID = @deviceID});
		}

		///<summary>Send several commands to a browser</summary>
		public void Commands(BrowserModCommandsParameters data)
		{
			_haContext.CallService("browser_mod", "commands", null, data);
		}

		///<summary>Send several commands to a browser</summary>
		///<param name="commands">List of commands to send</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Commands(object? @commands = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "commands", null, new BrowserModCommandsParameters{Commands = @commands, DeviceID = @deviceID});
		}

		///<summary>On all browsers, show a popup, and a javascript alert with the current device ID.</summary>
		public void Debug(BrowserModDebugParameters data)
		{
			_haContext.CallService("browser_mod", "debug", null, data);
		}

		///<summary>On all browsers, show a popup, and a javascript alert with the current device ID.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Debug(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "debug", null, new BrowserModDebugParameters{DeviceID = @deviceID});
		}

		///<summary>Do nothing for a while</summary>
		public void Delay(BrowserModDelayParameters data)
		{
			_haContext.CallService("browser_mod", "delay", null, data);
		}

		///<summary>Do nothing for a while</summary>
		///<param name="seconds">Number of seconds to delay eg: 5</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Delay(object? @seconds = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "delay", null, new BrowserModDelayParameters{Seconds = @seconds, DeviceID = @deviceID});
		}

		///<summary>Refresh the lovelace configuration.</summary>
		public void LovelaceReload(BrowserModLovelaceReloadParameters data)
		{
			_haContext.CallService("browser_mod", "lovelace_reload", null, data);
		}

		///<summary>Refresh the lovelace configuration.</summary>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void LovelaceReload(object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "lovelace_reload", null, new BrowserModLovelaceReloadParameters{DeviceID = @deviceID});
		}

		///<summary>Open the more info dialog of an entity on a browser.</summary>
		public void MoreInfo(BrowserModMoreInfoParameters data)
		{
			_haContext.CallService("browser_mod", "more_info", null, data);
		}

		///<summary>Open the more info dialog of an entity on a browser.</summary>
		///<param name="entityId">Entity to show more info for eg: camera.front_door</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		///<param name="large">(optional) Set to true to make wider eg: true</param>
		public void MoreInfo(object? @entityId = null, object? @deviceID = null, object? @large = null)
		{
			_haContext.CallService("browser_mod", "more_info", null, new BrowserModMoreInfoParameters{EntityId = @entityId, DeviceID = @deviceID, Large = @large});
		}

		///<summary>Navigate to a path on a browser.</summary>
		public void Navigate(BrowserModNavigateParameters data)
		{
			_haContext.CallService("browser_mod", "navigate", null, data);
		}

		///<summary>Navigate to a path on a browser.</summary>
		///<param name="navigationPath">Path to navigate to eg: /lovelace/1</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void Navigate(object? @navigationPath = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "navigate", null, new BrowserModNavigateParameters{NavigationPath = @navigationPath, DeviceID = @deviceID});
		}

		///<summary>Remove a blackout from a browser.</summary>
		public void NoBlackout(BrowserModNoBlackoutParameters data)
		{
			_haContext.CallService("browser_mod", "no_blackout", null, data);
		}

		///<summary>Remove a blackout from a browser.</summary>
		///<param name="brightness">(optional) On a Fully Kiosk Browser Plus set the screen brightness from 0 - 255.</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void NoBlackout(object? @brightness = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "no_blackout", null, new BrowserModNoBlackoutParameters{Brightness = @brightness, DeviceID = @deviceID});
		}

		///<summary>Pop up a card on a browser.</summary>
		public void Popup(BrowserModPopupParameters data)
		{
			_haContext.CallService("browser_mod", "popup", null, data);
		}

		///<summary>Pop up a card on a browser.</summary>
		///<param name="title">Name to show in popup bar eg: Popup example</param>
		///<param name="card">YAML config for card to show</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		///<param name="large">(optional) Set to true to make wider eg: true</param>
		///<param name="hideHeader">(optional) Hide header title and close button eg: true</param>
		///<param name="autoClose">(optional) Close popup when mouse is moved or key is pressed. Also hides header eg: true</param>
		///<param name="time">(optional) When mouse isn't moved or keys aren't pressed for this amount of seconds, reopen. Only usable with auto_close. See blackout eg: 20</param>
		public void Popup(object? @title = null, object? @card = null, object? @deviceID = null, object? @large = null, object? @hideHeader = null, object? @autoClose = null, object? @time = null)
		{
			_haContext.CallService("browser_mod", "popup", null, new BrowserModPopupParameters{Title = @title, Card = @card, DeviceID = @deviceID, Large = @large, HideHeader = @hideHeader, AutoClose = @autoClose, Time = @time});
		}

		///<summary>On all browsers, change the theme.</summary>
		public void SetTheme(BrowserModSetThemeParameters data)
		{
			_haContext.CallService("browser_mod", "set_theme", null, data);
		}

		///<summary>On all browsers, change the theme.</summary>
		///<param name="theme">Theme to change to eg: {theme: "clear_light"}</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		public void SetTheme(object? @theme = null, object? @deviceID = null)
		{
			_haContext.CallService("browser_mod", "set_theme", null, new BrowserModSetThemeParameters{Theme = @theme, DeviceID = @deviceID});
		}

		///<summary>Show a toast message in the bottom left on all browsers.</summary>
		public void Toast(BrowserModToastParameters data)
		{
			_haContext.CallService("browser_mod", "toast", null, data);
		}

		///<summary>Show a toast message in the bottom left on all browsers.</summary>
		///<param name="message">Message to show eg: Short message</param>
		///<param name="deviceID">(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</param>
		///<param name="duration">(optional) Time in milliseconds to show message for. Set to 0 for persistent display. eg: 10000</param>
		public void Toast(object? @message = null, object? @deviceID = null, object? @duration = null)
		{
			_haContext.CallService("browser_mod", "toast", null, new BrowserModToastParameters{Message = @message, DeviceID = @deviceID, Duration = @duration});
		}

		public void WindowReload()
		{
			_haContext.CallService("browser_mod", "window_reload", null);
		}
	}

	public record BrowserModBlackoutParameters
	{
		///<summary>(optional) The blackout will turn on automatically after the specified number of seconds. It works kind of like a screensaver and will keep turning on until blackout is called again with time: -1. eg: 20</summary>
		[JsonPropertyName("time")]
		public object? Time { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModClosePopupParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModCommandParameters
	{
		///<summary>Command to send eg: navigate</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModCommandsParameters
	{
		///<summary>List of commands to send</summary>
		[JsonPropertyName("commands")]
		public object? Commands { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModDebugParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModDelayParameters
	{
		///<summary>Number of seconds to delay eg: 5</summary>
		[JsonPropertyName("seconds")]
		public object? Seconds { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModLovelaceReloadParameters
	{
		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModMoreInfoParameters
	{
		///<summary>Entity to show more info for eg: camera.front_door</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }

		///<summary>(optional) Set to true to make wider eg: true</summary>
		[JsonPropertyName("large")]
		public object? Large { get; init; }
	}

	public record BrowserModNavigateParameters
	{
		///<summary>Path to navigate to eg: /lovelace/1</summary>
		[JsonPropertyName("navigation_path")]
		public object? NavigationPath { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModNoBlackoutParameters
	{
		///<summary>(optional) On a Fully Kiosk Browser Plus set the screen brightness from 0 - 255.</summary>
		[JsonPropertyName("brightness")]
		public object? Brightness { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModPopupParameters
	{
		///<summary>Name to show in popup bar eg: Popup example</summary>
		[JsonPropertyName("title")]
		public object? Title { get; init; }

		///<summary>YAML config for card to show</summary>
		[JsonPropertyName("card")]
		public object? Card { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }

		///<summary>(optional) Set to true to make wider eg: true</summary>
		[JsonPropertyName("large")]
		public object? Large { get; init; }

		///<summary>(optional) Hide header title and close button eg: true</summary>
		[JsonPropertyName("hide_header")]
		public object? HideHeader { get; init; }

		///<summary>(optional) Close popup when mouse is moved or key is pressed. Also hides header eg: true</summary>
		[JsonPropertyName("auto_close")]
		public object? AutoClose { get; init; }

		///<summary>(optional) When mouse isn't moved or keys aren't pressed for this amount of seconds, reopen. Only usable with auto_close. See blackout eg: 20</summary>
		[JsonPropertyName("time")]
		public object? Time { get; init; }
	}

	public record BrowserModSetThemeParameters
	{
		///<summary>Theme to change to eg: {theme: "clear_light"}</summary>
		[JsonPropertyName("theme")]
		public object? Theme { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }
	}

	public record BrowserModToastParameters
	{
		///<summary>Message to show eg: Short message</summary>
		[JsonPropertyName("message")]
		public object? Message { get; init; }

		///<summary>(optional) List of receiving browsers eg: ["99980b13-dabc9563", "office_computer"]</summary>
		[JsonPropertyName("deviceID")]
		public object? DeviceID { get; init; }

		///<summary>(optional) Time in milliseconds to show message for. Set to 0 for persistent display. eg: 10000</summary>
		[JsonPropertyName("duration")]
		public object? Duration { get; init; }
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

	public class GoogleServices
	{
		private readonly IHaContext _haContext;
		public GoogleServices(IHaContext haContext)
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
		[JsonPropertyName("calendar_id")]
		public string? CalendarId { get; init; }

		///<summary>Acts as the title of the event. eg: Bowling</summary>
		[JsonPropertyName("summary")]
		public string? Summary { get; init; }

		///<summary>The description of the event. Optional. eg: Birthday bowling</summary>
		[JsonPropertyName("description")]
		public string? Description { get; init; }

		///<summary>The date and time the event should start. eg: 2019-03-22 20:00:00</summary>
		[JsonPropertyName("start_date_time")]
		public string? StartDateTime { get; init; }

		///<summary>The date and time the event should end. eg: 2019-03-22 22:00:00</summary>
		[JsonPropertyName("end_date_time")]
		public string? EndDateTime { get; init; }

		///<summary>The date the whole day event should start. eg: 2019-03-10</summary>
		[JsonPropertyName("start_date")]
		public string? StartDate { get; init; }

		///<summary>The date the whole day event should end. eg: 2019-03-11</summary>
		[JsonPropertyName("end_date")]
		public string? EndDate { get; init; }

		///<summary>Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</summary>
		[JsonPropertyName("in")]
		public object? In { get; init; }
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
		///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
		public void Set(string @objectId, string? @name = null, object? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all});
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
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void Toggle(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
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

		///<summary>Number indicating level of white.</summary>
		[JsonPropertyName("white_value")]
		public long? WhiteValue { get; init; }

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
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public void Join(ServiceTarget target, object? @groupMembers = null)
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
		public void PlayMedia(ServiceTarget target, string @mediaContentId, string @mediaContentType)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
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
		///<summary>The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</summary>
		[JsonPropertyName("group_members")]
		public object? GroupMembers { get; init; }
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

	public class MicrosoftTodoServices
	{
		private readonly IHaContext _haContext;
		public MicrosoftTodoServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a new task.</summary>
		public void NewTask(MicrosoftTodoNewTaskParameters data)
		{
			_haContext.CallService("microsoft_todo", "new_task", null, data);
		}

		///<summary>Create a new task.</summary>
		///<param name="subject">The subject of the task. eg: Pick up the mail.</param>
		public void NewTask(object? @subject = null)
		{
			_haContext.CallService("microsoft_todo", "new_task", null, new MicrosoftTodoNewTaskParameters{Subject = @subject});
		}
	}

	public record MicrosoftTodoNewTaskParameters
	{
		///<summary>The subject of the task. eg: Pick up the mail.</summary>
		[JsonPropertyName("subject")]
		public object? Subject { get; init; }
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

		///<summary>Sends a notification message using the mobile_app_iphone_philipp_2 integration.</summary>
		public void MobileAppIphonePhilipp2(NotifyMobileAppIphonePhilipp2Parameters data)
		{
			_haContext.CallService("notify", "mobile_app_iphone_philipp_2", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_iphone_philipp_2 integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppIphonePhilipp2(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_iphone_philipp_2", null, new NotifyMobileAppIphonePhilipp2Parameters{Message = @message, Title = @title, Target = @target, Data = @data});
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

	public record NotifyMobileAppIphonePhilipp2Parameters
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

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
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

	public class SpeedtestdotnetServices
	{
		private readonly IHaContext _haContext;
		public SpeedtestdotnetServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Immediately execute a speed test with Speedtest.net</summary>
		public void Speedtest()
		{
			_haContext.CallService("speedtestdotnet", "speedtest", null);
		}
	}

	public class SpotcastServices
	{
		private readonly IHaContext _haContext;
		public SpotcastServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Starts spotify playback on chromecast devices</summary>
		public void Start(SpotcastStartParameters data)
		{
			_haContext.CallService("spotcast", "start", null, data);
		}

		///<summary>Starts spotify playback on chromecast devices</summary>
		///<param name="deviceName">The friendly name of the chromecast or spotify connect device. First checks spotify device list for name (not used together with entity_id and spotify_device_id). eg: Livingroom</param>
		///<param name="spotifyDeviceId">Advanced users only. The spotify device id (not used together with entity_id or device_name). eg: 4363634563457346xcyvydgf3qwa</param>
		///<param name="entityId">The entity_id of the chromecast mediaplayer. Friendly name MUST match the spotify connect device name (not used together with device_name and spotify_device_id). eg: media_player.vardagsrum</param>
		///<param name="uri">Supported Spotify URI as string. None or empty uri will transfer the current/last playback (see parameter force_playback). eg: spotify:playlist:37i9dQZF1DX3yvAYDslnv8</param>
		///<param name="category">A category to fetch playlist from. See https://developer.spotify.com/console/get-browse-categories/ for a list of categories</param>
		///<param name="country">Country code to use with category. See https://spotipy.readthedocs.io/en/2.19.0/#spotipy.client.Spotify.country_codes for list of available codes</param>
		///<param name="limit">Limit of playlist to fetch in a given category. Default 20</param>
		///<param name="search">A Search request to the spotify API. Will play the most relevant search result.</param>
		///<param name="account">Optionally starts Spotify using an alternative account specified in config. eg: my_wifes</param>
		///<param name="forcePlayback">In case of transfering playback: If true starts playing the user's last playback even if nothing is currently playing. eg: True</param>
		///<param name="randomSong">Starts the playback at a random position in the playlist or album. eg: True</param>
		///<param name="repeat">Set repeat mode for playback. eg: track</param>
		///<param name="shuffle">Set shuffle mode for playback. eg: True</param>
		///<param name="offset">Set offset mode for playback. 0 is the first song. eg: 1</param>
		///<param name="startVolume">Set the volume for playback in percentage. eg: 50</param>
		///<param name="ignoreFullyPlayed">Set to ignore or not already played episodes in a podcast playlist eg: True</param>
		public void Start(string? @deviceName = null, string? @spotifyDeviceId = null, string? @entityId = null, string? @uri = null, string? @category = null, string? @country = null, long? @limit = null, string? @search = null, string? @account = null, bool? @forcePlayback = null, bool? @randomSong = null, object? @repeat = null, bool? @shuffle = null, long? @offset = null, long? @startVolume = null, bool? @ignoreFullyPlayed = null)
		{
			_haContext.CallService("spotcast", "start", null, new SpotcastStartParameters{DeviceName = @deviceName, SpotifyDeviceId = @spotifyDeviceId, EntityId = @entityId, Uri = @uri, Category = @category, Country = @country, Limit = @limit, Search = @search, Account = @account, ForcePlayback = @forcePlayback, RandomSong = @randomSong, Repeat = @repeat, Shuffle = @shuffle, Offset = @offset, StartVolume = @startVolume, IgnoreFullyPlayed = @ignoreFullyPlayed});
		}
	}

	public record SpotcastStartParameters
	{
		///<summary>The friendly name of the chromecast or spotify connect device. First checks spotify device list for name (not used together with entity_id and spotify_device_id). eg: Livingroom</summary>
		[JsonPropertyName("device_name")]
		public string? DeviceName { get; init; }

		///<summary>Advanced users only. The spotify device id (not used together with entity_id or device_name). eg: 4363634563457346xcyvydgf3qwa</summary>
		[JsonPropertyName("spotify_device_id")]
		public string? SpotifyDeviceId { get; init; }

		///<summary>The entity_id of the chromecast mediaplayer. Friendly name MUST match the spotify connect device name (not used together with device_name and spotify_device_id). eg: media_player.vardagsrum</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Supported Spotify URI as string. None or empty uri will transfer the current/last playback (see parameter force_playback). eg: spotify:playlist:37i9dQZF1DX3yvAYDslnv8</summary>
		[JsonPropertyName("uri")]
		public string? Uri { get; init; }

		///<summary>A category to fetch playlist from. See https://developer.spotify.com/console/get-browse-categories/ for a list of categories</summary>
		[JsonPropertyName("category")]
		public string? Category { get; init; }

		///<summary>Country code to use with category. See https://spotipy.readthedocs.io/en/2.19.0/#spotipy.client.Spotify.country_codes for list of available codes</summary>
		[JsonPropertyName("country")]
		public string? Country { get; init; }

		///<summary>Limit of playlist to fetch in a given category. Default 20</summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }

		///<summary>A Search request to the spotify API. Will play the most relevant search result.</summary>
		[JsonPropertyName("search")]
		public string? Search { get; init; }

		///<summary>Optionally starts Spotify using an alternative account specified in config. eg: my_wifes</summary>
		[JsonPropertyName("account")]
		public string? Account { get; init; }

		///<summary>In case of transfering playback: If true starts playing the user's last playback even if nothing is currently playing. eg: True</summary>
		[JsonPropertyName("force_playback")]
		public bool? ForcePlayback { get; init; }

		///<summary>Starts the playback at a random position in the playlist or album. eg: True</summary>
		[JsonPropertyName("random_song")]
		public bool? RandomSong { get; init; }

		///<summary>Set repeat mode for playback. eg: track</summary>
		[JsonPropertyName("repeat")]
		public object? Repeat { get; init; }

		///<summary>Set shuffle mode for playback. eg: True</summary>
		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }

		///<summary>Set offset mode for playback. 0 is the first song. eg: 1</summary>
		[JsonPropertyName("offset")]
		public long? Offset { get; init; }

		///<summary>Set the volume for playback in percentage. eg: 50</summary>
		[JsonPropertyName("start_volume")]
		public long? StartVolume { get; init; }

		///<summary>Set to ignore or not already played episodes in a podcast playlist eg: True</summary>
		[JsonPropertyName("ignore_fully_played")]
		public bool? IgnoreFullyPlayed { get; init; }
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
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
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
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
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
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public static void Join(this MediaPlayerEntity target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, object? @groupMembers = null)
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
		public static void PlayMedia(this MediaPlayerEntity target, string @mediaContentId, string @mediaContentType)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, string @mediaContentId, string @mediaContentType)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
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
}