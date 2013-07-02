﻿using System.Runtime.InteropServices;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Vtex.Kd.Test
{
    [TestFixture]
    public class UnifiTest
    {
        private const string JsonResult =
           "{\"data\":[{\"_id\":\"51c9cc65d0a49dbd2c04faf0\",\"_rx_bytes\":164340,\"_rx_crypts\":0,\"_rx_dropped\":0,\"_rx_errors\":0,\"_rx_frags\":0,\"_rx_packets\":1248,\"_tx_bytes\":474510,\"_tx_dropped\":0,\"_tx_errors\":0,\"_tx_packets\":1011,\"_tx_retries\":0,\"_uptime\":1225,\"ap_mac\":\"00:27:22:f6:cf:72\",\"assoc_time\":1372273657,\"auth_time\":-267014130,\"authorized\":true,\"bssid\":\"06:27:22:f7:cf:72\",\"bytes\":638850,\"bytes.d\":168,\"bytes.r\":16,\"ccq\":950,\"channel\":11,\"dhcpend_time\":0,\"dhcpstart_time\":1072,\"essid\":\"Vtex - Office\",\"first_seen\":1372179556,\"hostname\":null,\"idletime\":2,\"is_11a\":null,\"is_11b\":null,\"is_11n\":true,\"is_guest\":false,\"last_seen\":1372274882,\"mac\":\"00:07:ab:af:7a:e8\",\"map_id\":\"51c35aef98079dbd2b583804\",\"noise\":-95,\"oui\":\"SamsungE\",\"powersave_enabled\":true,\"qos_policy_applied\":true,\"radio\":\"ng\",\"rssi\":26,\"rx_bytes\":164340,\"rx_bytes.d\":168,\"rx_bytes.r\":16,\"rx_crypts\":0,\"rx_crypts.d\":0,\"rx_crypts.r\":0,\"rx_dropped\":0,\"rx_dropped.d\":0,\"rx_dropped.r\":0,\"rx_errors\":0,\"rx_errors.d\":0,\"rx_errors.r\":0,\"rx_frags\":0,\"rx_frags.d\":0,\"rx_frags.r\":0,\"rx_packets\":1248,\"rx_packets.d\":12,\"rx_packets.r\":1,\"rx_rate\":39000,\"signal\":-69,\"state\":47,\"state_ht\":true,\"state_pwrmgt\":false,\"t\":\"sta\",\"tx_bytes\":474510,\"tx_bytes.d\":0,\"tx_bytes.r\":0,\"tx_dropped\":0,\"tx_dropped.d\":0,\"tx_dropped.r\":0,\"tx_errors\":0,\"tx_errors.d\":0,\"tx_errors.r\":0,\"tx_packets\":1011,\"tx_packets.d\":0,\"tx_packets.r\":0,\"tx_power\":40,\"tx_rate\":39000,\"tx_retries\":0,\"tx_retries.d\":0,\"tx_retries.r\":0,\"uptime\":1225,\"user_id\":\"51c9cc65d0a49dbd2c04faf0\"},{\"_id\":\"51c86ef0d6b89dbd8b09049a\",\"_rx_bytes\":163679663,\"_rx_crypts\":0,\"_rx_dropped\":0,\"_rx_errors\":0,\"_rx_frags\":0,\"_rx_packets\":720575,\"_tx_bytes\":810579865,\"_tx_dropped\":0,\"_tx_errors\":0,\"_tx_packets\":837746,\"_tx_retries\":0,\"_uptime\":146334,\"ap_mac\":\"00:27:22:f6:d2:53\",\"assoc_time\":1372128689,\"auth_time\":-22703949,\"authorized\":true,\"bssid\":\"06:27:22:f7:d2:53\",\"bytes\":974259528,\"bytes.d\":7970,\"bytes.r\":797,\"ccq\":791,\"channel\":1,\"dhcpend_time\":0,\"dhcpstart_time\":142373932,\"essid\":\"Vtex - Office\",\"first_seen\":1372090096,\"hostname\":\"breno-rni\",\"idletime\":1,\"ip\":\"10.1.13.70\",\"is_11a\":null,\"is_11b\":null,\"is_11n\":false,\"is_guest\":false,\"last_seen\":1372275023,\"mac\":\"00:11:6b:64:b0:0a\",\"map_id\":\"51c35aef98079dbd2b583804\",\"noise\":-93,\"oui\":\"DigitalD\",\"powersave_enabled\":false,\"qos_policy_applied\":true,\"radio\":\"ng\",\"rssi\":36,\"rx_bytes\":163679663,\"rx_bytes.d\":3591,\"rx_bytes.r\":359,\"rx_crypts\":0,\"rx_crypts.d\":0,\"rx_crypts.r\":0,\"rx_dropped\":0,\"rx_dropped.d\":0,\"rx_dropped.r\":0,\"rx_errors\":0,\"rx_errors.d\":0,\"rx_errors.r\":0,\"rx_frags\":0,\"rx_frags.d\":0,\"rx_frags.r\":0,\"rx_packets\":720575,\"rx_packets.d\":20,\"rx_packets.r\":2,\"rx_rate\":54000,\"signal\":-57,\"state\":37,\"state_ht\":false,\"state_pwrmgt\":false,\"t\":\"sta\",\"tx_bytes\":810579865,\"tx_bytes.d\":4379,\"tx_bytes.r\":437,\"tx_dropped\":0,\"tx_dropped.d\":0,\"tx_dropped.r\":0,\"tx_errors\":0,\"tx_errors.d\":0,\"tx_errors.r\":0,\"tx_packets\":837746,\"tx_packets.d\":17,\"tx_packets.r\":1,\"tx_power\":40,\"tx_rate\":48000,\"tx_retries\":0,\"tx_retries.d\":0,\"tx_retries.r\":0,\"uptime\":146334,\"user_id\":\"51c86ef0d6b89dbd8b09049a\"},{\"_rx_bytes\":3561901,\"_rx_crypts\":0,\"_rx_dropped\":0,\"_rx_errors\":0,\"_rx_frags\":0,\"_rx_packets\":21163,\"_tx_bytes\":4633720,\"_tx_dropped\":0,\"_tx_errors\":0,\"_tx_packets\":17586,\"_tx_retries\":0,\"_uptime\":6395,\"ap_mac\":\"00:27:22:f6:d2:53\",\"assoc_time\":1372268628,\"auth_time\":-162643133,\"authorized\":true,\"bssid\":\"06:27:22:f7:d2:53\",\"bytes\":8195621,\"bytes.d\":5142,\"bytes.r\":514,\"ccq\":790,\"channel\":1,\"dhcpend_time\":0,\"dhcpstart_time\":4140,\"essid\":\"Vtex - Office\",\"hostname\":\"android-6ff4a4318fe7813e\",\"idletime\":0,\"ip\":\"10.1.12.112\",\"is_11a\":null,\"is_11b\":null,\"is_11n\":true,\"is_guest\":false,\"last_seen\":1372275023,\"mac\":\"00:aa:70:89:8b:8f\",\"map_id\":\"51c35aef98079dbd2b583804\",\"noise\":-93,\"oui\":\"LgElectr\",\"powersave_enabled\":false,\"qos_policy_applied\":true,\"radio\":\"ng\",\"rssi\":20,\"rx_bytes\":3561901,\"rx_bytes.d\":2774,\"rx_bytes.r\":277,\"rx_crypts\":0,\"rx_crypts.d\":0,\"rx_crypts.r\":0,\"rx_dropped\":0,\"rx_dropped.d\":0,\"rx_dropped.r\":0,\"rx_errors\":0,\"rx_errors.d\":0,\"rx_errors.r\":0,\"rx_frags\":0,\"rx_frags.d\":0,\"rx_frags.r\":0,\"rx_packets\":21163,\"rx_packets.d\":30,\"rx_packets.r\":3,\"rx_rate\":1000,\"signal\":-73,\"state\":47,\"state_ht\":true,\"state_pwrmgt\":false,\"t\":\"sta\",\"tx_bytes\":4633720,\"tx_bytes.d\":2368,\"tx_bytes.r\":236,\"tx_dropped\":0,\"tx_dropped.d\":0,\"tx_dropped.r\":0,\"tx_errors\":0,\"tx_errors.d\":0,\"tx_errors.r\":0,\"tx_packets\":17586,\"tx_packets.d\":24,\"tx_packets.r\":2,\"tx_power\":40,\"tx_rate\":58500,\"tx_retries\":0,\"tx_retries.d\":0,\"tx_retries.r\":0,\"uptime\":6395,\"user_id\":\"51cb39a0d0a49dbdd6756f30\"},{\"_id\":\"51c86b8dd6b89dbd7c09049a\",\"_rx_bytes\":111306,\"_rx_crypts\":0,\"_rx_dropped\":0,\"_rx_errors\":0,\"_rx_frags\":0,\"_rx_packets\":496,\"_tx_bytes\":116919,\"_tx_dropped\":0,\"_tx_errors\":0,\"_tx_packets\":430,\"_tx_retries\":0,\"_uptime\":1552,\"ap_mac\":\"00:27:22:f6:cf:72\",\"assoc_time\":1372262132,\"auth_time\":-156146649,\"authorized\":true,\"bssid\":\"06:27:22:f7:cf:72\",\"bytes\":5500350,\"bytes.d\":0,\"bytes.r\":0,\"ccq\":765,\"channel\":11,\"dhcpend_time\":0,\"dhcpstart_time\":0,\"essid\":\"Vtex - Office\",\"first_seen\":1372089229,\"hostname\":\"android-4f0b9d4a0e51c855\",\"idletime\":44,\"ip\":\"10.1.12.179\",\"is_11a\":null,\"is_11b\":null,\"is_11n\":true,\"is_guest\":false,\"last_seen\":1372275018,\"mac\":\"04:46:65:54:95:90\",\"map_id\":\"51c35aef98079dbd2b583804\",\"noise\":-95,\"oui\":\"MurataMa\",\"powersave_enabled\":true,\"qos_policy_applied\":true,\"radio\":\"ng\",\"roam_count\":1,\"rssi\":35,\"rx_bytes\":1249566,\"rx_bytes.d\":0,\"rx_bytes.r\":0,\"rx_crypts\":0,\"rx_crypts.d\":0,\"rx_crypts.r\":0,\"rx_dropped\":0,\"rx_dropped.d\":0,\"rx_dropped.r\":0,\"rx_errors\":0,\"rx_errors.d\":0,\"rx_errors.r\":0,\"rx_frags\":0,\"rx_frags.d\":0,\"rx_frags.r\":0,\"rx_packets\":17416,\"rx_packets.d\":0,\"rx_packets.r\":0,\"rx_rate\":19500,\"signal\":-60,\"state\":47,\"state_ht\":true,\"state_pwrmgt\":false,\"t\":\"sta\",\"tx_bytes\":4250784,\"tx_bytes.d\":0,\"tx_bytes.r\":0,\"tx_dropped\":0,\"tx_dropped.d\":0,\"tx_dropped.r\":0,\"tx_errors\":0,\"tx_errors.d\":0,\"tx_errors.r\":0,\"tx_packets\":5351,\"tx_packets.d\":0,\"tx_packets.r\":0,\"tx_power\":40,\"tx_rate\":58500,\"tx_retries\":0,\"tx_retries.d\":0,\"tx_retries.r\":0,\"uptime\":12886,\"user_id\":\"51c86b8dd6b89dbd7c09049a\"},{\"_id\":\"51c88ae4beb09dbd179df0dc\",\"_rx_bytes\":1049838,\"_rx_crypts\":0,\"_rx_dropped\":0,\"_rx_errors\":0,\"_rx_frags\":0,\"_rx_packets\":9263,\"_tx_bytes\":4514731,\"_tx_dropped\":0,\"_tx_errors\":0,\"_tx_packets\":8649,\"_tx_retries\":0,\"_uptime\":5298,\"ap_mac\":\"00:27:22:f6:d2:53\",\"assoc_time\":1372269725,\"auth_time\":-163740334,\"authorized\":true,\"bssid\":\"06:27:22:f7:d2:53\",\"bytes\":5564569,\"bytes.d\":36476,\"bytes.r\":3647,\"ccq\":980,\"channel\":1,\"dhcpend_time\":0,\"dhcpstart_time\":0,\"essid\":\"Vtex - Office\",\"first_seen\":1372097252,\"hostname\":\"android-d0b4ad55feaf61b8\",\"idletime\":3,\"ip\":\"10.1.12.188\",\"is_11a\":null,\"is_11b\":null,\"is_11n\":true,\"is_guest\":false,\"last_seen\":1372275023,\"mac\":\"60:21:c0:b6:a0:4c\",\"map_id\":\"51c35aef98079dbd2b583804\",\"noise\":-93,\"oui\":\"\",\"powersave_enabled\":false,\"qos_policy_applied\":true,\"radio\":\"ng\",\"rssi\":16,\"rx_bytes\":1049838,\"rx_bytes.d\":5043,\"rx_bytes.r\":504,\"rx_crypts\":0,\"rx_crypts.d\":0,\"rx_crypts.r\":0,\"rx_dropped\":0,\"rx_dropped.d\":0,\"rx_dropped.r\":0,\"rx_errors\":0,\"rx_errors.d\":0,\"rx_errors.r\":0,\"rx_frags\":0,\"rx_frags.d\":0,\"rx_frags.r\":0,\"rx_packets\":9263,\"rx_packets.d\":58,\"rx_packets.r\":5,\"rx_rate\":26000,\"signal\":-77,\"state\":63,\"state_ht\":true,\"state_pwrmgt\":true,\"t\":\"sta\",\"tx_bytes\":4514731,\"tx_bytes.d\":31433,\"tx_bytes.r\":3143,\"tx_dropped\":0,\"tx_dropped.d\":0,\"tx_dropped.r\":0,\"tx_errors\":0,\"tx_errors.d\":0,\"tx_errors.r\":0,\"tx_packets\":8649,\"tx_packets.d\":106,\"tx_packets.r\":10,\"tx_power\":40,\"tx_rate\":52000,\"tx_retries\":0,\"tx_retries.d\":0,\"tx_retries.r\":0,\"uptime\":5298,\"user_id\":\"51c88ae4beb09dbd179df0dc\"},{\"_id\":\"51c86659d6b89dbd6a09049a\",\"_rx_bytes\":4753749,\"_rx_crypts\":0,\"_rx_dropped\":0,\"_rx_errors\":0,\"_rx_frags\":0,\"_rx_packets\":11323,\"_tx_bytes\":3794163,\"_tx_dropped\":0,\"_tx_errors\":0,\"_tx_packets\":6732,\"_tx_retries\":0,\"_uptime\":7943,\"ap_mac\":\"00:27:22:f6:cf:72\",\"assoc_time\":1372267075,\"auth_time\":-260431401,\"authorized\":true,\"bssid\":\"06:27:22:f7:cf:72\",\"bytes\":8547912,\"bytes.d\":0,\"bytes.r\":0,\"ccq\":970,\"channel\":11,\"dhcpend_time\":0,\"dhcpstart_time\":4563,\"essid\":\"Vtex - Office\",\"first_seen\":1372087897,\"hostname\":\"Leo-iPhone\",\"idletime\":33,\"ip\":\"10.1.12.87\",\"is_11a\":null,\"is_11b\":null,\"is_11n\":true,\"is_guest\":false,\"last_seen\":1372275018,\"mac\":\"88:53:95:a5:18:e8\",\"map_id\":\"51c35aef98079dbd2b583804\",\"noise\":-95,\"oui\":\"\",\"powersave_enabled\":true,\"qos_policy_applied\":true,\"radio\":\"ng\",\"rssi\":29,\"rx_bytes\":4753749,\"rx_bytes.d\":0,\"rx_bytes.r\":0,\"rx_crypts\":0,\"rx_crypts.d\":0,\"rx_crypts.r\":0,\"rx_dropped\":0,\"rx_dropped.d\":0,\"rx_dropped.r\":0,\"rx_errors\":0,\"rx_errors.d\":0,\"rx_errors.r\":0,\"rx_frags\":0,\"rx_frags.d\":0,\"rx_frags.r\":0,\"rx_packets\":11323,\"rx_packets.d\":0,\"rx_packets.r\":0,\"rx_rate\":6500,\"signal\":-66,\"state\":63,\"state_ht\":true,\"state_pwrmgt\":true,\"t\":\"sta\",\"tx_bytes\":3794163,\"tx_bytes.d\":0,\"tx_bytes.r\":0,\"tx_dropped\":0,\"tx_dropped.d\":0,\"tx_dropped.r\":0,\"tx_errors\":0,\"tx_errors.d\":0,\"tx_errors.r\":0,\"tx_packets\":6732,\"tx_packets.d\":0,\"tx_packets.r\":0,\"tx_power\":40,\"tx_rate\":65000,\"tx_retries\":0,\"tx_retries.d\":0,\"tx_retries.r\":0,\"uptime\":7943,\"user_id\":\"51c86659d6b89dbd6a09049a\"},{\"_id\":\"51c88ae4beb09dbd169df0dc\",\"_rx_bytes\":374414,\"_rx_crypts\":0,\"_rx_dropped\":0,\"_rx_errors\":0,\"_rx_frags\":0,\"_rx_packets\":4575,\"_tx_bytes\":3324920,\"_tx_dropped\":0,\"_tx_errors\":0,\"_tx_packets\":3534,\"_tx_retries\":0,\"_uptime\":2131,\"ap_mac\":\"00:27:22:f6:cf:72\",\"assoc_time\":1372264600,\"auth_time\":-158615134,\"authorized\":true,\"bssid\":\"06:27:22:f7:cf:72\",\"bytes\":45588371,\"bytes.d\":0,\"bytes.r\":0,\"ccq\":970,\"channel\":11,\"dhcpend_time\":0,\"dhcpstart_time\":24,\"essid\":\"Vtex - Office\",\"first_seen\":1372097252,\"hostname\":null,\"idletime\":85,\"ip\":\"10.1.12.12\",\"is_11a\":null,\"is_11b\":null,\"is_11n\":true,\"is_guest\":false,\"last_seen\":1372275018,\"mac\":\"88:53:95:a6:7f:d3\",\"map_id\":\"51c35aef98079dbd2b583804\",\"noise\":-95,\"oui\":\"\",\"powersave_enabled\":true,\"qos_policy_applied\":true,\"radio\":\"ng\",\"roam_count\":1,\"rssi\":29,\"rx_bytes\":9778975,\"rx_bytes.d\":0,\"rx_bytes.r\":0,\"rx_crypts\":0,\"rx_crypts.d\":0,\"rx_crypts.r\":0,\"rx_dropped\":0,\"rx_dropped.d\":0,\"rx_dropped.r\":0,\"rx_errors\":0,\"rx_errors.d\":0,\"rx_errors.r\":0,\"rx_frags\":0,\"rx_frags.d\":0,\"rx_frags.r\":0,\"rx_packets\":58144,\"rx_packets.d\":0,\"rx_packets.r\":0,\"rx_rate\":19500,\"signal\":-66,\"state\":47,\"state_ht\":true,\"state_pwrmgt\":false,\"t\":\"sta\",\"tx_bytes\":35809396,\"tx_bytes.d\":0,\"tx_bytes.r\":0,\"tx_dropped\":0,\"tx_dropped.d\":0,\"tx_dropped.r\":0,\"tx_errors\":0,\"tx_errors.d\":0,\"tx_errors.r\":0,\"tx_packets\":44979,\"tx_packets.d\":0,\"tx_packets.r\":0,\"tx_power\":40,\"tx_rate\":65000,\"tx_retries\":0,\"tx_retries.d\":0,\"tx_retries.r\":0,\"uptime\":10418,\"user_id\":\"51c88ae4beb09dbd169df0dc\"},{\"_id\":\"51cb02ecd0a49dbda105faf0\",\"_rx_bytes\":23404206,\"_rx_crypts\":0,\"_rx_dropped\":0,\"_rx_errors\":0,\"_rx_frags\":0,\"_rx_packets\":411044,\"_tx_bytes\":1415776519,\"_tx_dropped\":0,\"_tx_errors\":0,\"_tx_packets\":940366,\"_tx_retries\":0,\"_uptime\":11059,\"ap_mac\":\"00:27:22:f6:d2:53\",\"assoc_time\":1372263964,\"auth_time\":-157979143,\"authorized\":true,\"bssid\":\"06:27:22:f7:d2:53\",\"bytes\":1439180725,\"bytes.d\":181,\"bytes.r\":18,\"ccq\":1000,\"channel\":1,\"dhcpend_time\":0,\"dhcpstart_time\":238,\"essid\":\"Vtex - Office\",\"first_seen\":1372259052,\"hostname\":\"Gabriel-920\",\"idletime\":0,\"ip\":\"10.1.12.196\",\"is_11a\":null,\"is_11b\":null,\"is_11n\":true,\"is_guest\":false,\"last_seen\":1372275023,\"mac\":\"a8:44:81:34:ce:d8\",\"map_id\":\"51c35aef98079dbd2b583804\",\"noise\":-93,\"oui\":\"\",\"powersave_enabled\":true,\"qos_policy_applied\":true,\"radio\":\"ng\",\"rssi\":28,\"rx_bytes\":23404206,\"rx_bytes.d\":181,\"rx_bytes.r\":18,\"rx_crypts\":0,\"rx_crypts.d\":0,\"rx_crypts.r\":0,\"rx_dropped\":0,\"rx_dropped.d\":0,\"rx_dropped.r\":0,\"rx_errors\":0,\"rx_errors.d\":0,\"rx_errors.r\":0,\"rx_frags\":0,\"rx_frags.d\":0,\"rx_frags.r\":0,\"rx_packets\":411044,\"rx_packets.d\":3,\"rx_packets.r\":0,\"rx_rate\":6500,\"signal\":-65,\"state\":47,\"state_ht\":true,\"state_pwrmgt\":false,\"t\":\"sta\",\"tx_bytes\":1415776519,\"tx_bytes.d\":0,\"tx_bytes.r\":0,\"tx_dropped\":0,\"tx_dropped.d\":0,\"tx_dropped.r\":0,\"tx_errors\":0,\"tx_errors.d\":0,\"tx_errors.r\":0,\"tx_packets\":940366,\"tx_packets.d\":0,\"tx_packets.r\":0,\"tx_power\":40,\"tx_rate\":58500,\"tx_retries\":0,\"tx_retries.d\":0,\"tx_retries.r\":0,\"uptime\":11059,\"user_id\":\"51cb02ecd0a49dbda105faf0\"},{\"_id\":\"51c9ab95d0a49dbd19a58c0d\",\"_rx_bytes\":14059,\"_rx_crypts\":0,\"_rx_dropped\":0,\"_rx_errors\":0,\"_rx_frags\":0,\"_rx_packets\":75,\"_tx_bytes\":6976,\"_tx_dropped\":0,\"_tx_errors\":0,\"_tx_packets\":24,\"_tx_retries\":0,\"_uptime\":79,\"ap_mac\":\"00:27:22:f6:cf:72\",\"assoc_time\":1372274940,\"auth_time\":-268296082,\"authorized\":true,\"bssid\":\"06:27:22:f7:cf:72\",\"bytes\":21035,\"bytes.d\":14,\"bytes.r\":1,\"ccq\":950,\"channel\":11,\"dhcpend_time\":0,\"dhcpstart_time\":207,\"essid\":\"Vtex - Office\",\"first_seen\":1372171157,\"hostname\":\"GabrielPhone\",\"idletime\":2,\"ip\":\"10.1.12.126\",\"is_11a\":null,\"is_11b\":null,\"is_11n\":true,\"is_guest\":false,\"last_seen\":1372275018,\"mac\":\"a8:44:81:83:bf:8c\",\"map_id\":\"51c35aef98079dbd2b583804\",\"noise\":-95,\"oui\":\"\",\"powersave_enabled\":true,\"qos_policy_applied\":true,\"radio\":\"ng\",\"rssi\":24,\"rx_bytes\":14059,\"rx_bytes.d\":14,\"rx_bytes.r\":1,\"rx_crypts\":0,\"rx_crypts.d\":0,\"rx_crypts.r\":0,\"rx_dropped\":0,\"rx_dropped.d\":0,\"rx_dropped.r\":0,\"rx_errors\":0,\"rx_errors.d\":0,\"rx_errors.r\":0,\"rx_frags\":0,\"rx_frags.d\":0,\"rx_frags.r\":0,\"rx_packets\":75,\"rx_packets.d\":1,\"rx_packets.r\":0,\"rx_rate\":1000,\"signal\":-71,\"state\":47,\"state_ht\":true,\"state_pwrmgt\":false,\"t\":\"sta\",\"tx_bytes\":6976,\"tx_bytes.d\":0,\"tx_bytes.r\":0,\"tx_dropped\":0,\"tx_dropped.d\":0,\"tx_dropped.r\":0,\"tx_errors\":0,\"tx_errors.d\":0,\"tx_errors.r\":0,\"tx_packets\":24,\"tx_packets.d\":0,\"tx_packets.r\":0,\"tx_power\":40,\"tx_rate\":58500,\"tx_retries\":0,\"tx_retries.d\":0,\"tx_retries.r\":0,\"uptime\":78,\"user_id\":\"51c9ab95d0a49dbd19a58c0d\"},{\"_id\":\"51c9cca8d0a49dbd3104faf0\",\"_rx_bytes\":132567,\"_rx_crypts\":0,\"_rx_dropped\":0,\"_rx_errors\":0,\"_rx_frags\":0,\"_rx_packets\":4470,\"_tx_bytes\":140232,\"_tx_dropped\":0,\"_tx_errors\":0,\"_tx_packets\":1405,\"_tx_retries\":0,\"_uptime\":6650,\"ap_mac\":\"00:27:22:f6:d2:53\",\"assoc_time\":1372268373,\"auth_time\":-162388283,\"authorized\":true,\"bssid\":\"06:27:22:f7:d2:53\",\"bytes\":272799,\"bytes.d\":758,\"bytes.r\":75,\"ccq\":30,\"channel\":1,\"dhcpend_time\":0,\"dhcpstart_time\":0,\"essid\":\"Vtex - Office\",\"first_seen\":1372179624,\"hostname\":\"android-8f836c3db89c990d\",\"idletime\":0,\"ip\":\"10.1.12.210\",\"is_11a\":null,\"is_11b\":null,\"is_11n\":true,\"is_guest\":false,\"last_seen\":1372275023,\"mac\":\"b0:79:94:9b:97:12\",\"map_id\":\"51c35aef98079dbd2b583804\",\"noise\":-93,\"oui\":\"\",\"powersave_enabled\":true,\"qos_policy_applied\":true,\"radio\":\"ng\",\"rssi\":37,\"rx_bytes\":132567,\"rx_bytes.d\":434,\"rx_bytes.r\":43,\"rx_crypts\":0,\"rx_crypts.d\":0,\"rx_crypts.r\":0,\"rx_dropped\":0,\"rx_dropped.d\":0,\"rx_dropped.r\":0,\"rx_errors\":0,\"rx_errors.d\":0,\"rx_errors.r\":0,\"rx_frags\":0,\"rx_frags.d\":0,\"rx_frags.r\":0,\"rx_packets\":4470,\"rx_packets.d\":19,\"rx_packets.r\":1,\"rx_rate\":65000,\"signal\":-56,\"state\":63,\"state_ht\":true,\"state_pwrmgt\":true,\"t\":\"sta\",\"tx_bytes\":140232,\"tx_bytes.d\":324,\"tx_bytes.r\":32,\"tx_dropped\":0,\"tx_dropped.d\":0,\"tx_dropped.r\":0,\"tx_errors\":0,\"tx_errors.d\":0,\"tx_errors.r\":0,\"tx_packets\":1405,\"tx_packets.d\":6,\"tx_packets.r\":0,\"tx_power\":40,\"tx_rate\":1000,\"tx_retries\":0,\"tx_retries.d\":0,\"tx_retries.r\":0,\"uptime\":6650,\"user_id\":\"51c9cca8d0a49dbd3104faf0\"},{\"_id\":\"51c9ab95d0a49dbd1aa58c0d\",\"_rx_bytes\":401057,\"_rx_crypts\":0,\"_rx_dropped\":0,\"_rx_errors\":0,\"_rx_frags\":0,\"_rx_packets\":3900,\"_tx_bytes\":4250653,\"_tx_dropped\":0,\"_tx_errors\":0,\"_tx_packets\":3927,\"_tx_retries\":0,\"_uptime\":1348,\"ap_mac\":\"00:27:22:f6:d2:53\",\"assoc_time\":1372265349,\"auth_time\":-159363700,\"authorized\":true,\"bssid\":\"06:27:22:f7:d2:53\",\"bytes\":8018558,\"bytes.d\":3339,\"bytes.r\":333,\"ccq\":800,\"channel\":1,\"dhcpend_time\":0,\"dhcpstart_time\":205,\"essid\":\"Vtex - Office\",\"first_seen\":1372171157,\"hostname\":\"android-4afc178518a2204f\",\"idletime\":4,\"ip\":\"10.1.12.129\",\"is_11a\":null,\"is_11b\":null,\"is_11n\":true,\"is_guest\":false,\"last_seen\":1372275023,\"mac\":\"b0:79:94:b8:09:13\",\"map_id\":\"51c35aef98079dbd2b583804\",\"noise\":-93,\"oui\":\"\",\"powersave_enabled\":false,\"qos_policy_applied\":true,\"radio\":\"ng\",\"rssi\":34,\"rx_bytes\":1415223,\"rx_bytes.d\":1521,\"rx_bytes.r\":152,\"rx_crypts\":0,\"rx_crypts.d\":0,\"rx_crypts.r\":0,\"rx_dropped\":0,\"rx_dropped.d\":0,\"rx_dropped.r\":0,\"rx_errors\":0,\"rx_errors.d\":0,\"rx_errors.r\":0,\"rx_frags\":0,\"rx_frags.d\":0,\"rx_frags.r\":0,\"rx_packets\":10633,\"rx_packets.d\":13,\"rx_packets.r\":1,\"rx_rate\":58500,\"signal\":-59,\"state\":47,\"state_ht\":true,\"state_pwrmgt\":false,\"t\":\"sta\",\"tx_bytes\":6603335,\"tx_bytes.d\":1818,\"tx_bytes.r\":181,\"tx_dropped\":0,\"tx_dropped.d\":0,\"tx_dropped.r\":0,\"tx_errors\":0,\"tx_errors.d\":0,\"tx_errors.r\":0,\"tx_packets\":10322,\"tx_packets.d\":16,\"tx_packets.r\":1,\"tx_power\":40,\"tx_rate\":52000,\"tx_retries\":0,\"tx_retries.d\":0,\"tx_retries.r\":0,\"uptime\":9674,\"user_id\":\"51c9ab95d0a49dbd1aa58c0d\"}],\"meta\":{\"rc\":\"ok\"}}";

        [Test]
        public void FindStaByOui()
        {
            var result = UnifiStaResponseBuilder.CreateUnifiStaResponse(JsonResult);

            var oui = "SamsungE";

            var expectedSta = new UnifiSta()
            {
                oui = oui,
                noise = -95,
                signal = -69,
                ap_mac = "00:27:22:f6:cf:72"
                
            };

            var fulano = result.GetByOui(oui);

            Assert.AreEqual(expectedSta, fulano);

        }
        
    }
   
}
