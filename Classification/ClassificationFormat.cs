﻿//***************************************************************************
// 
//  MIT License
//
//  Copyright(c) 2019 gojimmypi
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
//
//***************************************************************************


using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using MColor = System.Windows.Media.Color; // yes, this can be simplified, but given the same names this adds clarity
using DColor = System.Drawing.Color;
using Microsoft.VisualStudio.PlatformUI;
using Microsoft.VisualStudio.Shell.Interop;

namespace VerilogLanguage
{
    #region Format definition

    #region ColorConverter
    public static class ColorConverter
    {
        /// <summary>
        /// Converts a System.Drawing.Color obtained from GetThemedColor to a System.Windows.Media.Color needed for EditorFormatDefinitions
        /// </summary>
        public static MColor ToMediaColor(this DColor color)
        {
            // thank you https://stackoverflow.com/questions/6096299/extension-methods-must-be-defined-in-a-non-generic-static-class
            // thank you https://stackoverflow.com/questions/4104910/convert-system-drawing-color-to-system-windows-media-color
            return MColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }
    #endregion


    #region Keyword always 
    /// <summary>
    /// Defines the editor format for the Verilog_always classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "always")]
    [Name("always")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_always : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "always" classification type
        /// </summary>
        public Verilog_always()
        {
            DisplayName = "Verilog - always"; //human readable version of the name (in Tools>Options>Environment>Fonts and Colors>Text Editor
                                              //System.Drawing.Color thisColor = Microsoft.VisualStudio.PlatformUI.VSColorTheme.GetThemedColor(Microsoft.VisualStudio.PlatformUI.EnvironmentColors.ClassDesignerCommentTextColorKey);
                                              //ForegroundColor = MColor.FromArgb(thisColor.A, thisColor.R, thisColor.G, thisColor.B);

            // ForegroundColor = ColorConverter.ToMediaColor(VSColorTheme.GetThemedColor(EnvironmentColors.ClassDesignerCommentTextColorKey));
            ForegroundColor = Colors.BlueViolet;

            // https://docs.microsoft.com/en-us/dotnet/api/system.attribute.getcustomattributes?view=netframework-4.7.2
            // System.Windows.Media.Colors mc = Microsoft.VisualStudio.Text.Classification.ClassificationTypeAttribute.GetCustomAttributes();
            // EditorFormatDefinition.DisplayName();
        }
    }

    #endregion // Keyword always



    #region Keyword assign 
    /// <summary>
    /// Defines the editor format for the Verilog_assign classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "assign")]
    [Name("assign")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_assign : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "assign" classification type
        /// </summary>
        public Verilog_assign()
        {
            DisplayName = "Verilog - assign"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword assign



    #region Keyword automatic 
    /// <summary>
    /// Defines the editor format for the Verilog_automatic classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "automatic")]
    [Name("automatic")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_automatic : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "automatic" classification type
        /// </summary>
        public Verilog_automatic()
        {
            DisplayName = "Verilog - automatic"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword automatic



    #region Keyword begin 
    /// <summary>
    /// Defines the editor format for the Verilog_begin classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "begin")]
    [Name("begin")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_begin : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "begin" classification type
        /// </summary>
        public Verilog_begin()
        {
            DisplayName = "Verilog - begin"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword begin



    #region Keyword case 
    /// <summary>
    /// Defines the editor format for the Verilog_case classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "case")]
    [Name("case")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_case : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "case" classification type
        /// </summary>
        public Verilog_case()
        {
            DisplayName = "Verilog - case"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword case



    #region Keyword casex 
    /// <summary>
    /// Defines the editor format for the Verilog_casex classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "casex")]
    [Name("casex")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_casex : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "casex" classification type
        /// </summary>
        public Verilog_casex()
        {
            DisplayName = "Verilog - casex"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword casex



    #region Keyword casez 
    /// <summary>
    /// Defines the editor format for the Verilog_casez classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "casez")]
    [Name("casez")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_casez : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "casez" classification type
        /// </summary>
        public Verilog_casez()
        {
            DisplayName = "Verilog - casez"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword casez



    #region Keyword cell 
    /// <summary>
    /// Defines the editor format for the Verilog_cell classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "cell")]
    [Name("cell")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_cell : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "cell" classification type
        /// </summary>
        public Verilog_cell()
        {
            DisplayName = "Verilog - cell"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword cell



    #region Keyword config 
    /// <summary>
    /// Defines the editor format for the Verilog_config classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "config")]
    [Name("config")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_config : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "config" classification type
        /// </summary>
        public Verilog_config()
        {
            DisplayName = "Verilog - config"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword config



    #region Keyword deassign 
    /// <summary>
    /// Defines the editor format for the Verilog_deassign classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "deassign")]
    [Name("deassign")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_deassign : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "deassign" classification type
        /// </summary>
        public Verilog_deassign()
        {
            DisplayName = "Verilog - deassign"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword deassign



    #region Keyword default 
    /// <summary>
    /// Defines the editor format for the Verilog_default classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "default")]
    [Name("default")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_default : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "default" classification type
        /// </summary>
        public Verilog_default()
        {
            DisplayName = "Verilog - default"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword default



    #region Keyword defparam 
    /// <summary>
    /// Defines the editor format for the Verilog_defparam classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "defparam")]
    [Name("defparam")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_defparam : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "defparam" classification type
        /// </summary>
        public Verilog_defparam()
        {
            DisplayName = "Verilog - defparam"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword defparam



    #region Keyword design 
    /// <summary>
    /// Defines the editor format for the Verilog_design classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "design")]
    [Name("design")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_design : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "design" classification type
        /// </summary>
        public Verilog_design()
        {
            DisplayName = "Verilog - design"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword design



    #region Keyword disable 
    /// <summary>
    /// Defines the editor format for the Verilog_disable classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "disable")]
    [Name("disable")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_disable : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "disable" classification type
        /// </summary>
        public Verilog_disable()
        {
            DisplayName = "Verilog - disable"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword disable



    #region Keyword edge 
    /// <summary>
    /// Defines the editor format for the Verilog_edge classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "edge")]
    [Name("edge")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_edge : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "edge" classification type
        /// </summary>
        public Verilog_edge()
        {
            DisplayName = "Verilog - edge"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword edge



    #region Keyword else 
    /// <summary>
    /// Defines the editor format for the Verilog_else classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "else")]
    [Name("else")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_else : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "else" classification type
        /// </summary>
        public Verilog_else()
        {
            DisplayName = "Verilog - else"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword else



    #region Keyword end 
    /// <summary>
    /// Defines the editor format for the Verilog_end classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "end")]
    [Name("end")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_end : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "end" classification type
        /// </summary>
        public Verilog_end()
        {
            DisplayName = "Verilog - end"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword end



    #region Keyword endcase 
    /// <summary>
    /// Defines the editor format for the Verilog_endcase classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "endcase")]
    [Name("endcase")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_endcase : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "endcase" classification type
        /// </summary>
        public Verilog_endcase()
        {
            DisplayName = "Verilog - endcase"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword endcase



    #region Keyword endconfig 
    /// <summary>
    /// Defines the editor format for the Verilog_endconfig classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "endconfig")]
    [Name("endconfig")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_endconfig : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "endconfig" classification type
        /// </summary>
        public Verilog_endconfig()
        {
            DisplayName = "Verilog - endconfig"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword endconfig



    #region Keyword endfunction 
    /// <summary>
    /// Defines the editor format for the Verilog_endfunction classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "endfunction")]
    [Name("endfunction")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_endfunction : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "endfunction" classification type
        /// </summary>
        public Verilog_endfunction()
        {
            DisplayName = "Verilog - endfunction"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword endfunction



    #region Keyword endgenerate 
    /// <summary>
    /// Defines the editor format for the Verilog_endgenerate classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "endgenerate")]
    [Name("endgenerate")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_endgenerate : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "endgenerate" classification type
        /// </summary>
        public Verilog_endgenerate()
        {
            DisplayName = "Verilog - endgenerate"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword endgenerate



    #region Keyword endmodule 
    /// <summary>
    /// Defines the editor format for the Verilog_endmodule classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "endmodule")]
    [Name("endmodule")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_endmodule : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "endmodule" classification type
        /// </summary>
        public Verilog_endmodule()
        {
            DisplayName = "Verilog - endmodule"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword endmodule



    #region Keyword endprimitive 
    /// <summary>
    /// Defines the editor format for the Verilog_endprimitive classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "endprimitive")]
    [Name("endprimitive")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_endprimitive : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "endprimitive" classification type
        /// </summary>
        public Verilog_endprimitive()
        {
            DisplayName = "Verilog - endprimitive"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword endprimitive



    #region Keyword endspecify 
    /// <summary>
    /// Defines the editor format for the Verilog_endspecify classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "endspecify")]
    [Name("endspecify")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_endspecify : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "endspecify" classification type
        /// </summary>
        public Verilog_endspecify()
        {
            DisplayName = "Verilog - endspecify"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword endspecify



    #region Keyword endtable 
    /// <summary>
    /// Defines the editor format for the Verilog_endtable classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "endtable")]
    [Name("endtable")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_endtable : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "endtable" classification type
        /// </summary>
        public Verilog_endtable()
        {
            DisplayName = "Verilog - endtable"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword endtable



    #region Keyword endtask 
    /// <summary>
    /// Defines the editor format for the Verilog_endtask classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "endtask")]
    [Name("endtask")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_endtask : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "endtask" classification type
        /// </summary>
        public Verilog_endtask()
        {
            DisplayName = "Verilog - endtask"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword endtask



    #region Keyword event 
    /// <summary>
    /// Defines the editor format for the Verilog_event classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "event")]
    [Name("event")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_event : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "event" classification type
        /// </summary>
        public Verilog_event()
        {
            DisplayName = "Verilog - event"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword event



    #region Keyword for 
    /// <summary>
    /// Defines the editor format for the Verilog_for classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "for")]
    [Name("for")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_for : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "for" classification type
        /// </summary>
        public Verilog_for()
        {
            DisplayName = "Verilog - for"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword for



    #region Keyword force 
    /// <summary>
    /// Defines the editor format for the Verilog_force classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "force")]
    [Name("force")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_force : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "force" classification type
        /// </summary>
        public Verilog_force()
        {
            DisplayName = "Verilog - force"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword force



    #region Keyword forever 
    /// <summary>
    /// Defines the editor format for the Verilog_forever classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "forever")]
    [Name("forever")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_forever : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "forever" classification type
        /// </summary>
        public Verilog_forever()
        {
            DisplayName = "Verilog - forever"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword forever



    #region Keyword fork 
    /// <summary>
    /// Defines the editor format for the Verilog_fork classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "fork")]
    [Name("fork")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_fork : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "fork" classification type
        /// </summary>
        public Verilog_fork()
        {
            DisplayName = "Verilog - fork"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword fork



    #region Keyword function 
    /// <summary>
    /// Defines the editor format for the Verilog_function classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "function")]
    [Name("function")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_function : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "function" classification type
        /// </summary>
        public Verilog_function()
        {
            DisplayName = "Verilog - function"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword function



    #region Keyword generate 
    /// <summary>
    /// Defines the editor format for the Verilog_generate classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "generate")]
    [Name("generate")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_generate : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "generate" classification type
        /// </summary>
        public Verilog_generate()
        {
            DisplayName = "Verilog - generate"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword generate



    #region Keyword genvar 
    /// <summary>
    /// Defines the editor format for the Verilog_genvar classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "genvar")]
    [Name("genvar")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_genvar : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "genvar" classification type
        /// </summary>
        public Verilog_genvar()
        {
            DisplayName = "Verilog - genvar"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword genvar



    #region Keyword if 
    /// <summary>
    /// Defines the editor format for the Verilog_if classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "if")]
    [Name("if")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_if : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "if" classification type
        /// </summary>
        public Verilog_if()
        {
            DisplayName = "Verilog - if"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword if



    #region Keyword ifnone 
    /// <summary>
    /// Defines the editor format for the Verilog_ifnone classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "ifnone")]
    [Name("ifnone")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_ifnone : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "ifnone" classification type
        /// </summary>
        public Verilog_ifnone()
        {
            DisplayName = "Verilog - ifnone"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword ifnone



    #region Keyword incdir 
    /// <summary>
    /// Defines the editor format for the Verilog_incdir classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "incdir")]
    [Name("incdir")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_incdir : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "incdir" classification type
        /// </summary>
        public Verilog_incdir()
        {
            DisplayName = "Verilog - incdir"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword incdir



    #region Keyword include 
    /// <summary>
    /// Defines the editor format for the Verilog_include classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "include")]
    [Name("include")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_include : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "include" classification type
        /// </summary>
        public Verilog_include()
        {
            DisplayName = "Verilog - include"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword include



    #region Keyword initial 
    /// <summary>
    /// Defines the editor format for the Verilog_initial classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "initial")]
    [Name("initial")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_initial : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "initial" classification type
        /// </summary>
        public Verilog_initial()
        {
            DisplayName = "Verilog - initial"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword initial



    #region Keyword inout 
    /// <summary>
    /// Defines the editor format for the Verilog_inout classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "inout")]
    [Name("inout")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_inout : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "inout" classification type
        /// </summary>
        public Verilog_inout()
        {
            DisplayName = "Verilog - inout"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword inout



    #region Keyword input 
    /// <summary>
    /// Defines the editor format for the Verilog_input classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "input")]
    [Name("input")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_input : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "input" classification type
        /// </summary>
        public Verilog_input()
        {
            DisplayName = "Verilog - input"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword input



    #region Keyword instance 
    /// <summary>
    /// Defines the editor format for the Verilog_instance classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "instance")]
    [Name("instance")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_instance : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "instance" classification type
        /// </summary>
        public Verilog_instance()
        {
            DisplayName = "Verilog - instance"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword instance



    #region Keyword join 
    /// <summary>
    /// Defines the editor format for the Verilog_join classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "join")]
    [Name("join")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_join : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "join" classification type
        /// </summary>
        public Verilog_join()
        {
            DisplayName = "Verilog - join"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword join



    #region Keyword liblist 
    /// <summary>
    /// Defines the editor format for the Verilog_liblist classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "liblist")]
    [Name("liblist")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_liblist : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "liblist" classification type
        /// </summary>
        public Verilog_liblist()
        {
            DisplayName = "Verilog - liblist"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword liblist



    #region Keyword library 
    /// <summary>
    /// Defines the editor format for the Verilog_library classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "library")]
    [Name("library")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_library : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "library" classification type
        /// </summary>
        public Verilog_library()
        {
            DisplayName = "Verilog - library"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword library



    #region Keyword localparam 
    /// <summary>
    /// Defines the editor format for the Verilog_localparam classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "localparam")]
    [Name("localparam")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_localparam : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "localparam" classification type
        /// </summary>
        public Verilog_localparam()
        {
            DisplayName = "Verilog - localparam"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword localparam



    #region Keyword macromodule 
    /// <summary>
    /// Defines the editor format for the Verilog_macromodule classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "macromodule")]
    [Name("macromodule")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_macromodule : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "macromodule" classification type
        /// </summary>
        public Verilog_macromodule()
        {
            DisplayName = "Verilog - macromodule"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword macromodule



    #region Keyword module 
    /// <summary>
    /// Defines the editor format for the Verilog_module classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "module")]
    [Name("module")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_module : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "module" classification type
        /// </summary>
        public Verilog_module()
        {
            DisplayName = "Verilog - module"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword module



    #region Keyword negedge 
    /// <summary>
    /// Defines the editor format for the Verilog_negedge classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "negedge")]
    [Name("negedge")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_negedge : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "negedge" classification type
        /// </summary>
        public Verilog_negedge()
        {
            DisplayName = "Verilog - negedge"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword negedge



    #region Keyword noshowcancelled 
    /// <summary>
    /// Defines the editor format for the Verilog_noshowcancelled classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "noshowcancelled")]
    [Name("noshowcancelled")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_noshowcancelled : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "noshowcancelled" classification type
        /// </summary>
        public Verilog_noshowcancelled()
        {
            DisplayName = "Verilog - noshowcancelled"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword noshowcancelled



    #region Keyword output 
    /// <summary>
    /// Defines the editor format for the Verilog_output classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "output")]
    [Name("output")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_output : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "output" classification type
        /// </summary>
        public Verilog_output()
        {
            DisplayName = "Verilog - output"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword output



    #region Keyword parameter 
    /// <summary>
    /// Defines the editor format for the Verilog_parameter classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "parameter")]
    [Name("parameter")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_parameter : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "parameter" classification type
        /// </summary>
        public Verilog_parameter()
        {
            DisplayName = "Verilog - parameter"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword parameter



    #region Keyword posedge 
    /// <summary>
    /// Defines the editor format for the Verilog_posedge classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "posedge")]
    [Name("posedge")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_posedge : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "posedge" classification type
        /// </summary>
        public Verilog_posedge()
        {
            DisplayName = "Verilog - posedge"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword posedge



    #region Keyword primitive 
    /// <summary>
    /// Defines the editor format for the Verilog_primitive classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "primitive")]
    [Name("primitive")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_primitive : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "primitive" classification type
        /// </summary>
        public Verilog_primitive()
        {
            DisplayName = "Verilog - primitive"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword primitive



    #region Keyword pulsestyle_ondetect 
    /// <summary>
    /// Defines the editor format for the Verilog_pulsestyle_ondetect classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "pulsestyle_ondetect")]
    [Name("pulsestyle_ondetect")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_pulsestyle_ondetect : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "pulsestyle_ondetect" classification type
        /// </summary>
        public Verilog_pulsestyle_ondetect()
        {
            DisplayName = "Verilog - pulsestyle_ondetect"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword pulsestyle_ondetect



    #region Keyword pulsestyle_onevent 
    /// <summary>
    /// Defines the editor format for the Verilog_pulsestyle_onevent classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "pulsestyle_onevent")]
    [Name("pulsestyle_onevent")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_pulsestyle_onevent : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "pulsestyle_onevent" classification type
        /// </summary>
        public Verilog_pulsestyle_onevent()
        {
            DisplayName = "Verilog - pulsestyle_onevent"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword pulsestyle_onevent



    #region Keyword reg 
    /// <summary>
    /// Defines the editor format for the Verilog_reg classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "reg")]
    [Name("reg")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_reg : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "reg" classification type
        /// </summary>
        public Verilog_reg()
        {
            DisplayName = "Verilog - reg"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword reg



    #region Keyword release 
    /// <summary>
    /// Defines the editor format for the Verilog_release classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "release")]
    [Name("release")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_release : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "release" classification type
        /// </summary>
        public Verilog_release()
        {
            DisplayName = "Verilog - release"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword release



    #region Keyword repeat 
    /// <summary>
    /// Defines the editor format for the Verilog_repeat classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "repeat")]
    [Name("repeat")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_repeat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "repeat" classification type
        /// </summary>
        public Verilog_repeat()
        {
            DisplayName = "Verilog - repeat"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword repeat



    #region Keyword scalared 
    /// <summary>
    /// Defines the editor format for the Verilog_scalared classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "scalared")]
    [Name("scalared")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_scalared : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "scalared" classification type
        /// </summary>
        public Verilog_scalared()
        {
            DisplayName = "Verilog - scalared"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword scalared



    #region Keyword showcancelled 
    /// <summary>
    /// Defines the editor format for the Verilog_showcancelled classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "showcancelled")]
    [Name("showcancelled")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_showcancelled : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "showcancelled" classification type
        /// </summary>
        public Verilog_showcancelled()
        {
            DisplayName = "Verilog - showcancelled"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword showcancelled



    #region Keyword signed 
    /// <summary>
    /// Defines the editor format for the Verilog_signed classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "signed")]
    [Name("signed")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_signed : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "signed" classification type
        /// </summary>
        public Verilog_signed()
        {
            DisplayName = "Verilog - signed"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword signed



    #region Keyword specify 
    /// <summary>
    /// Defines the editor format for the Verilog_specify classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "specify")]
    [Name("specify")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_specify : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "specify" classification type
        /// </summary>
        public Verilog_specify()
        {
            DisplayName = "Verilog - specify"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword specify



    #region Keyword specparam 
    /// <summary>
    /// Defines the editor format for the Verilog_specparam classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "specparam")]
    [Name("specparam")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_specparam : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "specparam" classification type
        /// </summary>
        public Verilog_specparam()
        {
            DisplayName = "Verilog - specparam"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword specparam



    #region Keyword strength 
    /// <summary>
    /// Defines the editor format for the Verilog_strength classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "strength")]
    [Name("strength")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_strength : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "strength" classification type
        /// </summary>
        public Verilog_strength()
        {
            DisplayName = "Verilog - strength"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword strength



    #region Keyword table 
    /// <summary>
    /// Defines the editor format for the Verilog_table classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "table")]
    [Name("table")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_table : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "table" classification type
        /// </summary>
        public Verilog_table()
        {
            DisplayName = "Verilog - table"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword table



    #region Keyword task 
    /// <summary>
    /// Defines the editor format for the Verilog_task classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "task")]
    [Name("task")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_task : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "task" classification type
        /// </summary>
        public Verilog_task()
        {
            DisplayName = "Verilog - task"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword task



    #region Keyword tri 
    /// <summary>
    /// Defines the editor format for the Verilog_tri classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "tri")]
    [Name("tri")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_tri : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "tri" classification type
        /// </summary>
        public Verilog_tri()
        {
            DisplayName = "Verilog - tri"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword tri



    #region Keyword tri0 
    /// <summary>
    /// Defines the editor format for the Verilog_tri0 classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "tri0")]
    [Name("tri0")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_tri0 : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "tri0" classification type
        /// </summary>
        public Verilog_tri0()
        {
            DisplayName = "Verilog - tri0"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword tri0



    #region Keyword tri1 
    /// <summary>
    /// Defines the editor format for the Verilog_tri1 classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "tri1")]
    [Name("tri1")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_tri1 : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "tri1" classification type
        /// </summary>
        public Verilog_tri1()
        {
            DisplayName = "Verilog - tri1"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword tri1



    #region Keyword triand 
    /// <summary>
    /// Defines the editor format for the Verilog_triand classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "triand")]
    [Name("triand")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_triand : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "triand" classification type
        /// </summary>
        public Verilog_triand()
        {
            DisplayName = "Verilog - triand"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword triand



    #region Keyword wand 
    /// <summary>
    /// Defines the editor format for the Verilog_wand classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "wand")]
    [Name("wand")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_wand : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "wand" classification type
        /// </summary>
        public Verilog_wand()
        {
            DisplayName = "Verilog - wand"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword wand



    #region Keyword trior 
    /// <summary>
    /// Defines the editor format for the Verilog_trior classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "trior")]
    [Name("trior")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_trior : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "trior" classification type
        /// </summary>
        public Verilog_trior()
        {
            DisplayName = "Verilog - trior"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword trior



    #region Keyword wor 
    /// <summary>
    /// Defines the editor format for the Verilog_wor classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "wor")]
    [Name("wor")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_wor : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "wor" classification type
        /// </summary>
        public Verilog_wor()
        {
            DisplayName = "Verilog - wor"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword wor



    #region Keyword trireg 
    /// <summary>
    /// Defines the editor format for the Verilog_trireg classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "trireg")]
    [Name("trireg")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_trireg : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "trireg" classification type
        /// </summary>
        public Verilog_trireg()
        {
            DisplayName = "Verilog - trireg"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword trireg



    #region Keyword unsigned 
    /// <summary>
    /// Defines the editor format for the Verilog_unsigned classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "unsigned")]
    [Name("unsigned")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_unsigned : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "unsigned" classification type
        /// </summary>
        public Verilog_unsigned()
        {
            DisplayName = "Verilog - unsigned"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword unsigned



    #region Keyword use 
    /// <summary>
    /// Defines the editor format for the Verilog_use classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "use")]
    [Name("use")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_use : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "use" classification type
        /// </summary>
        public Verilog_use()
        {
            DisplayName = "Verilog - use"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword use



    #region Keyword vectored 
    /// <summary>
    /// Defines the editor format for the Verilog_vectored classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "vectored")]
    [Name("vectored")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_vectored : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "vectored" classification type
        /// </summary>
        public Verilog_vectored()
        {
            DisplayName = "Verilog - vectored"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword vectored



    #region Keyword wait 
    /// <summary>
    /// Defines the editor format for the Verilog_wait classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "wait")]
    [Name("wait")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_wait : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "wait" classification type
        /// </summary>
        public Verilog_wait()
        {
            DisplayName = "Verilog - wait"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword wait



    #region Keyword while 
    /// <summary>
    /// Defines the editor format for the Verilog_while classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "while")]
    [Name("while")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_while : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "while" classification type
        /// </summary>
        public Verilog_while()
        {
            DisplayName = "Verilog - while"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword while



    #region Keyword wire 
    /// <summary>
    /// Defines the editor format for the Verilog_wire classification type. Text is colored BlueViolet
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "wire")]
    [Name("wire")]
    //this should be visible to the end user
    [UserVisible(true)] // sets this editor format definition visible for the user (in Tools>Options>Environment>Fonts and Colors>Text Editor
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_wire : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "wire" classification type
        /// </summary>
        public Verilog_wire()
        {
            DisplayName = "Verilog - wire"; //human readable version of the name
            ForegroundColor = Colors.BlueViolet;
        }
    }

    #endregion // Keyword wire


    #endregion //Format definition

    #region directives

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "directive")]
    [Name("directive")]
    //this should be visible to the end user
    [UserVisible(true)]
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_directive : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "directive" classification type
        /// </summary>
        public Verilog_directive()
        {
            DisplayName = "Verilog - Directive"; //human readable version of the name
            ForegroundColor = Colors.IndianRed;
        }
    }
    #endregion

    #region comments

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "vcomment")]
    [Name("vcomment")]
    //this should be visible to the end user
    [UserVisible(true)]
    //set the priority to be after the default classifiers
    [Order(Before = Priority.Default)]
    internal sealed class Verilog_comment : ClassificationFormatDefinition
    {
        /// <summary>
        /// Defines the visual format for the "directive" classification type
        /// </summary>
        public Verilog_comment()
        {
            DisplayName = "Verilog - Comment"; //human readable version of the name
            ForegroundColor = Colors.LightSeaGreen;
        }
    }
    #endregion
}
