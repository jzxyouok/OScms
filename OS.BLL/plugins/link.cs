using System;
using System.Data;
using System.Collections.Generic;
using  OS.Common;

namespace OS.BLL.plugins
{
	/// <summary>
	/// link
	/// </summary>
	public partial class link
	{
        private readonly Model.configs.siteconfig siteConfig = new BLL.configs.siteconfig().loadConfig(); //���վ��������Ϣ
        private readonly DAL.plugins.link dal;
		public link()
		{
            dal = new DAL.plugins.link(siteConfig.sysdatabaseprefix);
        }

		#region  Method

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
        public int Add(Model.plugins.link model)
		{
			return dal.Add(model);
		}

        /// <summary>
        /// �޸�һ������
        /// </summary>
        public void UpdateField(int id, string strValue)
        {
            dal.UpdateField(id, strValue);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
        public bool Update(Model.plugins.link model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int id)
		{
			return dal.Delete(id);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
        public Model.plugins.link GetModel(int id)
		{
			return dal.GetModel(id);
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
        public DataSet GetList(int Top, string strWhere)
        {
            return dal.GetList(Top, strWhere);
        }

        /// <summary>
        /// ��ò�ѯ��ҳ����
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            return dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
        }

		#endregion  Method
	}
}
