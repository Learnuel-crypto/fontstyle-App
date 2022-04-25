using System;

namespace WindowsFormsApplication1.Modification.Models
{
    /// <summary>
    /// NEW PROCEDURES QUERY TEXT
    ///Method names are procedure names
    /// </summary>
    internal  class Procedures
  {
      internal static string ProcedureText { get; private set; }

      /// <summary>
      /// create procedure to delete inovoice
      /// </summary>
      /// <returns></returns>
        internal static string sp_delete_invoice()
        {
            ProcedureText =
                "vJnp+gCKU8smNn1nIOJs3bAYG8+H+5kRwsMydKmUrcoPbE/5VTVHrkqzhhmmdWVSY/aU6InDLHag1Zpg+BbReJWWDeyFrcEvuay8BNqOq+fTGhz72j/qB/iFmPJkqE0OamIs/RRcGfsAlFPnkdk/TF8cfbjPaxS/hmiYdSXutfovehdIC2LGP4ZyMQ5D4jOo7e6WLgbtaVxzuS75N6UqTT5Ju+l3EPAvwKjmBEhmepxzfSWmMyfbmwNMGZWJ7fVSfH/Oi7wNpTXINCF3EAJ1jUcYDeLCNiUfStZIb4JEG/J3mmIfVB47n+Vnh64Kd0HgtS/iQBFx/TmPnyKuLebnBTN6bk5R2bG5XENiMn7H9ct89T+yY926bptG/9/+mYZYaW6OmBepPCJI+Wvq7P4Baw==";
 
            return ProcedureText;
        }
        internal static string sp_delete_cashflow()
        {
            ProcedureText =
                "vJnp+gCKU8smNn1nIOJs3V3ubMvhr6NiiPtly/VB1a2zefCEqcBZ/ZpBuNc4NMcn3t6xrz0sKMCc+Tj9C1TjJXrRXDd1wo9cSyaZARo8o2P/FaPjw1C2gIXVISisowLBE6RXC7BZHM6LRhVbr1tdA9H5wC60bGKdx2T03hAqhq5+JK/QyS/BRP+6jXknCfP7B84CAtIo0rB2RzZmJIycJEUWP8ntscZLaPyKeGUtL0K7teZYLA0uy3Af4Jmp5O7ZVtpQcF8AfFr33t0i+31gKTrluTul7qDS+P8+CkOLZcYy6+Xafl+2Ic0DW+kSzXmdzle1CTevF+3VPo/egATdQRyXqxks0WF74HHr3bZg8E9medrvVCHKZhZFe5upk0SAn7JeH0LyCrjhGcoMoB7jSA==";

            return ProcedureText;
        }
     
        internal static string sp_get_cashflow()
        {
            ProcedureText =
                "nUgEvRHMKUoWUWpNWIaBtt0Q8tDeWHccv4rGXBWl7Cp+oN+Kc13HRGqAxYS3qkNorfFeaZGaElYeQTk+zYDuAaUXsBAIdiAXOSs1L8xI+/5ZckziQzsoSPGF5ab8Htgqgaw7JyPuu1Ck05THIe2wK/282RqQlni0zh4p3Mxl3ZdOf4v6fPsbo6aJUZZOuZbdu337o9ONjRxZmCnDoRUAUDTdd8FucsAXttLlseKlneyL4b1a9r/5+x8GZQautbmZKmRa1AIX5NsK2YUNC4aaDlDqlW6r7AUuzwleoYlZdWE2HkK+SV5KQrFpO/a6nVFDu855Vrtbu/ry7HBnWMqENia4IhTot0yGnuh6N93GfrqxgBdOeXYTRyMHaIrStB2jhURoPOT4Dq5F8nJZhi9bxCNhuya2/acpeRT3mVOQdX69VAtNVBtsfSe47llph7xWjgmcfdfvpYZSY6HatNVHn4NQBbDBNryDY8N/am0aEtRosvp0xTdXSdUUGHggRc7n1kbxfZ+T+L5F7w5/1eB1uf5kTyrQImdtp9lZsTpvGgeKPx7LKKqFadkp6jPVTRE0rA5E5RfEoL54sgNk15H1fACHP0WYhndaMTXrla3QnwDMghkQc6KanPrhrOkYLqY/ajLVw1zu9Kcp/tdI4AHpnZSGXG6nj2IesNia9yNCW/Wfr3Pdd0QCP0+GBWTbYoft";
            return ProcedureText;
        }

        internal static string sp_get_monthly_expense()
        {
            ProcedureText =
                "8pdRoweUXP5ntW7ert+JBRuACEWmFTDi+w9BEXJHiQL+V1uJ3yhYIn10zmsRAYGLM0oJT71Sex9uXgRMTcRJ7qNzA9lVEuTbdOt3z8Fbs5jUuzThGo/i9Dm/YOj5HajvWgf6X2RioBrhGeLPDSV9sLkTcHNBDuz+/1XTiZjuYllB2TAYsx2nbWR/t1Odsy84VPjm/qKGzOQGRSENWZFXz1l6nOS5s9rowKrWR+40uk6CnvN3dqT1O/Cz7LTAVGbBNU8noJn6FrpmvSzSzmR1TM0p+a81yWxoi4zHiw61blOtJzhGGMNiw7udgKx6wLmKV4ndfJCdLqg0ZR8Wj1QWVkzTH6kUA0SaW1pF4ckNpgHnCNqWLVJ5pkGurZF2mQKeLnkPYy0q2HbhKDzX9IXlmkkyGBaOHNh6AWl1Ub8CrCqGwzX5scRSOj9mD21Z+Pl1+oarzPACIp6GAhSTjrtw3g==";
            return ProcedureText;
        }

        internal static string alter_sp_delete_cashflow()
        {
            return ProcedureText =
                "8EiCIFJLhgc5sOAbkpigOFimXltRXC9mp6/XoAAfYE2d2FjIzQAwNNxAboO66cTTvm9Fjq4tIZcUcc2VQiWKykyA6/Be3qf8L/BoRRUUozwxAoPQArmKyLdP0oexE/eMpLaXygdmEHbe4rCZVW1Ctvv7CcAo+9UJHRUa8qW/O/6GT0d7hYD7fEarLbpQOMzK8ocCILjMXD+M9zAnE0iKyG2ILk0wFgy25tI+iLQ4asNBJhWgOTgbuLaPDZQ3e4Q/hr+wxDAtynByaMnjM83uzq+gErqxoK8BArqdtB0aFj8x8QL2h2UYVIFGWrMQMaVBGgNyyM5gHUCGzwtzPOehLtZNUJ8fDTUki1mpM0gTJ9e7n9VPEGb2Pl2YcnanKbpVPbHMSQhVeItks6jf0lrsu961hU2arV7/HlzNlAKez/np7Fa73Pmdhs/ik3UQ0TxH06SUIVi1QJcRZ342MgvvUEldvJmA4lgkHAdIFzIkA2Ki0zDDR1RpQ/VWEtec4DRZaPtzhBnHyhhNhYhx0cEFzloYnp8gQsK4pb1f+nlT9VLcLyxil5euDg4BFzw/jwvX8CD214mHSxmtMR2sbhqmADIreQJn/H8pcJJY1UUCnfyX0Q/Xrv4O+zVeD98VPvEp86UONw0ze/3qau3FJa2GsJd7xPWuGlyeRW2b59zFjd0kqTqULaGnvmz2FH1Xo9Ba7CzgBi1Mc38MwdPOSK1uwg==";
        }

        internal static string create_view_job_items()
        {
            return ProcedureText = "TETkU9gPEqAWxHk/37MFpPsaRrjGkbGDlD+/1vCDV4IMpyZAksiK4bzwYvR+GoKo/QOWEhl8qNS9QaicGk/oqng4vRi6SVsAURpor+wScidJVDgnGV6d1AJPSotn3fOU3FAV7tEc7bFf0mP/AuapnSJfn69qnwEpuM01rBnohfhI3yuyNAlDchTU1tH/8/CoWB0Aqg8cXL6T2QMsYuw/55Ud2ZcXhOC/Qgw5SXhyKT4hc0/uNhwNDi217voPhH6s6+Z31iw0NOHgCLyYsX4XeVr12VrEDJw/ss2fvZiOUwWTtcK7wWJfM92UiXAFG27tb3xiEvbwEfQMZZGgJk/eqBlxS3FR/cMa60naqjcPV5mqep/o6UXSFvI0Lu4Ajh+Xz+O00xruN4YEPdVm+8Kz3w==";
        }

        internal static string create_sp_get_items_debt_paid_total()
        {
            return ProcedureText= "nUgEvRHMKUoWUWpNWIaBtmJs3Vkwqb0i26EXMq+K4Pgg25YvjjfkLb3UpQ2Hlg8oFmq3xt01Ac/SMsgM0xxFYHW2CnNmLcrkf9R5WhW3xQidi1MmMm6DTOLXo39aHw90FpZORCMKjnsRLifiVlAxp6VuZJvg0ZnZFZQ/CkMpiG58n6MoXwJ0EW/y25G5QGXKJ+bklKJPYl1pTtUmKy3qKQ==";
        }

        internal static string create_sp_get_item_invoice_total()
        {
            return ProcedureText =
                "nUgEvRHMKUoWUWpNWIaBtv6rRbjZ8XijIswW58PyaUoL6U9gRWBibCz5g9qEhnBhy4BStuZNMWlNQII0B98zaOBG6AbSKVV9dW31NPfy5KWmRTH7cl6zHputqmtupk1TuY35+SPstiojYhiWvTzn6xGSZV7kfJ+sge2qqr94h2FumGEQSZWgUXh9R3wCVoubesAUZ1OJI2O90TLTD8rkKw==";
        }

        internal static string create_sp_get_jobs_between_date()
        {
            return ProcedureText =
                "nUgEvRHMKUoWUWpNWIaBtp/+em+IRL3bPLG8jakEUm2bxlbzuy45mb/s2Ds+VZds2eMLS9fGzAm7Ag6ngX5arVRFP7Kg2FmMY0IleatH06bPU8LzKO0igsBZXsvj0SYb3K78fQAybk8SOYaEZjjCFIIaRNhF2t5xbYwtU2OeauxetBr5iSdXnTJdImK8nh5XnO745n7w1CwEehRaMk3kgSmXMOwJONsaxO3euT9+v0/At3HQ6bWy+cMU7f7Kx9LjhVEzYvWJi97FdVxDokOVkjSI0pEIe80hTnMiQ+vKqQagmMBvKJpesr7j3diFs/SkiYYnIqkaOglAad0qo4KFinMJio2JSfu38tyUreli/Mmei72KjJzfoGSpZflbof70P9/1m4USD8zoDmRUv/vLCUkdbDEvtDqOkLeeOqx6Gc4=";
        }

        internal static string create_sp_get_jobs_date()
        {
            return ProcedureText =
                "nUgEvRHMKUoWUWpNWIaBtk9Zcn4BCrq5Nm6hAieGVW3iaPC6v8s6OIw/Kddo1R0t0iI9Z4YN74MCV+bMIS1PJzh4HkhoVmSEQJ0v0MiPBOJB9ak7I0OaYlGC3J3qH38iNi5m+5l6ZJ3srqDig5IttZ3+pxiTlJFT5yWksd+K61zlyfL0t4/G6oqfB00EFs4Z6Z1uWZXQLJOFX3dzu+B8jNiEzhmSL4F0snerXfawc+7lmlsbKH/kURO4CJ/O/cHdmLSiHxKa1ywTnTI0DFnlub+OsLLLprktHAMFq7B13ksBQxvY2HZUFQ2JxHioNiCLtTdTpDsoL8OJo8IhM4+kBQ==";
        }

        internal static string create_sp_get_jobs()
        {
            return ProcedureText = "nUgEvRHMKUoWUWpNWIaBtv3VSf5rQRmSQu86an+zwZ+1fL7XDGpcyIlpawGZmuLWoas5xpCI0NehJI8rBZ/J0+958zDx+zGaVt/MzhOMcOsWZB+3tx+ruStPADn/JM4i3kXivv0jKlGbGOuOPUcM3FVBEybmhlNAy7ngCtenu9Vwq1KgJlY855SPZffJFXcVoxK57RMa3fO9Hg1e9skKFVhTerdWPmeiswUeylyzC3YLei7yOlR2Goejrx5ObKGZPzVlKiXP3pgjAN4V6d95JG9J9DHExk4J4eMumX4Zi6evURrkiG/KkBz1fOWTK0L/ZrwVtfQf02gX029iSyRJ/LXd0dtcnhrnY3oPXV2xUibF4JWkDI9dsb060BxJDwSbBejjsgCD8HHzfuDg07i0Itm0UYHaJ1GI0XHh+JfgGK+f1lBFaIsM2/8qePcqs/ndBvaCa1NqRqWHT9A1diM6OWnZ6vXZOoJZNnOY12nPavcwhBgF6h+UX2KB9MBLk8PQnYtojOwl57jjCz4114TWfbZdg5D6uwBW3CzPmfxEIGxfcl4kqjygIOUGKv0EiCMr3e+Cz8hir2lQcnBPh13Mu1X+tH3w7I0BYxbgPRrqa7RFLmRIKG1MnZm1Edmge+j4Z/ZqTY8HOJKb82W7Y2txwJl3CCfqHizGOh3seqqkyJA=";
        }

        /// <summary>
        ///  create update receipt procedure
        /// </summary>
        /// <returns></returns>
        internal static string sp_update_receipt()
        {
            return ProcedureText = "nUgEvRHMKUoWUWpNWIaBtkwz7Xjw6XCnPTzr1Vr0Sexef0339AuEJRzbSP0fk81dAslmEceLUrfn9sVDrZm+mOTWi6UIaLCI1wr3RpYtG7lmSB2QrvhIO5zpjBwgNlvYaSbl8I+bNNyTHl9pBhvvjDpgh3TFBH30PzRTS2cWb+zfGyoxirFPHjXE21lL0br1Vi3ZEHAUQUkZSjNvkRokdoJ8GU9b1QlSBC1p748QHMJmfKodyAgBL/V8Q+dYiz8CEp6iBQAyPXpCecPAt5QVI/FqQTMYt4lXdPi63Fr2loiG+6b5vEg5JBwZzmpXV7BowPlMkyTYdqkt3WHTNn2ZGNkiJ3Bb9VIXFMaeAHPhbjUuwM4yH2HG30UToNYV0XRjN08LeHD1yyLKGCacL2K+Z75zsZ1FNie2qHuCtN7FrYJ1skPG6PsL8rRiOTVpordfF4/Jhbg9EhauQJVbyMtUMra2w1k0fXZALdUweC6tIxbOfxU+ZF47X9APiXEuTPqFGWlKYaNiYxB94YP50TAz/bZKuQC/b2Km81PRVFWmRIgduRaGAAqNblwXvGzgXHulN2op5v7zXqucXU6afmYSAxrRT0lALLh9nRZZ72mu929MRGefgR/nFVr5yc7tfEVWyFqUOiQiId8tnJ7CTEziPn4waAtU8NTxyu5Pc3Z2eZ+iyTm/m5FY9NFhKl6Fa+fh5kGzTa7orOuMutLVVR/wkuA1DBrqYEYi3d6s3HylEEhyEkcDjzHyJDUASuElG/a8";
        }

        /// <summary>
        /// Create receipt Table
        /// </summary>
        /// <returns></returns>
        internal static string create_receipt_table()
        {
            return ProcedureText = "oJRXPp+w52b7EMW17Ww/ZgtaURqVCQoLrZl9EbQLArkYRG3cXd1AI/omFgbFThRa985EoQPhsAYn+nQCdCg27OyfedAg9dwNuELuETKfbL9OPDhUD+t68AqZm+zsPz5nsvi1zhi2Nw6wwJEbJ2kFjSYyuTB2rvyeDYjhmLX5G8MEskbFqIxPFVoTiDYpCXx/D+nJ/cJDiJDMFZEfmnLcyL3MZOjKSPTHvYfBo93KS4yejyiAur2i2xeaaIS/jZRfzd5Bqh6djBE6mE019i/yATpYYvxaDMr/Ofu9wj65KiuKs062RZot6EBSimMdFsl7Y2c7U47ucDkPiHJKMij3qygezD9SsVPGDcPO5i3lEUcj2FTAM6ECVLuzPFgWifw/";
        }

        internal static string sp_get_monthly_income()
        {
            ProcedureText =
                "nUgEvRHMKUoWUWpNWIaBtmoTbg7KAQ9FGw6p01B8sHiUgDTKxhs3mRCH2qdmhDlwNuKaMHuxkOFz9xQIR7E9RCJrhtrx7KsahXGnkzrRjOXgIQCVQzr8s5Iz2jo4hg+POhVOEdeHKXEycEc12XG+4AudAbs+NwjaNH/IDrAmfKj+icKjyL9zYks7+6h8cCBuiCs06m8raoAml/wcLo3IBs/buJLDPivkDVG/dSo+8zI1ymheqs8HWA2O08NOIszpmRmp6L+XOIClTm2Xr7xcRQDxNa2Q0lGXKs179vrzuB1i6GyBedtwViLyGIH6vXZOuQX4UqGgIILW/fA5xwqQW77rbvgixFB9154PDdd1QmeffBLhzAJGXiu6NuNn0ogwBdhhBpkMt9oSQLl5p935hbsddPt+/X4UTuVslm9ZTpuhGFpD0j8sTLOxg5mp/+WH";
            return ProcedureText;
        }

        internal static string sp_get_current_income()
        {
            ProcedureText = "mL8NL48TeK2PgyMwRB1ZMe2GyOAj86NUDIpMMo443CGvMuHq5jOWhMrTLyzELj6n3e9hI8roNCWuxDx+Kx3GYEFGN3UyDl+C8voTu9Suh+caqYNM6dH61IwqY+VX1zljkkh/M6JqiDvk6L+U8FLU4mSAHpyCIfxLlLdnNihHlbAKIywh8tJg2TkuFSNtvnNM6rU9PT2jaILvbkKGQraALqE1SmqdMaoMw8plBCDsfa1ES3LBIXPiyjgkx5b30Z57PtbrqjOv6Rsf0yDTbrIoTmljYLwmcYLOAcxbYmRCUf6bT2L+PsEfSAoDNoGW59YnHaQGAQZTIzYc28v0KFbha2mX6Gbj9B+XOu3jPoo9X0ud6mzWu7m5m4j4al8GGxW1W2wyA4gWFqaJ4tLoeUWBOQ==";
            return ProcedureText;
        }
        /// <summary>
        /// Create get receipt details procedure
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_receipt_heading()
        {
            return ProcedureText = "nUgEvRHMKUoWUWpNWIaBtsBBiGyrAFIYC96EzF6OOkfRKC4MY+XtShJ4nRhVDlR3SSCwaohFW4ySXh9B8wgq1IDV3oOvVyqVryllrv7TtPg=";
        }

        internal static string sp_get_current_income_athand()
        {
            ProcedureText = "8pdRoweUXP5ntW7ert+JBfLkRHoUDUEog5d3IbAO/D8ngAJVrB79X1Byytx9nObIppEcsN3jVVwDVHWTYW1jWDcatxWsmKzQK80PYk6tuVMmGUTYIo3Dk+6GvEXBkz4Kwc6Nv0e08p0LoRiX8GjFcndR1U2FSqDbRqUlyfbj9kwxjRrazI/qpQg/o0dkJgGsJfRlKWTNV1WmwyEuSfJRoMdEkiBzQhypd1Cv0iYFwX2TbXtJPeKt+M5sda5vUSyw1WLQvBy3tuK9/jwbak8V5kwoX/kE61bbaVZ8PzabGKGcxf2RMkDj16r8HyvLtlgQ7Jqvft18d0V+02cbH38U0qYKpoyEVvKhmMLsaX0anuROtW+7fJfsq+vjXks6ETkXfxJpS1xTTFT6N6Q3MwkvPez1O3k7Vdloe5F1Zi0p5Os=";
            return ProcedureText;
        }

        internal static string sp_get_current_income_inbank()
        {
            ProcedureText = "nUgEvRHMKUoWUWpNWIaBtvYUX3lBVjJhbO5Btukmbi6DjhFjV/U60twDjKz3k/tk1RCc/S5rgtOlKG0Sb2dMCs5yC5DUomiURNP6y4p5+E/MxYAfQLBbmHZKyKT2ifQT6kc9wgHdewzBMcOWW96V3tSqaauBZvZR3c5jfXAHED1ZeVKIT/BuWZM4Z0J8RIQzBzU9R/F7fdW+olil/jIxI0t/xcZKDeM6TbDcRwu+3LquNmsygWhv3U0cashgkoWFx5jLNsaisRKRZVnCpdlwX+IYOtDSJIY1W4sFoKNBQ5QWVtrfa4bKkvHxZDUyJrzA7tF7g1wIIsfrM08t6qnmNekVsOkoJWSPgTLQvB6m+oSi17Df+lndOnckAzGgaL1GuGjTMHjfgCCtBna0XP4ELj4UacpAAnvNRTKAb/XZSCtenlw0hhxBOUYAfMtLwgn4";
            return ProcedureText;
        }

        internal static string sp_get_current_month_expense()
        {
            ProcedureText = "mL8NL48TeK2PgyMwRB1ZMeOHauPKWFxrsQ1LwaOAQwaJqaBSyQt9S/6MHZnIxUSIBS9SXAGvZ3PcYA9KZNbqxhl79RQdorwfK8Xe7EjStcJaCXf0Y9XZyOuLhbnI54O2i7MTSVQKKukyRLKbbyqKfS2Mg4mpU93oGzsjR7YYCpWld+psWw6eythVkiFEFmvuvkXYn8Uk8UQO/6T4uhURiaTucEBcUB6M+hP3XUJQ1nJPevt25DEtgvhQU5dA987l36aUWfhjV8Mo+no699WJJRZKmzF4o2XEvlDgG9TbDa9l+feeckJyRdyioAJ/C84Kl8eXJT1ozl6g22JPhL20lXm5NI3f4sktLV7C2LcM/WbUtYlIeIpno/BQFvyZuVcrpD0F6g0ennRth0yA3ELwDQ==";
            return ProcedureText;
        }

        internal static string sp_view_cashflow_by_heading()
        {
            ProcedureText = "hnUEYJsgnFFfQCVcSu0SinbUHd9V4p2Oa30XBLjeGrv7id0RwtbyauRtvrAz9dxisXphGY9b6Z4vOS/ccbUZYXQ0yr0DRt+PO0oFOU9cRHk7CYtHUqBlBc2RbYOkqzMjOkFe8AB5LoKsvGTy8YuF/VstVuZUMPChSNMtmgUNieR6283b3tgtB85VH9NWaz0sZmPn4AN9itiByhl7JpfxdOvIFry5AP/IoXMdTp2JeN6xEplaGZjhar0qSsXcqSZZZNJuVPAGiGRAdALoLHuatjEP+jgRWK/m16vlp1PX8cKuSq7mw0RC447uJ9LKhJ3g";
            return ProcedureText;
        }

        internal static string sp_customer_number_exist()
        {
            ProcedureText = "nUgEvRHMKUoWUWpNWIaBtirXtarYL9wqLMzNbh1GO2w4W2ba/33+Aa+u5yiDUOMTL3xs7CWnbgG9Vi92msNn1QOUIfeOYUkV+RzARF5XU1K3Wa7GKA69Y99AEJvWJe2v+b/ajr6yYsXRyPvQEs91ss2B9nyoZ25P0q/2Da60UugJpGl7DWDCNjjJV1gBMiS/aC+yS2D5iwXnASAhUnOS74AsmfU58kDSNCgLmdCM5lU=";
            return ProcedureText;
        }

        

        internal static string sp_view_invoice_details()
        {
            ProcedureText = "hnUEYJsgnFFfQCVcSu0SiqiYeUbJ5oQlbRwi3m2eY37L/nVZLUoBi7f3d7J5tosK1MLZao20PTnqGkoxxFJaRVKFgkGF9JX9s+5Sruup81J24PNBw4+o3exOsK1m1wC86XAlUmRpNQJRxA9+5Tt3h1DRaMyrusYVwmGnx6+MV4duuwxYsMHruApUCCVjH6Gdx6dyNx0gE49VH0hacPOHnXBrUeZ7HrWMMaqcLHaySkKLHbibIyfnllsPIVDv5qdT6KqwLNTxr4GXkhMCEjxeAdEiRoFnK9HQa94tpM9+64u3XPAfLqAloQkHRvNrPJjGXivSi0ucTvkbt3lnN/m1G2Kn0gA8Ke3x7O3Qy+A2J52N58Z6uTEQa8AdQizV4OSHC/AKkSsVYz9CBQ6w8VFjKlMOa+FY1csNRKxApXt3HNIxeYvaTwlC6f0h64Ca6C0/g6qLZqjDK5l8xh+6c7+6Tny9eU2btHxg8LXhsad/PMHT+U35obJ4HcuE8unvk10HijADN/BW2brVclP3KUoKjf7mkKk1bEKEKPJw4m9/qi0TpUvVgKRh2K6JN8rTVgiP9gB8AH6O4L2fZdrCZO8tfGLe3gBErzk0O5c9Hu2fB7JA5934CNeuGg7M5hPEZxnd4c4q4k9QtCbBY9BybIFx/C4NouTlUhFygTjEL/RuT7ICAlkmJzFSnIbFaMBsziRsS1RsP5hA92GXuqRM8kbvzI92o76K3Z0C7Wei+66ZrVz8ObS3HpsMu30BzWvxpC02k4hubFITyV04hwWl0gTCZDXmNIfU0ytSDJUeo7yCfs7zsWmjXCSlh0U36sTG9mf5xuhLwWT3eURxPM0wpHZN9RG7+9NXKjOt4Dgi2VjEhEM=";
            return ProcedureText;
        }

        internal static string sp_customer_invoice_sum_bydate()
        {
            return ProcedureText= "nUgEvRHMKUoWUWpNWIaBtgJKvJSNwBNYQcQ8vLycpFAItVTWEJ9IWV3n/Sc5obzHVvqySr1ERxVYe7CuTVnsHmkA/F+eiJBfl7Ryd4PxDcX+vvo86ZsgMAec15Nc0Y2ProHjDdv1+EBVxNkmRwBS/ezC0Rv479i58nZBt1vAJJerCiRvqAeIy0gYUblG/7Kod+7LvTYtYVwWwQRrQvgAlxI56ay5NV0KCw0oQGZ6oxFfq+XZxQZPZwbvlQTVl+pCWcwBr8HuoZCGu71QD91O4lgVrziXjQmNG1IK3Gpr/sS9j6Cy5PViIktUnEoaG6EWoepR8TX/7K4ufdB2NGU/XMQ+TaDJ6LUAL3QWNmWU3Nt2dDIiAql07tn38XBiEY/6E71cai8G8dlUT78aPGNDLHBiqIIRKTppc6c1IWIIR+xiLiqNvUYs7cINPap9QnPHpC54+b+/BEBWXIuZn4Lietdk1oqx0E1DYhDCkAmZjeKXS5bWrovFnhmIoAKB+ULu";
        }

        internal static string sp_customer_invoice_sum_between_date()
        {
            return ProcedureText= "mL8NL48TeK2PgyMwRB1ZMexalahppUvGmgZ8aGPdQBEUAYRQnM8BXrWvOci4jJc/MgWvbfStoiQZVoGE9l1hbzb+A5mhJOupovaB4Y2KJpCHqzE9xsDqyPiaregZTY9+aqy3kviR8JepX6J5b53bAlCAbYMZ5rMJTo9VZJJ9txQOQ/jrVvRUvNu8OrmtiQc4FNtRfi3pSpudh9ZT2zrvuKuiFFhDEt7hOqesC1PTIqBeXWdy3ZY4HB0t1eraj11OXhWGDRH1VyCktOSOGi8Pv+WT50aSCsrL32N7tXmr0y1g/RWavxyIliLEw6cSGegaDtY1lBaPonUgoosx3Ycb4UA9gDpHcFr7fcvP0vzCahMDASWfZPaDnlEHccV4M9UE7/BzaApkJMunh+F0WA662AGjqj9iVe9ORUS2gaGloqoLP+gC+vbPLUy/zeJawfaKFEmnBYzQycm8/XQNaKdfcT6Ku61EBkAeKw8y2iAWm1MF2eQgBMUL0Y+MA2+8+Rquh4S+AaxteL6wsYnKpZedTDdbJoRWcxfQvyxjPYRdyeJc1UMIVLz46wNqQ7B2OXxL";
        }

        /// <summary>
        /// Create customer invoice report
        /// </summary>
        /// <returns></returns>
        internal static string sp_customer_invoice_sum()
        {
           return  ProcedureText= "nUgEvRHMKUoWUWpNWIaBtgJKvJSNwBNYQcQ8vLycpFDPoXQoCusGJDtvTv739I4Nly/iUU3AIfw/BC4FAMFVSH3CHzQ9DmmF9bnO8TrK0VgCu6BcsBiQ+EwRGydrpReFrez/oTJBnBdbHK7A4n1jVIVvePLHcwzN9POeo3ptAn5ZD3NEhFK7i6BH9ZVye9smM5YW2rbSQ58Cl0HJZwV8fYvhu6xOGLovrxR9fOWbcGTDpn8l8JFyc0R1yl8u5dgvDiCqFQGgSLLov3cbVB/K2KByTK77b88HKihqUolxYiPoDflsVgmrD+u8asRKisLMRwUz7qdXuzo/wV/QRAxARj0bGxctmBCZSe+Yb4wxmJiziUu+4P2oAIXd0hHIs1tE29lyWkgBuByzFn3G59NXu9OhqZSEhcic78L4bS/EuK8ycY3+OppvJb44xAuTiknIjPo5x0MlY12XtgHL2dtrPq7YKrUyWu+K6ITaFyQtBmQ4s2KraEnI1EEHDjYQnEbVu5qU6GAtkTC/KregnHarmGy/hw8HTsACJ/mZ5mEq4SwCdJN6y5l0UsPknlAgehYXIgrLunK/A8KCsbuexpPjZuGX0ruowrYo1eSx9XaSlFi8VEtnL3KTHhhAOPj458EnFnwd32E4npsJQACT3W6hAAHBsyW9j0ZzBUfybc+XcTqLj7amFVudkru6wCkTzY6yvQvGZU1xtgi3AvpPTd1+71UuNifFXwGhUfJ+MkIa/Rrt7gsY0mz/1NYG112nubKPwab/H3GUkLyv1ex7+tYPNCWaw5C1txj6Cczdyf44kBuSAXL/1cqqh4r6y97FUBGSpgEdgkssVZqAiQ4flX/xVQ==";
        }

        internal static string alter_sp_view_invoice_by_date()
        {
            return ProcedureText =
                "yXc/KX2DZjnZQmlvYnD/mGwlhK//W+5lZMKGOl38qUDw9a/tZtVdm1qB0B+L8Vua9haRGf9045nbops30l5Rd3qleQkEsg1n2KIVZNTvne634U2osS2abEaoUSOWr21ELUnyYZIhRSnps4ceBc5cBdyW2tPsnjnZZXE6BQUMJ50hZljmk7cuxW3KdBWugSdB2RdDWrxomz7tLeNSOsQbNCt9XIFuRr7H7s3kNUK6PkdNGpPZT2utec4AZRHcukKWRJyaUjGipYs3CIB9GVmiKFqi2hF5XUDoc+nN7fjEp+7t1s6gIaELOBBkczzsWNEMrnLridd7P0rMSQs9N/n+0Q==";
        }

        internal static string alter_sp_get_current_invoice_income_inhand()
        {
            return ProcedureText =
                "CP7qTyJgDDbMYt7hbJ/29Zo9MaHlv1wyomCFQ6RrIqeSB/YewskAVp00LG46K8vWHUNglZ1UrRw3oXYN1Z8RcY4GPWxOgfhtmzaKcEzHEPVcPDjH5yE5KEnrufxM5OZueGcQQXcOw6nzKPxSM0ACcZUY0ra/8lguR9Ac7izGxCl/oMg3rD70PplNDBf3UHt9MuuXy2eriRbuiTS35GJ63NJ06TRZeQ1r/P+d8SS/PsPMdCiQp3iKd3Vy4C1AdfTTQnvWYwebaO3w6fjl3P2Swbsfv2JhyMRsefV7XLwNa4afa5CMzc5S9U1NiGEqY/lZOunnRk6HatCmIqMnxhOFzrSbJa/dwzPUq9a1bLoXo6kaj73V1ngdMSAPoSYwh3zs1eU80/K8qm+xtBMzGh9zbK2c+QHZZg8RP67OjU+Wv7k=";
        }

        internal static string alter_sp_get_today_invoice_income_balance()
        {
            return ProcedureText =
                "H7SWA206CdbRdxTElObfV5V6HTvrMVfCx7oIe3ZcxnQpUFj818mu+GckenaBXPjvNLh/81xTkOWdWdOMSIHePwN4NLHzOsne+VBgg0ppEsKDscCfZRX4HIGxQWsIREkpmqEH6rhAi34qPQVgMdMYXC67mHhbEdueNKA/E1OTPdbUDp6BAPoTwZ5tYag+JCQyPQPvqqgE+bgMrPKDJkIP5LY0YRH7v5vyqwK2MqLxMwqzpZZEgsYHq53+heiFxYD0NADWPEOCnqxZOVmRIvrSwQ==";
        }

        internal static string alter_sp_get_today_invoice_income_inhand()
        {
            return ProcedureText =
                "Gbh4aK9mJlccbR4Wt0JKmnjK84HGSo+pOKl6CbgaMEcJAglGyEGo4jQk/59cinj3Af9fgIgMhdDjnmqFYedsCan3mkTQArLi2qJggPBLlg0etMpUveCnkbmIQs/nxiugOqWEOqjrpTFSJi7HDgRCnhyHTsk3LIR22yHw5wcxAZWMvfOtIDfG6wrnVcUl6qFf9zuzCi64OmnfKTjAYP2EAxGsTXpOnmtImWdSiB1SFciZOoDDtf30i5mZfE6PMPFX/MEbYhUz5QZcVJ9zytNjuLS/mv/QdQkrmrm2mUFV5o0=";
        }

        internal static string alter_sp_get_today_invoice_income_inbank()
        {
            return ProcedureText =
                "H7SWA206CdbRdxTElObfV5V6HTvrMVfCx7oIe3ZcxnS1kxXdW4X7QJbJy/M2EtqVQ+b9x/gKv5+GpOjB9xVK5/Pn79MiwT/JiAYDBO6tjYTcgAK3Ps4puY8xp8Oyqy21sl+/XXi75fSQfrg0QivAUBsyY7y9jJC55T3P6fANP9652/oaKLsEg/s+b+hGp/kf0p2SoXzbcRlyX6AS96621E1ly71GI/DeCL2aCYwUnJJw/QS1k6bpC3Ki8kr0GwezjlELtxhITq1+2s7ViqwtpgtMVUpMmC9Xop7ayHC6WeI=";
        }

        internal static string alter_sp_get_current_invoice_income_inbank()
        {
            return ProcedureText =
                "dIxV8u5nCCOmeFdOYaMZ27Em+im4U6Cu+t27hQ6DrqjXPNho73UUsr2Ie/rpq7mK/+oq9az1/LAbKdDOeUgML42d/FSmXzeLFG+mhi3PKAbzun9M6ld8wZ6D8DgAug541w1Tjs6sEyKhUgN8pdxdutAZc+9sdMP3svXJD87T+PSB5SMzcVfium58HQSBgfsRU7+fS2mv2QhBReK7hVUcRq4J+d0dvyieqbe+j59D7ZzyXQYih1kgWKFRx0P+k8j0uc3L7xktSeMAaTqw4iFTO51KRGC+hRcMVBne/V7TeD1f/PmXiHLAVDhViKgLZyICSm72GtNB/nnPC1v9UB23ycwFhZEgG5oTH42u3f6cuzAPF8HbGQLWDGszQbHC2ZOHLIwxhs3x0LvX47qJpN9pSEGAWlmRs0Eg+xQ93SFUVC+R6ahOKb1LxUVouWsXPKg2";
        }

        internal static string alter_sp_get_current_month_invoice_debt()
        {
            return ProcedureText =
                "CP7qTyJgDDbMYt7hbJ/29c4YXCA0R7CMgZxN2osK4Fk+b07u0fFzCcR0ju7lVTlR3+WZgBgFv27iGMm2TZ6gOJUZbmP9jHtr5aycEf1gNqIBQl3P1wLaKTIHZc7KcF0eJP3rGGMzaqpIirSg6dZoK/5OLm10BuJxBjAaL04qYCtGYkv8Ef20S9zI0PsMQUzjZq76UB6qjCuUUqT+x+hSeRxp7MGuMBYco9P/q5VW6myqW7MW+zTZ8RpRehX5uvsNvQAW9WtOJV22mdfSPOLZ3PP9J8+YxtLSBPvE6rHdmLl34x6faV5xrbL9zDDyuC4ePPFbFXvxMzpz7eaku8i7HTW5PpAbIQvElNqBIqV4xnHnUOarQGYbtsHsqRdX/+AUM9wvh6WW0j/ouBKEs8t9CQ==";
        }

        internal static string alter_sp_get_current_month_invoice()
        {
            return ProcedureText =
                "CP7qTyJgDDbMYt7hbJ/29c4YXCA0R7CMgZxN2osK4Fn79cm64ZBsrfTxW4MSgmwbGFT2H+SCtg1YzDrrhgZT2J66nJhyaXOyAz2ihCSpHXiSMGSEzqEAG5pHwYByzKDwiTYLmpQae/TfMSTw/+Tn+QWeRsKtwk0KaWrt/4uxxS2/GJm3+mR25jHPv1n00bPf5Bqw0gcLMjXP/pjK2iABn9+fOur3Zz7+ExcL6rEkOjhSd4zPdsSv/1bVb7p4NcGMEMchcolA5C9Mncx4JfjDYPa+6fxFOeL4P1+Ahayg49xTCqsdFhwJCcX+UrJlGJMFtiwWJ5TWWNLX2Z/T6PPU2f1FZb70fM61T4N+CyOKhO2OFoVmo4fXEO5vcOvuTa/TS3zBDTn7W2t0b/JuxygJUOvAMMeE17UG/MdFtaLv2lY=";
        }

        internal static string alter_sp_get_last_monthly_invoice_debt()
        {
            return ProcedureText =
                "H7SWA206CdbRdxTElObfVzjfFnKGOCYZMhGGnHz+a5vinEZuVXboKa5EPkzCyjNPeBVe7T2RBvkTYMJoGkhEqANhNECxJAwPQDFqvNrpPSSMeGxxUVtEnKBkwcuqlXeJuwKNU1a21IlGfKinSORhb0CIYTB2gHJbJLu96FGtSrzQZC38ZBLdgmQTuCDepM58Cn0OiBhWoNG87LvJVvq8qghDxrAZqDHd5U6/DH11ziv7aMHENE9TEbP7fz3by/DWoWRAS2wD/c/2G8BYQGUUsp3LdmNzx3GxbS0Iqip5BSZBGNiTBVLUQoA138fGnl4DUWJevZ9Nz3uXLocpW50hUDkAeouoqtPG+9e6nx9fpxa8fQgJ4gVffzUXUWAAJmmaeOeCt5bwmfc/NwUJXFwmh7+OuZa4sRWcjJ27Z/5gwuFTGDws17e1a+Vt6EwqtgVn";
        }

        internal static string alter_sp_get_last_monthly_invoice_income()
        {
            return ProcedureText =
                "CP7qTyJgDDbMYt7hbJ/29aP2hJw0dQh1TTadWQVEKy/PAQhZqeOyoigyA4dkb13nUNcnhzP4zTow9SjTcuiMD1Gpfxi2sSH8o8OA113jBe/JaPn2W3UKIZCYLygl5tgB3wcd5ExEdy5hQAEcPNUTVSVpbCf20m9A259yIjQ/PUB85k8BYbcj0vhFiEN6wSLw8eN5bU5yUHpe1+ZjBHXk/o6C5J4I1tlVQoeVNYcUnJBupFLdNpfK3/UfJignYqGA5Wl8zUL3is6zVxv74fCrCfQKPY0Q4at0jTb5GveXrwYYzhmguHAVkSTWhsEKwOQ+itwGYGxtUjWDiU1xWH6S++d72UGzZ6G5m5xL8w2vNTww9hz3S4Qeb57GfsKdl4zlJAop8SBtnqe1pT4isslJ8gdXUSk5XwaE/6ONw2azEkLSoOT292cu3iFbOwR4g0WnFKCKqgGZ9esr+sYxFnv0DcUKD3eVhdP0Rl43ZoZGjtY=";
        }

        internal static string alter_sp_get_current_income_inbank()
        {
            return  ProcedureText= "CP7qTyJgDDbMYt7hbJ/29YKXJFwo4zf6iiuRydR5eQnd1BrXe8jn8FKffTDgq3y3m8+BKOZetwDe+fRaOjbgr/cmGsd0gFHPKeSdxkk2afESG7mK5HlhhAZQAqZsxfeatULhRVPJpETO91KCrXvs5+nvTWl9u04zXLO7kBbRxHq9bQHDfJ+Vlc6H1N1CByy3zXoVNLRleRcbNbc7ZIEJpVcaXZo26JdOSbx2ogAxiO04v3SsvAg4UG85roshP3e25GUUzCuPZQhujo8dVTdk1LuPJ6C9KGyKYM+vLe8o9xQ=";
        }

        internal static string sp_get_current_income_inbank_bydate()
        {
            return ProcedureText= "nUgEvRHMKUoWUWpNWIaBtvYUX3lBVjJhbO5Btukmbi6oudkSE9CIeYE083k/cqAa6P2yWMYx+jv5PK6peRxKlZdyg5nQ9Tq+hvVld0rwn0RXDWPxZIls+a1lMzBNdvEJiuq7JcvCtPWZCa/ocKJX5kOCiIXmnLuFh3QelRDa+s8ZTb3+nuYjcf7VMqLlduDngRnsP5SVZwK0TLJ1XMCe4/GR0NaSyMeRcC7anmhWvzTE2jsBIn4W56MJc1r0tohVzqEW/XTU/EgyT2RniANZ6NFjTeBVONgsyhHp7ID4BswwBXBOUtV+UXwEew2lbHNxvUDP0pgp2QbS5bevPMUSyQ==";
        }

        internal static string alter_sp_view_invoice_between_date()
        {
            return ProcedureText =
                "yXc/KX2DZjnZQmlvYnD/mCcsZjJAyZKC20g0MaQ+tDRQ5IqT99LvH04z8PdTFYKZImst6UrW4M5Lf9jFLMThuBFonu8DZbUuLj2bIPME4w53tXQ55LLnhJtgy+TetQk2um9vZHKOp4sOr1KwuB3Qn17E7Ae3BvMR4o4xdMaGJJ5DDgrmsaor0kNm+k7AExqI4cSOOsFD9tx8M6qwqrSLhUwvv9f8ORf1Q3iOT9FMwGUSpEUNVlFvLejPZ0XrO7gdlLarpYgj2+YKGdiLWmUIIvKiR4Cbftw8BpzQzZT6T/9xMTf7gt7Qx7v4cVJxbsp8FIpLwAJGRVJSaspiZXGLo7h95rKA9y+FlnzAU0UcZldXsd1AYEB+6gpf+khuVeQ3sEPeQklOOMCx74cIZ6eRZbpJmOJN6zOMdKGThBxD8oCK+qB//Set359tmUCXoDVd";
        }
 
        internal static string alter_sp_view_invoice_details()
        {
            return ProcedureText = "yXc/KX2DZjnZQmlvYnD/mFUdeqDB51QFvQFsrcUe1UDI1sJyBPwwpAzosRU7yIqCzINKK3ZIOlwUHuIlkf0SM8kwhCElDqql0dUel8XC5ASTrjMmBhbK3U7FLGY/LwpDMnoVsoeRAwR3aDY8c7YWqQoI4gnqDEFT0kuT0cx5y2d5AbcNA0Z7iVuR8xMAWzB3oT4RHCeLVYD5oe/TVdDBRVbbUjv8AaoLAjJzac3VrXBLsVMchRVqYYNWdbkXnqbq3A3p7WxQAzzAtyRp+sSl03aPx0IJ6U6z8NRxjkNo7y+ZzaOhB9oKkFvU9NXOs24KcRvaXDRm6Up9ltTp8BjHMJdBpcHq8MCdqjGCpKbWWSNBiebzrD0vtqW1S2MfKSUKzfEBa4CICiU0AgkNNOzNhmK4KnjDC4b04mmoXUL4ikV/LKvbqDJ11hObZRHhke6VIL7GXbidnJKW3x1ifKIY1nRTp+rzzUJIOC7XdpVLw+PX22TNY4mKZlHBpqiOBbJpYI4zmirpi3Qc5zEPgK1NIjDPEmiLXSd51wBXmFQUFT/me5+mlj0zwh2XUtEZQPN6aCj95eH4+/OVCxNRmfjXMfJ005C2zlc/SiFkoa8V7cQETAmfD9l+6LjX6lxKbK6QA53p3BinekF9h71LAOIjjbgawQW2L/CwtS7xRz7nuimlv31RLDcG2nA8mWVcSxBAjCv6cGHFmDzKHv+160kSzQ2fTnRl1x+6GJXs2G7l34fskLQuRhYo8XgdJDsbRFDd3o6jbCmOZf7AeV2Bjs1pJWDxML2lizakACpK0TCS86BnsKuXPYEwdvtf7/Dv+8mUZ/BYZPZAnIBXJt5u2c42yhTojGCKUIytjkVdJOei8wrngABrWGTyWPAsdsSmcISg";
        }

        /// <summary>
        /// alter only invoice procedure
        /// </summary>
        /// <returns></returns>
        internal static string alter_sp_only_invoice()
        {
            return ProcedureText =
                "r1tXtzLCul3rUkzzC3ZF1oSmdAljcUVuAlxl6ED3NALOCvSoR0TLlkROJVPNDVVNh0spMB6vRv9AbqtsTQjcxF8ZNPYmg/OylTKSVq+KlQjoxsSLr6fhHnd/E26Y5xtoMTg22fqqEWLbVccBs4g0iwQ6HRs64EB8jztryNdAbDH2AdVYdO6S4unYuNQuucIzeXX9SDxh3hxUo8c+BFN0ipJeq0YcUDoW7xNN+H1wbVjswXmpV1S3sLHH+k/R/tSZAH33zaU7Dtxf1e9mG/uOzMNlVCvdymJ2fsiJjbTKX91mSpC8yOxXOsRGn8axDUlHZdwpoXs78+qqyISiAlw3VDpbNA5MUY8sWjPSOf2pZRfDBRUY/G4dmB9xz6Yz0FmK";
        }

        /// <summary>
        /// Get last month's total invoice
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_last_monthly_invoice_income()
        {
            ProcedureText = "mL8NL48TeK2PgyMwRB1ZMak4+Dd+oiZfY6YaqG/W3MRLC4rEJBZik1RUobO019ERED4xJ/5nxnoAH88MIrha/Hp8pb1lnLShodm45OeGZp1nRuUmNNnwtzSzwPYP05iDBl0v0KKTL2SY6DAMuxy6cmlUc45TMNDKh+38/iT1UaRUXoKnhtZoyWDxRqOBTt6FZHFk8RH3dfTUV6Ih0Euvm3Rok42nl1pcTT/HwrEgZU1kwdrqs8702Q7zhcsWSyPl9P/g2tYhb3Hq4GJI7HWk2DjJN30yU4VRhWYtFOV5FnBxivfJxVDQZoL/NfAdbSVLZUVG4hQJ3s+7nCmYo3jKKHE87xqRN+ez/F0hbWQaU0BRN4K+dK3qHsGSXn7tGDpB9hRyACR2VuzY8v4E2wSNXgjSNXW/PFekX1rk/tifiw4B/UKwSW54VKoWw2P/SzFP";
            return ProcedureText;
        }

        internal static string alter_invoice_table()
        {
          return  ProcedureText = "97M3jJ9LgJHKmCnBcklqdeqbfNTe79TPHjWF5b2rT2ODqX3+SOLlR1t23UXNAGtZ363DXAEFPu95qd61BAkjjw==";
        }

        /// <summary>
        /// Alter invoice procedure
        /// </summary>
        /// <returns></returns>
        internal static string alter_sp_invoice()
        {
            ProcedureText = "IZFA+OV+2xi/I+sNacF2/Ezq5snvefEgwrEEZqY+5ssffbd/EK0J7+CBGfNjze7OrsqMKER7AQHCFeo9lM903xIBBG6eH1Od0RXjFmLXzBUszD5Qq7mNOY8nBt9E5+kzqRLMobou967IdMPNMBTiI3twV5Y6bpkrFBtWv+/iTc0qhRgYjfDiHyArombk+mEKyWeLow+FriA9PgS9H9iSJfwcLgnU/wrw9MSPOBAUUyK58oe+iKLius6OdpTYF2ays6lu5MtfBDhDUePS6g98kAF5GCSJqMsAa7zDmiGriGCMnXawP+qFxMVyqhO9ka4TDOre+u4Y5EWujKU+dQahxg45cQ48GFrdS4FbWBRQTqfSrACRRzqpZ+7NtbtfNffghcCeVNSLSb5JlvOGwS/Go1fF3ommGgp6i4PN9Yar9bPUhbW5Y67CpK/K5holjPIrJyRdzyM5uhhAsJKH0mC5hCeI7Mnvqfxnn7oW41nz5muDO71l0hfG0+OqTcHOxx6GqyMBdddWXhzpqIF+MR6fn6+N3RiD/cKEB3m7xOqK6xrwBT4WbxB3PCOTfcA7rTLL7rKqq/3U1ni5Kgs/WaEXG9KBeLLzG/6Nf1G7TfaIIAIcTO4Ewv/FdA+dBU416MOWLLy+WwQJ+Cjv6NkLtQ56BGiw4TjoUkH15DFON5t/89r9y8C3EP7EanMkEqjdcw8zQH4tLUmGUBrT0d0OVCq8P2vj0s+Q83TyiJbe0j1rb+DPw7NbefvFRKiKIc76RLLwY/cGJq5dEJor4q123nl5OwiZZ0Lz9LijNiChMA9cxP9IVxnaUUarbnCDqJExZKSTI2ZTCyLLlJheUTXniynSR9cfARN7hDXLH3QlrwXw5dYfd2CzfmUhQ60+ps/DPaytXb1EvAlWYNmnbNcvb8HL2Tp3lgT6steANpaM7UKCK3MprXCf6XPpxA/tuizoeHcf6sq9kUnb/cK0EuZWHV0Uq5O88duDsqxPzB1NaRfA1g74fXZ7tFTXfVmYWpvuJq/9dgLJVgmOBXFuia0YpZNy8EahD9jmiZ/kzGXdOVQcP0+dPKaoDik4XW8HGIjkpbDKJJynlOXtm3Vj9brUSsaoc5d9KLariMIOCWmt/yr14oySpKskv3ZTqMkmUpfXs1BUkgHsj18fEdLAxn+lNTcU2Qv5eJmXvNl1iZitSiwKaIWB3D5gwPTKnqXnIJOSsV8wqUyDvhNvDlhzCRrRUCD17kFcQeKC7hw3e8zvLKuSTVoNrOwPxISGeS9QXyzX+Brk3rnb93Viu6a0D5UZ1sFz0RastdDdPejDjzojAOUirH64+YIn/xGV2pHJRFhXrAY055nxHC/5mRJdpL2g4BQQzfyhyRxvrtAUHb3o2PEv/uAwnZpUud7fwTXO+qQQPdN76dVRfEvF9N3qaSPgZ5qtCfIj1rdVrM4MIlKkXH6OQqHAFSx6ghneSq2n8EfrGmfr50xRgeQKUmBYFXuw+m1CyAGfzV44zDM+R9RQLgUP3wXCGfF9bKk0Sh/z2sqYTg6i98F7+5+WD0qEaLu6VTQ7lNnCUq79iHKKvVBcc26bxn5IGkDD9UMcVDmUXoaPhndGZ+nxvjmkM10ZXAvQGI8kJw3DfBHA8HOQ3ZZJ4ZhsPzx+Zv6+z8KkkT9OD+f1v2lMAr0wotInubPXCDEVAPIkSIH4Occgxtnr5wWQ4Tq2oVVVxGlvfJycZHccGEcRqJkrF2yG/v1IHiX1ctLJkO+xsfo6xaGMEUKjQAvoOlNVpn5kOK+U2Z3Bt74hO+PXnPAe";

            return ProcedureText;
        }

        /// <summary>
        /// Get current month total invoice
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_current_month_invoice()
        {
            ProcedureText = "nUgEvRHMKUoWUWpNWIaBtluhuNMowHs/3bOjiqcWVCdvkWqz3PEdCpEvy7OjrMF5ulYxXl5hSA7ct44IBbbG0zuvZnWRT3OpWoBsRjQVg2k70+2fVH6+QT/p8oMNWY/K0BbWPxeYWUIbl/PjaYDLh3duqm3vgyl32wSG8NrfPBsX0iBrwjgpSngaom5DGG2jB7oLSlkotm3cJYjjmAYzF1fq0xuFMoUhdeHazvUWVpXImM3oGH4Xzam9HxSXU/cSB1YM8iHbgSIXP0u4J7uh9G3rZamQ9tqZSO6zBeHH/f2jWP6cu9n0sEcOJVyh4HQiz90f9SD6zSbD38F4/L1zvoeXIOdD9fKMbM6fbux0MMDTJHfcxO/IjD1Cv4BaBnUA";
            return ProcedureText;
        }
        /// <summary>
        /// Get past month invoice debt
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_last_monthly_invoice_debt()
        {
            ProcedureText = "nUgEvRHMKUoWUWpNWIaBtl4ePrBfw17nVPTEg47Q4IJb7rO7RcPGNE4NPnEMxgUXRm8mEVaKgYIXq4OrN/Q9pvMrZsdExqqenPgjOzzYFGOZS6jANuR5u2FAtBZeoceAbpKs+Cgs6BBAAr4PH8Jrjqvv/raI36O2Ae12sH79P6rtG+G5TTbYUZ89DvxMzhHhCdORdO2sxwu1TNF/W9cIoGSoUd26yWu8f5FSfHy8PJRUWhV3bb16BPjR2AxrVakGwMsMsbaKsic+F4932D9Wh8gAvSlWOEeicbd4Qqy/nRdFQ0rsVLGBbHyWSM1He55mtDPpIV0+PBwBDIj5wCtuBVRY/GefpfDLUiekr6LLTomMJbg31zoT+OyXKXCExsLySMKZg+k4IRlphutmVmOOLr8IpQzFteO8ZRlgk4NeJzTscULIloBm1aKvzZOU2iGH";
            return ProcedureText;
        }
        /// <summary>
        /// Get current month invoice debt
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_current_month_invoice_debt()
        {
            ProcedureText = "nUgEvRHMKUoWUWpNWIaBtluhuNMowHs/3bOjiqcWVCegajSpbtAqj1tM7Nfoz0N1x0iYd2zmGqJx4xJrVtCLPU9+3MMsczX8/HbR1M7JwWMNXcPjioRHwrUo/ywdsHqYc1/XE9qifgKejAHbfq1PRNQuTS3nc3GIFNsUXNk38fYrtWnnu+sv6ApJpiWxYPJPawjvbe2RP2WjDxG59PZN24d+1WKrldH5TgBXD1r3uMzqWwDnFCLUNffH7ZQZNqvLC8njRvyEbkYSAqQfbSARoy1qHCB2OuwFWkVLOfaQ9AKDKsuDo3Ax90nm5thIB0AWwchxqPWgDJdrEHk3KavARVd3z0D0GDBxMBHJmu8AUhpGdyJA8ZR+r8wAfyS+QKS/";
            return ProcedureText;
        }

        internal static string sp_get_invoice_cashflow()
        {
            return ProcedureText =
                "mL8NL48TeK2PgyMwRB1ZMZp2xhGlunVOddGDLQF54lP3njIw4HSn2LVKNVNdsOeRajYOd+DeGrvGyXLqCJjtoP+orLTc7JgE+EcEmh0WMDupiXvOdq0NNRr+GHnszaIKwsKafOdtmi7rdqFgRYeDmMQ0v099RJQ0HmDJUpyrKTr+T9viBpqxPz5u5gSP5V6hOFkkGx961MdtLuLSMDMTuQ==";
        }

        /// <summary>
        /// Create procedure to get customer invoice
        /// </summary>
        /// <returns></returns>
        internal static string sp_view_invoice_details_by_customer()
        {
            ProcedureText = "nUgEvRHMKUoWUWpNWIaBtuxHrRxTxixhZAL7E+KnliYc/AXw3r4VPRLfVMtQfCrnc97zYFpedW5CSyJ+d5gxZp+5nEubUSjAFvpE+jVP/rhO4xazGVuOuspgjQrtPFEzJ6wfBQN81D1m9u1AnfWPhl1sNpQFy7JKNN5G5a1aZqa9DCcdIH4Vrddu2B0cMf3/RJ9fEG5myJDPZU+2sAs8KymgPyFQggb4C3cmp9w9e4ADjQLEwTddKOlGv/cLD2P2QMAp7Lpq21EL1V/oSqOONkiVKvwoDkCxbQ7DEENEgQwxFoxkdFEhtZjuRPyh6BbLfXEM569tAO4Z8ALZ60MKEGqLqXIp4znBZyvcaN7/fySN3RujSrfNvxJYpSgSBe+DCMb4dY3G2ZRxOIip1mmzS2Gtk79Fp4RtCUNT3Rfv6bfcdYCygiIeXv2DFNsV+HSKJS6xuQjAPAHjGCh1sr3MdzQzsci61aTRcL6hoPEJnf6/GNRNG3gZ4mrnvu9amcs+28nrNYJl3PCjUSmNvsY6zxYApKuXHQGH3HgstUjtYb9db95oCPhPSVBSA1Oe2t68LFdXLwfaEsLoo3xxPaLexS1K21OjXD1FFPCxZZ0EkI2htXzM6hGLLFrJ3R7BuDDRR6Zc3PmTCSMHjTnoF/s+UMCK1hE5D/RvCw0R8jlLc+xDYSQBInwS+NjXt9T6tFD5qJAZW6x1K/JLJ0qyZM2jyd1hcWPqziz2p3f02uzpzxoRl5NZvzjVP1TWmvKTftRKlQtwsgD3IRTC6pbj6mrMrDxy4MW8zV4d8qq4lJUyk4fCWYiMJliJUDQT7fTdWLc3GBFMEHtmCwSBbJEF23Id7LiYL7cTSmiABOW+0C54rcAQjLb/c624lt4dkGSKveq9SosMpQml2sU49VM0F5Tdd5m/myEcWja/kQuBriYQ1pSu+7kuTnciCdFQy7UbcWRAQpVl+S7Lg2/WPjSOsy13cbhV4P/WNgZRiLy2VntzdTIKqs7sNQnu1wwkghkQ7+gQUqctvUfS3vaso9GJvR7arcgGiQOasy2SeKAsTrxVOGGzNVF0lF2m8AVymCQvceAj";
            return ProcedureText;
        }

        internal static string sp_delete_invoice_cashflow()
        {
           return  ProcedureText= "mL8NL48TeK2PgyMwRB1ZMTcUbRSXrJjnWJMvDwA7qWjXRfVNawvFtPHDb3VJbCkJk1UBnThpl4RSM05pTakxYpa8j43QQjpuV40eLF+AYwzTvZvhQ0jzE9hAQAHCNIjMxsphyewS/+s5+4NHLFhQnwExpTRAcGgcRNazGmG+QJc=";
        }

        /// <summary>
        /// create debt payment receipt table
        /// </summary>
        /// <returns></returns>
        internal static string create_debt_payment_receipt_table()
        {
            return ProcedureText =
                "TVgtK3jTvRnjqMgo97hyKight/jhMcd5XoB0AgTcH/7T4Lg6wnxYeknv4y66VKZ51MpjeiDT76HIvNRlMZX74MPZSoBA9e5XpazOfzmL85LEYt1XFdKRSJ0XAnHdMbMBvLT4LyOoeqMpNk7A7Kp7X4olgPdbmCmjKKkr6/ZIQxf+AXZb04s5KobTvX/i2G3D+6BsQJNh9ZNqHTBXYENTnqrjzU9zmjoUiKMh2vGGQFKNkBebRDrJ79UWjWPZ63maBxWhSyf6oEy/4dcWcL9HUIsTBycYYVwoQpSB+AmOLKAAo4jay6ah7atgRJ5agSDDEFja0H2ekWb10ZlNMRi4X/rFelE+wh5mN7LlcxlljCX1y+MYqrwEuYjnDaYDQpINEz5DLj7hz+SX3UgriHPMxnOjKwgwCl5IZkZie5KYJlgAmvgg7EvKKbo9ijgZNhwj4pYmA972Nh1oFc9xlCtlAm0GsTlGeMi0hTaxA2H5RX7h417nDfRh+DWCmdPj3x36BKbLWVlJSvZ2jTTrT+EFIw==";
        }

        /// <summary>
        /// Create procedure to get debt payment details
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_debt_payment_details()
        {
            return ProcedureText =
                "nUgEvRHMKUoWUWpNWIaBtpM0KpPRxs6pX+r2EXDXPKF8lx8IWydD1bi658+pNCGmoQQbOJOM7Ogz9KsBqPX4XfVjk1G8ZVeUl+OwAfkRUXOfMXaiFK9Zj6bRKrGZLYwPVnAYpO8otVAOiWZ863Kah7Ae9C6+5duomm6U19OQ8NDNCHIFh21YOWYGT6/iVMe8q6NL7YkthhsW1wVzJSTxdC/qrA3+vchGpVXGQCTwvLmOx3ldnALPgNZ1C5GT/zs0cc3pvSyPMtuMSNstXl+LRCryKOcNAo8gTNCdrp/nvjmbBQsxzfVYa08Jp0zd5T5o";
        }

        /// <summary>
        /// Create procedure to get customer debt
        /// </summary>
        /// <returns></returns>
        internal static string sp_view_invoice_customer_debt()
        {
            ProcedureText = "nUgEvRHMKUoWUWpNWIaBtuyTuK4EUqRkw3hWmXYfFcfjt2RpmfO0NTZyhFTpBgb4SbpylRBgvrzKUj+yq385+/vZfRHQn5GoTNUNjO1x3RZ34tun1ac+AdML7pUNznuOtiY7NwA0IZZ/GMr99FQzHlq83OCM7hejT6cgF0JnzqGjJgsemZWH1IJIDGpqtp45sdl5IT2IEgr9qwRdc8MrKzOpbxyNRB37LbsAdchAkx/08RLrn7U8u/WiKEOw07Mla53uwnjoFJyf3sP+p5he00mp/hUnjD3LPfXAKgeTIFP3cMhmFWbu1N7Z8PhK1UWaLykcvMcfbycSkEFa5KnQTHbCIn7A5Q3OgwMvMwhjeZRQ8YXwKvIYttHHrgYtisNiMFLNqW8sIQWSPcNpmpWlKYuGBi9kMc3JvoYnIrHWNFiJN8f4JINjPRsC+7tS1r3Y7RBBVyFg4IxJz2FGCiXzzcvMPB95w3wC+NBhMtizHZ0e0Qg1BWEa1QXqVTmg+nbj3h2wdEHhnM1ybx8im4wbAPtN32xjgb92KaNGPmDNX2k=";
            return ProcedureText;
        }

        internal static string sp_get_invoice_heading()
        {
            return ProcedureText= "nUgEvRHMKUoWUWpNWIaBtiHmefXliO8tBna6aLmKjM5ALFvh0RZ9Xm/U+olAmribXnCN+E8J8AbXfHF+EuU87q273vsrFtxEa+NcICbUVlxn6viY4N0ENx28kmLfcwN8AFunwraaLINdEv1IksP3KDwIo475PITViD+yWeSHblQzeXeQP1pxPzLlkcxVW+nS23MQE6bgVus2Sp2bJSauohdVRHOEjUMkx1ry0iUc+YemWVtRzpeqbrk8jK76Xy3cQL+LPnGvtwRONBXJVWkWNKmvSMFd+QuCTkkY8GXvtsHHzv8S/YgZPBA0Bx4FUJYjwsXo7Xp3EkinbW+N0s6p0GBqkVBb29YFDYMCXg8Ys80=";
        }

        /// <summary>
        /// Get invoice cash in hand
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_current_invoice_income_inhand()
        {
            ProcedureText = "nUgEvRHMKUoWUWpNWIaBtq2B7twK71hKfKZgXmPOg54ZcE+i/pUHjnicPYuaWNHdparhgVOsHPrZWekqJyhanLwsEOZFrIvfh04mSvgqFDobB3aXkHVABXzPNPd2hjbB6+twOC/SdeGpNRSaor5+Jp2x+wqJjIDqUQuKQ6ig0lIyiWaHOINR5K5292KC6oYDPATEqav2FqNaLMgk1pAC4qauMSiFvFp0vcUruUgau6KX5GKdjvVIAe781ZFdFpZOcv+9lTrMqbMJTH5iMDdbm8lmf5E7W3V5NNgMRq+QrdymDm2cw5kSVfUeBRxwDp2Cjd1plqINQiJuVSCsoe0zA13iPbhpFDRZ3kdNDifI+7iPWdVGt0WCUMFn3v59yDG22Z4B75D3W3H+Mo0F+J9Glq+U92S5xyiu5R7IGoOqz8U=";
            return ProcedureText;
        }
        /// <summary>
        /// Get invoice cash in bank
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_current_invoice_income_inbank()
        {
            ProcedureText = "mL8NL48TeK2PgyMwRB1ZMYTNrV4srpSQRBlIoFLAXdFfd+wnAEjFTk5eV2hPQF1eApG/r73YCxijOGzhRyA8IB+GMjJudcuRSllQ2jzEKbb3BzBHYozPYE9poTV8S5m+Nnkc63EB1vpSAlSZUaaDaC2iAcrREOQ69nnICDjnN1T3SFB77QH0Rkwb65DXQKqkF5nU8J9Ok1ONjINJCwn3WLozW7buAMTOJquRfzUWSj7SziaS7egEFEUypgG7/j2MFPLJ6rci+CqNW0iv8528a+NNg8oA9a4E7YjqR3OBPCEA7cgHfY2P+E/gIiHpDkuIfLbI6fl8caX+JgXcGZguXlLMVgoj66T1rOLT1kelljvjJwBrcoBbSihSVwmhyLV5VNX74oOkPH1fgtzCPFoRUsP8j1T/+NF4ZGmFEuRSWrU=";
            return ProcedureText;
        }
        /// <summary>
        /// Create delete customer procedure
        /// </summary>
        /// <returns></returns>
        internal static string sp_delete_customer()
        {

            ProcedureText = "vJnp+gCKU8smNn1nIOJs3QyWo/iqSCgNoi4lLmFYDsDlW94RijvEEuDGm404tKb1vktlj5ABLkY3haDRK96y75CRP51IRqOfqYjPlb/tAS+utYTw7x3R1D58SVrU+MkstGNujuk3FUjwGCEWWAzXYQ==";
            return ProcedureText;
        }

        /// <summary>
        /// today cash in hand
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_today_invoice_income_inhand()
        {
            ProcedureText = "8pdRoweUXP5ntW7ert+JBbWK0hmYmo1GEnwPuoCme5289wImoy4yNhIr3lMYdm6loohaezpd0wyJKjYt0p3wXh2OyImm7W+wplGiQNLZ6Vn+phG3cz9XBJ8/fAFDcXbgqktRMEYhBU3s4lZk/7cLyd+ri5EBOkvIT5QB35IDxo346xmhSdLZqTuS955W1N6QDu/Xef9C6r5C5Jsao+HfwSFDNoICprt75/qULcqTEKyjsw33rKQE6rmOYZf79vre4+HoG57/0ei4ydS0x4XsGuwdp1CKz/YVqoCg/lgeeP8=";
            return ProcedureText;
        }
        /// <summary>
        /// Create update customer procedure
        /// </summary>
        /// <returns></returns>
        internal static string sp_update_customer()
        {

            ProcedureText = "s/vJy+WvgJXB+hbeU1wDUyKffvwXHXhphmj3tFll9+dO+W+Rv/GfhtyrSOeBadeCCsOeUaCKS6DmYGWfv5/ccslxfjgvte8WiN84omDdVP7c+sqCQfzahiwJbt7zbeumLTzih4rm+5EXSSxV2qRtt9spWDYQt9DW52T5gDpOvdV9Flm/PhVp2DQWqXnGD84ZLWxSYuj79K/sJb2y5owmzeGmuTmyheNoiLlH/Ri1RBc=";
            return ProcedureText;
        }

        /// <summary>
        /// Today cash in bank
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_today_invoice_income_inbank()
        {
            ProcedureText = "8pdRoweUXP5ntW7ert+JBbWK0hmYmo1GEnwPuoCme52xuwD84HytRCmi03ssrXwm/KWFm+jB+3ygqlGepnyCfnnN1KWZAIb+7GtwbwTDnAOHR5az1JUex+dDJsnFRwRwDUtj6Hot+hrtJrtpNKBzUaRtEZRHaKahj5RIafaGVOM7SWSsJA2t9mEA4qBDMUrB0mvGem82D4/BFVXCe8r4CwSL9f67ry7vuGIvCp88dkGyluOv9OUq0DWmY4ai5B1SkCZynbu40RArpCCobyA1TZJf9JciEgAlS9aA+Lr1Mek=";
            return ProcedureText;
        }
        /// <summary>
        /// Today balance payments
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_today_invoice_income_balance()
        {
            ProcedureText = "mL8NL48TeK2PgyMwRB1ZMXWrasJyAnFeRsbjhUP5JHr2AuMzp6NMN7U7MwsDHq3LQI2Khh6lKMo5NkXbmgXLU7DWPBp8w5SeBHseVyv18kMpqSpg5tQT/F9c6OjEXQ1Va438xDBW2FQyU9PPRRViOk0cdvhqVOHvBaUyyhpi8xbAHvYUK03AgJ15I/tSqKFkhS+vDuVKUVKmcFU2nbqhc7+jB96LEXhYQdaHyfjd8I2gXmRemFPU72N9ChCM2jebdP0WjQND6v8b3+DKSCjbcw==";
            return ProcedureText;
        }
        /// <summary>
        /// Today cash in hand
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_today_income_inhand()
        {
            ProcedureText = "nUgEvRHMKUoWUWpNWIaBtrVRdcxv22fN28MPXuCosnxqOlXBL0aSut3IDOqV9FRm74fvgS0hCNRu9UAafhhRcNNnEmq6O4a0jvwI9IdVyKEv5MDJUgvekNG8D9An8EEqRyXV+h00I0UenTmsZIso08scFPr8WxeX3VspwvK9tlopqMrGVOtOncnyytJQWvP/bq9Y6apkYpZosxbBWru+Q8r4kcq5S2fwRCPgEswaSa1GbuDGRq+lDFp1DEl9WZIzKZIhzZqLyHu+7iYEnTNfL2B/J9tiakln73xzvRuRqCk=";
            return ProcedureText;
        }
        /// <summary>
        /// Today cash in bank
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_today_income_inbank()
        {
            ProcedureText = "nUgEvRHMKUoWUWpNWIaBtrVRdcxv22fN28MPXuCosnxJQzUP3VyYDjLvMfBcLMGj0480Kr1qo7PfQWTDns8CcJjuwXRCN0fxkNfDA1HOFwpWxqF/EpuO1Z0oUB+l8pS6XkM58hoyPpyqkkk1pONqqEgAZx4cjQRTDRWD87mm0sCh4rFJg2K7cFDhcuEb9RMUb3Sm0X1JEgB2KqVdYFDpiK8OiNsGHpQCH0M4L3kKwDW8yHYO90vQYipm2fC138S9AW0K+qJV/G94DXbzVNTlfeiJ1MOgbdsWRNGKwXNGpKw=";
            return ProcedureText;
        }
        /// <summary>
        /// Get today cashflow expense
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_today_cashflow_expense()
        {
            ProcedureText = "nUgEvRHMKUoWUWpNWIaBtlTKd4Zz2nf6dC+a0rtJ8CkpYKRtwj7IfntHuwRvogAATUyuGIiP96wh0oDhDkQahcZwfgH/GAocPecy1jLS1YO85yPT+0XcskRmjd4v72kY9wQedG42f//jD7o6+jsJb7e3aTmUWu/CAvP2fz34nreIFxHcJtFZIY3ihKTmS0UtQB3PB2tA//ymSw6/imkOMIp0SILUEPUsFQCXTqtqiiV8ZWHmbxYIUaGTQCz6iNgKRgAnehh32hrmPw7z2F9aTQ==";
            return ProcedureText;
        }
        /// <summary>
        /// Create procedure to get invoice customer
        /// </summary>
        /// <returns></returns>
        internal static string sp_customer_invoice()
        {
            ProcedureText = "QfsTx5HETVeYT75Nw89ny+ifjxp761kJL8Cdt0TSBA3CjFtzF8fD2uhhZ/87Q76EwFUPoh6fUGJLwQKI+jY2tSxIUwWN8YSIa8ZDKfWdAMySMAooc/YqWD52RAMEWByOKW7evhOWYxugCt/8sgWldkNFb5YKBuFvBOZw+MbF5o1LJDjJRT53/gEWVPMXh0HQejrb5nY4ADz6685meX2T6JkxC/Yhy5A0xRuj8PLucNlsGMWbgrrrtu/NSTMklwzC";
            return ProcedureText;
        }

        internal static string sp_delete_customer_invoice()
        {
            ProcedureText = "nUgEvRHMKUoWUWpNWIaBtlGedh1Cu808X3t9lv4jNYvpokAT8rkmgxEgLb85PllOXcIAiNBidAg63Rk5QL8K+H/l37iFrYQHaeQfwuPghzHZy1DG2lECO3N/lwwnnRdrbPor0lrEn3im7PikhHZ+j3lONYZsMbY1ZnkKYXVvtSHztYH2HuR2goZ9RpezRPogkC4ZBopFjXHa1TXb9Z6tstMXnPjQpAbnxLiu+1aPUbu3dyDZ7bfBDI2auBqeEE9hV+/0gHssOrRgmrAPvp6JGBXJRoX8YSrGLQ+vFM9HMBaVjD4/c6OwUTpo+ckCaOe0UF0eXIIop64ZRrGXi3bwajpYLp1aJEliQ4ddAYq7bTRhmTc95kJ3NgIF/pH3MZnR";
            return ProcedureText;
        }
        /// <summary>
        /// Create procedure to pay invoice balance
        /// </summary>
        /// <returns></returns>
        internal static string sp_pay_debt()
        {
            ProcedureText = "zThTVwaMoQY4j4ZZORYSIQkXfV181jD7/W8kpX2yCMvTuuaPuhrPEYQhIKYhIFydRbeklVLq2VE78ag22MSjeDPprt8ODaySOlSX6yzK1JUdobSzo9oDvQCxoj7EDz5ft9+ciGpyzchzCm+RcUIEQoD16vpVQI+TXfyz74BK44AzI8Orctg7+cg9Dd2T46Faa5hNhh2pHoAq1j6cSOk3CuH7n3duW2QFN7W4uwVPVHVY3o4E3RwNumaXug9xf7BiHvR9r86kvnSFwqKJrJ6UvNw9JLIdBKcz1YmRqUhDBQnKryJNLytXNWkftNO84zsOThG3AAhjDaX2qWTrY859VyevTM3BqjtrTkJ4nkhu4U+XTsrzp+P//zRQXs6ocgh5Bom5UhSKmzUS9hBqXpVbAhaEKzDnhZ0MgvmkS675P2gvWUovU7q6ZT/5JR10nu5vNavGIiI9usz7/M3d90w/0b5yp4u0qxzoanjow2Oi6i0wZvqBwH77A2s5ivGvziopYbndpKW8TzU8Ot6dVzdfTSQMHeoc6+yQs6xLyPssOxSCFMH4yz20j/FTT92ElQ8v1DkKyHDqazn2mM3M6jc2Bn/Bw9TNSxGMiKmo/Y7Xc2jmOaDsjIjtTyHj1HbYn4fgeI8tA03maCA+4DLkU12eQXJzd9jxH+UkrmeklODm58z0C6IW9sIsKFPrwtHCkOPS25eZG4oj6A2rsz6MvGlwOiEU8swgWKglJLtQMGwzHZshBR7kKq3mzjqNUPHJxmBT0NNvUFAiEWy06rsxn49/iEEAykEmSvkqahJH8Igqfr5Xw+9tBc3BXSbZZlNu3P+fQDF366kHqhNrXXcLV2KbXoq4nUJ1o1C6vXqE1g2pKlLYw+tKK1rF7N//Yt1s76G/TlOdL6aX8d2h5Z9UmTNyBCWvidEOqT3skSdCYUrGEpqjmBjiObTneKLyY6Bw9y4CPH0RgB93vZudPzTWD29wtle5pEPWjiF9dvjxwabx7XVK8iP+0zZA0DH4h7d1CAKczAPGpvwJ/CJYcnUfcb+2lMUe/mKVrmUlBTB3ER73KOLRUcqUPo146iQpXRMfl7KVEJeJ7nk4Hqca8l8JseCeBjvb9jILWvDpDN5S2CP0ZFfmAnMh2piDonnI03WmctaMSa6jLk35DR8bAR6/gGaH9W+buO+8N4zUtWLJL/eQo5x34Hx1Xn/O/LofBXkNNuilqJsy1WB8NhXPAPwzhzVUertp8uXCYGRsSvXppFixgeJjtq0OyVQ8J4KB6joK6XwQ9hwgE0IN4PupGV/yO5smYt57+KtNKUGGZI/XOu9T3ie9SVSAscaqMlEWtz+B20IfYYlXopPA5UeWs4Fe4mjeOA==";
            return ProcedureText;
        }
        /// <summary>
        /// Create procedure to get last invoice id
        /// </summary>
        /// <returns></returns>
        internal static string sp_get_last_invoice_id()
        {
            return ProcedureText =
                "mL8NL48TeK2PgyMwRB1ZMZIRZPs9jSCi/gPo5w77+7ziIcrS1wv6KMkRCrRk/uk//RH8O5sM10L63hxViSEr3UekzMZs0yklpy2g4ASI+DMLSqq2xi/HWMQgpAG+/Eea/0t/LG1M2XKWyct5VM62KKuusbgMiIm4pgP7gWJKI98=";
        }
        /// <summary>
        /// Create procdure to chect invoice id exist
        /// </summary>
        /// <returns></returns>
        internal static string sp_invoice_id_exist()
        {
            return ProcedureText =
                "nUgEvRHMKUoWUWpNWIaBtj5+MV6OmtLU1ejfCOiQ/kQZztZF17thRYoQQtvl96dD3SKvc2NGj19FcY1Eqv15/XIm0DworffLmgWhwr1nIq28If08lzj6saJ7c8HdBt9R5OkKjX8U9U44QRBH96sZ7jyqTGvQZkh+8PqBLWKHowVEgbIkCHIX/YiQOEMYzXtY";
        }

        internal static string sp_get_code_status()
        {
            return ProcedureText =
                "8pdRoweUXP5ntW7ert+JBeSbHrsf+YsPfTNynH/dy8dCF5Zj+3AziqRJJYHEU5aF9OFb7LVXIQpZQqZfW8aZcb2xMnVuBjkjs292TR0E6kjWLMk25YHIbE7UbUf7f0aR47QkgnzGXAP6Jo8510X+2eskW0PAeXarc25DajU8wGOHNszDMthbGT+yDI1XcbTLj834iJygQYzE892O1z3zpKy9OYBXZCsgBZZc0zuEhz9vbMH47S1JnlBYSTQLSgO2ltErpPLjY5IyKDDD1Q5QFw==";
        }

        internal static string sp_get_today_income_inhand_bydate()
        {
           return ProcedureText= "nUgEvRHMKUoWUWpNWIaBtrVRdcxv22fN28MPXuCosnyMoYN8c3PchnOfsMRaCOQLWCm+xmASXf2ol7jvx+PP1pSwmqLScLOCZ2nQYU3CIEweZzJ5pVo6inJV0brd1KR41hMaaA/Dr8vKA0xiX0Dx+oRqSmTgnKuLyK6uQ26N2GWsuCaBBLyloUJIr/bst/HSUVyCLevQZHyHzDrHOy/wASG1Sp0HngoOslbcx6DTncj1ThRE7r09pxVHL4VckhVLSoRAUKUH6keT4VGNFgTZRvWyI4SPrc2NIjtiF1h5pCWaYlp65zh9lZViouEaUiv4";
        }

        internal static string sp_get_today_invoice_income_inhand_bydate()
        {
           return ProcedureText="nUgEvRHMKUoWUWpNWIaBtl3vmoP/RtNfOWd+TOg0M4z26bSWWj2JQqFGiPYP0guPg3uzxBfJjRI58rs47s8tL8AIdZ7Xk8Dx8xjngvWbKsxBYnuC2pSdfY9FdXhUL94I/k7gEU4XXnP5qpuQ69nJktPuL1e5JqZ5xzaMtGenSGBmfCQVuz2IfnWNtvNbhF9wTAmV1Fi/luI+LsctVwQoZ1txLGeskiv03lHJgO4cYZZfJXaZbHBvdCEVr/7E6lJelhQ8dvsoIlDE3Ls+4o+f2/Xqmlgt1CU+rarZOhgDWoo=";
        }

        internal static string sp_get_today_invoice_income_inbank_bydate()
        {
           return ProcedureText= "mL8NL48TeK2PgyMwRB1ZMXWrasJyAnFeRsbjhUP5JHpaEcL9iNzpJi6xUY4Bf3vILMaU4qWlkRA88XmDQeiRbZG6IqfTtVcbGY1DJtyvyROTzxEGreu9GnFBrVGyhspt99WRGB+IZ+uW4mnd2zLICn273ndJVE2KcmgKDt0HCqyrQSnxRIHzXP/fAMkZGw6loF1jOht9TJ8TNkIa0dRi+KaPLFlpKNAeBL0DPi+RvnX8JA+W3ffB7IpSatAzoxI4JkC2z6AZ3cDYZ3FyI8Fg8t76fBibau+eLGmzOEjYkgs=";
        }

        internal static string sp_view_invoice_details_by_customer_bydate()
        {
           return ProcedureText= "hnUEYJsgnFFfQCVcSu0SiqiYeUbJ5oQlbRwi3m2eY3478gyqLy87akkqxm736zga00BG2BkSb+vdEfl1te/VvQs4kkL9HYrKxJKhMjMNzKSDNyMIeU4cxqsKRTM1QTGEvu2j/TTgrMNK2UeijME+Vc7TBLs6k2VMhd3iIsll1PuxUbbzBy/PIeredRnd8B+mDUTBywW5G6gBIcMHOq58loFsSz41b8o0Gjz0/jTR2azdIaCQH24Ek8rYdNEjsjx6JY9UIX9eeOhYV/cHW9QovnOG+QNBdkMzS4U0Qkcwp6aqCHyvT+huI35mCokbhsr+TDkKjo6Q2CPvCjfUkdQKtcnSsnd1yqKYgx9Pl8OXeuar9eL38xLqQ6WsR0znSPEyv/w71gQVgVUNhQrGpUs2yogMpnuxvdM50vR43LZfsQ6kPsLb7Vhib6hwQPZauAh2ChkKdZawK+01h7TnWSg8Z2Uv+3Xh8UWITr1SSNmXNYYp7ab/U5c44JJB6Xtw6xbbE+cMp8uKac3jy2U9BZhV+Upk2UFKZO6lUofKzP2q7cqVvGbY90LFbeRIS1fQvuWr+Ktz68GXpvYxxWd0oOlyQqXGnI5yzFpi5RAazJ+3qisZGj9JzwM1vJFD9vuVcLy8ljdtOUgfzsG5oP1DzVLQ4g==";
        }

        internal static string sp_view_invoice_details_by_customer_between_date()
        {
            return ProcedureText= "mL8NL48TeK2PgyMwRB1ZMbfDVA30BTm4yXNRX6vUjelKSIGCPP70yC+E8d6dVHYQF15KsId3PX9WdL35AlaFQVmx7A0PsjvtE/xcRY41OD6Ob+XdTKGRfvg2I0vdlydxqw1BSf4jxUVfqb6bh9svMbgkWA9Ey3HGOhRIgtylaZZfDXQOBtyP+IdaTxJqQnzY3/edh2+ktv17aIz4EXazpmMzzoih25ElkQ9Ja8py9nH9N72nrgfOAmOig0NpLfHPzCOQToM8jPoiya6DCOMlxnGMiyPvXqLr/XQ5TxJ1lMqgsWxEfeHFf/kvV7tY7bE36sig1cM29Gwu5AYUAZ8cu8SMdBuixzEXCttKUeBmcan4Tq+R3oWyBXkDCa1bYFrENkJ00DR6Ud5kzn++gI8r5Tb6Pl/x29F8BvWHQjLHbTEp47nwV28RdO+PL91fVTUTXebMSKJom9ukoGU0t6Gwa/bMgIRsgsniHN4v9Qm9whACH/Oi/Qz/C+qoe87QeN8VvQ3pVcKX0fV3wS1PRvd12cOW0+FKIMuGJybcAB3JEWH7ivofNOV6p6B+bIZVI08eMekv6l81wFo2dwxqNfivyBWidhrUR/mTtWur8z5awd1DqFf37bKyxU1u68aIbIzTUzWU2JDIb1Ry7leIblRowltpQzi4KiLAsoENarCu1qOcXx6Ujo1BuY6WvPoXDg2VRYakb1e8BdBNwykyM3gIQVziSv5pVoZb4jYP/93rriE=";
        }
    }
}
