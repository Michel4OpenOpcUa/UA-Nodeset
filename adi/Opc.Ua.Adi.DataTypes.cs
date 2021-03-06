/* ========================================================================
 * Copyright (c) 2005-2016 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua.Di;
using Opc.Ua;

namespace Opc.Ua.Adi
{
    #region ExecutionCycleEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_ExecutionCycleEnumeration)
    /// <summary>
    /// A description for the ExecutionCycleEnumeration DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Adi.Namespaces.OpcUaAdiXsd)]
    public enum ExecutionCycleEnumeration
    {
        /// <summary>
        /// Idle, no cleaning or acquisition cycle in progress
        /// </summary>
        [EnumMember(Value = "IDLE_0")]
        IDLE = 0,

        /// <summary>
        /// Scquisition cycle collecting data for diagnostic purpose
        /// </summary>
        [EnumMember(Value = "DIAGNOSTIC_1")]
        DIAGNOSTIC = 1,

        /// <summary>
        /// Cleaning cycle
        /// </summary>
        [EnumMember(Value = "CLEANING_2")]
        CLEANING = 2,

        /// <summary>
        /// Calibration acquisition cycle
        /// </summary>
        [EnumMember(Value = "CALIBRATION_4")]
        CALIBRATION = 4,

        /// <summary>
        /// Validation acquisition cycle
        /// </summary>
        [EnumMember(Value = "VALIDATION_8")]
        VALIDATION = 8,

        /// <summary>
        /// Sample acquisition cycle
        /// </summary>
        [EnumMember(Value = "SAMPLING_16")]
        SAMPLING = 16,

        /// <summary>
        /// Scquisition cycle collecting data for diagnostic purpose and sample is extracted from the process to be sent in control lab
        /// </summary>
        [EnumMember(Value = "DIAGNOSTIC_WITH_GRAB_SAMPLE_32769")]
        DIAGNOSTIC_WITH_GRAB_SAMPLE = 32769,

        /// <summary>
        /// Cleaning cycle with or without acquisition and sample is extracted from the process to be sent in control lab
        /// </summary>
        [EnumMember(Value = "CLEANING_WITH_GRAB_SAMPLE_32770")]
        CLEANING_WITH_GRAB_SAMPLE = 32770,

        /// <summary>
        /// Calibration acquisition cycle and sample is extracted from the process to be sent in control lab
        /// </summary>
        [EnumMember(Value = "CALIBRATION_WITH_GRAB_SAMPLE_32772")]
        CALIBRATION_WITH_GRAB_SAMPLE = 32772,

        /// <summary>
        /// Validation acquisition cycle and sample is extracted from the process to be sent in control lab
        /// </summary>
        [EnumMember(Value = "VALIDATION_WITH_GRAB_SAMPLE_32776")]
        VALIDATION_WITH_GRAB_SAMPLE = 32776,

        /// <summary>
        /// Sample acquisition cycle and sample is extracted from the process to be sent in control lab
        /// </summary>
        [EnumMember(Value = "SAMPLING_WITH_GRAB_SAMPLE_32784")]
        SAMPLING_WITH_GRAB_SAMPLE = 32784,
    }

    #region ExecutionCycleEnumerationCollection Class
    /// <summary>
    /// A collection of ExecutionCycleEnumeration objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfExecutionCycleEnumeration", Namespace = Opc.Ua.Adi.Namespaces.OpcUaAdiXsd, ItemName = "ExecutionCycleEnumeration")]
    #if !NET_STANDARD
    public partial class ExecutionCycleEnumerationCollection : List<ExecutionCycleEnumeration>, ICloneable
    #else
    public partial class ExecutionCycleEnumerationCollection : List<ExecutionCycleEnumeration>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ExecutionCycleEnumerationCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ExecutionCycleEnumerationCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ExecutionCycleEnumerationCollection(IEnumerable<ExecutionCycleEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ExecutionCycleEnumerationCollection(ExecutionCycleEnumeration[] values)
        {
            if (values != null)
            {
                return new ExecutionCycleEnumerationCollection(values);
            }

            return new ExecutionCycleEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ExecutionCycleEnumeration[](ExecutionCycleEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (ExecutionCycleEnumerationCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ExecutionCycleEnumerationCollection clone = new ExecutionCycleEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ExecutionCycleEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AcquisitionResultStatusEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_AcquisitionResultStatusEnumeration)
    /// <summary>
    /// A description for the AcquisitionResultStatusEnumeration DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Adi.Namespaces.OpcUaAdiXsd)]
    public enum AcquisitionResultStatusEnumeration
    {
        /// <summary>
        /// No longer used.
        /// </summary>
        [EnumMember(Value = "NOT_USED_0")]
        NOT_USED = 0,

        /// <summary>
        /// The acquisition has been completed as requested without any error.
        /// </summary>
        [EnumMember(Value = "GOOD_1")]
        GOOD = 1,

        /// <summary>
        /// The acquisition has been completed as requested with error.
        /// </summary>
        [EnumMember(Value = "BAD_2")]
        BAD = 2,

        /// <summary>
        /// The acquisition has been completed but nothing can be said about the quality of the result.
        /// </summary>
        [EnumMember(Value = "UNKNOWN_3")]
        UNKNOWN = 3,

        /// <summary>
        /// The acquisition has been partially completed as requested without any error.
        /// </summary>
        [EnumMember(Value = "PARTIAL_4")]
        PARTIAL = 4,
    }

    #region AcquisitionResultStatusEnumerationCollection Class
    /// <summary>
    /// A collection of AcquisitionResultStatusEnumeration objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAcquisitionResultStatusEnumeration", Namespace = Opc.Ua.Adi.Namespaces.OpcUaAdiXsd, ItemName = "AcquisitionResultStatusEnumeration")]
    #if !NET_STANDARD
    public partial class AcquisitionResultStatusEnumerationCollection : List<AcquisitionResultStatusEnumeration>, ICloneable
    #else
    public partial class AcquisitionResultStatusEnumerationCollection : List<AcquisitionResultStatusEnumeration>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public AcquisitionResultStatusEnumerationCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public AcquisitionResultStatusEnumerationCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public AcquisitionResultStatusEnumerationCollection(IEnumerable<AcquisitionResultStatusEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator AcquisitionResultStatusEnumerationCollection(AcquisitionResultStatusEnumeration[] values)
        {
            if (values != null)
            {
                return new AcquisitionResultStatusEnumerationCollection(values);
            }

            return new AcquisitionResultStatusEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator AcquisitionResultStatusEnumeration[](AcquisitionResultStatusEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (AcquisitionResultStatusEnumerationCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AcquisitionResultStatusEnumerationCollection clone = new AcquisitionResultStatusEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AcquisitionResultStatusEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region AlarmStateEnumeration Enumeration
    #if (!OPCUA_EXCLUDE_AlarmStateEnumeration)
    /// <summary>
    /// A description for the AlarmStateEnumeration DataType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Adi.Namespaces.OpcUaAdiXsd)]
    public enum AlarmStateEnumeration
    {
        /// <summary>
        /// Normal
        /// </summary>
        [EnumMember(Value = "NORMAL_0")]
        NORMAL_0 = 0,

        /// <summary>
        /// In low warning range
        /// </summary>
        [EnumMember(Value = "WARNING_LOW_1")]
        WARNING_LOW_1 = 1,

        /// <summary>
        /// In high warning range
        /// </summary>
        [EnumMember(Value = "WARNING_HIGH_2")]
        WARNING_HIGH_2 = 2,

        /// <summary>
        /// In warning range (low or high) or some other warning cause
        /// </summary>
        [EnumMember(Value = "WARNING_4")]
        WARNING_4 = 4,

        /// <summary>
        /// In low alarm range
        /// </summary>
        [EnumMember(Value = "ALARM_LOW_8")]
        ALARM_LOW_8 = 8,

        /// <summary>
        /// In high alarm range
        /// </summary>
        [EnumMember(Value = "ALARM_HIGH_16")]
        ALARM_HIGH_16 = 16,

        /// <summary>
        /// In alarm range (low or high) or some other alarm cause
        /// </summary>
        [EnumMember(Value = "ALARM_32")]
        ALARM_32 = 32,
    }

    #region AlarmStateEnumerationCollection Class
    /// <summary>
    /// A collection of AlarmStateEnumeration objects.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [CollectionDataContract(Name = "ListOfAlarmStateEnumeration", Namespace = Opc.Ua.Adi.Namespaces.OpcUaAdiXsd, ItemName = "AlarmStateEnumeration")]
    #if !NET_STANDARD
    public partial class AlarmStateEnumerationCollection : List<AlarmStateEnumeration>, ICloneable
    #else
    public partial class AlarmStateEnumerationCollection : List<AlarmStateEnumeration>
    #endif
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public AlarmStateEnumerationCollection() {}

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public AlarmStateEnumerationCollection(int capacity) : base(capacity) {}

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public AlarmStateEnumerationCollection(IEnumerable<AlarmStateEnumeration> collection) : base(collection) {}
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator AlarmStateEnumerationCollection(AlarmStateEnumeration[] values)
        {
            if (values != null)
            {
                return new AlarmStateEnumerationCollection(values);
            }

            return new AlarmStateEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator AlarmStateEnumeration[](AlarmStateEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #if !NET_STANDARD
        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            return (AlarmStateEnumerationCollection)this.MemberwiseClone();
        }
        #endregion
        #endif

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            AlarmStateEnumerationCollection clone = new AlarmStateEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AlarmStateEnumeration)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}