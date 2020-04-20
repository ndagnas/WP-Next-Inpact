﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : SR.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet SR
// Créé le       : 23/03/2015
// Modifié le    : 31/03/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Windows;
using System.Collections.Generic;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "NextInpact.Service.Resources"
//*******************************************************************************************************************************
namespace NextInpact.Service.Resources
	{

	//   ####  #### 
	//  #      #   #
	//   ###   #### 
	//      #  #   #
	//  ####   #   #
	
	//***************************************************************************************************************************
	// Classe SR
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Permet l'accès aux ressources.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public static class SR
		{
		//-----------------------------------------------------------------------------------------------------------------------
		// Section des Attributs
		//-----------------------------------------------------------------------------------------------------------------------
		private static Dictionary<string, string> ContentBuffer = null;
		//-----------------------------------------------------------------------------------------------------------------------

		//***********************************************************************************************************************
		/// <summary>
		/// Constructeur statique de l'objet <b>SR</b>.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		static SR () { SR.ContentBuffer = new Dictionary<string, string> (); }
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		/// <summary>
		/// Obtiens la ressources à l'emplacement spécifiée.
		/// </summary>
		/// <param name="Path">Dossier de la ressource.</param>
		/// <param name="Name">Nom de la ressource.</param>
		/// <returns>Ressources demandée.</returns>
		//-----------------------------------------------------------------------------------------------------------------------
		public static string GetResource ( string Path, string Name )
			{
			//-------------------------------------------------------------------------------------------------------------------
			#region // Implémentation de la Procédure
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			try
				{
				//---------------------------------------------------------------------------------------------------------------
				string FileName = string.Format ( "Service/Resources/{0}/{1}", Path, Name );

				if ( ContentBuffer.ContainsKey ( FileName ) ) return ContentBuffer[FileName];
				//---------------------------------------------------------------------------------------------------------------

				//---------------------------------------------------------------------------------------------------------------
#if WINDOWS_PHONE
				var File = Application.GetResourceStream ( new Uri ( FileName, UriKind.Relative ) );
#else
				var File = Application.GetRemoteStream ( new Uri ( FileName, UriKind.Relative ) );
#endif
				//---------------------------------------------------------------------------------------------------------------

				//---------------------------------------------------------------------------------------------------------------
				if ( File != null )
					{
					//-----------------------------------------------------------------------------------------------------------
					using ( var Sr = new StreamReader ( File.Stream ) )
						{
						//-------------------------------------------------------------------------------------------------------
						string Content = Sr.ReadToEnd ();

						ContentBuffer[FileName] = Content;

						return Content;
						//-------------------------------------------------------------------------------------------------------
						}
					//-----------------------------------------------------------------------------------------------------------
					}
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			catch {}
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			return string.Empty;
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			#endregion
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "NextInpact.Service.Resources"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
