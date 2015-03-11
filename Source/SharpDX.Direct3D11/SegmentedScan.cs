// Copyright (c) 2010-2014 SharpDX - Alexandre Mutel
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
#if !W8CORE
using System;

namespace SharpDX.Direct3D11
{
    public partial class SegmentedScan
    {
        /// <summary>	
        /// Creates a segmented scan context.	
        /// </summary>	
        /// <param name="deviceContext">Pointer to an <see cref="SharpDX.Direct3D11.DeviceContext"/> interface. </param>
        /// <param name="maxElementScanSize">Maximum single scan size, in elements (FLOAT, UINT, or INT). </param>
        /// <unmanaged>HRESULT D3DX11CreateSegmentedScan([In] ID3D11DeviceContext* pDeviceContext,[None] int MaxElementScanSize,[Out] ID3DX11SegmentedScan** ppScan)</unmanaged>
        public SegmentedScan(DeviceContext deviceContext, int maxElementScanSize)
        {
            D3DCSX.CreateSegmentedScan(deviceContext, maxElementScanSize, this);
        }        
    }
}
#endif