using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SmartExpense {
    public class Vietnamese {
        public string RemoveDiacritics(string text) {
            if (string.IsNullOrEmpty(text))
                return text;

            string normalized = text.Normalize(NormalizationForm.FormD);

            StringBuilder builder = new StringBuilder();

            foreach (char c in normalized) {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(c); // diacritics have a different unicode category than letter

                if (category != UnicodeCategory.NonSpacingMark) { // keep only characters that are not diacritic marks: 'á'->'a'+'dia'
                    builder.Append(c);
                }
            }

            return builder.ToString().Normalize(NormalizationForm.FormD); // return normalized string in FormC again
        }
    }
}
