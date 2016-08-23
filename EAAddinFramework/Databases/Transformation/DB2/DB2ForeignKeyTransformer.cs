﻿
using System;
using System.Collections.Generic;
using System.Linq;
using UML=TSF.UmlToolingFramework.UML;
using UTF_EA=TSF.UmlToolingFramework.Wrappers.EA;
using DB=DatabaseFramework;
using DB_EA = EAAddinFramework.Databases;
using EAAddinFramework.Utilities;

namespace EAAddinFramework.Databases.Transformation.DB2
{
	/// <summary>
	/// Description of DB2ForeignKeyTransformer.
	/// </summary>
	public class DB2ForeignKeyTransformer:EAForeignKeyTransformer
	{
		public DB2ForeignKeyTransformer(ForeignKey foreignKey, UTF_EA.Association association):base(foreignKey,association)
		{
		}
	}
}
