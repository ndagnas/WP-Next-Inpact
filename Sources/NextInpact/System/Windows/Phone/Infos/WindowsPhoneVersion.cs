//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : WindowsPhoneVersion.cs
// Auteur        : Nicolas Dagnas
// Description   : Impl�mentation de l'objet WindowsPhoneVersion
// Cr�� le       : 13/05/2015
// Modifi� le    : 13/05/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// D�but du bloc "System.Windows.Phone.Infos"
//*******************************************************************************************************************************
namespace System.Windows.Phone.Infos
	{

	//  #   #  ####          #   #  #####  ####    ####  #   ###   #   #
	//  #   #  #   #         #   #  #      #   #  #      #  #   #  ##  #
	//  #   #  ####   #####  #   #  ###    ####    ###   #  #   #  # # #
	//  # # #  #              # #   #      #   #      #  #  #   #  #  ##
	//   # #   #               #    #####  #   #  ####   #   ###   #   #

	//***************************************************************************************************************************
	// Classe WindowsPhoneVersion
	//***************************************************************************************************************************
	#region // D�claration et Impl�mentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Permet de g�rer les diff�rentes version de Windows Phone.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public enum WindowsPhoneVersion
		{
		/// <summary>
		/// Windows Phone 7.
		/// </summary>
		WP70,
		/// <summary>
		/// Windows Phone 7.5.
		/// </summary>
		WP71,
		/// <summary>
		/// Windows Phone 8.
		/// </summary>
		WP80,
		/// <summary>
		/// Windows Phone 8.1.
		/// </summary>
		WP81,
		/// <summary>
		/// Windows Phone 10.
		/// </summary>
		WP10,
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "System.Windows.Phone.Infos"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************