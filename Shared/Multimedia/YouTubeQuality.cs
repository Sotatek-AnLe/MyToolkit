//-----------------------------------------------------------------------
// <copyright file="YouTubeQuality.cs" company="MyToolkit">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>http://mytoolkit.codeplex.com/license</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

namespace MyToolkit.Multimedia
{
	public enum YouTubeQuality : short
	{
		// video
		Quality144P,
		Quality240P,
		Quality270P,
		Quality360P,
		Quality480P,
		Quality520P,
		Quality720P,
		Quality1080P,
        Quality2160P,

		// audio
		QualityLow, 
		QualityMedium, 
		QualityHigh,

		NotAvailable,
		Unknown,
	}

	public enum YouTubeThumbnailSize : short
	{
		Small, 
		Medium, 
		Large
	}
}