﻿// Copyright (c) Jeremy W. Kuhne. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace WInterop.Windows
{
    // https://msdn.microsoft.com/en-us/library/windows/desktop/ms724947.aspx
    public enum SystemParameterType : uint
    {
        SPI_GETBEEP                     = 0x0001,
        SPI_SETBEEP                     = 0x0002,
        SPI_GETMOUSE                    = 0x0003,
        SPI_SETMOUSE                    = 0x0004,
        SPI_GETBORDER                   = 0x0005,
        SPI_SETBORDER                   = 0x0006,
        SPI_GETKEYBOARDSPEED            = 0x000A,
        SPI_SETKEYBOARDSPEED            = 0x000B,
        SPI_LANGDRIVER                  = 0x000C,
        SPI_ICONHORIZONTALSPACING       = 0x000D,
        SPI_GETSCREENSAVETIMEOUT        = 0x000E,
        SPI_SETSCREENSAVETIMEOUT        = 0x000F,
        SPI_GETSCREENSAVEACTIVE         = 0x0010,
        SPI_SETSCREENSAVEACTIVE         = 0x0011,
        SPI_GETGRIDGRANULARITY          = 0x0012,
        SPI_SETGRIDGRANULARITY          = 0x0013,
        SPI_SETDESKWALLPAPER            = 0x0014,
        SPI_SETDESKPATTERN              = 0x0015,
        SPI_GETKEYBOARDDELAY            = 0x0016,
        SPI_SETKEYBOARDDELAY            = 0x0017,
        SPI_ICONVERTICALSPACING         = 0x0018,
        SPI_GETICONTITLEWRAP            = 0x0019,
        SPI_SETICONTITLEWRAP            = 0x001A,
        SPI_GETMENUDROPALIGNMENT        = 0x001B,
        SPI_SETMENUDROPALIGNMENT        = 0x001C,
        SPI_SETDOUBLECLKWIDTH           = 0x001D,
        SPI_SETDOUBLECLKHEIGHT          = 0x001E,
        SPI_GETICONTITLELOGFONT         = 0x001F,
        SPI_SETDOUBLECLICKTIME          = 0x0020,
        SPI_SETMOUSEBUTTONSWAP          = 0x0021,
        SPI_SETICONTITLELOGFONT         = 0x0022,
        SPI_GETFASTTASKSWITCH           = 0x0023,
        SPI_SETFASTTASKSWITCH           = 0x0024,
        SPI_SETDRAGFULLWINDOWS          = 0x0025,
        SPI_GETDRAGFULLWINDOWS          = 0x0026,
        SPI_GETNONCLIENTMETRICS         = 0x0029,
        SPI_SETNONCLIENTMETRICS         = 0x002A,
        SPI_GETMINIMIZEDMETRICS         = 0x002B,
        SPI_SETMINIMIZEDMETRICS         = 0x002C,
        SPI_GETICONMETRICS              = 0x002D,
        SPI_SETICONMETRICS              = 0x002E,
        SPI_SETWORKAREA                 = 0x002F,
        SPI_GETWORKAREA                 = 0x0030,
        SPI_SETPENWINDOWS               = 0x0031,
        SPI_GETHIGHCONTRAST             = 0x0042,
        SPI_SETHIGHCONTRAST             = 0x0043,
        SPI_GETKEYBOARDPREF             = 0x0044,
        SPI_SETKEYBOARDPREF             = 0x0045,
        SPI_GETSCREENREADER             = 0x0046,
        SPI_SETSCREENREADER             = 0x0047,
        SPI_GETANIMATION                = 0x0048,
        SPI_SETANIMATION                = 0x0049,
        SPI_GETFONTSMOOTHING            = 0x004A,
        SPI_SETFONTSMOOTHING            = 0x004B,
        SPI_SETDRAGWIDTH                = 0x004C,
        SPI_SETDRAGHEIGHT               = 0x004D,
        SPI_SETHANDHELD                 = 0x004E,
        SPI_GETLOWPOWERTIMEOUT          = 0x004F,
        SPI_GETPOWEROFFTIMEOUT          = 0x0050,
        SPI_SETLOWPOWERTIMEOUT          = 0x0051,
        SPI_SETPOWEROFFTIMEOUT          = 0x0052,
        SPI_GETLOWPOWERACTIVE           = 0x0053,
        SPI_GETPOWEROFFACTIVE           = 0x0054,
        SPI_SETLOWPOWERACTIVE           = 0x0055,
        SPI_SETPOWEROFFACTIVE           = 0x0056,
        SPI_SETCURSORS                  = 0x0057,
        SPI_SETICONS                    = 0x0058,
        SPI_GETDEFAULTINPUTLANG         = 0x0059,
        SPI_SETDEFAULTINPUTLANG         = 0x005A,
        SPI_SETLANGTOGGLE               = 0x005B,
        SPI_GETWINDOWSEXTENSION         = 0x005C,
        SPI_SETMOUSETRAILS              = 0x005D,
        SPI_GETMOUSETRAILS              = 0x005E,
        SPI_SETSCREENSAVERRUNNING       = 0x0061,
        SPI_SCREENSAVERRUNNING          = SPI_SETSCREENSAVERRUNNING,
        SPI_GETFILTERKEYS               = 0x0032,
        SPI_SETFILTERKEYS               = 0x0033,
        SPI_GETTOGGLEKEYS               = 0x0034,
        SPI_SETTOGGLEKEYS               = 0x0035,
        SPI_GETMOUSEKEYS                = 0x0036,
        SPI_SETMOUSEKEYS                = 0x0037,
        SPI_GETSHOWSOUNDS               = 0x0038,
        SPI_SETSHOWSOUNDS               = 0x0039,
        SPI_GETSTICKYKEYS               = 0x003A,
        SPI_SETSTICKYKEYS               = 0x003B,
        SPI_GETACCESSTIMEOUT            = 0x003C,
        SPI_SETACCESSTIMEOUT            = 0x003D,
        SPI_GETSERIALKEYS               = 0x003E,
        SPI_SETSERIALKEYS               = 0x003F,
        SPI_GETSOUNDSENTRY              = 0x0040,
        SPI_SETSOUNDSENTRY              = 0x0041,
        SPI_GETSNAPTODEFBUTTON          = 0x005F,
        SPI_SETSNAPTODEFBUTTON          = 0x0060,
        SPI_GETMOUSEHOVERWIDTH          = 0x0062,
        SPI_SETMOUSEHOVERWIDTH          = 0x0063,
        SPI_GETMOUSEHOVERHEIGHT         = 0x0064,
        SPI_SETMOUSEHOVERHEIGHT         = 0x0065,
        SPI_GETMOUSEHOVERTIME           = 0x0066,
        SPI_SETMOUSEHOVERTIME           = 0x0067,
        SPI_GETWHEELSCROLLLINES         = 0x0068,
        SPI_SETWHEELSCROLLLINES         = 0x0069,
        SPI_GETMENUSHOWDELAY            = 0x006A,
        SPI_SETMENUSHOWDELAY            = 0x006B,
        SPI_GETWHEELSCROLLCHARS         = 0x006C,
        SPI_SETWHEELSCROLLCHARS         = 0x006D,
        SPI_GETSHOWIMEUI                = 0x006E,
        SPI_SETSHOWIMEUI                = 0x006F,
        SPI_GETMOUSESPEED               = 0x0070,
        SPI_SETMOUSESPEED               = 0x0071,
        SPI_GETSCREENSAVERRUNNING       = 0x0072,
        SPI_GETDESKWALLPAPER            = 0x0073,
        SPI_GETAUDIODESCRIPTION         = 0x0074,
        SPI_SETAUDIODESCRIPTION         = 0x0075,
        SPI_GETSCREENSAVESECURE         = 0x0076,
        SPI_SETSCREENSAVESECURE         = 0x0077,
        SPI_GETHUNGAPPTIMEOUT           = 0x0078,
        SPI_SETHUNGAPPTIMEOUT           = 0x0079,
        SPI_GETWAITTOKILLTIMEOUT        = 0x007A,
        SPI_SETWAITTOKILLTIMEOUT        = 0x007B,
        SPI_GETWAITTOKILLSERVICETIMEOUT = 0x007C,
        SPI_SETWAITTOKILLSERVICETIMEOUT = 0x007D,
        SPI_GETMOUSEDOCKTHRESHOLD       = 0x007E,
        SPI_SETMOUSEDOCKTHRESHOLD       = 0x007F,
        SPI_GETPENDOCKTHRESHOLD         = 0x0080,
        SPI_SETPENDOCKTHRESHOLD         = 0x0081,
        SPI_GETWINARRANGING             = 0x0082,
        SPI_SETWINARRANGING             = 0x0083,
        SPI_GETMOUSEDRAGOUTTHRESHOLD    = 0x0084,
        SPI_SETMOUSEDRAGOUTTHRESHOLD    = 0x0085,
        SPI_GETPENDRAGOUTTHRESHOLD      = 0x0086,
        SPI_SETPENDRAGOUTTHRESHOLD      = 0x0087,
        SPI_GETMOUSESIDEMOVETHRESHOLD   = 0x0088,
        SPI_SETMOUSESIDEMOVETHRESHOLD   = 0x0089,
        SPI_GETPENSIDEMOVETHRESHOLD     = 0x008A,
        SPI_SETPENSIDEMOVETHRESHOLD     = 0x008B,
        SPI_GETDRAGFROMMAXIMIZE         = 0x008C,
        SPI_SETDRAGFROMMAXIMIZE         = 0x008D,
        SPI_GETSNAPSIZING               = 0x008E,
        SPI_SETSNAPSIZING               = 0x008F,
        SPI_GETDOCKMOVING               = 0x0090,
        SPI_SETDOCKMOVING               = 0x0091,
        SPI_GETTOUCHPREDICTIONPARAMETERS    = 0x009C,
        SPI_SETTOUCHPREDICTIONPARAMETERS    = 0x009D,
        SPI_GETLOGICALDPIOVERRIDE           = 0x009E,
        SPI_SETLOGICALDPIOVERRIDE           = 0x009F,
        SPI_GETMENURECT                     = 0x00A2,
        SPI_SETMENURECT                     = 0x00A3,
        SPI_GETACTIVEWINDOWTRACKING         = 0x1000,
        SPI_SETACTIVEWINDOWTRACKING         = 0x1001,
        SPI_GETMENUANIMATION                = 0x1002,
        SPI_SETMENUANIMATION                = 0x1003,
        SPI_GETCOMBOBOXANIMATION            = 0x1004,
        SPI_SETCOMBOBOXANIMATION            = 0x1005,
        SPI_GETLISTBOXSMOOTHSCROLLING       = 0x1006,
        SPI_SETLISTBOXSMOOTHSCROLLING       = 0x1007,
        SPI_GETGRADIENTCAPTIONS             = 0x1008,
        SPI_SETGRADIENTCAPTIONS             = 0x1009,
        SPI_GETKEYBOARDCUES                 = 0x100A,
        SPI_SETKEYBOARDCUES                 = 0x100B,
        SPI_GETMENUUNDERLINES               = SPI_GETKEYBOARDCUES,
        SPI_SETMENUUNDERLINES               = SPI_SETKEYBOARDCUES,
        SPI_GETACTIVEWNDTRKZORDER           = 0x100C,
        SPI_SETACTIVEWNDTRKZORDER           = 0x100D,
        SPI_GETHOTTRACKING                  = 0x100E,
        SPI_SETHOTTRACKING                  = 0x100F,
        SPI_GETMENUFADE                     = 0x1012,
        SPI_SETMENUFADE                     = 0x1013,
        SPI_GETSELECTIONFADE                = 0x1014,
        SPI_SETSELECTIONFADE                = 0x1015,
        SPI_GETTOOLTIPANIMATION             = 0x1016,
        SPI_SETTOOLTIPANIMATION             = 0x1017,
        SPI_GETTOOLTIPFADE                  = 0x1018,
        SPI_SETTOOLTIPFADE                  = 0x1019,
        SPI_GETCURSORSHADOW                 = 0x101A,
        SPI_SETCURSORSHADOW                 = 0x101B,
        SPI_GETMOUSESONAR                   = 0x101C,
        SPI_SETMOUSESONAR                   = 0x101D,
        SPI_GETMOUSECLICKLOCK               = 0x101E,
        SPI_SETMOUSECLICKLOCK               = 0x101F,
        SPI_GETMOUSEVANISH                  = 0x1020,
        SPI_SETMOUSEVANISH                  = 0x1021,
        SPI_GETFLATMENU                     = 0x1022,
        SPI_SETFLATMENU                     = 0x1023,
        SPI_GETDROPSHADOW                   = 0x1024,
        SPI_SETDROPSHADOW                   = 0x1025,
        SPI_GETBLOCKSENDINPUTRESETS         = 0x1026,
        SPI_SETBLOCKSENDINPUTRESETS         = 0x1027,
        SPI_GETUIEFFECTS                    = 0x103E,
        SPI_SETUIEFFECTS                    = 0x103F,
        SPI_GETDISABLEOVERLAPPEDCONTENT     = 0x1040,
        SPI_SETDISABLEOVERLAPPEDCONTENT     = 0x1041,
        SPI_GETCLIENTAREAANIMATION          = 0x1042,
        SPI_SETCLIENTAREAANIMATION          = 0x1043,
        SPI_GETCLEARTYPE                    = 0x1048,
        SPI_SETCLEARTYPE                    = 0x1049,
        SPI_GETSPEECHRECOGNITION            = 0x104A,
        SPI_SETSPEECHRECOGNITION            = 0x104B,
        SPI_GETCARETBROWSING                = 0x104C,
        SPI_SETCARETBROWSING                = 0x104D,
        SPI_GETTHREADLOCALINPUTSETTINGS     = 0x104E,
        SPI_SETTHREADLOCALINPUTSETTINGS     = 0x104F,
        SPI_GETSYSTEMLANGUAGEBAR            = 0x1050,
        SPI_SETSYSTEMLANGUAGEBAR            = 0x1051,
        SPI_GETFOREGROUNDLOCKTIMEOUT        = 0x2000,
        SPI_SETFOREGROUNDLOCKTIMEOUT        = 0x2001,
        SPI_GETACTIVEWNDTRKTIMEOUT          = 0x2002,
        SPI_SETACTIVEWNDTRKTIMEOUT          = 0x2003,
        SPI_GETFOREGROUNDFLASHCOUNT         = 0x2004,
        SPI_SETFOREGROUNDFLASHCOUNT         = 0x2005,
        SPI_GETCARETWIDTH                   = 0x2006,
        SPI_SETCARETWIDTH                   = 0x2007,
        SPI_GETMOUSECLICKLOCKTIME           = 0x2008,
        SPI_SETMOUSECLICKLOCKTIME           = 0x2009,
        SPI_GETFONTSMOOTHINGTYPE            = 0x200A,
        SPI_SETFONTSMOOTHINGTYPE            = 0x200B,
        SPI_GETFONTSMOOTHINGCONTRAST        = 0x200C,
        SPI_SETFONTSMOOTHINGCONTRAST        = 0x200D,
        SPI_GETFOCUSBORDERWIDTH             = 0x200E,
        SPI_SETFOCUSBORDERWIDTH             = 0x200F,
        SPI_GETFOCUSBORDERHEIGHT            = 0x2010,
        SPI_SETFOCUSBORDERHEIGHT            = 0x2011,
        SPI_GETFONTSMOOTHINGORIENTATION     = 0x2012,
        SPI_SETFONTSMOOTHINGORIENTATION     = 0x2013,
        SPI_GETMINIMUMHITRADIUS             = 0x2014,
        SPI_SETMINIMUMHITRADIUS             = 0x2015,
        SPI_GETMESSAGEDURATION              = 0x2016,
        SPI_SETMESSAGEDURATION              = 0x2017,
        SPI_GETCONTACTVISUALIZATION         = 0x2018,
        SPI_SETCONTACTVISUALIZATION         = 0x2019,
        SPI_GETGESTUREVISUALIZATION         = 0x201A,
        SPI_SETGESTUREVISUALIZATION         = 0x201B,
        SPI_GETMOUSEWHEELROUTING            = 0x201C,
        SPI_SETMOUSEWHEELROUTING            = 0x201D,
        SPI_GETPENVISUALIZATION             = 0x201E,
        SPI_SETPENVISUALIZATION             = 0x201F,
        SPI_GETPENARBITRATIONTYPE           = 0x2020,
        SPI_SETPENARBITRATIONTYPE           = 0x2021
    }
}