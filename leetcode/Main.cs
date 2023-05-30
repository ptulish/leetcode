
using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading.Channels;

// ReSharper disable once IdentifierTypo
namespace leetcode;

public class Main
{
	public Main()
	{
		//Console.WriteLine(MergeAlternately("abc", "pqr") + " " + MergeAlternately("ab", "pqrs"));
		//Console.WriteLine(GcdOfStrings("TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX") + " " + GcdOfStrings("ABABAB", "ABAB") + " " + GcdOfStrings("LEET", "CODE"));
		//foreach (var h in arrayAndExtra(new int[] { 1, 2, 3, 4 }, 2))
		//{
		//	Console.WriteLine(h);
		//}
		//Console.WriteLine(arrayAndExtra(new int[] { 1, 2, 3, 4 }, 2));
		//Console.WriteLine(Flowers(new int[] { 0, 1, 0, 1, 0, 0, 0, 1 }, 5));
		//Console.WriteLine(Flowers(new int[] {0,1,0,1,0,0,0,1}, 1));
		//Console.WriteLine(Flowers(new int[] {1, 0, 0, 0, 1, 0, 0}, 2));
		//Console.WriteLine(stringSwap("leetcode"));
		//Console.WriteLine(ReverseWords(" the sky is  blue "));
		//Console.WriteLine(triplet(new int[] {20, 100, 10, 12, 5, 13}));
		//Console.WriteLine(stringCompr(new char[] {'a', 'a', 'b', 'b', 'b', 'c', 'c', 'c'}));
		//zerosToEnd(new int[] {1,0, 0});
		//Console.WriteLine(subSeq("abc", "ahbgdc"));
		// Console.WriteLine(MaxVowels("leetcode", 3));
		// Console.WriteLine(MyChallenge(new int[]{2,3,3,5,5,6,6}));
		Console.WriteLine(LongestOnes(new int[] { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }, 3));
		//Console.WriteLine("max oper:   " + maxOper(new int[] { 1,2,3,4}, 5));
		//Console.WriteLine(LongestSubarray(new int[] {1,1,0,1}));
		//Console.WriteLine(LargestAltitude(new int[] {-4, -3, -2, -1, 4, 3, 2}));
		//Console.WriteLine(PivotIndex(new int[] {2,1,-1}));
		//Console.WriteLine(FindDifference(new int[] {1,2,3,3}, new int[] {1,1,2,2}));
		// ListNode head = new ListNode(2, new ListNode(1, new ListNode(3)));
		//
		// Console.WriteLine(head);
		// Console.WriteLine(DeleteMiddle(head));
		// ListNode tmp = head;
		// while (tmp != null)
		// {
		// 	Console.WriteLine(tmp.val);
		// 	tmp = tmp.next;
		// }
		Console.WriteLine(UniqueOccurrences(new int[] {1,2,2,1,1,3}));
	}
	public bool UniqueOccurrences(int[] arr)
	{



		return false;
	}
	private int LongestOnes(int[] ints, int k)
    {
        int r = 0, l = 0, max = 0, cur = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            
            if (ints[i] == 0)
            {
                cur++;
            }

            if (cur > k && l < ints.Length - 1)
            {

                do
                {
                    l++;
                } while (ints[l] == 1 && l < ints.Length - 1);

                if (l > 0 && ints[l-1] != 0)
                {
                    cur--;
                }
                

            } else if (l == ints.Length - 1)
                l++;

            if (i - l > max)
            {
                max = i - l;
            }
            
        }

        return max;
    }
	
    public string MyChallenge(int[] ints)
    {
        string[,] weekdays = new string[7,7];
        string[] todos = new string[]
        {
            "2 задачи в Leetcode", 
            "3 задачи в Leetcode", 
            "4 задачи в Leetcode",
            "100 отжиманий за день",
            "200 отжиманий за день",
            "300 отжиманий за день",
            "30 страниц книги",
            "40 страниц книги",
            "50 страниц книги",
            "2 урока в ITProger",
            "3 урока в ITProger",
            "4 урока в ITProger",
            "5 урока в ITProger",
            "1 тема в Android",
            "2 темы в Android",
            "3 темы в Android",
            "2 задания в project Euler",
            "3 задания в project Euler",
            "2 задания в codewars",
            "3 задания в codewars",
            "4 задания в codewars",
            "5 заданий в codewars",
            "Убраться в комнате",
            "Пробежка 3 км",
            "пробежка 5 км",
            "Пробежка 7 км",
            "Пробежка 8 км",
            "Пробежка 10 км",
            

        };
        Random rand = new Random();

        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < ints[i]; j++)
            {
                int randInt = rand.Next(1, 59);
                switch (randInt)
                {
                    case 1:
                    case 2:
                    case 3:
                        weekdays[i, j] = todos[0];
                        break;
                    case 4:
                    case 5:
                        weekdays[i, j] = todos[1];
                        break;
                    case 6:
                        weekdays[i, j] = todos[2];
                        break;
                    case 7:
                    case 8:
                    case 9:
                        weekdays[i, j] = todos[3];
                        break;
                    case 10: 
                    case 11:
                        weekdays[i, j] = todos[4];
                        break;
                    case 12:
                        weekdays[i, j] = todos[5];
                        break;
                    case 13:
                    case 14:
                    case 15:
                        weekdays[i, j] = todos[6];
                        break;
                    case 16: 
                    case 17:
                        weekdays[i, j] = todos[7];
                        break;
                    case 18:
                        weekdays[i, j] = todos[8];
                        break;
                    case 19:
                    case 20:
                    case 21: 
                    case 22:
                        weekdays[i, j] = todos[9];
                        break;
                    case 23:
                    case 24:
                    case 25:
                        weekdays[i, j] = todos[10];
                        break;
                    case 26:
                    case 27:
                        weekdays[i, j] = todos[11];
                        break;
                    case 28:
                        weekdays[i, j] = todos[12];
                        break;
                    case 29:
                    case 30:
                    case 31:
                        weekdays[i, j] = todos[13];
                        break;
                    case 32:
                    case 33:
                        weekdays[i, j] = todos[14];
                        break;
                    case 34:
                        weekdays[i, j] = todos[15];
                        break;
                    case 35:
                    case 36:
                        weekdays[i, j] = todos[16];
                        break;
                    case 37:
                        weekdays[i, j] = todos[17];
                        break;
                    case 38:
                    case 39:
                    case 40:
                    case 41:
                        weekdays[i, j] = todos[18];
                        break;
                    case 42:
                    case 43:
                    case 44:
                        weekdays[i, j] = todos[19];
                        break;
                    case 45:
                    case 46:
                        weekdays[i, j] = todos[20];
                        break;
                    case 47:
                        weekdays[i, j] = todos[21];
                        break;
                    case 48:
                        weekdays[i, j] = todos[22];
                        break;
                    case 49: 
                    case 50:
                    case 51:
                    case 52:
                        weekdays[i, j] = todos[23];
                        break;
                    case 53:
                    case 54: 
                    case 55:
                        weekdays[i, j] = todos[24];
                        break;
                    case 56:
                    case 57:
                        weekdays[i, j] = todos[25];
                        break;
                    case 58:
                        weekdays[i, j] = todos[26];
                        break;
                    
                    default:
                        
                        break;
                }
            }
        }

        string returnString = String.Empty;
        for (int i = 0; i < 7; i++)
        {
            
            returnString += "\n";
            switch (i)
            {
                case 0:
                    returnString += "Понидельник: \n   ";
                    for (int j = 0; j < 7; j++)
                    {
                        if (weekdays[i,j] != null)
                        {
                            returnString += weekdays[i, j] + " \n   ";
                        }
                    }

                    break;
                case 1:
                    returnString += "Вторник: \n   ";
                    for (int j = 0; j < weekdays.GetLength(1); j++)
                    {
                        if (weekdays[i,j] != null)
                        {
                            returnString += weekdays[i, j] + " \n   ";
                        }                    }

                    break;
                case 2:
                    returnString += "Среда: \n   ";
                    for (int j = 0; j < weekdays.GetLength(1); j++)
                    {
                        if (weekdays[i,j] != null)
                        {
                            returnString += weekdays[i, j] + " \n   ";
                        }
                    }

                    break;
                case 3:
                    returnString += "Четверг: \n   ";
                    for (int j = 0; j < weekdays.GetLength(1); j++)
                    {
                        if (weekdays[i,j] != null)
                        {
                            returnString += weekdays[i, j] + " \n   ";
                        }
                    }

                    break;
                case 4:
                    returnString += "Пятница: \n   ";
                    for (int j = 0; j < weekdays.GetLength(1); j++)
                    {
                        if (weekdays[i,j] != null)
                        {
                            returnString += weekdays[i, j] + " \n   ";
                        }
                    }

                    break;
                case 5:
                    returnString += "Суббота: \n   ";
                    for (int j = 0; j < weekdays.GetLength(1); j++)
                    {
                        if (weekdays[i,j] != null)
                        {
                            returnString += weekdays[i, j] + " \n   ";
                        }
                    }

                    break;
                case 6:
                    returnString += "Воскресенье: \n   ";
                    for (int j = 0; j < weekdays.GetLength(1); j++)
                    {
                        if (weekdays[i,j] != null)
                        {
                            returnString += weekdays[i, j] + " \n   ";
                        }
                    }

                    break;
                default:
                    break;
            }
        }

        return returnString;
    }

    public int gcd(int a, int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }
        return a; 
    }
    
    public int MaxVowels(string s, int k)
    {
        int max = 0;
        
        char[] tmp = new char[s.Length];
        for (int i = 0; i < k; i++)
        {
            tmp[i] = s[i];
            if (isVowel(tmp[i]))
            {
                max++;
            }
        }

        int count = max;
        for (int i = k; i < s.Length; i++)
        {
            if (isVowel(tmp[i - k]))
            {
                count--;
            }

            if (isVowel(s[i]))
            {
                count++;
            }

            tmp[i - k] = ' ';
            tmp[i] = s[i];
            if (count > max)
            {
                max = count;
            }
        }
        return max;
    }

    public bool isVowel(char a)
    {
        if (a == 'a' || a == 'e' || a == 'u' || a == 'i' || a == 'o' || a == 'A' || a == 'E' || a == 'U' || a == 'I' || a == 'O')
        {
            return true;
        }

        return false;
    }
    
    private double FindMaxAverage(int[] ints, int k)
    {
        Stopwatch stopwatch = Stopwatch.StartNew(); // создаем и сразу запускаем таймер
        double max = 0;
        for (int i = 0; i < k; i++)
        {
            max += ints[i];
        }

        int tmp = (int)max;
        int tmp1;
        for (int i = k; i < ints.Length; i++)
        {
            tmp -= ints[i - k];
            tmp += ints[i];
            if (tmp > max)
            {
                max = tmp;
            }
        }
        stopwatch.Stop(); // останавливаем таймер

        TimeSpan elapsedTime = stopwatch.Elapsed; // здесь будет время выполнения вашей функции

        Console.WriteLine("Время выполнения функции: " + elapsedTime);
        return max / k;
        
    }

    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] ans = new int[n];
        for (int i = 0; i < n; ++i) ans[i] = 1;

        int leftProduct = 1, rightProduct = 1;
        for (int i = 1, j = n - 2; i < n; ++i, --j)
        {
            leftProduct *= nums[i - 1];
            rightProduct *= nums[j + 1];
            ans[i] *= leftProduct;
            ans[j] *= rightProduct;
        }
        
        return ans;
    }
    
    public int MaxOperations(int[] ints, int k) {
        Array.Sort(ints);
        List<int> list = ints.ToList<int>();
        int start = 0;
        int end = list.Count - 1;
        int count = 0;

        while (start < end)
        {
            if (list[start] + list[end] == k)
            {
                count++;
                start++;
                end--;
            }
            else if (list[start] + list[end] < k)
            {
                start++;
            }
            else
            {
                end--;
            }
        }
        return count;
    }
    private ListNode DeleteMiddle(ListNode head)
	{
		int size = ListSize(head);
        ListNode tmp = head;
		int middle;

		switch (size)
		{
			case 1:
				return head;
			case 2:
			case 3:
				middle = 1;
				break;
			case 4:
			case 5:
				middle = 2;
				break;
			default:
				middle = size / 2;
				break;
		}

		if (middle == 1)
		{
			if(size == 2)
			{
				head.next = null;
				return head;
			}
			else if (size == 3)
			{
				head.next = findNode(head, 2);
				return head;
			}
		}

		for (int i = 0; i < middle; i++)
		{
			tmp = tmp.next;
			if (i == middle - 2)
			{
				tmp.next = findNode(head, middle + 1);
				break;
			}
		}

        return head;
	}

    private ListNode findNode(ListNode head, int i)
    {
		int j = 0;
        while(head != null && i > j)
		{
			head = head.next;
			j++;
		}
		return head;
    }

    private int ListSize(ListNode head)
	{
		int count = 0;
		while (head != null)
		{
			count++;
			head = head.next;
		}
		return count;
    }

    private IList<IList<int>> FindDifference(int[] ints1, int[] ints2)
    {
		IList<IList<int>> list = new List<IList<int>>();
		List<int> first =  getElementOnlyInFirstList(ints1, ints2) ;
		List<int> second = getElementOnlyInFirstList(ints2, ints1);
		list.Add(first);
		list.Add(second);	

        return list;
    }

    private List<int> getElementOnlyInFirstList(int[] ints1, int[] ints2)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < ints1.Length; i++)
        {
            bool found1 = false;
            bool found2 = false;

            for (int j = 0; j < list.Count(); j++)
			{
				if (ints1[i] == list[j])
				{
					found2 = true;
				}
			}
			if (found2)
			{
				continue;
			}
            for (int j = 0; j < ints2.Length; j++)
            {
                if (ints1[i] == ints2[j])
                {
                    found1 = true;
                    break;
                }
            }
            if (!found1)
            {
                list.Add(ints1[i]);
            }
        }
        return list;
    }

    private int PivotIndex(int[] ints)
    {
		int sum = ints.Sum();
		int leftsum = 0;
		int rightsum = sum - ints[0];
		if (leftsum == rightsum)
		{
			return 0;
		}
		for (int i = 1; i < ints.Length; i++)
		{
			leftsum += ints[i - 1];
			rightsum = sum - ints[i] - leftsum;
			if (leftsum == rightsum)
			{
				return i;
			}
		}
		return -1;
    }

    private int LargestAltitude(int[] ints)
    {
		int start = 0;
		int max = 0;

		for (int i = 0; i < ints.Length; i++)
		{
			start += ints[i];
			if (start > max)
			{
				max = start;
			}
		}
		return max;
    }

    private int LongestSubarray(int[] ints)
    {
        int l = -1, r = -1, max = 0;

        for (int i = 0; i < ints.Length; i++)
		{

			if (ints[i] == 0)
			{
                l = 0;
                r = 0;
                int j = i + 1;
				while (j < ints.Length && ints[j] == 1)
				{
					r++;
					j++;
				}
				j = i - 1;
				while (j >= 0 && ints[j] == 1)
				{
					l++;
					j--;
				}
				if (r + l > max)
				{
					max = r + l;
				}

			}
		}

		if( l == -1 && r == -1 )
		{
			return ints.Length - 1;
		}

		return max;
    }

    private int maxOper(int[] ints, int v)
    {
		List<int> list = ints.ToList<int>();
		int count = 0;

		for (int i = 0; i < list.Count;)
		{
			Console.WriteLine(list.Count);
            for (int j = i + 1; j < list.Count; j++)
			{
				Console.WriteLine(list[i] + " + " + list[j] + " = " + (list[i] + list[j]));
                if (list[i] + list[j] == v)
				{
					list.RemoveAt(j);
					list.RemoveAt(i);
					count++;
					break;
				}
				if (j == list.Count - 1)
					i++;
			}
			
		}


		return count;
    }

    private int MaxArea(int[] ints)
    {
		int l = 0,
			r = ints.Length - 1,
			current_max = 0,
			max = 0;

		while (l < r)
		{
			current_max = (r - l) * Math.Min(ints[l], ints[r]);
			if(current_max > max)
			{
				max = current_max;
			}
			if (ints[l] <= ints[r])
				l++;
			else
				r--;
		}
		return max;
    }

    private bool subSeq(string v2, string v1)
    {
		if (v2 == "")
		{
			return true;
		}
		List<int> list = new List<int>();

		bool check = false;
		int i = 0;

        foreach (var v in v2)
		{
			for (; i < v1.Length; i++)
			{
				if (v == v1[i])
				{
					list.Add(i);
					check = true;
					i++;
					break;
				}
				check = false;
			}
			if (!check)
			{
				return false;
			}
		}
		if (list.Count <= v2.Length)
		{
			return false;
		}
		int before = -1;
		foreach (var v in list)
		{
            Console.WriteLine("v: " + v + "   before: " + before);
            if (v > before)
			{
				before = v;
			} else
			{
				return false;
			}
		}
		Console.WriteLine(v2.Length + " " + list.Count) ;
        if (check)
			return true;
		else
			return false;

    }

    private void zerosToEnd(int[] ints)
    {
		int j = 0;
		for (int i = 0; i < ints.Length - 1; i++)
		{
			j = i;
            if (ints[i] == 0)
			{
				while (j < ints.Length && ints[j] == 0)
					j++;
				if (j < ints.Length)
				{
                    int tmp = ints[j];
                    ints[j] = 0;
                    ints[i] = tmp;
                }

				
			}

		}
		for (int i = 0; i < ints.Length; i++)
			Console.WriteLine(ints[i]);
    }

    private int stringCompr(char[] chars)
    {
		int i = 0, res = 0;
		
		while(i < chars.Length)
		{
			int groupLength = 1;
			while(groupLength + i < chars.Length && chars[i + groupLength] == chars[i])
			{
				groupLength++;
			}
			chars[res++] = chars[i];
			if (groupLength > 1)
			{
				string groupLengthStr = groupLength.ToString();
				for (int j = 0; j < groupLengthStr.Length; j++)
				{
					chars[res++] = groupLengthStr[j];
				}
			}
			i += groupLength;
		}
		foreach (char c in chars)
			Console.Write(c);

		return res;
    }

    private bool triplet(int[] ints)
    {
		int min = int.MaxValue;
		int min2 = int.MaxValue;
		foreach (int i in ints)
		{
			if (i <= min)
			{
				min = i;
			} else if (i <= min)
			{
				min2 = i;
			} else
			{
				return true;
			}
		}


		return false; ;
    }

    private string ReverseWords(string v)
    {
		string[] words = v.Split(' ');
		int count = words.Count();
        List<string> retur = new List<string>();

		for (int i = count - 1; i >= 0; i--)
		{
			retur.Add(words[i]);
			Console.WriteLine(words[i]);
        }
		string returString = string.Empty;
		
		foreach (string word in retur)
		{
			if (word == "")
			{
				continue;
			}
            returString += word + ' ';
		}
		
		returString.Remove(returString.Length - 1);

		return returString;
    }

    private string stringSwap(string v)
	{
		int length = v.Length;
		char[] arr = v.ToCharArray();
		int j = length - 1;
		for (int i = 0; i < length; i++)
		{
			if (i >= j)
			{
				break;
			}
			if (vowel(v[i]) == false)
			{
				continue;
			}

			for (; j > 0; j--)
			{
				if (vowel(v[j]) == false) { continue; }

				char tmp;

				tmp = v[j];
				arr[j]= arr[i];
				arr[i] = tmp;
				j--;
				break;
			}
		}
		return new string(arr);
    }

    private bool vowel(char v)
    {
        switch (v)
		{
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
			case 'A':
			case 'E':
			case 'I':
			case 'O':
			case 'U':
				return true;
			default:
				return false;
		}
    }

    private bool Flowers(int[] ints, int v)
    {
		int empty = 0;
		int length = ints.Length;

		for (int i = 0; i < length; i++)
			if (ints[i] == 0)
				if (i == 0 || ints[i - 1] == 0)
					if (i == length || ints[i + 1] == 0)
					{
						empty++;
						ints[i] = 1;
					}
		return empty >= v ? true : false;
    }

    private bool[] arrayAndExtra(int[] ints, int v)
	{
		int max = ints.Max();
		int j = 0;
		bool[] bools = new bool[ints.Length];
		foreach (int i in ints)
		{
			if (i + v >= max)
			{
				bools[j] = true;
			}
			else
			{
				bools[j] = false;
			}
			j++;
		}

		return bools;
	}

    private string GcdOfStrings(string str1, string str2)
	{
		string shortest = string.Empty;
		string longest = string.Empty;
		if (str1.Length == str2.Length)
		{
			shortest = str1;
			longest = str2;
		}
		else
		{
			shortest = str1.Length > str2.Length ? str2 : str1;
			longest = str1.Length < str2.Length ? str2 : str1;
		}
        bool contains = false;
		int k = 0;
		int n = 0;
        while (shortest.Length != 0)
        {
			if(longest.Length % shortest.Length != 0)
			{
				shortest = shortest.Remove(shortest.Length - 1);
				continue;
			}
			else
			{
				k = str1.Length / shortest.Length;
				n = str2.Length / shortest.Length;
            }

			contains = longest.Contains(shortest);

			if (contains)
			{
				string res1 = string.Empty;
                string res2 = string.Empty;
                for (int i = 0; i < k; i++)
				{
					res1 += shortest;
				}
				for (int i = 0; i < n; i++)
				{
					res2 += shortest;
				}
				if ((res1 == str1 || res1 == str2) && (res2 == str1 || res2 == str2))
					return shortest;
			}
			shortest = shortest.Remove(shortest.Length - 1);
        }
		return "";
	}

	private string MergeAlternately(string word1, string word2)
	{
		string result = string.Empty;
		int count = word1.Length > word2.Length ? word1.Length : word2.Length;
		int word1Length = word1.Length;
		int word2Length = word2.Length;
        for (int i = 0;i < count; i++)
		{
            Console.WriteLine();
            if (word1Length > i)
				result += word1[i];
			if (word2Length > i)
				result += word2[i];
		}
        Console.WriteLine("after forloop");
        return result;
	}

	private void firstExercise()
	{
		bool first = IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" });
		bool second = IsValidWalk(new string[] { "w", "e", "w", "e" });
		bool third = IsValidWalk(new string[] { "w" });
		bool fourth = IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" });

		Console.WriteLine(first + ", " + second + ", " + third + ", " + fourth);
	}

	private void secondExercise()
	{
        Sum s = new Sum();
        Console.WriteLine(s.GetSum(-50, 0) + ",   " + s.GetSum(-505, 4) + ",   " + s.GetSum(-3221, 123));
	}

    private bool IsValidWalk(String[] walk)
    {
		int count = walk.Length;
		Console.WriteLine(count);
		if (count != 10)
		{
			return false;
		}

		int horCount = 0;
		int vertCount = 0;

		foreach (String s in walk)
		{
			Console.WriteLine($"{s}");	
			switch (s)
			{
				case "n":
					vertCount++;
					break;
				case "s":
					vertCount--;
					break;
				case "e":
					horCount++;
					break;
				case "w":
					horCount--;
					break;
				default:
					return false;
			}
		}
		if (horCount == 0 && vertCount == 0)
		{
			return true;
		}
		else
		{
			return false;
		}

    }
}
public class Sum
{
    public int GetSum(int a, int b)
    {
		if (a > b)
		{
			int tmp = a;
			a = b;
			b = tmp;
		}
		 
		int count = (a < 0 && b >= 0) || (a >= 0 && b < 0) ? Math.Abs(a) + Math.Abs(b) : Math.Abs(b) - Math.Abs(a);
		if (count < 0)
			count *= -1;
        if (count == 1)
		{
			return a + b;
		}

        b = a == 0 ? a++ : a;

        for (int i = 0; i < count; i++) 
            a += ++b;

		return a;
    }
}
public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode (int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}
}

        
