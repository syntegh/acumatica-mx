using PX.Data;
using PX.Objects.AR;
using System;

namespace AcumaticaMX
{
    /// <summary>
    /// Extensi�n de ARRegister para asociar informaci�n de CFDIs
    /// </summary>
    [PXTable(typeof(ARRegister.docType), typeof(ARRegister.refNbr), IsOptional = true)]
    public class MXARRegisterExtension : PXCacheExtension<PX.Objects.AR.ARRegister>
    {
        // Campos persistentes (en BD) *************

        // - Datos del comprobante fiscal

        #region Serie

        public abstract class series : IBqlField { }

        [PXDBString(25, IsFixed = false, IsUnicode = true)]
        [PXUIField(DisplayName = "Serie", Enabled = false)]
        public virtual string Series { get; set; }

        #endregion Serie

        #region FormaDePago

        public abstract class paymentForm : IBqlField { }

        [PXDBString(50, IsFixed = false, IsUnicode = true)]
        [PXDefault(AcumaticaMX.Common.PayForm.One)]
        [PXStringList(AcumaticaMX.Common.PayForm.Values)]
        [PXUIField(DisplayName = "Forma de Pago")]
        public virtual string PaymentForm { get; set; }

        #endregion FormaDePago

        #region MetodoDePago

        public abstract class paymentMethod : IBqlField { }

        [PXDBString(50, IsFixed = false, IsUnicode = true)]
        [PXDefault(AcumaticaMX.Common.PayMethod.Transfer)]
        [PXStringList(
            new string[]
            {
                AcumaticaMX.Common.PayMethod.Cash, AcumaticaMX.Common.PayMethod.Cheque,
                AcumaticaMX.Common.PayMethod.Transfer, AcumaticaMX.Common.PayMethod.CreditCard,
                AcumaticaMX.Common.PayMethod.Wallet, AcumaticaMX.Common.PayMethod.Electronic,
                AcumaticaMX.Common.PayMethod.Coupons, AcumaticaMX.Common.PayMethod.DebitCard,
                AcumaticaMX.Common.PayMethod.ServiceCard, AcumaticaMX.Common.PayMethod.NA,
                AcumaticaMX.Common.PayMethod.Other,
            },
            new string[]
            {
                AcumaticaMX.Common.PayMethod.CashLabel, AcumaticaMX.Common.PayMethod.ChequeLabel,
                AcumaticaMX.Common.PayMethod.TransferLabel, AcumaticaMX.Common.PayMethod.CreditCardLabel,
                AcumaticaMX.Common.PayMethod.WalletLabel, AcumaticaMX.Common.PayMethod.ElectronicLabel,
                AcumaticaMX.Common.PayMethod.CouponsLabel, AcumaticaMX.Common.PayMethod.DebitCardLabel,
                AcumaticaMX.Common.PayMethod.ServiceCardLabel, AcumaticaMX.Common.PayMethod.NALabel,
                AcumaticaMX.Common.PayMethod.OtherLabel,
            }, MultiSelect = true)]
        [PXUIField(DisplayName = "Metodo de Pago")]
        public virtual string PaymentMethod { get; set; }

        #endregion MetodoDePago

        #region NumCtaPago

        public abstract class originAccount : IBqlField { }

        [PXDBString(20, IsFixed = false, IsUnicode = true)]
        [PXUIField(DisplayName = "Cuenta de Pago", Enabled = false)]
        public virtual string OriginAccount { get; set; }

        #endregion NumCtaPago

        #region condicionesDePago

        public abstract class paymentTerms : IBqlField { }

        [PXDBString(100, IsFixed = false, IsUnicode = true)]
        [PXUIField(DisplayName = "Condiciones de Pago")]
        public virtual string PaymentTerms { get; set; }

        #endregion condicionesDePago

        //  -- Datos de sello del comprobante

        #region noCertificado

        public abstract class certificateNum : IBqlField { }

        [PXDBString(20, IsFixed = true, IsUnicode = false)]
        [PXUIField(DisplayName = "Certificado del Emisor", Enabled = false)]
        public virtual string CertificateNum { get; set; }

        #endregion noCertificado

        #region certificado

        public abstract class certificate : IBqlField { }

        [PXDBString(2500, IsFixed = false, IsUnicode = true)]
        [PXUIField(DisplayName = "Certificado", Enabled = false)]
        public virtual string Certificate { get; set; }

        #endregion certificado

        #region SealDate

        public abstract class sealDate : IBqlField { }

        [PXDBDate()]
        [PXUIField(DisplayName = "Fecha de Emisi�n", Enabled = false)]
        public virtual DateTime? SealDate { get; set; }

        #endregion SealDate

        // --- Sello del comprobante

        #region Sello

        public abstract class seal : IBqlField { }

        [PXDBString(500, IsFixed = false, IsUnicode = true)]
        [PXUIField(DisplayName = "Sello CFD", Enabled = false)]
        public virtual string Seal { get; set; }

        #endregion Sello

        // -- Datos del timbrado del comprobante

        #region Uuid

        public abstract class uuid : IBqlField { }

        [PXDBGuid()]
        [PXUIField(DisplayName = "UUID", Enabled = false, Visibility = PXUIVisibility.SelectorVisible)]
        public virtual Guid? Uuid { get; set; }

        #endregion Uuid

        #region NoCertificadoSAT

        public abstract class satCertificateNum : IBqlField { }

        [PXDBString(20, IsFixed = true, IsUnicode = false)]
        [PXUIField(DisplayName = "No. Certificado SAT", Enabled = false)]
        public virtual string SatCertificateNum { get; set; }

        #endregion NoCertificadoSAT

        #region FechaTimbrado

        public abstract class stampDate : IBqlField { }

        [PXDBDate()]
        [PXUIField(DisplayName = "Fecha de Timbrado", Enabled = false)]
        public virtual DateTime? StampDate { get; set; }

        #endregion FechaTimbrado

        #region FechaCancelacion

        public abstract class cancelDate : IBqlField { }

        [PXDBDate()]
        [PXUIField(DisplayName = "Fecha de Cancelaci�n", Enabled = false)]
        public virtual DateTime? CancelDate { get; set; }

        #endregion FechaCancelacion

        // --- Sello del SAT

        #region SelloSAT

        public abstract class stamp : IBqlField { }

        [PXDBString(500, IsFixed = false, IsUnicode = true)]
        [PXUIField(DisplayName = "Sello SAT", Enabled = false)]
        public virtual string Stamp { get; set; }

        #endregion SelloSAT

        //  -- Campos de addenda

        #region QrCode

        public abstract class qrCode : IBqlField { }

        [PXDBString(95, IsFixed = false, IsUnicode = true)]
        [PXUIField(DisplayName = "Codigo QR", Enabled = false)]
        public virtual string QrCode { get; set; }

        #endregion QrCode

        #region CadenaOriginalTFD

        public abstract class stampString : IBqlField { }

        [PXDBString(1000, IsFixed = false, IsUnicode = true)]
        [PXUIField(DisplayName = "Cadena Original TFD", Enabled = false)]
        public virtual string StampString { get; set; }

        #endregion CadenaOriginalTFD

        // Campos no persistentes *************

        #region CadenaOriginal

        public abstract class documentString : IBqlField { }

        [PXString(4000, IsFixed = false, IsUnicode = true)]
        [PXUIField(DisplayName = "Cadena Original", Enabled = false)]
        public virtual string DocumentString { get; set; }

        #endregion CadenaOriginal

        #region CantidadEnLetra

        public abstract class amountInWords : IBqlField { }

        [PXString(4000, IsFixed = false, IsUnicode = true)]
        [PXUIField(DisplayName = "Monto en Letra", Enabled = false)]
        public virtual string AmountInWords
        {
            [PXDependsOnFields(typeof(ARRegister.curyOrigDocAmt), typeof(ARRegister.curyID))]
            get
            {
                return Convert.ToWords(this.Base.CuryOrigDocAmt, this.Base.CuryID);
            }
            set
            {
            }
        }

        #endregion CantidadEnLetra

        #region QrCodeImg

        public abstract class qrCodeImg : PX.Data.IBqlField
        {
        }

        /// <summary>
        /// Propiedad disponible para calcular y mostrar la imagen del c�digo QR.
        /// </summary>
        /// <value>
        /// Debe regresar un Data URL con el contenido de la imagen del c�digo.
        /// </value>
        [PXString(IsFixed = false, IsUnicode = true)]
        [PXUIField(DisplayName = "C�digo QR")]
        public virtual string QrCodeImg { get; set; }

        #endregion QrCodeImg

        #region Estado

        public abstract class stampStatus : IBqlField { }

        [PXString(1, IsFixed = true)]
        [PXDefault(CfdiStatus.Clean)]
        [PXUnboundDefault(CfdiStatus.Clean)]
        [PXUIField(DisplayName = "Edo. Timbrado", Visibility = PXUIVisibility.SelectorVisible, Enabled = false)]
        [CfdiStatus.List()]
        [SetCfdiStatus()]
        public virtual string StampStatus { get; set; }

        #endregion Estado

        #region Timbrable

        public abstract class notStampable : IBqlField { }

        [PXBool()]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "No Timbrar", Visibility = PXUIVisibility.SelectorVisible, Enabled = false)]
        [StampableStatus()]
        public virtual bool? NotStampable { get; set; }

        #endregion Timbrable
    }
}