﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJs.Blazor.Interop
{
    /// <summary>
    /// Defines that a callback parameter will be set to its default value instead of the deserialized
    /// chart.js value. Can be applied to parameters of methods passed to a <see cref="DelegateHandler{T}"/>.
    /// Use this attribute to improve performance by applying it to parameters that are expected to have
    /// a large size like the 'chartData' parameter of <see cref="ChartJS.Common.Handlers.LegendLabelFilter"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
    public sealed class IgnoreCallbackValueAttribute : Attribute
    {
        /// <summary>
        /// Creates a new instance of the <see cref="IgnoreCallbackValueAttribute" /> class.
        /// </summary>
        public IgnoreCallbackValueAttribute()
        {
        }
    }
}