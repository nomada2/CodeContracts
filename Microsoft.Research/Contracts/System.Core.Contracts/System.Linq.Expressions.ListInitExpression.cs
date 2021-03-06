// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Text;

namespace System.Linq.Expressions
{
  // Summary:
  //     Represents a constructor call that has a collection initializer.
  public sealed class ListInitExpression : Expression
  {
    private ListInitExpression() { }

    // Summary:
    //     Gets the element initializers that are used to initialize a collection.
    //
    // Returns:
    //     A System.Collections.ObjectModel.ReadOnlyCollection<T> of System.Linq.Expressions.ElementInit
    //     objects which represent the elements that are used to initialize the collection.
    public ReadOnlyCollection<ElementInit> Initializers
    {
      get
      {
        Contract.Ensures(Contract.Result<ReadOnlyCollection<ElementInit>>() != null);
        Contract.Ensures(Contract.Result<ReadOnlyCollection<ElementInit>>().Count >= 1);
        return default(ReadOnlyCollection<ElementInit>);
      }
    }
    //
    // Summary:
    //     Gets the expression that contains a call to the constructor of a collection
    //     type.
    //
    // Returns:
    //     A System.Linq.Expressions.NewExpression that represents the call to the constructor
    //     of a collection type.
    public NewExpression NewExpression
    {
      get
      {
        Contract.Ensures(Contract.Result<NewExpression>() != null);
        return default(NewExpression);
      }
    }

#if NETFRAMEWORK_4_0 || SILVERLIGHT_4_0 || SILVERLIGHT_5_0
    //
    // Summary:
    //     Creates a new expression that is like this one, but using the supplied children.
    //     If all of the children are the same, it will return this expression.
    //
    // Parameters:
    //   newExpression:
    //     The System.Linq.Expressions.ListInitExpression.NewExpression property of the
    //     result.
    //
    //   initializers:
    //     The System.Linq.Expressions.ListInitExpression.Initializers property of the result.
    //
    // Returns:
    //     This expression if no children are changed or an expression with the updated
    //     children.
    [Pure]
    public ListInitExpression Update(NewExpression newExpression, IEnumerable<ElementInit> initializers)
    {
      Contract.Requires(newExpression != null);
      Contract.Requires(initializers != null);
      Contract.Ensures(Contract.Result<ListInitExpression>() != null);
      return default(ListInitExpression);
    }
#endif
  }
}
