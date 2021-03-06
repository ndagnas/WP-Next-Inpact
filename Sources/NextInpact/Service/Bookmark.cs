﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : Bookmark.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet Bookmark
// Créé le       : 31/03/2015
// Modifié le    : 31/03/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Runtime.Serialization;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "NextInpact.Service"
//*******************************************************************************************************************************
namespace NextInpact.Service
	{

	//  ####    ###    ###   #   #  #   #   ###   ####   #   #
	//  #   #  #   #  #   #  #  #   ## ##  #   #  #   #  #  # 
	//  ####   #   #  #   #  ###    # # #  #####  ####   ###  
	//  #   #  #   #  #   #  #  #   #   #  #   #  #   #  #  # 
	//  ####    ###    ###   #   #  #   #  #   #  #   #  #   #

	//***************************************************************************************************************************
	// Classe Bookmark
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Définit un marque page.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	[DataContract]
	public class Bookmark
		{
		//***********************************************************************************************************************
		/// <summary>
		/// Initialise une nouvelle instance de l'objet <b>Article</b>.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public Bookmark () {}
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		/// <summary>
		/// Obtiens ou définit le titre de l'article.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		[DataMember]public string Title { get; set; }
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		/// <summary>
		/// Obtiens l'url de l'article.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		[DataMember]public string Uri { get; set; }
		//***********************************************************************************************************************
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "NextInpact.Service"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
