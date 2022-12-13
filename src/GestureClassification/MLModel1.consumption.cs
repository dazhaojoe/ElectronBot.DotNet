﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace GestureClassification
{
    public partial class MLModel1
    {
        /// <summary>
        /// model input class for MLModel1.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"col0")]
            public float Col0 { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"col1")]
            public float Col1 { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"col2")]
            public float Col2 { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"col3")]
            public float Col3 { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"col4")]
            public float Col4 { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"col5")]
            public float Col5 { get; set; }

            [LoadColumn(6)]
            [ColumnName(@"col6")]
            public float Col6 { get; set; }

            [LoadColumn(7)]
            [ColumnName(@"col7")]
            public float Col7 { get; set; }

            [LoadColumn(8)]
            [ColumnName(@"col8")]
            public float Col8 { get; set; }

            [LoadColumn(9)]
            [ColumnName(@"col9")]
            public float Col9 { get; set; }

            [LoadColumn(10)]
            [ColumnName(@"col10")]
            public float Col10 { get; set; }

            [LoadColumn(11)]
            [ColumnName(@"col11")]
            public float Col11 { get; set; }

            [LoadColumn(12)]
            [ColumnName(@"col12")]
            public float Col12 { get; set; }

            [LoadColumn(13)]
            [ColumnName(@"col13")]
            public float Col13 { get; set; }

            [LoadColumn(14)]
            [ColumnName(@"col14")]
            public float Col14 { get; set; }

            [LoadColumn(15)]
            [ColumnName(@"col15")]
            public float Col15 { get; set; }

            [LoadColumn(16)]
            [ColumnName(@"col16")]
            public float Col16 { get; set; }

            [LoadColumn(17)]
            [ColumnName(@"col17")]
            public float Col17 { get; set; }

            [LoadColumn(18)]
            [ColumnName(@"col18")]
            public float Col18 { get; set; }

            [LoadColumn(19)]
            [ColumnName(@"col19")]
            public float Col19 { get; set; }

            [LoadColumn(20)]
            [ColumnName(@"col20")]
            public float Col20 { get; set; }

            [LoadColumn(21)]
            [ColumnName(@"col21")]
            public float Col21 { get; set; }

            [LoadColumn(22)]
            [ColumnName(@"col22")]
            public float Col22 { get; set; }

            [LoadColumn(23)]
            [ColumnName(@"col23")]
            public float Col23 { get; set; }

            [LoadColumn(24)]
            [ColumnName(@"col24")]
            public float Col24 { get; set; }

            [LoadColumn(25)]
            [ColumnName(@"col25")]
            public float Col25 { get; set; }

            [LoadColumn(26)]
            [ColumnName(@"col26")]
            public float Col26 { get; set; }

            [LoadColumn(27)]
            [ColumnName(@"col27")]
            public float Col27 { get; set; }

            [LoadColumn(28)]
            [ColumnName(@"col28")]
            public float Col28 { get; set; }

            [LoadColumn(29)]
            [ColumnName(@"col29")]
            public float Col29 { get; set; }

            [LoadColumn(30)]
            [ColumnName(@"col30")]
            public float Col30 { get; set; }

            [LoadColumn(31)]
            [ColumnName(@"col31")]
            public float Col31 { get; set; }

            [LoadColumn(32)]
            [ColumnName(@"col32")]
            public float Col32 { get; set; }

            [LoadColumn(33)]
            [ColumnName(@"col33")]
            public float Col33 { get; set; }

            [LoadColumn(34)]
            [ColumnName(@"col34")]
            public float Col34 { get; set; }

            [LoadColumn(35)]
            [ColumnName(@"col35")]
            public float Col35 { get; set; }

            [LoadColumn(36)]
            [ColumnName(@"col36")]
            public float Col36 { get; set; }

            [LoadColumn(37)]
            [ColumnName(@"col37")]
            public float Col37 { get; set; }

            [LoadColumn(38)]
            [ColumnName(@"col38")]
            public float Col38 { get; set; }

            [LoadColumn(39)]
            [ColumnName(@"col39")]
            public float Col39 { get; set; }

            [LoadColumn(40)]
            [ColumnName(@"col40")]
            public float Col40 { get; set; }

            [LoadColumn(41)]
            [ColumnName(@"col41")]
            public float Col41 { get; set; }

            [LoadColumn(42)]
            [ColumnName(@"col42")]
            public float Col42 { get; set; }

            [LoadColumn(43)]
            [ColumnName(@"col43")]
            public float Col43 { get; set; }

            [LoadColumn(44)]
            [ColumnName(@"col44")]
            public float Col44 { get; set; }

            [LoadColumn(45)]
            [ColumnName(@"col45")]
            public float Col45 { get; set; }

            [LoadColumn(46)]
            [ColumnName(@"col46")]
            public float Col46 { get; set; }

            [LoadColumn(47)]
            [ColumnName(@"col47")]
            public float Col47 { get; set; }

            [LoadColumn(48)]
            [ColumnName(@"col48")]
            public float Col48 { get; set; }

            [LoadColumn(49)]
            [ColumnName(@"col49")]
            public float Col49 { get; set; }

            [LoadColumn(50)]
            [ColumnName(@"col50")]
            public float Col50 { get; set; }

            [LoadColumn(51)]
            [ColumnName(@"col51")]
            public float Col51 { get; set; }

            [LoadColumn(52)]
            [ColumnName(@"col52")]
            public float Col52 { get; set; }

            [LoadColumn(53)]
            [ColumnName(@"col53")]
            public float Col53 { get; set; }

            [LoadColumn(54)]
            [ColumnName(@"col54")]
            public float Col54 { get; set; }

            [LoadColumn(55)]
            [ColumnName(@"col55")]
            public float Col55 { get; set; }

            [LoadColumn(56)]
            [ColumnName(@"col56")]
            public float Col56 { get; set; }

            [LoadColumn(57)]
            [ColumnName(@"col57")]
            public float Col57 { get; set; }

            [LoadColumn(58)]
            [ColumnName(@"col58")]
            public float Col58 { get; set; }

            [LoadColumn(59)]
            [ColumnName(@"col59")]
            public float Col59 { get; set; }

            [LoadColumn(60)]
            [ColumnName(@"col60")]
            public float Col60 { get; set; }

            [LoadColumn(61)]
            [ColumnName(@"col61")]
            public float Col61 { get; set; }

            [LoadColumn(62)]
            [ColumnName(@"col62")]
            public float Col62 { get; set; }

            [LoadColumn(63)]
            [ColumnName(@"col63")]
            public string Col63 { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel1.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"col0")]
            public float Col0 { get; set; }

            [ColumnName(@"col1")]
            public float Col1 { get; set; }

            [ColumnName(@"col2")]
            public float Col2 { get; set; }

            [ColumnName(@"col3")]
            public float Col3 { get; set; }

            [ColumnName(@"col4")]
            public float Col4 { get; set; }

            [ColumnName(@"col5")]
            public float Col5 { get; set; }

            [ColumnName(@"col6")]
            public float Col6 { get; set; }

            [ColumnName(@"col7")]
            public float Col7 { get; set; }

            [ColumnName(@"col8")]
            public float Col8 { get; set; }

            [ColumnName(@"col9")]
            public float Col9 { get; set; }

            [ColumnName(@"col10")]
            public float Col10 { get; set; }

            [ColumnName(@"col11")]
            public float Col11 { get; set; }

            [ColumnName(@"col12")]
            public float Col12 { get; set; }

            [ColumnName(@"col13")]
            public float Col13 { get; set; }

            [ColumnName(@"col14")]
            public float Col14 { get; set; }

            [ColumnName(@"col15")]
            public float Col15 { get; set; }

            [ColumnName(@"col16")]
            public float Col16 { get; set; }

            [ColumnName(@"col17")]
            public float Col17 { get; set; }

            [ColumnName(@"col18")]
            public float Col18 { get; set; }

            [ColumnName(@"col19")]
            public float Col19 { get; set; }

            [ColumnName(@"col20")]
            public float Col20 { get; set; }

            [ColumnName(@"col21")]
            public float Col21 { get; set; }

            [ColumnName(@"col22")]
            public float Col22 { get; set; }

            [ColumnName(@"col23")]
            public float Col23 { get; set; }

            [ColumnName(@"col24")]
            public float Col24 { get; set; }

            [ColumnName(@"col25")]
            public float Col25 { get; set; }

            [ColumnName(@"col26")]
            public float Col26 { get; set; }

            [ColumnName(@"col27")]
            public float Col27 { get; set; }

            [ColumnName(@"col28")]
            public float Col28 { get; set; }

            [ColumnName(@"col29")]
            public float Col29 { get; set; }

            [ColumnName(@"col30")]
            public float Col30 { get; set; }

            [ColumnName(@"col31")]
            public float Col31 { get; set; }

            [ColumnName(@"col32")]
            public float Col32 { get; set; }

            [ColumnName(@"col33")]
            public float Col33 { get; set; }

            [ColumnName(@"col34")]
            public float Col34 { get; set; }

            [ColumnName(@"col35")]
            public float Col35 { get; set; }

            [ColumnName(@"col36")]
            public float Col36 { get; set; }

            [ColumnName(@"col37")]
            public float Col37 { get; set; }

            [ColumnName(@"col38")]
            public float Col38 { get; set; }

            [ColumnName(@"col39")]
            public float Col39 { get; set; }

            [ColumnName(@"col40")]
            public float Col40 { get; set; }

            [ColumnName(@"col41")]
            public float Col41 { get; set; }

            [ColumnName(@"col42")]
            public float Col42 { get; set; }

            [ColumnName(@"col43")]
            public float Col43 { get; set; }

            [ColumnName(@"col44")]
            public float Col44 { get; set; }

            [ColumnName(@"col45")]
            public float Col45 { get; set; }

            [ColumnName(@"col46")]
            public float Col46 { get; set; }

            [ColumnName(@"col47")]
            public float Col47 { get; set; }

            [ColumnName(@"col48")]
            public float Col48 { get; set; }

            [ColumnName(@"col49")]
            public float Col49 { get; set; }

            [ColumnName(@"col50")]
            public float Col50 { get; set; }

            [ColumnName(@"col51")]
            public float Col51 { get; set; }

            [ColumnName(@"col52")]
            public float Col52 { get; set; }

            [ColumnName(@"col53")]
            public float Col53 { get; set; }

            [ColumnName(@"col54")]
            public float Col54 { get; set; }

            [ColumnName(@"col55")]
            public float Col55 { get; set; }

            [ColumnName(@"col56")]
            public float Col56 { get; set; }

            [ColumnName(@"col57")]
            public float Col57 { get; set; }

            [ColumnName(@"col58")]
            public float Col58 { get; set; }

            [ColumnName(@"col59")]
            public float Col59 { get; set; }

            [ColumnName(@"col60")]
            public float Col60 { get; set; }

            [ColumnName(@"col61")]
            public float Col61 { get; set; }

            [ColumnName(@"col62")]
            public float Col62 { get; set; }

            [ColumnName(@"col63")]
            public uint Col63 { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public string PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float[] Score { get; set; }

        }

        #endregion

        //private static string MLNetModelPath = Path.GetFullPath("MLModel1.zip");
        private static string MLNetModelPath = "";

        public static void SetModelPath(string path)
        {
            MLNetModelPath = path;
        }

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
