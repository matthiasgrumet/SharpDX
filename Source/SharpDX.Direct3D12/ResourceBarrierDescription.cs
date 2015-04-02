﻿// Copyright (c) 2010-2014 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Runtime.InteropServices;

namespace SharpDX.Direct3D12
{
    public partial struct ResourceBarrierDescription
    {
        public SharpDX.Direct3D12.ResourceBarrierType Type;

        private Union union;

        public SharpDX.Direct3D12.ResourceTransitionBarrierDescription Transition
        {
            get { return union.Transition; }
            set { union.Transition = value; }
        }

        public SharpDX.Direct3D12.ResourceAliasingBarrierDescription Aliasing
        {
            get { return union.Aliasing; }
            set { union.Aliasing = value; }
        }

        public SharpDX.Direct3D12.ResourceUnorderedAccessViewBarrierDescription UnorderedAccessView
        {
            get { return union.UnorderedAccessView; }
            set { union.UnorderedAccessView = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceBarrierDescription"/> struct.
        /// </summary>
        /// <param name="transition">The transition.</param>
        public ResourceBarrierDescription(ResourceTransitionBarrierDescription transition) : this()
        {
            Type = ResourceBarrierType.Transition;
            Transition = transition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceBarrierDescription"/> struct.
        /// </summary>
        /// <param name="aliasing">The aliasing.</param>
        public ResourceBarrierDescription(ResourceAliasingBarrierDescription aliasing)
            : this()
        {
            Type = ResourceBarrierType.Aliasing;
            Aliasing = aliasing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceBarrierDescription"/> struct.
        /// </summary>
        /// <param name="unorderedAccessView">The unordered access view.</param>
        public ResourceBarrierDescription(ResourceUnorderedAccessViewBarrierDescription unorderedAccessView)
            : this()
        {
            Type = ResourceBarrierType.UnorderedAccessView;
            UnorderedAccessView = unorderedAccessView;
        }

        public static implicit operator ResourceBarrierDescription(ResourceTransitionBarrierDescription description)
        {
            return new ResourceBarrierDescription(description);
        }

        public static implicit operator ResourceBarrierDescription(ResourceAliasingBarrierDescription description)
        {
            return new ResourceBarrierDescription(description);
        }

        public static implicit operator ResourceBarrierDescription(ResourceUnorderedAccessViewBarrierDescription description)
        {
            return new ResourceBarrierDescription(description);
        }

        /// <summary>
        /// Because this union contains pointers, it is aligned on 8 bytes boundary, making the field ResourceBarrierDescription.Type 
        /// to be aligned on 8 bytes instead of 4 bytes, so we can't use directly Explicit layout on ResourceBarrierDescription
        /// </summary>
        [StructLayout(LayoutKind.Explicit, Pack = 0)]
        private partial struct Union
        {
            [FieldOffset(0)]
            public SharpDX.Direct3D12.ResourceTransitionBarrierDescription Transition;

            [FieldOffset(0)]
            public SharpDX.Direct3D12.ResourceAliasingBarrierDescription Aliasing;

            [FieldOffset(0)]
            public SharpDX.Direct3D12.ResourceUnorderedAccessViewBarrierDescription UnorderedAccessView;
        }
    }
}