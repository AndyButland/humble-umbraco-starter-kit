//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.2.1+25a20cf
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Web Page</summary>
	[PublishedModel("Humble_Document_WebPage")]
	public partial class Humble_Document_WebPage : PublishedContentModel, IHumble_Composition_HasBlockEditor, IHumble_Composition_HasOpenGraph, IHumble_Composition_HasSeo
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		public new const string ModelTypeAlias = "Humble_Document_WebPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Humble_Document_WebPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Humble_Document_WebPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("content")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel Content => global::Umbraco.Cms.Web.Common.PublishedModels.Humble_Composition_HasBlockEditor.GetContent(this, _publishedValueFallback);

		///<summary>
		/// Description: (Recommended) Override the description shown to users when this page is shared on networks such as Facebook.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("description")]
		public virtual string Description => global::Umbraco.Cms.Web.Common.PublishedModels.Humble_Composition_HasOpenGraph.GetDescription(this, _publishedValueFallback);

		///<summary>
		/// Image: (Recommended)
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("image")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Image => global::Umbraco.Cms.Web.Common.PublishedModels.Humble_Composition_HasOpenGraph.GetImage(this, _publishedValueFallback);

		///<summary>
		/// Title: (Recommended) Override the title shown to users when this page is shared on networks such as Facebook. Typically between 40 and 60 characters in length.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("title")]
		public virtual string Title => global::Umbraco.Cms.Web.Common.PublishedModels.Humble_Composition_HasOpenGraph.GetTitle(this, _publishedValueFallback);

		///<summary>
		/// Indexing: (Optional) By default, this page will ask to be indexed by robots, e.g. search engines, and links will be followed for discoverability.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("indexing")]
		public virtual string Indexing => global::Umbraco.Cms.Web.Common.PublishedModels.Humble_Composition_HasSeo.GetIndexing(this, _publishedValueFallback);

		///<summary>
		/// Description: (Recommended) Describes the content of this page and is often utilized by directory pages, e.g. search engines, to provide a summary in search results.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoDescription")]
		public virtual string SeoDescription => global::Umbraco.Cms.Web.Common.PublishedModels.Humble_Composition_HasSeo.GetSeoDescription(this, _publishedValueFallback);

		///<summary>
		/// Keywords: (Private) Marketable keywords and phrases that content on this page should be written to. This is considered private and will not be displayed on the front end of the website.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoKeywords")]
		public virtual global::System.Collections.Generic.IEnumerable<string> SeoKeywords => global::Umbraco.Cms.Web.Common.PublishedModels.Humble_Composition_HasSeo.GetSeoKeywords(this, _publishedValueFallback);

		///<summary>
		/// Title: (Recommended) By default, the page title will match the content title. This field allows you to provide a custom title. Longer and more descriptive titles perform better than short or generic titles.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.2.1+25a20cf")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoTitle")]
		public virtual string SeoTitle => global::Umbraco.Cms.Web.Common.PublishedModels.Humble_Composition_HasSeo.GetSeoTitle(this, _publishedValueFallback);
	}
}
