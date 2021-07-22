using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace GlobalAnomaliesMVC.Models
{
    /// <summary>
    /// Class <c>AccordionItem</c> represents a single AccordionItem object: {string: accordionHeader, List<string>accordionItemList}
    /// </summary>
    public class AccordionItem
    {
        private List<string> accordionItemList;
        public List<string> AccordionItemList
        {
            get
            {
                return accordionItemList;
            }

            set
            {
                if (value == null || value.Count <= 0)
                {
                    System.Diagnostics.Debug.WriteLine("Failed to Initialize Accordion Item.  AccordionItemList is null or empty.");
                    throw new Exception("InvalidAccordionItemListException");
                }

                accordionItemList = value;
            }
        }

        private string accordionHeader;
        public string AccordionHeader
        {
            get
            {
                return accordionHeader;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    System.Diagnostics.Debug.WriteLine("Failed to Initialize AccordionHeader.  AccordionHeaderText is null or empty.");
                    throw new Exception("InvalidAccordionItemHeaderException");
                }
                accordionHeader = value;
            }
        }
    }

    /// <summary>
    /// Class <c>AccordionList</c> represents a list of AccordionObjects as defined by bootstrap
    /// <para>List<{string: AccordionHeaderText, List<string>: AccordionListItems}></returns></para>
    /// </summary>
    public class AccordionList
    {
        private List<AccordionItem> accordionList;
        public List<AccordionItem> AccordionListProperty
        {
            get
            {
                return accordionList;
            }
        }

        public AccordionList()
        {
            accordionList = new List<AccordionItem>();
        }

        public void AddAccordionItem(string accordionHeaderText, params string[] accordionItemList)
        {
            List<string> accordionItems = new List<string>();

            try
            {
                if (string.IsNullOrWhiteSpace(accordionHeaderText))
                {
                    System.Diagnostics.Debug.WriteLine("Failed to Initialize AccordionHeader.  AccordionHeaderText is null or empty.");
                    throw new Exception("InvalidAccordionHeaderException");
                }

                if (accordionItemList == null || accordionItemList.Length == 0)
                {
                    System.Diagnostics.Debug.WriteLine("Failed to Initialize Accordion Item.  AccordionItemList is null or empty.");
                    throw new Exception("InvalidAccordionListException");
                }

                if (accordionList == null)
                    accordionList = new List<AccordionItem>();

                foreach (var item in accordionItemList)
                {
                    accordionItems.Add(item);
                }

                accordionList.Add(new AccordionItem()
                {
                    AccordionHeader = accordionHeaderText,
                    AccordionItemList = accordionItems
                });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception caught: ", ex);
            }

        }

    }   


}