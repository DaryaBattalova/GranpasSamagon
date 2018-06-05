using System;
using System.Collections;
using System.Web.Http;

namespace GrandpasSamagon.Controllers
{
    /// <summary>
    /// Represents a controller that is responsible for sugar bags.
    /// </summary>
    [RoutePrefix("api/sugar")]
    public class SugarController : ApiController
    {
        /// <summary>
        /// Gets indexes of bags whose sum in preassigned.
        /// </summary>
        /// <param name="info">An info about bags.</param>
        /// <returns>Indexes of bags whose sum in preassigned.</returns>
        [HttpPost]
        [Route("counting")]
        public IHttpActionResult GetIndexesOfBagsNeeded(Models.SugarInfo info)
        {
            int[] arr = SplitStringToIntArr(info.WeightArray);
            int sum = info.WeightNeeded;
            string result = string.Empty;

            try
            {
                result = GetIndexes(arr, sum);
                if (result == string.Empty) return Ok("Unfortunatelly, it's impossible to get such a weight");
                return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        /// <summary>
        /// Gets indexes of elements whose sum equals to preassigned.
        /// </summary>
        /// <param name="arr">An array of elements.</param>
        /// <param name="sum">A sum of two elements.</param>
        /// <returns>Indexes of elements whose sum equals to preassigned.</returns>
        public string GetIndexes(int[] arr, int sum)
        {
            string result = string.Empty;
            Hashtable numbers = new Hashtable();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!numbers.ContainsKey(arr[i]))
                {
                    numbers.Add(arr[i], i);
                }
                else
                {
                    if (arr[i] * 2 == sum)
                    {
                        result = numbers[arr[i]] + ", " + i.ToString();
                        return result;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (numbers.ContainsKey(sum - arr[i]))
                {
                    result = i.ToString() + ", " + numbers[sum - arr[i]];
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// Converts string to int array.
        /// </summary>
        /// <param name="stingToBeSplited">A string to be converted.</param>
        /// <returns></returns>
        private int[] SplitStringToIntArr(string stingToBeSplited)
        {
            string[] stringArr = stingToBeSplited.Split(',');
            int[] arr = new int[stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                arr[i] = Convert.ToInt32(stringArr[i]);
            }
            return arr;
        }

    }
}