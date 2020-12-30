using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LOYADE.SPATIALANALYZER
{
    public class Logger
    {
        public Logger()
        {

        }

        private string _logfile = "";

        private string _logstring = "";

        public string LogString
        {
            get
            {
                return _logstring;
            }

            set
            {
                _logstring = value;
                StreamWriter sr = null;
                try
                {
                    if (!File.Exists(_logfile))
                    {
                        sr = File.CreateText(_logfile);
                    }
                    else
                    {
                        sr = File.AppendText(_logfile);
                    }
                    sr.WriteLine(_logstring);
                }
                catch
                {
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                }
            }
        }

        public string LogFile
        {
            get
            {
                return _logfile;
            }

            set
            {
                _logfile = value;
            }
        }
    }
}
