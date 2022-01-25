/**
 * Copyright (c) 2019-2020 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using System;
using UnityEngine;
using System.Reflection;
using System.Linq;

namespace Simulator.Editor.Autoware
{
    [System.AttributeUsage(AttributeTargets.Field)]
    public class VectorMapCSVAttribute : Attribute
    {
        public string FileName { get; private set; }

        public VectorMapCSVAttribute(string filename)
        {
            FileName = filename;
        }
    }

    public class Point
    {
        public int PID;
        public double B;
        public double L;
        public double H;
        public double Bx;
        public double Ly;
        public int ReF;
        public int MCODE1;
        public int MCODE2;
        public int MCODE3;

        public static Point GetDefaultPoint()
        {
            return new Point()
            {
                PID = 1,
                B = .0,
                L = .0,
                H = .0,
                Bx = .0,
                Ly = .0,
                ReF = 7,
                MCODE1 = 0,
                MCODE2 = 0,
                MCODE3 = 0,
            };
        }

        public static Point MakePoint(int PID, double Bx, double Ly, double H)
        {
            return new Point()
            {
                PID = PID,
                B = .0,
                L = .0,
                H = H,
                Bx = Bx,
                Ly = Ly,
                ReF = 7,
                MCODE1 = 0,
                MCODE2 = 0,
                MCODE3 = 0,
            };
        }
    }

    public struct Line
    {
        public int LID;
        public int BPID;
        public int FPID;
        public int BLID;
        public int FLID;

        public static Line GetDefaultLine()
        {
            return new Line()
            {
                LID = 1,
                BPID = 1,
                FPID = 2,
                BLID = 0,
                FLID = 2,
            };
        }

        public static Line MakeLine(int LID, int BPID, int FPID, int BLID, int FLID)
        {
            return new Line()
            {
                LID = LID,
                BPID = BPID,
                FPID = FPID,
                BLID = BLID, //this is before line id
                FLID = FLID, //this is after line id
            };
        }
    }

    public struct Lane
    {
        public int LnID;
        public int DID;
        public int BLID;
        public int FLID;
        public int BNID;
        public int FNID;
        public int JCT;
        public int BLID2;
        public int BLID3;
        public int BLID4;
        public int FLID2;
        public int FLID3;
        public int FLID4;
        public int ClossID;
        public double Span;
        public int LCnt;
        public int Lno;
        public int LaneType;
        public int LimitVel;
        public int RefVel;
        public int RoadSecID;
        public int LaneChgFG;

        public static Lane GetDefaultLane()
        {
            return new Lane()
            {
                LnID = 1,
                DID = 1,
                BLID = 0,
                FLID = 1,
                BNID = 1,
                FNID = 2,
                JCT = 0,
                BLID2 = 0,
                BLID3 = 0,
                BLID4 = 0,
                FLID2 = 0,
                FLID3 = 0,
                FLID4 = 0,
                ClossID = 0,
                Span = 1.0,
                LCnt = 1,
                Lno = 1,
                LaneType = 0,
                LimitVel = 60,
                RefVel = 60,
                RoadSecID = 0,
                LaneChgFG = 0,
            };
        }

        public static Lane MakeLane(int LnID, int DID, int BLID, int FLID, int BNID, int FNID, int LCnt, int Lno, int speedLimit)
        {
            return new Lane()
            {
                LnID = LnID,
                DID = DID,
                BLID = BLID, //this is before lane id
                FLID = FLID, //this is after lane id
                BNID = BNID,
                FNID = FNID,
                JCT = 0,
                BLID2 = 0,
                BLID3 = 0,
                BLID4 = 0,
                FLID2 = 0,
                FLID3 = 0,
                FLID4 = 0,
                ClossID = 0,
                Span = 1.0,
                LCnt = LCnt,
                Lno = Lno,
                LaneType = 0,
                LimitVel = speedLimit,
                RefVel = speedLimit,
                RoadSecID = 0,
                LaneChgFG = 0,
            };
        }
    }

    public struct DtLane
    {
        public int DID;
        public double Dist; //int or double?
        public int PID;
        public double Dir;
        public double Apara;
        public double r;
        public double slope;
        public double cant;
        public double LW;
        public double RW;

        public static DtLane GetDefaultDtLane()
        {
            return new DtLane()
            {
                DID = 1,
                Dist = .0,
                PID = 1,
                Dir = .0,
                Apara = .0,
                r = .0,
                slope = .0,
                cant = .0,
                LW = .065,
                RW = .065,
            };
        }

        public static DtLane MakeDtLane(int DID, int Dist, int PID, double Dir, double slope, double LW, double RW)
        {
            return new DtLane()
            {
                DID = DID,
                Dist = Dist,
                PID = PID,
                Dir = Dir,
                Apara = .0,
                r = .0,
                slope = slope,
                cant = .0,
                LW = LW,
                RW = RW,
            };
        }
    }

    public struct StopLine
    {
        public int ID;
        public int LID;
        public int TLID;
        public int SignID;
        public int LinkID;

        public static StopLine GetDefaultStopLine()
        {
            return new StopLine()
            {
                ID = 1,
                LID = 1,
                TLID = 0,
                SignID = 0,
                LinkID = 0,
            };
        }

        public static StopLine MakeStopLine(int ID, int LID, int TLID, int SignID, int LinkID)
        {
            return new StopLine()
            {
                ID = ID,
                LID = LID,
                TLID = TLID,
                SignID = SignID,
                LinkID = LinkID,
            };
        }
    }

    public struct WhiteLine
    {
        public int ID;
        public int LID;
        public double Width;
        public string Color;
        public int type;
        public int LinkID;

        public static WhiteLine GetDefaultWhiteLine()
        {
            return new WhiteLine()
            {
                ID = 1,
                LID = 1,
                Width = .15,
                Color = "W",
                type = 0,
                LinkID = 0,
            };
        }

        public static WhiteLine MakeWhiteLine(int ID, int LID, double Width, string Color, int type, int LinkID)
        {
            return new WhiteLine()
            {
                ID = ID,
                LID = LID,
                Width = Width,
                Color = Color,
                type = type,
                LinkID = LinkID,
            };
        }
    }

    public struct Vector
    {
        public int VID;
        public int PID;
        public double Hang;
        public double Vang;

        public static Vector MakeVector(int VID, int PID, double Hang, double Vang)
        {
            return new Vector()
            {
                VID = VID,
                PID = PID,
                Hang = Hang,
                Vang = Vang,
            };
        }
    }

    public struct Node
    {
        public int NID;
        public int PID;

        public static Node GetDefaultNode()
        {
            return new Node()
            {
                NID = 1,
                PID = 1,
            };
        }

        public static Node MakeNode(int NID, int PID)
        {
            return new Node()
            {
                NID = NID,
                PID = PID,
            };
        }
    }

    public struct Pole
    {
        public int PLID;
        public int VID;
        public double Length;
        public double Dim;

        public static Pole GetDefaultPole()
        {
            return new Pole()
            {
                PLID = 1,
                VID = 1,
                Length = 13.5,
                Dim = 0.4,
            };
        }

        public static Pole MakePole(int PLID, int VID, double Length, double Dim)
        {
            return new Pole()
            {
                PLID = PLID,
                VID = VID,
                Length = Length,
                Dim = Dim,
            };
        }
    }

    public struct SignalData
    {
        public int ID;
        public int VID;
        public int PLID;
        public int Type;
        public int LinkID;

        public static SignalData GetDefaultSignalData()
        {
            return new SignalData()
            {
                ID = 1,
                VID = 1,
                PLID = 1,
                Type = 1,
                LinkID = 1,
            };
        }

        public static SignalData MakeSignalData(int ID, int VID, int PLID, int Type, int LinkID)
        {
            return new SignalData()
            {
                ID = ID,
                VID = VID,
                PLID = PLID,
                Type = Type,
                LinkID = LinkID,
            };
        }
    }

    // Other

    public struct VectorMapPosition
    {
        public double Bx;
        public double Ly;
        public double H;
    }

    public class VectorMapUtility
    {
        public static string GetCSVHeader(System.Type type)
        {
            var fieldInfos = type.GetFields(BindingFlags.Instance | BindingFlags.Public);
            return string.Join(",", fieldInfos.Select(x => x.Name));
        }

        // Convert coordinate to Autoware/Rviz coordinate
        public static Vector3 GetRvizCoordinates(Vector3 unityPos)
        {
            return new Vector3(unityPos.z, -unityPos.x, unityPos.y);
        }

        // Convert from Autoware/Rviz to Unity coordinates
        public static Vector3 GetUnityCoordinate(Vector3 rvizPos)
        {
            return new Vector3(-rvizPos.y, rvizPos.z, rvizPos.x);
        }

        public static VectorMapPosition GetVectorMapPosition(Vector3 unityPos, float exportScale = 1)
        {
            var convertedPos = VectorMapUtility.GetRvizCoordinates(unityPos);
            convertedPos *= exportScale;
            return new VectorMapPosition() { Bx = convertedPos.y, Ly = convertedPos.x, H = convertedPos.z };
        }

        public static Vector3 GetUnityPosition(VectorMapPosition vmPos, float exportScale = 1)
        {
            var inverseConvertedPos = new Vector3((float)vmPos.Ly, (float)vmPos.Bx, (float)vmPos.H);
            inverseConvertedPos /= exportScale;
            return VectorMapUtility.GetUnityCoordinate(inverseConvertedPos);
        }
    }
}