// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace Kin.Stellar.Sdk.xdr
{
// === xdr source ============================================================

//  enum LedgerEntryType
//  {
//      ACCOUNT = 0,
//      TRUSTLINE = 1,
//      OFFER = 2,
//      DATA = 3
//  };

//  ===========================================================================
    public class LedgerEntryType
    {
        public enum LedgerEntryTypeEnum
        {
            ACCOUNT = 0,
            TRUSTLINE = 1,
            OFFER = 2,
            DATA = 3
        }

        public LedgerEntryTypeEnum InnerValue { get; set; } = default(LedgerEntryTypeEnum);

        public static LedgerEntryType Create(LedgerEntryTypeEnum v)
        {
            return new LedgerEntryType
            {
                InnerValue = v
            };
        }

        public static LedgerEntryType Decode(XdrDataInputStream stream)
        {
            var value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(LedgerEntryTypeEnum.ACCOUNT);
                case 1: return Create(LedgerEntryTypeEnum.TRUSTLINE);
                case 2: return Create(LedgerEntryTypeEnum.OFFER);
                case 3: return Create(LedgerEntryTypeEnum.DATA);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, LedgerEntryType value)
        {
            stream.WriteInt((int) value.InnerValue);
        }
    }
}