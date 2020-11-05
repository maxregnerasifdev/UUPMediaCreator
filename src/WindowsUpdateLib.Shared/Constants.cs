﻿namespace WindowsUpdateLib
{
    public static class Constants
    {
        public const string ClientWebServiceServerNamespace     = "http://www.microsoft.com/SoftwareDistribution/Server/ClientWebService";
        public const string WindowsUpdateAuthorizationSchema    = "http://schemas.microsoft.com/msus/2014/10/WindowsUpdateAuthorization";
        public const string Endpoint                            = "https://fe3cr.delivery.mp.microsoft.com/ClientWebService/client.asmx";
        public const string ClientProtocolVersion               = "2.41";
        public const string OldCookieExpiration                 = "2016-07-27T07:18:09Z";
        public const string LastChangeDate                      = "2015-10-21T17:01:07.1472913Z";
        public const string SecurityExpirationTimestamp         = "2044-08-02T20:09:03Z";

        public static readonly string Action                    = $"{ClientWebServiceServerNamespace}/";
        public static readonly string UserAgent                 = $"Windows-Update-Agent/10.0.10011.16384 Client-Protocol/{ClientProtocolVersion}";
        public static readonly int[] InstalledNonLeafUpdateIDs  = new int[]
        {
            1,
            2,
            3,
            10,
            11,
            17,
            19,
            2359974,
            2359977,
            5143990,
            5169043,
            5169044,
            5169047,
            8788830,
            8806526,
            9125350,
            9154769,
            10809856,
            23110993,
            23110994,
            23110995,
            23110996,
            23110999,
            23111000,
            23111001,
            23111002,
            23111003,
            23111004,
            24513870,
            28880263,
            30077688,
            30486944,
            59830006,
            59830007,
            59830008,
            60484010,
            62450018,
            62450019,
            62450020,
            98959022,
            98959023,
            98959024,
            98959025,
            98959026,
            105939029,
            105995585,
            106017178,
            107825194,
            117765322,
            129905029,
            130040030,
            130040031,
            130040032,
            130040033,
            133399034,
            138372035,
            138372036,
            139536037,
            139536038,
            139536039,
            139536040,
            142045136,
            158941041,
            158941042,
            158941043,
            158941044,
            159776047,
            160733048,
            160733049,
            160733050,
            160733051,
            160733055,
            160733056,
            161870057,
            161870058,
            161870059
            /*0,
            2,
            117765322,
            106017178,
            105939029,
            142045136,
            142046142,
            105984757,
            105995585,
            107825194,
            140377312,
            140367832,
            138380194,
            138378071,
            140406050,
            140423713,
            140422973,
            140421668,
            138380128,
            10,
            11,
            133399034,
            2359977,
            31209591,
            31213588,
            31211625,
            105379574,
            31212713,
            105370746,
            31220302,
            31220279,
            105376634,
            31207585,
            31219420,
            90199702,
            105368563,
            31218518,
            90212090,
            5169044,
            31197811,
            31205557,
            105362613,
            105378752,
            31202713,
            31222086,
            30530962,
            105373615,
            105364552,
            31208451,
            105373503,
            8806526,
            31258008,
            31208440,
            31190936,
            105377546,
            105369591,
            31210536,
            31203522,
            105381626,
            31198836,
            105382587,
            59830009*/
            /*1,
            2,
            3,
            10,
            11,
            17,
            19,
            2359974,
            2359977,
            5143990,
            5169043,
            5169044,
            5169047,
            8788830,
            8806526,
            9125350,
            9154769,
            10809856,
            23110993,
            23110994,
            23110995,
            23110996,
            23110999,
            23111000,
            23111001,
            23111002,
            23111003,
            23111004,
            24513870,
            28880263,
            30077688,
            30486944,
            59830006,
            59830007,
            59830008,
            60484010,
            62450018,
            62450019,
            62450020,
            69801474,
            98959022,
            98959023,
            98959024,
            98959025,
            98959026,
            105939029,
            105995585,
            106017178,
            107825194,
            117765322,
            129905029,
            130040030,
            130040031,
            130040032,
            130040033,
            133399034,
            138372035,
            138372036,
            139536037,
            139536038,
            139536039,
            139536040,
            142045136,
            158941041,
            158941042,
            158941043,
            158941044,
            159776047,
            160733048,
            160733049,
            160733050,
            160733051,
            160733055,
            160733056,
            161870057,
            161870058,
            161870059,*/
        };
    }
}