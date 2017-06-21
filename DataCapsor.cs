using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using static PXCMFaceData;
using static PXCMFaceData.ExpressionsData;

namespace DF_FaceTracking.cs
{
    class DataCapsor
    {
        public Face _face;
        //public int _index;
        //face detection data
        public int box_x;
        public int box_y, box_w, box_h;
        public Single averageDepth;

        //face pose data
        public Single headCenter_x, headCenter_y, headCenter_z;
        //public int pos_confi;
        //public Single yaw, pitch, roll;
        //public Single pose_q_x, pose_q_y, pose_q_z, pose_q_w;

        //face expression data
        //public Dictionary<string, int> expressions = new Dictionary<string, int>();

        //face pulse data
        //public float heartRate;

        //face gaze tracking
        //public Single gazePoint_x, gazePoint_y;
        //public int gaze_confi;
        //public float g_hor_ang, g_ver_ang;

        public DataCapsor()
        {
            this._face = null;
            //this._index = 0;
        }
        //public DataCapsor() { }
        public void intergrateData(int index, Face face)
        {
            _face = face;
            //_index = index;
            //string output = JsonConvert.SerializeObject(_index);
            PXCMRectI32 box_rect;
            //query bounding rect
            DetectionData fDetection = face.QueryDetection();
            PoseData fPose = face.QueryPose();
            ExpressionsData fExpression = face.QueryExpressions();
            GazeData fGaze = face.QueryGaze();

            fDetection.QueryBoundingRect(out box_rect);
            box_x = box_rect.x;
            box_y = box_rect.y;
            box_w = box_rect.w;
            box_h = box_rect.h;

            //query average depth
            fDetection.QueryFaceAverageDepth(out averageDepth);

            //query head position
            HeadPosition hp;
            fPose.QueryHeadPosition(out hp);
            headCenter_x = hp.headCenter.x;
            headCenter_y = hp.headCenter.y;
            headCenter_z = hp.headCenter.z;

            //query pose confidence
            //pos_confi = fPose.QueryConfidence();

            //query pose euler angles
            PoseEulerAngles pea;
            fPose.QueryPoseAngles(out pea);
            //yaw = pea.yaw;
            //pitch = pea.pitch;
            //roll = pea.roll;

            //query pose quaternion
            PoseQuaternion pq;
            fPose.QueryPoseQuaternion(out pq);
            //pose_q_w = pq.w;
            //pose_q_x = pq.x;
            //pose_q_y = pq.y;
            //pose_q_z = pq.z;

            //query expression data
            Type expressionType = typeof(FaceExpression);
            FaceExpressionResult fer = new FaceExpressionResult();

            foreach(string s in Enum.GetNames(expressionType))
            {
               
                FaceExpression typeIndex = (FaceExpression)Enum.Parse(expressionType, s);
                //fExpression.QueryExpression(ExpressionsData.FaceExpression.EXPRESSION_BROW_LOWERER_LEFT, out fer);
                fExpression.QueryExpression(typeIndex, out fer);
               // Console.WriteLine(s + ".." + fer.intensity);

                //int value;
                //if (expressions.TryGetValue(s, out value))
                //{
                //    //modify
                //    expressions[s] = fer.intensity;
                //}
                //else
                //{
                //    //add
                //    expressions.Add(s, fer.intensity);
                //}
                
            }
            //query pulse 
            PulseData fPulse = face.QueryPulse();
            //if(fPulse != null)
            //{
            //    //Console.WriteLine("pulsed");
            //    heartRate = fPulse.QueryHeartRate();
            //}
            

            //query gaze 
            //if(fGaze != null)
            //{
            //    Console.WriteLine("gazed!");
            //    gazePoint_x = fGaze.QueryGazePoint().screenPoint.x;
            //    gazePoint_y = fGaze.QueryGazePoint().screenPoint.y;

            //    gaze_confi = fGaze.QueryGazePoint().confidence;

            //    g_hor_ang = (float)fGaze.QueryGazeHorizontalAngle();
            //    g_ver_ang = (float)fGaze.QueryGazeVerticalAngle();
            //}
            

            
        }
    }
}


