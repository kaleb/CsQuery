﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsQuery.Engine
{
    /// <summary>
    /// Bitfield of flags for specifying the SelectorType.
    /// </summary>

    [Flags]
    public enum SelectorType
    {
        /// <summary>
        /// Return all elements.
        /// </summary>
        All = 1,
        /// <summary>
        /// Return only a specific tag/node name.
        /// </summary>
        Tag = 2,
        /// <summary>
        /// Return a specific ID.
        /// </summary>
        ID = 4,
        /// <summary>
        /// Return elements containing a specific class.
        /// </summary>
        Class = 8,
        /// <summary>
        /// Return elements matching an attribute type selector
        /// </summary>
        AttributeValue = 32,
        /// <summary>
        /// Return elements matching a pseudoclass filter selector.
        /// </summary>
        PseudoClass = 128,
        /// <summary>
        /// Return specific elements
        /// </summary>
        Elements = 256,
        /// <summary>
        /// Generate HTML.
        /// </summary>
        HTML = 512,
        /// <summary>
        /// Return nothing.
        /// </summary>
        None = 1024   // returns no values ever

    }

    /// <summary>
    /// Values that represent the type of attribute selector
    /// </summary>

    public enum AttributeSelectorType
    {
        /// <summary>
        /// The attribute exists.
        /// </summary>
        Exists = 1,
        /// <summary>
        /// The attribute's value matches a specific value.
        /// </summary>
        Equals = 2,
        /// <summary>
        /// The attribute's value starts with a specific value.
        /// </summary>
        StartsWith = 3,
        /// <summary>
        /// The attribute's value contains a specified substring.
        /// </summary>
        Contains = 4,
        /// <summary>
        /// The attribute does not exist.
        /// </summary>
        NotExists = 5,
        /// <summary>
        /// The attribute contains a complete word (e.g. a subtring bounded by whitespace).
        /// </summary>
        ContainsWord = 6,
        /// <summary>
        /// The attribute ends with a specified substring.
        /// </summary>
        EndsWith = 7,
        /// <summary>
        /// The attribute does not equal a string.
        /// </summary>
        NotEquals = 8,
        /// <summary>
        /// The attribute value, or the part of the value before a hyphen (if present), matches a value
        /// </summary>
        StartsWithOrHyphen=9 // for lang
    }

    /// <summary>
    /// Values that represent CombinatorType. This is a bit of a misnomer because Combinator is used
    /// in CSS selector-speak to refer to how one subpart of a selector relates to another.
    /// Unfortunately, I use it to refer to how one *group* of a selector relates to another. This is
    /// an internal concept, mostly, and is required to link subparts of a selector together.
    /// </summary>

    public enum CombinatorType
    {
        /// <summary>
        ///  The results of this selector clause are grouped with the results of the prior, e.g. an "or" condition
        /// </summary>
        Grouped = 1,       
        
        /// <summary>
        /// The selector clause is applied to the results of the prior one.
        /// </summary>
        Chained = 2,  

        /// <summary>
        /// The selector clause is applied to the root context of this selector.
        /// </summary>
        Root = 3      
    }

    /// <summary>
    /// Values that represent TraversalType. This is essentially what CSS calls "combinator" and
    /// defines the traversal mechanism used from one selector subpart to the next.
    /// </summary>

    public enum TraversalType
    {

        /// <summary>
        /// Return all elements
        /// </summary>
        All = 1,
        /// <summary>
        /// The operand matches a subset of the prior selection.
        /// </summary>
        Filter = 2,
        /// <summary>
        /// The operand matches only descendants of the prior selection.
        /// </summary>
        Descendent = 3,
        /// <summary>
        /// The operand matches only direct children of the prior selection.
        /// </summary>
        Child = 4,
        /// <summary>
        /// The operand matches only the element immediately following (adjacent to) the prior selection.
        /// </summary>
        Adjacent = 5,
        /// <summary>
        /// The operand matches all siblings of the prior selection.
        /// </summary>
        Sibling = 6
        // ,Inherited = 7. 
    }

    /// <summary>
    /// Position-type selectors match one or more element children of another element. The selection engine can either access all 
    /// matching children, or test a particular element for matching a selector
    /// </summary>
    public enum PseudoClassType
    {
        All = 1,

        // jQuery pseudoclass selectors
        // 
        Even = 2, 
        Odd = 3,
        First = 4,
        Last = 5,
        IndexEquals = 6,
        IndexLessThan = 7,
        IndexGreaterThan = 8,
        Parent = 9,
        Visible = 10,
        Hidden = 11,
        Header = 12,
        Has = 13,
        Not = 14, 
        
        // CSS pseudoclass selectors
        
        FirstChild = 20,
        LastChild = 21,
        NthChild = 22,
        FirstOfType = 23,
        LastOfType = 24,
        NthOfType = 25,
        NthLastChild = 26,
        NthLastOfType = 27,
        OnlyChild = 28,
        OnlyOfType = 29,
        Empty = 30
        
    }


}
