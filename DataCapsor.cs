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
        public int _index;
        //face detection data
        public int box_x, box_y, box_w, box_h;
        public Single averageDepth;

        //face pose data
        public Single headCenter_x, headCenter_y, headCenter_z;
        public int pos_confi;
        public Single yaw, pitch, roll;
        public Single pose_q_x, pose_q_y, pose_q_z, pose_q_w;

        //face expression data
        public Dictionary<string, int> expressions = new Dictionary<string, int>();

        public DataCapsor()
        {
            this._face = null;
            this._index = 0;
        }
        //public DataCapsor() { }
        public void intergrateData(int index, Face face)
        {
            _face = face;
            _index = index;
            //string output = JsonConvert.SerializeObject(_index);
            PXCMRectI32 box_rect;
            //query bounding rect
            DetectionData fDetection = face.QueryDetection();
            PoseData fPose = face.QueryPose();
            ExpressionsData fExpression = face.QueryExpressions();


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
            pos_confi = fPose.QueryConfidence();

            //query pose euler angles
            PoseEulerAngles pea;
            fPose.QueryPoseAngles(out pea);
            yaw = pea.yaw;
            pitch = pea.pitch;
            roll = pea.roll;

            //query pose quaternion
            PoseQuaternion pq;
            fPose.QueryPoseQuaternion(out pq);
            pose_q_w = pq.w;
            pose_q_x = pq.x;
            pose_q_y = pq.y;
            pose_q_z = pq.z;

            //query expression data
            //FaceExpressionResult fer = new FaceExpressionResult();
            //fExpression.QueryExpression(ExpressionsData.FaceExpression.EXPRESSION_BROW_LOWERER_LEFT, out fer);
            //expressions.Add(FaceExpression.EXPRESSION_BROW_LOWERER_LEFT.ToString(), fer.intensity);


            
      
        }
    }
}
