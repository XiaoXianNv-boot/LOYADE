using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using SpatialAnalyzerSDK;

namespace LOYADE.SPATIALANALYZER
{
    public class NRKSdkProvider
    {
        private ISpatialAnalyzerSDK NRKSdk = new SpatialAnalyzerSDKClass();

        private Logger _logger = new Logger();

        enum MPStatus
        {
            SdkError = -1,
            Undone = 0,
            InProgress = 1,
            DoneSuccess = 2,
            DoneFatalError = 3,
            DoneMinorError = 4,
            CurrentTask = 5
        };

        public NRKSdkProvider()
        {

        }

        public void SetLogFile(string file)
        {
            _logger.LogFile = file;
        }

        public void FunctionWait(int waittime)
        {
            Thread.Sleep(waittime);
        }

        public bool SendResult = false;
        public int ResultCode = 0;

        public bool Connect(string host)
        {
            try
            {
                SendResult = NRKSdk.Connect(host);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : Connect(" + host + ") Success";
                else
                    _logger.LogString = DateTime.Now + " : Connect(" + host + ") Fail";
            }
            catch (Exception ex)
            {
                SendResult = false;
                _logger.LogString = DateTime.Now + " : Connect(" + host + ") ERROR - " + ex.Message;
            }
            return SendResult;
        }

        public void SetStep(string cmd)
        {
            //NRKSdk.SetStep("Construct a Point in Working Coordinates");
            try
            {
                NRKSdk.SetStep(cmd);
                _logger.LogString = DateTime.Now + " : SetStep(" + cmd + ")";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetStep(" + cmd + ") ERROR - " + ex.Message;
            }
        }

        public void SetColInstIdArg(string arg, string collection, int instid)
        {
            try
            {
                SendResult = NRKSdk.SetColInstIdArg(arg, collection, instid);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetColInstIdArg(" + arg + " [" + collection + "," + instid + "]) Success";
                else
                    _logger.LogString = DateTime.Now + " : SetColInstIdArg(" + arg + " [" + collection + "," + instid + "]) Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetColInstIdArg(" + arg + " [" + collection + "," + instid + "]) ERROR - " + ex.Message;
            }
        }

        public void SetVectorArg(string arg, double x, double y, double z)
        {
            //NRKSdk.SetVectorArg("Working Coordinates", 10.1234, 20.2345, 30.5678);
            try
            {
                SendResult = NRKSdk.SetVectorArg(arg, x, y, z);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetVectorArg(" + arg + " [" + x + "," + y + "," + z + "]) Success";
                else
                    _logger.LogString = DateTime.Now + " : SetVectorArg(" + arg + " [" + x + "," + y + "," + z + "]) Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetVectorArg(" + arg + " [" + x + "," + y + "," + z + "]) ERROR - " + ex.Message;
            }
        }

        public void SetStringArg(string arg, string value)
        {
            //NRKSdk.SetStringArg("Question to ask", "Enter Sphere Name");
            try
            {
                SendResult = NRKSdk.SetStringArg(arg, value);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetStringArg(" + arg + " [" + value + "]) Success";
                else
                    _logger.LogString = DateTime.Now + " : SetStringArg(" + arg + " [" + value + "]) Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetStringArg(" + arg + " [" + value + "]) ERROR - " + ex.Message;
            }
        }

        public void SetFontTypeArg(string arg, string fontfamily, int size, int r, int g, int b)
        {
            try
            {
                SendResult = NRKSdk.SetFontTypeArg(arg, fontfamily, (byte)size, (byte)r, (byte)g, (byte)b);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetFontTypeArg(" + arg + " [" + fontfamily + "," + size + "," + r + "," + g + "," + b + "]) Success";
                else
                    _logger.LogString = DateTime.Now + " : SetFontTypeArg(" + arg + " [" + fontfamily + "," + size + "," + r + "," + g + "," + b + "]) Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetFontTypeArg(" + arg + " [" + fontfamily + "," + size + "," + r + "," + g + "," + b + "]) ERROR - " + ex.Message;
            }
        }

        public void SetIntegerArg(string arg, int value)
        {
            try
            {
                SendResult = NRKSdk.SetIntegerArg(arg, value);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetIntegerArg(" + arg + " [" + value + "]) Success";
                else
                    _logger.LogString = DateTime.Now + " : SetIntegerArg(" + arg + " [" + value + "]) Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetIntegerArg(" + arg + " [" + value + "]) ERROR - " + ex.Message;
            }
        }

        public void SetBoolArg(string arg, bool value)
        {
            try
            {
                SendResult = NRKSdk.SetBoolArg(arg, value);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetBoolArg(" + arg + " [" + value + "]) Success";
                else
                    _logger.LogString = DateTime.Now + " : SetBoolArg(" + arg + " [" + value + "]) Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetBoolArg(" + arg + " [" + value + "]) ERROR - " + ex.Message;
            }
        }


        public void SetDoubleArg(string arg, double value)
        {
            try
            {
                SendResult = NRKSdk.SetDoubleArg(arg, value);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetDoubleArg(" + arg + " [" + value + "]) Success";
                else
                    _logger.LogString = DateTime.Now + " : SetDoubleArg(" + arg + " [" + value + "]) Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetDoubleArg(" + arg + " [" + value + "]) ERROR - " + ex.Message;
            }
        }

        public void SetFilePathArg(string arg, string path, bool embedded)
        {
            try
            {
                SendResult = NRKSdk.SetFilePathArg(arg, path, embedded);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetFilePathArg(" + arg + " [" + path + "]) Success";
                else
                    _logger.LogString = DateTime.Now + " : SetFilePathArg(" + arg + " [" + path + "]) Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetFilePathArg(" + arg + " [" + path + "]) ERROR - " + ex.Message;
            }
        }

        public void SetPointNameArg(string arg, string collection, string group, string target)
        {
            //NRKSdk.SetPointNameArg("Point Name", "", "TestGrp", "TestPt");
            try
            {
                SendResult = NRKSdk.SetPointNameArg(arg, collection, group, target);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetPointNameArg(" + arg + " [" + collection + "," + group + "," + target + "]) Success";
                else
                    _logger.LogString = DateTime.Now + " : SetPointNameArg(" + arg + " [" + collection + "," + group + "," + target + "]) Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetPointNameArg(" + arg + " [" + collection + "," + group + "," + target + "]) ERROR - " + ex.Message;
            }
        }

        public void SetTransformArg(string arg, object vmatrix)
        {
            //NRKSdk.SetTransformArg("Transform in Working Coordinates", ref objMatrix);
            try
            {
                VariantWrapper matrixobj = new VariantWrapper(vmatrix);
                Object objMatrix = matrixobj;
                SendResult = NRKSdk.SetTransformArg(arg, ref objMatrix);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetTransformArg(" + arg + ") Success";
                else
                    _logger.LogString = DateTime.Now + " : SetTransformArg(" + arg + ") Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetTransformArg(" + arg + ") ERROR - " + ex.Message;
            }
        }

        public void SetObjectNameArg(string arg, string objectname)
        {
            try
            {
                SendResult = NRKSdk.SetObjectNameArg(arg, objectname);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetObjectNameArg(" + arg + " [" + objectname + "]) Success";
                else
                    _logger.LogString = DateTime.Now + " : SetObjectNameArg(" + arg + " [" + objectname + "]) Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetObjectNameArg(" + arg + " [" + objectname + "]) ERROR - " + ex.Message;
            }
        }

        public void SetCollectionNameArg(string arg, string objectname)
        {
            try
            {
                SendResult = NRKSdk.SetCollectionNameArg(arg, objectname);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetCollectionNameArg(" + arg + " [" + objectname + "]) Success";
                else
                    _logger.LogString = DateTime.Now + " : SetCollectionNameArg(" + arg + " [" + objectname + "]) Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetCollectionNameArg(" + arg + " [" + objectname + "]) ERROR - " + ex.Message;
            }
        }

        public void SetCollectionObjectNameArg(string arg, string collection, string objectname)
        {
            //NRKSdk.SetCollectionObjectNameArg("Object Name", "", sphereName);
            try
            {
                SendResult = NRKSdk.SetCollectionObjectNameArg(arg, collection, objectname);
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : SetCollectionObjectNameArg(" + arg + " [" + collection + "," + objectname + "]) Success";
                else
                    _logger.LogString = DateTime.Now + " : SetCollectionObjectNameArg(" + arg + " [" + collection + "," + objectname + "]) Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : SetCollectionObjectNameArg(" + arg + " [" + collection + "," + objectname + "]) ERROR - " + ex.Message;
            }
        }

        public bool ExecuteStep()
        {
            SendResult = false;
            try
            {
                SendResult = NRKSdk.ExecuteStep();
                if (SendResult)
                    _logger.LogString = DateTime.Now + " : ExecuteStep() Success";
                else
                    _logger.LogString = DateTime.Now + " : ExecuteStep() Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : ExecuteStep() ERROR - " + ex.Message;
            }
            return SendResult;
        }

        public bool CheckResultCodeSdkError()
        {
            if (ResultCode == (int)MPStatus.SdkError)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckResultCodeDoneSuccess()
        {
            if (ResultCode == (int)MPStatus.DoneSuccess)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string SetNewInstrument(string instrumenttype)
        {
            string rets = "";
            NRKSdk.SetStep("Add New Instrument");
            if (NRKSdk.SetInstTypeNameArg("Instrument Type", instrumenttype))
            {
                if (NRKSdk.ExecuteStep())
                {
                    string sCol = null;
                    int instId = -1;
                    if (NRKSdk.GetColInstIdArg("Instrument Added (result)", ref sCol, ref instId))
                    {
                        if (instId != -1)
                            rets = sCol + "," + instId;
                    }
                }
            }
            return rets;
        }

        public bool TestInstrumentConnection(int instrId)
        {
            NRKSdk.SetStep("Verify Instrument Connection");
            NRKSdk.SetColInstIdArg("Instrument's ID", "", instrId);
            NRKSdk.ExecuteStep();
            bool bret = false;
            NRKSdk.GetBoolArg("Connected?", ref bret);
            return bret;
        }

        public string GetCollectionNameArg()
        {
            string sret = "";
            try
            {
                NRKSdk.SetStep("Get Active Collection Name");
                NRKSdk.ExecuteStep();
                SendResult = NRKSdk.GetCollectionNameArg("Currently Active Collection Name", ref sret);
                if (SendResult)
                {
                    _logger.LogString = DateTime.Now + " : GetCollectionNameArg() Success = " + sret;
                }
                else
                    _logger.LogString = DateTime.Now + " : GetCollectionNameArg() Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : GetCollectionNameArg() ERROR - " + ex.Message;
            }
            return sret;
        }


        public int GetMPStepResult()
        {
            try
            {
                SendResult = NRKSdk.GetMPStepResult(ref ResultCode);
                if (SendResult)
                {
                    _logger.LogString = DateTime.Now + " : GetMPStepResult() Success";
                }
                else
                    _logger.LogString = DateTime.Now + " : GetMPStepResult() Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : GetMPStepResult() ERROR - " + ex.Message;
            }
            return ResultCode;
        }

        public string GetMPStepMessages()
        {
            string msg = "";
            try
            {
                Object obj = null;
                SendResult = NRKSdk.GetMPStepMessages(ref obj);
                if (SendResult)
                {
                    Array msgs = (Array)obj;
                    for (int i = 0; i < msgs.Length; i++)
                    {
                        msg += (String)msgs.GetValue(i);
                        msg += "\n";
                    }
                    _logger.LogString = DateTime.Now + " : GetMPStepMessages() Success = " + msg;
                }
                else
                    _logger.LogString = DateTime.Now + " : GetMPStepMessages() Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : GetMPStepMessages() ERROR - " + ex.Message;
            }
            return msg;
        }

        public double GetDoubleArg(string arg)
        {
            double radius = 0.0;
            try
            {
                SendResult = NRKSdk.GetDoubleArg(arg, ref radius);
                if (SendResult)
                {
                    _logger.LogString = DateTime.Now + " : GetDoubleArg(" + arg + ") Success = " + radius;
                }
                else
                    _logger.LogString = DateTime.Now + " : GetDoubleArg(" + arg + ") Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : GetDoubleArg() ERROR - " + ex.Message;
            }
            return radius;
        }

        public Object GetTransformArg(string arg)
        {
            Object vMatrix = null;
            try
            {
                SendResult = NRKSdk.GetTransformArg(arg, ref vMatrix);
                if (SendResult)
                {
                    _logger.LogString = DateTime.Now + " : GetTransformArg(" + arg + ") Success";
                }
                else
                    _logger.LogString = DateTime.Now + " : GetTransformArg(" + arg + ") Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : GetTransformArg() ERROR - " + ex.Message;
            }
            return vMatrix;
        }

        public double[,] GetTransformArgDoubleArray(string arg)
        {
            double[,] T = new double[0, 0];
            try
            {
                Object vMatrix = null;
                SendResult = NRKSdk.GetTransformArg(arg, ref vMatrix);
                if (SendResult)
                {
                    Array matrix = (Array)vMatrix;

                    int lXstart, lXend;
                    int lYstart, lYend;
                    int row = -1;
                    int col = -1;

                    lXstart = matrix.GetLowerBound(0);
                    lXend = matrix.GetUpperBound(0);
                    lYstart = matrix.GetLowerBound(1);
                    lYend = matrix.GetUpperBound(1);

                    T = new double[lXend + 1, lYend + 1];
                    for (row = lXstart; row <= lXend; row++)
                    {
                        for (col = lYstart; col <= lYend; col++)
                        {
                            double element;
                            element = (double)matrix.GetValue(row, col);
                            T[row, col] = element;
                        }
                    }
                    _logger.LogString = DateTime.Now + " : GetTransformArgDoubleArray(" + arg + ") Success";
                }
                else
                    _logger.LogString = DateTime.Now + " : GetTransformArgDoubleArray(" + arg + ") Fail";
            }
            catch (Exception ex)
            {
                _logger.LogString = DateTime.Now + " : GetTransformArgDoubleArray() ERROR - " + ex.Message;
            }
            return T;
        }

        public string GetPointCoordinate(string collection, string grouo, string pointid)
        {
            string sret = "";
            NRKSdk.SetStep("Get Point Coordinate");
            NRKSdk.SetPointNameArg("Point Name", collection, grouo, pointid);
            NRKSdk.ExecuteStep();

            double xVal = 0;
            double yVal = 0;
            double zVal = 0;
            NRKSdk.GetVectorArg("Vector Representation", ref xVal, ref yVal, ref zVal);

            //double value=0;
            //NRKSdk.GetDoubleArg("X Value", ref value); 
            //NRKSdk.GetDoubleArg("Y Value", ref value); 
            //NRKSdk.GetDoubleArg("Z Value", ref value);

            sret = xVal + "," + yVal + "," + zVal;
            return sret;
        }

        public void a()
        {
            /*
            bool Connect(string ipAddress)
            bool ConnectEx(string ipAddress, ref int statusCode)
            bool ExecuteStep()
            bool GetBoolArg(string argName, ref bool value)
            bool GetChartNameArg(string argName, ref string chartName)
            bool GetCloudNameArg(string argName, ref string cloudName)
            bool GetColInstIdArg(string argName, ref string collectionName, ref int instId)
            bool GetColInstIdRefListArg(string argName, ref object colInstIdList)
            bool GetCollectionGroupNameRefListArg(string argName, ref object colGroupNameList)
            bool GetCollectionNameArg(string argName, ref string collectionName)
            bool GetCollectionObjectNameArg(string argName, ref string collectionName, ref string objectName)
            bool GetCollectionObjectNameRefListArg(string argName, ref object objectNameList)
            bool GetCollectionVectorGroupNameRefListArg(string argName, ref object colVectorGrpNameList)
            bool GetColVectorGroupNameArg(string argName, ref string collectionName, ref string vectorGroupName)
            bool GetDoubleArg(string argName, ref double value)
            bool GetFilePathArg(string argName, ref string path, ref bool embeddedFile)
            bool GetFrameNameArg(string argName, ref string frameName)
            bool GetInstIdArg(string argName, ref int instId)
            bool GetIntegerArg(string argName, ref int value)
            bool GetMPStepMessages(ref object vArray)
            bool GetMPStepResult(ref int resultCode)
            bool GetObjectNameArg(string argName, ref string objectName)
            bool GetPerimeterNameArg(string argName, ref string perimeterName)
            bool GetPointNameArg(string argName, ref string collectionName, ref string groupName, ref string targetName)
            bool GetPointNameRefListArg(string argName, ref object pointNameList)
            bool GetReportOutputOptionsArg(string argName, ref string outputType, ref string pathOrEmbeddedName)
            bool GetReportViewOptionsArg(string argName, ref string viewType, ref string collectionName, ref string calloutName)
            bool GetResultArg(string argName, ref string objectName)
            bool GetStringArg(string argName, ref string value)
            bool GetStringRefListArg(string argName, ref object stringList)
            bool GetTransformArg(string argName, ref object transform)
            bool GetVectorArg(string argName, ref double XValue, ref double yValue, ref double zValue)
            bool GetVectorGroupNameArg(string argName, ref string vectorGrpName)
            bool GetVectorNameRefListArg(string argName, ref object vectorNameList)
            bool GetViewNameArg(string argName, ref string viewName)
            bool GetWorldTransformArg(string argName, ref object transform, ref double scaleFactor)
            bool SetAsciiFileFormatArg(string argName, string asciiFileFormat)
            bool SetAxisNameArg(string argName, string axisName)
            bool SetBaseColorTypeArg(string argName, string baseColorType)
            bool SetBoolArg(string argName, bool value)
            bool SetChartNameArg(string argName, string chartName)
            bool SetChartTypeArg(string argName, string chartType)
            bool SetCloudNameArg(string argName, string cloudName)
            bool SetColInstIdArg(string argName, string collectionName, int instId)
            bool SetColInstIdRefListArg(string argName, ref object colInstIdList)
            bool SetCollectionGroupNameRefListArg(string argName, ref object groupNameList)
            bool SetCollectionNameArg(string argName, string collectionName)
            bool SetCollectionObjectNameArg(string argName, string collectionName, string objectName)
            bool SetCollectionObjectNameRefListArg(string argName, ref object objectNameList)
            bool SetCollectionVectorGroupNameRefListArg(string argName, ref object colVectorGrpNameList)
            bool SetColorArg(string argName, byte redColorVal, byte greenColorVal, byte blueColorVal)
            bool SetColorizationOptionsArg(string argName, string colorRangeMethod, string baseHighColor, string baseMidColor, string baseLowColor, bool bDrawTubes, bool bDrawArrowheads, bool bIndicateValues, double vectorMagnification, int vectorWidth, bool bDrawBlotches, double blotchSize, bool bShowOutOfToleranceOnly, bool bShowColorBarInView, bool bShowColorBarPercentages, bool bShowColorBarFractions, double highSaturationLimit, double lowSaturationLimit, double highTolerance, double lowTolerance)
            bool SetColorRangeMethodArg(string argName, string colorRangeMethod)
            bool SetColVectorGroupNameArg(string argName, string collectionName, string vectorGroupName)
            bool SetCoordinateSystemTypeArg(string argName, string coordSystemType)
            bool SetDatasetTypeArg(string argName, string datasetType)
            bool SetDistanceUnitsArg(string argName, string distanceUnits)
            bool SetDoubleArg(string argName, double value)
            bool SetExportDataDelimeterTypeArg(string argName, string delimeterType)
            bool SetExportTargetNameFormatArg(string argName, string targetNameFormat)
            bool SetFilePathArg(string argName, string path, bool embeddedFile)
            bool SetFitDofOptionsArg(string argName, bool bAllowX, bool bAllowY, bool bAllowZ, bool bAllowRx, bool bAllowRy, bool bAllowRz, bool bRotateAboutCentroid)
            bool SetFontTypeArg(string argName, string fontName, byte fontSize, byte redColorVal, byte greenColorVal, byte blueColorVal)
            bool SetFrameNameArg(string argName, string frameName)
            bool SetGeometryTypeArg(string argName, string geometryType)
            bool SetInstIdArg(string argName, int instId)
            bool SetInstTypeNameArg(string argName, string instType)
            bool SetIntegerArg(string argName, int value)
            bool SetMoveDirectionTypeArg(string argName, string moveDirection)
            bool SetMPDialogInteractionModeArg(string argName, string mpDialogInteractionMode)
            bool SetMPInteractionModeArg(string argName, string mpInteractionMode)
            bool SetObjectNameArg(string argName, string objectName)
            bool SetObjectTypeArg(string argName, string objectType)
            bool SetPerimeterNameArg(string argName, string perimeterName)
            bool SetPointDeltaReportOptionsArg(string argName, string coordSys, string detailsFormat, bool bShowA, bool bShowB, bool bShowDelta, bool bShowMag, bool bShowComponent1, bool bShowComponent2, bool bShowComponent3, bool bSortPointNames, bool bShowToleranceFields, bool bColorizeInToleranceFields)
            bool SetPointNameArg(string argName, string collectionName, string groupName, string targetName)
            bool SetPointNameRefListArg(string argName, ref object pointNameList)
            bool SetProjectionOptionsArg(string argName, string projectionType, bool bIgnoreEdgeProjections, bool bOverrideTargetOffsets, double overrideTargetOffsetsValue, bool bAddExtraMaterialThickness, double extraMaterialThicknessValue)
            bool SetRenderModeTypeArg(string argName, string renderModeType)
            bool SetReportOutputOptionsArg(string argName, string outputType, string pathOrEmbeddedName)
            bool SetReportPageSettingsArg(string argName, string pageOrientation)
            bool SetReportTypeArg(string argName, string reportType)
            bool SetReportViewOptionsArg(string argName, string viewType, string collectionName, string calloutName)
            bool SetResultArg(string argName, string objectName)
            bool SetSAInteractionModeArg(string argName, string saInteractionMode)
            bool SetShowUsmnDialogTypeArg(string argName, string showType)
            void SetStep(string stepName)
            bool SetStringArg(string argName, string value)
            bool SetStringRefListArg(string argName, ref object stringList)
            bool SetSurfDissectModeTypeArg(string argName, string dissectModeType)
            bool SetTransformArg(string argName, ref object transform)
            bool SetUserSummaryInfoFilesArg(string argName, string leftSummaryFilePath, string rightSummaryFilePath)
            bool SetVectorArg(string argName, double XValue, double yValue, double zValue)
            bool SetVectorGroupNameArg(string argName, string vectorGrpName)
            bool SetVectorNameRefListArg(string argName, ref object vectorNameList)
            bool SetViewNameArg(string argName, string viewName)
            bool SetWindowStateArg(string argName, string windowState)
            bool SetWorkbookAddressModeTypeArg(string argName, string workbookAddressMode)
            bool SetWorldTransformArg(string argName, ref object transform, double scaleFactor)
            bool SetWriteModeTypeArg(string argName, string writeMode)
            */



        }
    }
}
