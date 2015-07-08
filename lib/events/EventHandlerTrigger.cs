﻿/*
* Copyright (C) 2013 Doubango Telecom <http://www.doubango.org>
* License: GPLv3
* This file is part of Open Source Thialgou project <http://code.google.com/p/thialgou/>
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thialgou.lib.events
{
    /// <summary>
    /// Helper class to handle event triggering.
    /// </summary>
    public static class EventHandlerTrigger
    {
        /// <summary>
        /// Check that the event handler is not null, and trigger this event with the given
        /// source and an <see cref="EventArgs.Empty"/>.
        /// </summary>
        /// <param name="handler">The event handler to trigger</param>
        /// <param name="source">The source to use</param>
        public static void TriggerEvent(EventHandler handler, Object source)
        {
            if (handler != null)
            {
                handler(source, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Check that the event handler is not null, and trigger this event with the given source
        /// and event data. This method has been made generic to handle all the <see cref="EventArgs"/>.
        /// </summary>
        /// <param name="handler">The event handler to trigger</param>
        /// <param name="source">The source to use</param>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        public static void TriggerEvent<T>(EventHandler<T> handler, Object source, T args) where T : EventArgs
        {
            if (handler != null)
            {
                handler(source, args);
            }
        }

        public static void TriggerEventAsync<T>(EventHandler<T> handler, Object source, T args) where T : EventArgs
        {
            if (handler != null)
            {
                new System.Threading.Thread(delegate()
                {
                    handler(source, args);
                })
                .Start();
            }
        }
    }
}
