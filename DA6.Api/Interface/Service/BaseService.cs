using DA6.Api.Attributes;
using DA6.Api.Exceptions;
using DA6.Api.Interface.IService;
using DA6.Core.Data;
using DA6.Core.Enums;
using Microsoft.EntityFrameworkCore;

namespace DA6.Api.Interface.Service
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected DA6DbContext _context = null;
        private DbSet<T> table = null;
        public BaseService(DA6DbContext context)
        {
            this._context = context;
            table = _context.Set<T>();
        }
        public int Delete(object id)
        {
            T existing = GetById(id);
            var result = table.Remove(existing);
            if (result != null)
            {
                Save();
                return (int)StatusCodeRespon.Success;
            }
            return (int)StatusCodeRespon.BadRequest;

        }

        public virtual IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public virtual T GetById(object id)
        {
            return table.Find(id);
        }

        public virtual int Insert(T obj)
        {
            var isValid = ValidateObject(obj);
            if (isValid == true)
            {
                isValid = ValidateObjectCustom(obj);
            }
            if (isValid == true)
            {
                var result = table.Add(obj);
                if (result != null)
                {
                    Save();
                    return (int)StatusCodeRespon.UpdateSuccess;
                }
            }
            return (int)StatusCodeRespon.BadRequest;
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }

        public virtual int Update(T obj)
        {
            var isValid = ValidateObject(obj);
            if (isValid == true)
            {
                isValid = ValidateObjectCustom(obj);
            }
            if (isValid == true)
            {
                var result = table.Attach(obj);
                _context.Entry(obj).State = EntityState.Modified;
                if (result != null)
                {
                    Save();
                    return (int)StatusCodeRespon.UpdateSuccess;
                }
            }
            return (int)StatusCodeRespon.BadRequest;
        }
        #region Validate
        bool ValidateObject(T entity)
        {
            List<string> errorMsg = new List<string>();
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(entity);
                var propertyNameOriginal = property.Name;
                var propertyNames = property.GetCustomAttributes(typeof(PropertyName), true);
                var propertyNotEmptys = property.GetCustomAttributes(typeof(NotEmpty), true);
                var propertyMaxLength = property.GetCustomAttributes(typeof(MaxLength), true);
                var propertyDuplicate = property.GetCustomAttributes(typeof(CheckDuplicate), true);
                var propertyCheckDate = property.GetCustomAttributes(typeof(checkDate), true);
                if (propertyNames.Length > 0)
                {
                    propertyNameOriginal = ((PropertyName)propertyNames[0]).Name;
                }
                if (propertyNotEmptys.Length > 0)
                {
                    if (propertyValue == null || string.IsNullOrEmpty(propertyValue.ToString()))
                    {
                        errorMsg.Add(String.Format(Properties.Resources.Check_NotEmpty, propertyNameOriginal));
                    }
                }
                if (propertyMaxLength.Length > 0)
                {
                    var length = ((MaxLength)propertyMaxLength[0]).Length;
                    //3. nếu thông tin bắt buộc nhập hiển thị cảnh báo hoặc đánh giấu trang thái không hợp lệ
                    if (propertyValue != null && ((string)propertyValue).Trim().Length > length)
                    {
                        errorMsg.Add(String.Format(Properties.Resources.Check_Maxlength, propertyNameOriginal, length));
                    }
                }
                if (propertyDuplicate.Length > 0)
                {
                    if (propertyValue != null)
                    {
                        //var checkDuplicate = _baseRepository.GetDuplicateProperty(entity, property.Name, propertyValue);
                        //if (checkDuplicate != null)
                        //{
                        //    errorMsg.Add(String.Format(Properties.VNResources.Check_Duplicate, propertyNameOriginal));
                        //}
                    }
                }
                if (propertyCheckDate.Length > 0)
                {
                    if (propertyValue != null)
                    {
                        if ((DateTime)propertyValue > DateTime.Now)
                        {
                            errorMsg.Add(string.Format(Properties.Resources.Check_Date_Time, propertyNameOriginal));
                        }
                    }
                }

            }
            if (errorMsg.Count > 0)
            {
                throw new HttpResponseException(errorMsg);
            }
            return true;
        }
        /// <summary>
        /// Người dùng có thể custom lại validate nếu cần
        /// </summary>p
        /// <param name="entity">Đối tượng</param>
        /// <returns></returns>
        /// NVChien(20/12/2021)
        protected virtual bool ValidateObjectCustom(T entity)
        {
            return true;
        }



        #endregion
    }
}
