﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : SectionsPopup.xaml.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation de la Popup SectionsPopup
// Environnement : Visual Studio 2012
// Créé le       : 12/05/2015
// Modifié le    : 12/05/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Phone.Infos;
using System.Windows.Media.Imaging;
using System.Windows.Controls.Primitives;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
using NextInpact.Service;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "NextInpact.Popups"
//*******************************************************************************************************************************
namespace NextInpact.Popups
	{

	//   ####  #####   ###   #####  #   ###   #   #   ####
	//  #      #      #   #    #    #  #   #  ##  #  #    
	//   ###   ###    #        #    #  #   #  # # #   ### 
	//      #  #      #   #    #    #  #   #  #  ##      #
	//  ####   #####   ###     #    #   ###   #   #  #### 

	//***************************************************************************************************************************
	// Classe SectionsPopup
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Fournit une fenêtre de zoom sur une photo.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public partial class SectionsPopup : UserControl
		{
		//-----------------------------------------------------------------------------------------------------------------------
		// Section des Attributs
		//-----------------------------------------------------------------------------------------------------------------------
		private EventHandler OnComplete;
		//-----------------------------------------------------------------------------------------------------------------------

		//***********************************************************************************************************************
		/// <summary>
		/// Initialise une nouvelle instance de l'objet <b>SectionsPopup</b>.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public SectionsPopup ()
			{
			//-------------------------------------------------------------------------------------------------------------------
			this.InitializeComponent ();
			
			this.OnOrientationChanged ( DeviceInfos.Orientation );
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		/// <summary>
		/// Initialise une nouvelle instance de l'objet <b>SectionsPopup</b>.
		/// </summary>
		//-----------------------------------------------------------------------------------------------------------------------
		public SectionsPopup ( EventHandler OnComplete )
			{
			//-------------------------------------------------------------------------------------------------------------------
			this.InitializeComponent ();

			this.OnComplete = OnComplete;

			this.OnOrientationChanged ( DeviceInfos.Orientation );
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		// Prototype   : protected override void OnOrientationChanged ( 
		//                                                       OrientationChangedEventArgs Args )
		// Description : Appelé après la modification de la propriété Orientation
		//***********************************************************************************************************************
		/// <summary>
		/// Appelé après la modification de la propriété Orientation.
		/// </summary>
		/// <param name="Args">Arguments d'événement.</param>
		//-----------------------------------------------------------------------------------------------------------------------
		public void OnOrientationChanged ( PhoneOrientation Value )
			{
			//-------------------------------------------------------------------------------------------------------------------
			double ButtonCount = 3;
			double ScreenWidth = 480;
			
			if ( Value == PhoneOrientation.Portrait )
				{
				//---------------------------------------------------------------------------------------------------------------
				ButtonCount = 3;
				ScreenWidth = Application.Current.Host.Content.ActualWidth;
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			else
				{
				//---------------------------------------------------------------------------------------------------------------
				ButtonCount = 5;
				//---------------------------------------------------------------------------------------------------------------

				//---------------------------------------------------------------------------------------------------------------
				#if WP80
				//---------------------------------------------------------------------------------------------------------------
					ScreenWidth = Application.Current.Host.Content.ActualHeight - 
				                                                  DeviceInfos.ApplicationBarHeight;
				//---------------------------------------------------------------------------------------------------------------
				#endif
				//---------------------------------------------------------------------------------------------------------------

				//---------------------------------------------------------------------------------------------------------------
				#if WP81
				//---------------------------------------------------------------------------------------------------------------
					ScreenWidth = Application.Current.Host.Content.ActualHeight - 
				                                              DeviceInfos.ApplicationBarHeight * 2;
				//---------------------------------------------------------------------------------------------------------------
				#endif
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------

			//-------------------------------------------------------------------------------------------------------------------
			double ItemWidth = ( ScreenWidth - ( 4 * ( ButtonCount + 1 ) ) ) / ButtonCount;

			foreach ( FrameworkElement Child in this.Layout.Children ) Child.Width = ItemWidth;
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		/// <summary>
		/// Est appelé lors d'un clic sur un lien interne.
		/// </summary>
		/// <param name="Sender">Objet source de l'appel.</param>
		/// <param name="Args"><b>RoutedEventArgs</b> qui contient les données d'événement.</param>
		//-----------------------------------------------------------------------------------------------------------------------
		private void OnSectionClick ( object Sender, RoutedEventArgs Args )
			{
			//-------------------------------------------------------------------------------------------------------------------
			var Self = Sender as FrameworkElement;

			if ( Self != null && this.OnComplete != null )
				{
				//---------------------------------------------------------------------------------------------------------------
				SectionType Section = SectionType.All;
				//---------------------------------------------------------------------------------------------------------------
				
				//---------------------------------------------------------------------------------------------------------------
				switch ( Self.Tag.ToString () )
					{
					//-----------------------------------------------------------------------------------------------------------
					case "SectionType.Culture"   : Section = SectionType.Culture;   break;
					case "SectionType.Law"       : Section = SectionType.Law;       break;
					case "SectionType.Economy"   : Section = SectionType.Economy;   break;
					case "SectionType.Internet"  : Section = SectionType.Internet;  break;
					case "SectionType.Software"  : Section = SectionType.Software;  break;
					case "SectionType.Hardware"  : Section = SectionType.Hardware;  break;
					case "SectionType.Mobility"  : Section = SectionType.Mobility;  break;
					case "SectionType.Drafting"  : Section = SectionType.Drafting;  break;
					//-----------------------------------------------------------------------------------------------------------
					case "SectionType.Tests"     : Section = SectionType.Tests;     break;
					case "SectionType.Folders"   : Section = SectionType.Folders;   break;
					case "SectionType.GoodDeals" : Section = SectionType.GoodDeals; break;
					case "SectionType.Forum"     : Section = SectionType.Forum;     break;
					case "SectionType.Shoutbox"  : Section = SectionType.Shoutbox;  break;
					case "SectionType.Bookmarks" : Section = SectionType.Bookmarks; break;
					//-----------------------------------------------------------------------------------------------------------

					}
				//---------------------------------------------------------------------------------------------------------------
				
				//---------------------------------------------------------------------------------------------------------------
				this.OnComplete ( this, new ObjectEventArgs<SectionType> ( Section ) );
				//---------------------------------------------------------------------------------------------------------------
				}
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		/// <summary>
		/// Est appelé lors d'un clic sur un lien interne.
		/// </summary>
		/// <param name="Sender">Objet source de l'appel.</param>
		/// <param name="Args"><b>RoutedEventArgs</b> qui contient les données d'événement.</param>
		//-----------------------------------------------------------------------------------------------------------------------
		private void OnOptionsButtonClick ( object Sender, RoutedEventArgs Args )
			{
			//-------------------------------------------------------------------------------------------------------------------
			this.OnComplete ( this, EventArgs.Empty );
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "NextInpact.Popups"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
