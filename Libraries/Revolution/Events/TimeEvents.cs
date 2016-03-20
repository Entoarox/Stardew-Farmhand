﻿using Revolution.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revolution.Events
{
    public class TimeEvents
    {
        public static event EventHandler OnBeforeTimeChanged = delegate { };
        public static event EventHandler OnAfterTimeChanged = delegate { };
        public static event EventHandler OnBeforeDayChanged = delegate { };
        public static event EventHandler OnAfterDayChanged = delegate { };
        public static event EventHandler OnBeforeSeasonChanged = delegate { };
        public static event EventHandler OnAfterSeasonChanged = delegate { };

        public static event EventHandler OnBeforeYearChanged = delegate { };
        public static event EventHandler OnAfterYearChanged = delegate { };

        [Hook(HookType.Entry, "StardewValley.Game1", "performTenMinuteClockUpdate")]
        internal static void InvokeBeforeTimeChanged(Int32 priorInt, Int32 newInt)
        {
            OnBeforeTimeChanged.Invoke(null, EventArgs.Empty);
        }

        [Hook(HookType.Exit, "StardewValley.Game1", "performTenMinuteClockUpdate")]
        internal static void InvokeAfterTimeChanged(Int32 priorInt, Int32 newInt)
        {
            OnAfterTimeChanged.Invoke(null, EventArgs.Empty);
        }

        [Hook(HookType.Entry, "StardewValley.Game1", "newDayAfterFade")]
        internal static void InvokeBeforeDayChanged(Int32 priorInt, Int32 newInt)
        {
            OnBeforeDayChanged.Invoke(null, EventArgs.Empty);
        }
        [Hook(HookType.Exit, "StardewValley.Game1", "newDayAfterFade")]
        internal static void InvokeAfterDayChanged(Int32 priorInt, Int32 newInt)
        {
            OnAfterDayChanged.Invoke(null, EventArgs.Empty);
        }
        
        [Hook(HookType.Entry, "StardewValley.Game1", "newSeason")]
        internal static void InvokeBeforeSeasonChanged(String priorString, String newString)
        {
            OnBeforeSeasonChanged.Invoke(null, EventArgs.Empty);
        }
        [Hook(HookType.Exit, "StardewValley.Game1", "newSeason")]
        internal static void InvokeAfterSeasonChanged(String priorString, String newString)
        {
            OnAfterSeasonChanged.Invoke(null, EventArgs.Empty);
        }
        
        [PendingHook]
        internal static void InvokeBeforeYearChanged(Int32 priorInt, Int32 newInt) 
        {
            throw new NotImplementedException();
        }
        
        [PendingHook]
        internal static void InvokeAfterYearChanged(Int32 priorInt, Int32 newInt)
        {
            throw new NotImplementedException();
        }
    }
}