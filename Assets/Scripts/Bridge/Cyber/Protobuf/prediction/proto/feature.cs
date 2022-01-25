// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: feature.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.prediction
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Lane : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Lane()
        {
            current_lane_feature = new global::System.Collections.Generic.List<LaneFeature>();
            nearby_lane_feature = new global::System.Collections.Generic.List<LaneFeature>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<LaneFeature> current_lane_feature { get; private set; }

        [global::ProtoBuf.ProtoMember(2)]
        public LaneFeature lane_feature { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<LaneFeature> nearby_lane_feature { get; private set; }

        [global::ProtoBuf.ProtoMember(4)]
        public LaneGraph lane_graph { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public LaneGraph lane_graph_ordered { get; set; }

        [global::ProtoBuf.ProtoMember(26)]
        public double label_update_time_delta
        {
            get { return __pbn__label_update_time_delta.GetValueOrDefault(); }
            set { __pbn__label_update_time_delta = value; }
        }
        public bool ShouldSerializelabel_update_time_delta()
        {
            return __pbn__label_update_time_delta != null;
        }
        public void Resetlabel_update_time_delta()
        {
            __pbn__label_update_time_delta = null;
        }
        private double? __pbn__label_update_time_delta;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LaneFeature : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LaneFeature()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string lane_id
        {
            get { return __pbn__lane_id ?? ""; }
            set { __pbn__lane_id = value; }
        }
        public bool ShouldSerializelane_id()
        {
            return __pbn__lane_id != null;
        }
        public void Resetlane_id()
        {
            __pbn__lane_id = null;
        }
        private string __pbn__lane_id;

        [global::ProtoBuf.ProtoMember(2)]
        public uint lane_turn_type
        {
            get { return __pbn__lane_turn_type.GetValueOrDefault(); }
            set { __pbn__lane_turn_type = value; }
        }
        public bool ShouldSerializelane_turn_type()
        {
            return __pbn__lane_turn_type != null;
        }
        public void Resetlane_turn_type()
        {
            __pbn__lane_turn_type = null;
        }
        private uint? __pbn__lane_turn_type;

        [global::ProtoBuf.ProtoMember(3)]
        public double lane_s
        {
            get { return __pbn__lane_s.GetValueOrDefault(); }
            set { __pbn__lane_s = value; }
        }
        public bool ShouldSerializelane_s()
        {
            return __pbn__lane_s != null;
        }
        public void Resetlane_s()
        {
            __pbn__lane_s = null;
        }
        private double? __pbn__lane_s;

        [global::ProtoBuf.ProtoMember(4)]
        public double lane_l
        {
            get { return __pbn__lane_l.GetValueOrDefault(); }
            set { __pbn__lane_l = value; }
        }
        public bool ShouldSerializelane_l()
        {
            return __pbn__lane_l != null;
        }
        public void Resetlane_l()
        {
            __pbn__lane_l = null;
        }
        private double? __pbn__lane_l;

        [global::ProtoBuf.ProtoMember(5)]
        public double angle_diff
        {
            get { return __pbn__angle_diff.GetValueOrDefault(); }
            set { __pbn__angle_diff = value; }
        }
        public bool ShouldSerializeangle_diff()
        {
            return __pbn__angle_diff != null;
        }
        public void Resetangle_diff()
        {
            __pbn__angle_diff = null;
        }
        private double? __pbn__angle_diff;

        [global::ProtoBuf.ProtoMember(6)]
        public double dist_to_left_boundary
        {
            get { return __pbn__dist_to_left_boundary.GetValueOrDefault(); }
            set { __pbn__dist_to_left_boundary = value; }
        }
        public bool ShouldSerializedist_to_left_boundary()
        {
            return __pbn__dist_to_left_boundary != null;
        }
        public void Resetdist_to_left_boundary()
        {
            __pbn__dist_to_left_boundary = null;
        }
        private double? __pbn__dist_to_left_boundary;

        [global::ProtoBuf.ProtoMember(7)]
        public double dist_to_right_boundary
        {
            get { return __pbn__dist_to_right_boundary.GetValueOrDefault(); }
            set { __pbn__dist_to_right_boundary = value; }
        }
        public bool ShouldSerializedist_to_right_boundary()
        {
            return __pbn__dist_to_right_boundary != null;
        }
        public void Resetdist_to_right_boundary()
        {
            __pbn__dist_to_right_boundary = null;
        }
        private double? __pbn__dist_to_right_boundary;

        [global::ProtoBuf.ProtoMember(8)]
        public double lane_heading
        {
            get { return __pbn__lane_heading.GetValueOrDefault(); }
            set { __pbn__lane_heading = value; }
        }
        public bool ShouldSerializelane_heading()
        {
            return __pbn__lane_heading != null;
        }
        public void Resetlane_heading()
        {
            __pbn__lane_heading = null;
        }
        private double? __pbn__lane_heading;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(global::apollo.hdmap.Lane.LaneType.None)]
        public global::apollo.hdmap.Lane.LaneType lane_type
        {
            get { return __pbn__lane_type ?? global::apollo.hdmap.Lane.LaneType.None; }
            set { __pbn__lane_type = value; }
        }
        public bool ShouldSerializelane_type()
        {
            return __pbn__lane_type != null;
        }
        public void Resetlane_type()
        {
            __pbn__lane_type = null;
        }
        private global::apollo.hdmap.Lane.LaneType? __pbn__lane_type;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class JunctionExit : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public JunctionExit()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string exit_lane_id
        {
            get { return __pbn__exit_lane_id ?? ""; }
            set { __pbn__exit_lane_id = value; }
        }
        public bool ShouldSerializeexit_lane_id()
        {
            return __pbn__exit_lane_id != null;
        }
        public void Resetexit_lane_id()
        {
            __pbn__exit_lane_id = null;
        }
        private string __pbn__exit_lane_id;

        [global::ProtoBuf.ProtoMember(2)]
        public global::apollo.common.Point3D exit_position { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public double exit_heading
        {
            get { return __pbn__exit_heading.GetValueOrDefault(); }
            set { __pbn__exit_heading = value; }
        }
        public bool ShouldSerializeexit_heading()
        {
            return __pbn__exit_heading != null;
        }
        public void Resetexit_heading()
        {
            __pbn__exit_heading = null;
        }
        private double? __pbn__exit_heading;

        [global::ProtoBuf.ProtoMember(4)]
        public double exit_width
        {
            get { return __pbn__exit_width.GetValueOrDefault(); }
            set { __pbn__exit_width = value; }
        }
        public bool ShouldSerializeexit_width()
        {
            return __pbn__exit_width != null;
        }
        public void Resetexit_width()
        {
            __pbn__exit_width = null;
        }
        private double? __pbn__exit_width;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class JunctionFeature : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public JunctionFeature()
        {
            junction_exit = new global::System.Collections.Generic.List<JunctionExit>();
            start_lane_id = new global::System.Collections.Generic.List<string>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string junction_id
        {
            get { return __pbn__junction_id ?? ""; }
            set { __pbn__junction_id = value; }
        }
        public bool ShouldSerializejunction_id()
        {
            return __pbn__junction_id != null;
        }
        public void Resetjunction_id()
        {
            __pbn__junction_id = null;
        }
        private string __pbn__junction_id;

        [global::ProtoBuf.ProtoMember(2)]
        public double junction_range
        {
            get { return __pbn__junction_range.GetValueOrDefault(); }
            set { __pbn__junction_range = value; }
        }
        public bool ShouldSerializejunction_range()
        {
            return __pbn__junction_range != null;
        }
        public void Resetjunction_range()
        {
            __pbn__junction_range = null;
        }
        private double? __pbn__junction_range;

        [global::ProtoBuf.ProtoMember(3)]
        public LaneFeature enter_lane { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<JunctionExit> junction_exit { get; private set; }

        [global::ProtoBuf.ProtoMember(5)]
        public double[] junction_mlp_feature { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public int[] junction_mlp_label { get; set; }

        [global::ProtoBuf.ProtoMember(7)]
        public double[] junction_mlp_probability { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public global::System.Collections.Generic.List<string> start_lane_id { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ObstaclePriority : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ObstaclePriority()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(25)]
        [global::System.ComponentModel.DefaultValue(Priority.Normal)]
        public Priority priority
        {
            get { return __pbn__priority ?? Priority.Normal; }
            set { __pbn__priority = value; }
        }
        public bool ShouldSerializepriority()
        {
            return __pbn__priority != null;
        }
        public void Resetpriority()
        {
            __pbn__priority = null;
        }
        private Priority? __pbn__priority;

        [global::ProtoBuf.ProtoContract()]
        public enum Priority
        {
            [global::ProtoBuf.ProtoEnum(Name = @"CAUTION")]
            Caution = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"NORMAL")]
            Normal = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"IGNORE")]
            Ignore = 3,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Trajectory : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Trajectory()
        {
            trajectory_point = new global::System.Collections.Generic.List<global::apollo.common.TrajectoryPoint>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double probability
        {
            get { return __pbn__probability.GetValueOrDefault(); }
            set { __pbn__probability = value; }
        }
        public bool ShouldSerializeprobability()
        {
            return __pbn__probability != null;
        }
        public void Resetprobability()
        {
            __pbn__probability = null;
        }
        private double? __pbn__probability;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<global::apollo.common.TrajectoryPoint> trajectory_point { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Feature : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Feature()
        {
            polygon_point = new global::System.Collections.Generic.List<global::apollo.common.Point3D>();
            future_trajectory_points = new global::System.Collections.Generic.List<PredictionTrajectoryPoint>();
            short_term_predicted_trajectory_points = new global::System.Collections.Generic.List<global::apollo.common.TrajectoryPoint>();
            predicted_trajectory = new global::System.Collections.Generic.List<Trajectory>();
            adc_trajectory_point = new global::System.Collections.Generic.List<global::apollo.common.TrajectoryPoint>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int id
        {
            get { return __pbn__id.GetValueOrDefault(); }
            set { __pbn__id = value; }
        }
        public bool ShouldSerializeid()
        {
            return __pbn__id != null;
        }
        public void Resetid()
        {
            __pbn__id = null;
        }
        private int? __pbn__id;

        [global::ProtoBuf.ProtoMember(30)]
        public global::System.Collections.Generic.List<global::apollo.common.Point3D> polygon_point { get; private set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::apollo.common.Point3D position { get; set; }

        [global::ProtoBuf.ProtoMember(27)]
        public global::apollo.common.Point3D front_position { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public global::apollo.common.Point3D velocity { get; set; }

        [global::ProtoBuf.ProtoMember(28)]
        public global::apollo.common.Point3D raw_velocity { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public global::apollo.common.Point3D acceleration { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public double velocity_heading
        {
            get { return __pbn__velocity_heading.GetValueOrDefault(); }
            set { __pbn__velocity_heading = value; }
        }
        public bool ShouldSerializevelocity_heading()
        {
            return __pbn__velocity_heading != null;
        }
        public void Resetvelocity_heading()
        {
            __pbn__velocity_heading = null;
        }
        private double? __pbn__velocity_heading;

        [global::ProtoBuf.ProtoMember(6)]
        public double speed
        {
            get { return __pbn__speed.GetValueOrDefault(); }
            set { __pbn__speed = value; }
        }
        public bool ShouldSerializespeed()
        {
            return __pbn__speed != null;
        }
        public void Resetspeed()
        {
            __pbn__speed = null;
        }
        private double? __pbn__speed;

        [global::ProtoBuf.ProtoMember(7)]
        public double acc
        {
            get { return __pbn__acc.GetValueOrDefault(); }
            set { __pbn__acc = value; }
        }
        public bool ShouldSerializeacc()
        {
            return __pbn__acc != null;
        }
        public void Resetacc()
        {
            __pbn__acc = null;
        }
        private double? __pbn__acc;

        [global::ProtoBuf.ProtoMember(8)]
        public double theta
        {
            get { return __pbn__theta.GetValueOrDefault(); }
            set { __pbn__theta = value; }
        }
        public bool ShouldSerializetheta()
        {
            return __pbn__theta != null;
        }
        public void Resettheta()
        {
            __pbn__theta = null;
        }
        private double? __pbn__theta;

        [global::ProtoBuf.ProtoMember(9)]
        public double length
        {
            get { return __pbn__length.GetValueOrDefault(); }
            set { __pbn__length = value; }
        }
        public bool ShouldSerializelength()
        {
            return __pbn__length != null;
        }
        public void Resetlength()
        {
            __pbn__length = null;
        }
        private double? __pbn__length;

        [global::ProtoBuf.ProtoMember(10)]
        public double width
        {
            get { return __pbn__width.GetValueOrDefault(); }
            set { __pbn__width = value; }
        }
        public bool ShouldSerializewidth()
        {
            return __pbn__width != null;
        }
        public void Resetwidth()
        {
            __pbn__width = null;
        }
        private double? __pbn__width;

        [global::ProtoBuf.ProtoMember(11)]
        public double height
        {
            get { return __pbn__height.GetValueOrDefault(); }
            set { __pbn__height = value; }
        }
        public bool ShouldSerializeheight()
        {
            return __pbn__height != null;
        }
        public void Resetheight()
        {
            __pbn__height = null;
        }
        private double? __pbn__height;

        [global::ProtoBuf.ProtoMember(12)]
        public double tracking_time
        {
            get { return __pbn__tracking_time.GetValueOrDefault(); }
            set { __pbn__tracking_time = value; }
        }
        public bool ShouldSerializetracking_time()
        {
            return __pbn__tracking_time != null;
        }
        public void Resettracking_time()
        {
            __pbn__tracking_time = null;
        }
        private double? __pbn__tracking_time;

        [global::ProtoBuf.ProtoMember(13)]
        public double timestamp
        {
            get { return __pbn__timestamp.GetValueOrDefault(); }
            set { __pbn__timestamp = value; }
        }
        public bool ShouldSerializetimestamp()
        {
            return __pbn__timestamp != null;
        }
        public void Resettimestamp()
        {
            __pbn__timestamp = null;
        }
        private double? __pbn__timestamp;

        [global::ProtoBuf.ProtoMember(14)]
        public Lane lane { get; set; }

        [global::ProtoBuf.ProtoMember(26)]
        public JunctionFeature junction_feature { get; set; }

        [global::ProtoBuf.ProtoMember(16)]
        public global::apollo.common.Point3D t_position { get; set; }

        [global::ProtoBuf.ProtoMember(17)]
        [global::System.Obsolete]
        public global::apollo.common.Point3D t_velocity { get; set; }

        [global::ProtoBuf.ProtoMember(18)]
        [global::System.Obsolete]
        public double t_velocity_heading
        {
            get { return __pbn__t_velocity_heading.GetValueOrDefault(); }
            set { __pbn__t_velocity_heading = value; }
        }
        public bool ShouldSerializet_velocity_heading()
        {
            return __pbn__t_velocity_heading != null;
        }
        public void Resett_velocity_heading()
        {
            __pbn__t_velocity_heading = null;
        }
        private double? __pbn__t_velocity_heading;

        [global::ProtoBuf.ProtoMember(19)]
        [global::System.Obsolete]
        public double t_speed
        {
            get { return __pbn__t_speed.GetValueOrDefault(); }
            set { __pbn__t_speed = value; }
        }
        public bool ShouldSerializet_speed()
        {
            return __pbn__t_speed != null;
        }
        public void Resett_speed()
        {
            __pbn__t_speed = null;
        }
        private double? __pbn__t_speed;

        [global::ProtoBuf.ProtoMember(20)]
        [global::System.Obsolete]
        public global::apollo.common.Point3D t_acceleration { get; set; }

        [global::ProtoBuf.ProtoMember(21)]
        [global::System.Obsolete]
        public double t_acc
        {
            get { return __pbn__t_acc.GetValueOrDefault(); }
            set { __pbn__t_acc = value; }
        }
        public bool ShouldSerializet_acc()
        {
            return __pbn__t_acc != null;
        }
        public void Resett_acc()
        {
            __pbn__t_acc = null;
        }
        private double? __pbn__t_acc;

        [global::ProtoBuf.ProtoMember(22)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool is_still
        {
            get { return __pbn__is_still ?? false; }
            set { __pbn__is_still = value; }
        }
        public bool ShouldSerializeis_still()
        {
            return __pbn__is_still != null;
        }
        public void Resetis_still()
        {
            __pbn__is_still = null;
        }
        private bool? __pbn__is_still;

        [global::ProtoBuf.ProtoMember(23)]
        [global::System.ComponentModel.DefaultValue(global::apollo.perception.PerceptionObstacle.Type.Unknown)]
        public global::apollo.perception.PerceptionObstacle.Type type
        {
            get { return __pbn__type ?? global::apollo.perception.PerceptionObstacle.Type.Unknown; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype()
        {
            return __pbn__type != null;
        }
        public void Resettype()
        {
            __pbn__type = null;
        }
        private global::apollo.perception.PerceptionObstacle.Type? __pbn__type;

        [global::ProtoBuf.ProtoMember(24)]
        public double label_update_time_delta
        {
            get { return __pbn__label_update_time_delta.GetValueOrDefault(); }
            set { __pbn__label_update_time_delta = value; }
        }
        public bool ShouldSerializelabel_update_time_delta()
        {
            return __pbn__label_update_time_delta != null;
        }
        public void Resetlabel_update_time_delta()
        {
            __pbn__label_update_time_delta = null;
        }
        private double? __pbn__label_update_time_delta;

        [global::ProtoBuf.ProtoMember(25)]
        public ObstaclePriority priority { get; set; }

        [global::ProtoBuf.ProtoMember(29)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool is_near_junction
        {
            get { return __pbn__is_near_junction ?? false; }
            set { __pbn__is_near_junction = value; }
        }
        public bool ShouldSerializeis_near_junction()
        {
            return __pbn__is_near_junction != null;
        }
        public void Resetis_near_junction()
        {
            __pbn__is_near_junction = null;
        }
        private bool? __pbn__is_near_junction;

        [global::ProtoBuf.ProtoMember(31)]
        public global::System.Collections.Generic.List<PredictionTrajectoryPoint> future_trajectory_points { get; private set; }

        [global::ProtoBuf.ProtoMember(32)]
        public global::System.Collections.Generic.List<global::apollo.common.TrajectoryPoint> short_term_predicted_trajectory_points { get; private set; }

        [global::ProtoBuf.ProtoMember(33)]
        public global::System.Collections.Generic.List<Trajectory> predicted_trajectory { get; private set; }

        [global::ProtoBuf.ProtoMember(34)]
        public global::System.Collections.Generic.List<global::apollo.common.TrajectoryPoint> adc_trajectory_point { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ObstacleHistory : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ObstacleHistory()
        {
            feature = new global::System.Collections.Generic.List<Feature>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<Feature> feature { get; private set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool is_trainable
        {
            get { return __pbn__is_trainable ?? false; }
            set { __pbn__is_trainable = value; }
        }
        public bool ShouldSerializeis_trainable()
        {
            return __pbn__is_trainable != null;
        }
        public void Resetis_trainable()
        {
            __pbn__is_trainable = null;
        }
        private bool? __pbn__is_trainable;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class FrameEnv : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public FrameEnv()
        {
            obstacles_history = new global::System.Collections.Generic.List<ObstacleHistory>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double timestamp
        {
            get { return __pbn__timestamp.GetValueOrDefault(); }
            set { __pbn__timestamp = value; }
        }
        public bool ShouldSerializetimestamp()
        {
            return __pbn__timestamp != null;
        }
        public void Resettimestamp()
        {
            __pbn__timestamp = null;
        }
        private double? __pbn__timestamp;

        [global::ProtoBuf.ProtoMember(2)]
        public ObstacleHistory ego_history { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<ObstacleHistory> obstacles_history { get; private set; }

    }

}

#pragma warning restore 0612, 1591, 3021