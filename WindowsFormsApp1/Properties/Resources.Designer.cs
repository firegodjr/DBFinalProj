﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFinalProj.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DBFinalProj.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE RESIDENT
        ///(	SSN					INT				NOT NULL,
        ///	PhoneN				VARCHAR(20),
        ///	Name				VARCHAR(30)		NOT NULL,
        ///	OutstandingBalance	INT,
        ///	MissedChores		TINYINT,
        ///	SmallGroup			VARCHAR(50),	
        ///	NextSemesterPlan	VARCHAR(50),
        ///	GradDate			DATE,
        ///	ContractStartDate	DATE			NOT NULL,
        ///	ContractEndDate		DATE			NOT NULL,
        ///	ContractMealPlan	VARCHAR(20),
        ///	KP					BOOL			NOT NULL,
        ///	FM					BOOL			NOT NULL,
        ///	Primary Key(SSN)
        ///);
        ///
        ///CREATE TABLE ROOM
        ///(	RoomNumber		SMALLINT		NOT NULL,
        ///	ChoreSet		VARCHAR(10)		NOT NULL,
        ///	 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Create_Script {
            get {
                return ResourceManager.GetString("Create_Script", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO resident
        ///VALUES 
        ///(000000001, &quot;618-618-6118&quot;, &quot;Kermit Kermidian&quot;, 250, 6, &quot;Kermit&apos;s Deep Talks&quot;, &quot;Kermit Plans to Move Out&quot;, 20220522, 20170818,20220517,&quot;Meal Plan 1&quot;,1, 0),
        ///(000000002, &quot;666-654-7890&quot;, &quot;Ms. Piggy&quot;, 6, 0, &quot;Kermit&apos;s Deep Talks&quot;, &quot;Co-Op in Nashville&quot;, 20220522, 20170818,20220517,&quot;Meal Plan 3&quot;,0, 0),
        ///(000000003, &quot;666-654-7891&quot;, &quot;Grover&quot;, 1200, 13, &quot;Kermit&apos;s Deep Talks&quot;, &quot;Stay in House&quot;, 20220522, 20170818,20220517,&quot;Meal Plan 2&quot;,0, 0),
        ///(000000004, &quot;666-654-2222&quot;, &quot;Cookie Monster&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Insert_Script {
            get {
                return ResourceManager.GetString("Insert_Script", resourceCulture);
            }
        }
    }
}
