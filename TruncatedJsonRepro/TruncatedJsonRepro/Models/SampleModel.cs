using System.Collections.Generic;

namespace TruncatedJsonRepro.Models
{

	public class DavUrl
	{
		public string Href
		{ get; set; }
	}

	public class ViewInBrowserUrl
	{
		public string Href
		{ get; set; }
	}

	public class OneNoteClientUrl
	{
		public string Href
		{ get; set; }
	}

	public class OneNoteWebUrl
	{
		public string Href
		{ get; set; }
	}

	public class Links
	{
		public DavUrl DavUrl
		{ get; set; }
		public ViewInBrowserUrl ViewInBrowserUrl
		{ get; set; }
		public OneNoteClientUrl OneNoteClientUrl
		{ get; set; }
		public OneNoteWebUrl OneNoteWebUrl
		{ get; set; }
	}

	public class SectionData
	{
		public string SectionId
		{ get; set; }
		public string SectionName
		{ get; set; }
		public string CreatedTime
		{ get; set; }
		public string CreatedBy
		{ get; set; }
		public string NotebookId
		{ get; set; }
		public string ParentId
		{ get; set; }
		public string LastModifiedTime
		{ get; set; }
		public string LastModifiedBy
		{ get; set; }
		public Links Links
		{ get; set; }
		public bool IsInsideRecycleBin
		{ get; set; }
		public string Knowledge
		{ get; set; }
		public List<string> PageIds
		{ get; set; }
		public string Color
		{ get; set; }
	}

	public class OneNoteClientUrl2
	{
		public string Href
		{ get; set; }
	}

	public class OneNoteWebUrl2
	{
		public string Href
		{ get; set; }
	}

	public class PageLinks
	{
		public OneNoteClientUrl2 OneNoteClientUrl
		{ get; set; }
		public OneNoteWebUrl2 OneNoteWebUrl
		{ get; set; }
	}

	public class PageMetadata
	{
		public string PageId
		{ get; set; }
		public string SectionId
		{ get; set; }
		public string NotebookId
		{ get; set; }
		public string CreatedTime
		{ get; set; }
		public string LastModifiedTime
		{ get; set; }
		public string LastModifier
		{ get; set; }
		public string LastModifierInitials
		{ get; set; }
		public string Title
		{ get; set; }
		public PageLinks PageLinks
		{ get; set; }
		public object AppId
		{ get; set; }
		public string Author
		{ get; set; }
		public string AuthorInitials
		{ get; set; }
		public int PageLevel
		{ get; set; }
		public int PageOrder
		{ get; set; }
		public bool IsInsideRecycleBin
		{ get; set; }
		public List<object> Tags
		{ get; set; }
		public string PreviewText
		{ get; set; }
		public string FullText
		{ get; set; }
	}

	public class RootObject
	{
		public SectionData SectionData
		{ get; set; }
		public List<PageMetadata> PageMetadata
		{ get; set; }
	}

}