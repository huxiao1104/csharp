#region NAligner Copyright

/*
 * NAligner
 * C# port of JAligner API, http://jaligner.sourceforge.net
 * 
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; either version 2
* of the License, or (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program; if not, write to the Free Software
* Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
*/

#endregion

namespace Salsa.Core.Bio.Algorithms.SmithWaterman
{
    /// <summary> Markups line characters. </summary>
    internal abstract class Markups
    {
        /// <summary> Markup line identity character</summary>
        public const char IDENTITY = '|';

        /// <summary> Markup line similarity character</summary>
        public const char SIMILARITY = ':';

        /// <summary> Markup line gap character</summary>
        public const char GAP = ' ';

        /// <summary> Markup line mismatch character</summary>
        public const char MISMATCH = '.';
    }
}