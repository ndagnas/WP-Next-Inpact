﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : DismissedEventArgs.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de l'objet DismissedEventArgs
// Créé le       : 22/04/201ML5
// Modifié le    : 22/04/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "System.Windows.Phone.Controls"
//*******************************************************************************************************************************
namespace System.Windows.Phone.Controls
	{

	//  ####   #   ####  #   #  #   ####   ####  #  #   #   ###  
	//  #   #  #  #      ## ##  #  #      #      #  ##  #  #   # 
	//  #   #  #   ###   # # #  #   ###    ###   #  # # #  #     
	//  #   #  #      #  #   #  #      #      #  #  #  ##  #   ##
	//  ####   #  ####   #   #  #  ####   ####   #  #   #   ### #

	//***************************************************************************************************************************
	// Classe DismissedEventArgs
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Provides data for the CustomMessageBox's Dismissed event.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public class DismissedEventArgs : EventArgs
		{
		//***********************************************************************************************************************
		/// <summary>
		/// Initializes a new instance of the DismissedEventArgs class.
		/// </summary>
		/// <param name="result">The result value.</param>
		//-----------------------------------------------------------------------------------------------------------------------
		public DismissedEventArgs ( CustomMessageBoxResult Result ) { this.Result = Result; }
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		/// <summary>
		/// Gets or sets the result value.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public CustomMessageBoxResult Result { get; private set; }
		//***********************************************************************************************************************
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "System.Windows.Phone.Controls"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
