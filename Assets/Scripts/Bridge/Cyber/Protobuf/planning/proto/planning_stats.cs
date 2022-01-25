// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: planning_stats.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class StatsGroup : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public StatsGroup()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double max
        {
            get { return __pbn__max.GetValueOrDefault(); }
            set { __pbn__max = value; }
        }
        public bool ShouldSerializemax()
        {
            return __pbn__max != null;
        }
        public void Resetmax()
        {
            __pbn__max = null;
        }
        private double? __pbn__max;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(10000000000)]
        public double min
        {
            get { return __pbn__min ?? 10000000000; }
            set { __pbn__min = value; }
        }
        public bool ShouldSerializemin()
        {
            return __pbn__min != null;
        }
        public void Resetmin()
        {
            __pbn__min = null;
        }
        private double? __pbn__min;

        [global::ProtoBuf.ProtoMember(3)]
        public double sum
        {
            get { return __pbn__sum.GetValueOrDefault(); }
            set { __pbn__sum = value; }
        }
        public bool ShouldSerializesum()
        {
            return __pbn__sum != null;
        }
        public void Resetsum()
        {
            __pbn__sum = null;
        }
        private double? __pbn__sum;

        [global::ProtoBuf.ProtoMember(4)]
        public double avg
        {
            get { return __pbn__avg.GetValueOrDefault(); }
            set { __pbn__avg = value; }
        }
        public bool ShouldSerializeavg()
        {
            return __pbn__avg != null;
        }
        public void Resetavg()
        {
            __pbn__avg = null;
        }
        private double? __pbn__avg;

        [global::ProtoBuf.ProtoMember(5)]
        public int num
        {
            get { return __pbn__num.GetValueOrDefault(); }
            set { __pbn__num = value; }
        }
        public bool ShouldSerializenum()
        {
            return __pbn__num != null;
        }
        public void Resetnum()
        {
            __pbn__num = null;
        }
        private int? __pbn__num;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PlanningStats : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PlanningStats()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public StatsGroup total_path_length { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public StatsGroup total_path_time { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public StatsGroup v { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public StatsGroup a { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public StatsGroup kappa { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public StatsGroup dkappa { get; set; }

    }

}

#pragma warning restore 0612, 1591, 3021
