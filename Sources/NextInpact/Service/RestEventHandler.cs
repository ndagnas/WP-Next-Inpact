﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : RestEventArgs.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet RestEventArgs
// Créé le       : 24/02/2015
// Modifié le    : 24/02/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "NextInpact.Service"
//*******************************************************************************************************************************
namespace NextInpact.Service
	{
	
	//  ####   #####   ####  #####         #####  #   #  #####         #   #  ####   #### 
	//  #   #  #      #        #           #      #   #    #           #   #  #   #  #   #
	//  ####   ###     ###     #    #####  ###    #   #    #    #####  #####  #   #  #### 
	//  #   #  #          #    #           #       # #     #           #   #  #   #  #   #
	//  #   #  #####  ####     #           #####    #      #           #   #  ####   #   #

	//***************************************************************************************************************************
	// Délégué RestEventHandler
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Délégé utilisé pour passer une réponse du service-web.
	/// </summary>
	/// <param name="Sender">Objet à l'origine de l'appel.</param>
	/// <param name="Args">
	/// Objet <b>RestEventArgs</b> contenant les données de l'événement.
	/// </param>
	//---------------------------------------------------------------------------------------------------------------------------
	public delegate void RestEventHandler ( object Sender, RestEventArgs Args );
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "NextInpact.Service"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
