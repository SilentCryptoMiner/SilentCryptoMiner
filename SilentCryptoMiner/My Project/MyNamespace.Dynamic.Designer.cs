using System;
using System.ComponentModel;
using System.Diagnostics;

namespace SilentCryptoMiner.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Advanced m_Advanced;

            public Advanced Advanced
            {
                [DebuggerHidden]
                get
                {
                    m_Advanced = Create__Instance__(m_Advanced);
                    return m_Advanced;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Advanced))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Advanced);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Builder m_Form1;

            public Builder Form1
            {
                [DebuggerHidden]
                get
                {
                    m_Form1 = Create__Instance__(m_Form1);
                    return m_Form1;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form1))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form1);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MinerETH m_MinerETH;

            public MinerETH MinerETH
            {
                [DebuggerHidden]
                get
                {
                    m_MinerETH = Create__Instance__(m_MinerETH);
                    return m_MinerETH;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_MinerETH))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MinerETH);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MinerXMR m_MinerXMR;

            public MinerXMR MinerXMR
            {
                [DebuggerHidden]
                get
                {
                    m_MinerXMR = Create__Instance__(m_MinerXMR);
                    return m_MinerXMR;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_MinerXMR))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MinerXMR);
                }
            }
        }
    }
}