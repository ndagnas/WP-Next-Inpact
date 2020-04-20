﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : ArticleType.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet Article
// Créé le       : 23/03/2015
// Modifié le    : 23/03/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Globalization;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "NextInpact.Service"
//*******************************************************************************************************************************
namespace NextInpact.Service
	{

	//   ###   ####   #####  #   ###   #      #####         #####  #   #  ####   #####
	//  #   #  #   #    #    #  #   #  #      #               #     # #   #   #  #    
	//  #####  ####     #    #  #      #      ###    #####    #      #    ####   ###  
	//  #   #  #   #    #    #  #   #  #      #               #      #    #      #    
	//  #   #  #   #    #    #   ###   #####  #####           #      #    #      #####

	//***************************************************************************************************************************
	// Classe ArticleType
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Définit un type d'article.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public enum ArticleType
		{
		/// <summary>
		/// L'article est un article
		/// </summary>
		Article,
		/// <summary>
		/// L'article est un test
		/// </summary>
		Test   ,
		/// <summary>
		/// L'article est un dossier
		/// </summary>
		Folder ,
		/// <summary>
		/// L'article est une recherche
		/// </summary>
		Search ,
		/// <summary>
		/// L'article autre chose
		/// </summary>
		Other  ,
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "NextInpact.Service"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************