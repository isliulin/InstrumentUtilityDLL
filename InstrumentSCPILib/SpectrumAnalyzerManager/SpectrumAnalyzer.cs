﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentSCPILib.SpectrumAnalyzerManager
{

    /// <summary>
    /// SpectrumAnalyzer 
    /// </summary>
    public  class SpectrumAnalyzer
    {
        internal SpectrumAnalyzer()
        {
            
        }

        /// <summary>
        /// 获取对象实例
        /// </summary>
        /// <param name="spectrumAnalyzerType">仪表型号</param>
        /// <returns></returns>
        public static ISpectrumAnalyzer GetInstance(SpectrumAnalyzerType  spectrumAnalyzerType)
        {
            switch (spectrumAnalyzerType)
            {
                case SpectrumAnalyzerType.Agilent_856X:
                    return new Agilent_856x();
                case SpectrumAnalyzerType.Agilent_ESA_E:
                    return new Agilent_ESA_E();
                case SpectrumAnalyzerType.Agilent_E4407B:
                    return new Agilent_E4407B();
                case SpectrumAnalyzerType.RS_FSU:
                    return new RS_FSU();
                case SpectrumAnalyzerType.RS_FSW:
                    return new RS_FSW();
                default:
                    return null;
            }

        }




     



    }
}
